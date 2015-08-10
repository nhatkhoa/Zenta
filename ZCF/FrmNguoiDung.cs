using System;
using System.Drawing;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraPrinting.Native;

namespace ZCF
{
    public partial class FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {

        public FrmNguoiDung()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            // ---- Lấy cơ sở dữ liệu từ phương thức getlistnguoidung đỗ vào grid data
            gcNguoiDung.DataSource = NguoiDung.GetListNguoiDung();

        }


        // ---- Sự kiện khi dòng đang chọn bị thay đổi (nhấn vào dòng khác)
        private void gvKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // ---- Lấy index dòng vừa chọn
            var index = gvNguoiDung.GetFocusedDataSourceRowIndex();
            // ---- Thay đổi tọa độ hiển thị của btnXoa theo dòng người dùng vừa nhấn
            btnXoa.Location = new Point(btnXoa.Location.X,
               115 + index * 23);
            // ---- Tọa độ ngang giữ nguyên
            // ---- Tọa độ dọc theo index dòng nhấn

            // ---- Ẩn panel thêm Người Dùng
            panelThem.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // ---- Hiện panel thêm nhân viên mới nếu nó đang đóng hoặc người lại
            if (panelThem.Visible == true)
            {
                panelThem.Visible = false;
            }
            else
            {
                panelThem.Visible = true;
            }
            // ---- Visible : xác định đối tượng có xuất hiện hay không

        }

        // ---- Sự kiện khi thay đổi giá trị của một dòng trong grid data
        private void gvNguoiDung_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            // ---- Lấy dữ liệu dòng vừa thay đổi dưới dạng DataRow
            var row = gvNguoiDung.GetFocusedDataRow();
            // ---- Gọi phương thức Update nhân viên
            NguoiDung.UpdateNguoiDung((int) row[0], 
                                            row[1].ToString(),
                                            row[2].ToString(), 
                                            row[3].ToString(),
                                     (bool) row[4]);
            // ---- Load lại database
            LoadData();

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ---- Nếu người dùng nhập đầy đủ thông tin
            if (!textHoTen.Text.IsEmpty() || !textTaiKhoan.Text.IsEmpty() || !textMatKhau.Text.IsEmpty())
            {
                // ---- Gọi phương thức thêm người dùng mới với quản trị = False
                NguoiDung.AddNguoiDung(textHoTen.Text.Trim(), textTaiKhoan.Text.Trim(), textMatKhau.Text.Trim(), false);
                // ---- Quyền quản trị người dùng có thể chỉnh sau

                // ---- Trỏ lại vào ô họ tên
                textHoTen.Focus();
                textHoTen.SelectAll();

                // ---- Load lại Grid Data
                LoadData();
            }
            else
            {
                // ---- Xuất thông báo đến người dùng
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin người dùng!");
                // ---- Trỏ vào ô Họ Tên
                textHoTen.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // ---- Ẩn panel Thêm Người Dùng mới
            panelThem.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // ---- Lấy id của người dùng trong dòng đang được chọn ép kiểu về int
            var id = (int)gvNguoiDung.GetFocusedRowCellValue(ID);
            // ---- ID là tên column chứa ID người dùng trong bảng được tao ban đầu

            // ---- Nếu người dùng chính là người sử dụng thì không được xoá
            if (id == NguoiDung.DaDangNhap)
            {
                MessageBox.Show("Bạn đang xoá chính mình! Vui lòng xem lại!");
                return;
            }

            if (id == CauHinh.AdminChinh())
            {
                MessageBox.Show(
                    "Quản trị viên toàn quyền không xoá được! Bạn phải thay thế tài khoản khác trước khi xoá nó!");
                return;
            }


            // ---- Gọi phương thức xóa người dùng nếu không thành công trả ra thông báo
            if (NguoiDung.DelNguoiDung(id))
            {
                // ---- Load lại Data
                LoadData();
            }
            else
            {
                MessageBox.Show("Người dùng này đã được chuyển tới thùng rác! \nBạn có thể vào quản lý thùng rác để phục hồi!");
                // ---- load lại data mới
                LoadData();
            }


        }

        private void textHoTen_Click(object sender, EventArgs e)
        {
            // ---- Bôi toàn bộ text trong ô khi nhấn
            textHoTen.SelectAll();
        }

        private void textTaiKhoan_Click(object sender, EventArgs e)
        {
            // ---- Bôi toàn bộ text trong ô khi nhấn
            textTaiKhoan.SelectAll();
        }

        private void textMatKhau_Click(object sender, EventArgs e)
        {
            // ---- Xóa toàn bộ text trong ô khi nhấn
            textMatKhau.Text = "";
        }

        private void textHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ---- Nếu người dùng nhấn Enter trong ô Họ Tên
            if (e.KeyChar == 13)
            {
                // ---- Chuyển con trỏ sang ô tài khoản
                textTaiKhoan.Focus();
                textTaiKhoan.SelectAll();
            }
                
        }

        private void textTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ---- Nếu người dùng nhấn Enter trong ô tài Khoản
            if (e.KeyChar == 13)
            {
                // ---- Chuyển con trỏ sang ô tài khoản
                textMatKhau.Focus();
                textMatKhau.SelectAll();
            }
        }

        private void textMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ---- Nếu người dùng nhấn Enter trong ô Mật Khẩu
            if (e.KeyChar == 13)
            {
               // ---- Gọi nút thêm dòng mới
                btnAdd_Click(null,null);
                // ---- Trỏ lại vào ô họ tên
                textHoTen.Focus();
                textHoTen.SelectAll();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetAdmin_Click(object sender, EventArgs e)
        {
            // ---- Lấy id của người dùng trong dòng đang được chọn ép kiểu về int
            var id = (int)gvNguoiDung.GetFocusedRowCellValue(ID);
            // ---- ID là tên column chứa ID người dùng trong bảng được tao ban đầu

            // ---- Nếu là quản trị mới được chuyển quyền
            if ((bool) gvNguoiDung.GetFocusedRowCellValue(QuanTri))
            {
                // ---- Hiển thị hộp thoại xác nhận chuyển quyền Admin
                var dialog = MessageBox.Show("Bạn chắc chắn muốn chuyển quyền admin chính cho tài khoản khác ?",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // ---- Nếu đồng ý
                if (dialog == DialogResult.Yes)
                {
                    //---- Gọi phương thức Cấu Hình Admin Chính
                    CauHinh.SetAdminChinh(id);
                    MessageBox.Show("Chuyển đồi quyền admin thành công!");
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Người bạn chọn hiện tại không phải là quản trị viên!");
            }
        }
    }
}