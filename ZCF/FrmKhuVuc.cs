using System;
using System.Drawing;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraPrinting.Native;

namespace ZCF
{
    public partial class FrmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhuVuc()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            // ---- Gọi phương thức lấy danh sách khu vực và đổ vào Data Grid
            gcKhuVuc.DataSource = KhuVuc.GetKhuVuc();
        }
        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            // ---- Hiện panel thêm khu vực nếu nó ẩn
            if (!panelThem.Visible)
            {
                panelThem.Visible = true;
            }
            else
            {
                panelThem.Visible = false;
            }
        }

        // ---- Sự kiện khi dòng đang chọn bị thay đổi (nhấn vào dòng khác)
        private void gvKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // ---- Lấy index dòng vừa nhấn trong bảng
            var index = e.FocusedRowHandle;
            // ---- Thay đổi tọa độ hiển thị của btnXoa theo dòng người dùng vừa nhấn
            btnXoa.Location = new Point(btnXoa.Location.X,
               106 + (index % 10) * 21);
            // ---- Tọa độ ngang giữ nguyên
            // ---- Tọa độ dọc theo index dòng nhấn

            // ---- Ẩn panel thêm Khu Vực
            panelThem.Visible = false;
        }
        

        // ---- Sự kiên khi thay đổi giá trị của một ô trong bảng
        private void gvKhuVuc_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            // ---- Lấy dữ liệu dòng vừa thay đổi dưới dạng DataRow
            var row = gvKhuVuc.GetFocusedDataRow();
            // ---- Gọi phương thức Update Khu Vực
            KhuVuc.UpdateKhuVuc( (int)row[0], row[1].ToString(), (int)row[2]);
            // ---- col 1 : ID Khu Vực, col 2 : Tên Khu Vực, 3 : Số Bàn
            // ---- Load lại database
            LoadData();
        }

        // ---- Sự kiện khi nhấn nút ReLoad
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textTen_Click(object sender, EventArgs e)
        {
            // ---- Bôi đen toàn bộ text trong ô
            textTen.SelectAll();
        }

        private void textBan_Click(object sender, EventArgs e)
        {
            // ---- Bôi đen toàn bộ text trong ô
            textBan.SelectAll();
        }

        // ---- Sự kiện khi nhấn nút ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ---- Nếu thông tin đã được nhập đầy đủ
            if (!textTen.Text.IsEmpty() || !textBan.Text.IsEmpty())
            {
                // ---- Gọi phương thức thêm Khu vực mới 
                KhuVuc.AddKhuVuc(textTen.Text.Trim(), int.Parse(textBan.Text));
                // ---- Load lại data
                LoadData();
                // ---- Chuyển con trỏ vào lại ô Tên 
                textTen.Focus();
                textTen.SelectAll();
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // ---- Ẩn panel thêm 
            panelThem.Visible = false;
        }

        private void textTen_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
             // ---- Khi người dùng nhấn Enter trong ô Tên
            if (e.KeyChar == 13)
            {
                // ---- Chuyển con trỏ sang ô số bàn
                textBan.Focus();
                textBan.SelectAll();
            }
                
        }

        private void textBan_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // ---- Khi người dùng nhấn Enter trong ô Số Bàn
            if (e.KeyChar == 13)
                // ---- Gọi nút ADD
                btnAdd_Click(null, null);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            // ---- Đóng Form Quản Lý
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // ---- Lấy id của khu vực trong dòng đang được chọn ép kiểu về int
            var id = (int)gvKhuVuc.GetFocusedRowCellValue(ID);
            // ---- ID là tên column chứa ID Khu vực trong bảng

            // ---- Gọi phương thức xóa người dùng nếu không thành công trả ra thông báo
            if (KhuVuc.DelKhuVuc(id))
            {
                // ---- Load lại Data
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thể xóa khu vực này ! Khu vực đã được sử dụng!");
            }
        }
    }
}