using System;
using System.Drawing;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraPrinting.Native;

namespace ZCF
{
    public partial class FrmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        private int _nhom;

        public FrmDanhMuc()
        {
            InitializeComponent();
            InitDatabase();
        }

        private void InitDatabase()
        {
            // ---- Lấy dữ liệu danh sách nhóm
            gcNhom.DataSource = DanhMuc.TableNhom();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region Quản lý Nhóm

        // ---- Sự kiên khi thay đổi dòng chọn trong danh sách nhóm
        private void gvNhom_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                // ---- thay đổi cờ nhóm danh mục
                _nhom = (int) gvNhom.GetFocusedRowCellValue(ID);
                // ---- Cập nhật danh sách danh mục theo nhóm mới
                gcDanhMuc.DataSource = DanhMuc.GetDanhMuc(_nhom);
                // ---- Thay đổi vị trí button xóa theo dòng chọn
                btnXoaNhom.Location = new Point(btnXoaNhom.Location.X, 133 + gvNhom.GetFocusedDataSourceRowIndex()*21);
                // ---- Nếu trong nhóm này vẫn còn danh mục thì tắt nút xóa
                if (!gvDanhMuc.IsEmpty)
                    btnXoaNhom.Enabled = false;
                else
                    btnXoaNhom.Enabled = true;
            }
            catch
            {

            }
        }

        // ---- Sự kiện khi giá trị một dòng bị thay đổi
        private void gvNhom_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                // ---- Lấy giá trị dòng vừa thay đổi
                var row = gvNhom.GetFocusedDataRow();
                // ---- Gọi phương thức thay đổi Nhóm Danh Mục
                DanhMuc.UpdateNhom((int) row[0], row[1].ToString());
            }
            catch
            {
                MessageBox.Show("Không thay đổi được !");
            }
            // ---- Cập nhật lại danh sách nhóm
            gcNhom.DataSource = DanhMuc.TableNhom();
        }

        private void btnDongNhom_Click(object sender, EventArgs e)
        {
            panelThemNhom.Visible = false;
        }

        private void textTenNhom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
        }

        private void textTenNhom_Click(object sender, EventArgs e)
        {
            // ---- Bôi toàn bộ chữ trong ô text
            textTenNhom.SelectAll();
        }

        private void btnNewNhom_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTenNhom.Text.IsEmpty())
                    throw new Exception();
                // ---- Gọi phương thức thêm Nhóm Danh Mục
                DanhMuc.AddNhom(textTenNhom.Text.Trim());
                // ---- Chuyển con trỏ vào ô Tên Danh Mục
                textTenNhom.Focus();
                // ---- Bôi đen toàn bộ text
                textTenNhom.SelectAll();
                // ---- Cập nhật lại danh sách danh mục
                gcNhom.DataSource = DanhMuc.TableNhom();
            }
            catch
            {
                MessageBox.Show("Bạn cần nhập đầy đủ tên");
                textTenNhom.Focus();
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            // ---- Lấy id Nhóm vừa được chọn
            var id = (int)gvNhom.GetFocusedRowCellValue(ID);
            // ---- Gọi phương thức xóa danh mục nếu thất bại thì thông báo
            if (!DanhMuc.DelNhom(id))
            {
                MessageBox.Show("Hiện tại không thể xóa danh mục này! Vì nó vẫn được sử dụng!");
            }
            // ---- Cập nhật lại danh sách danh mục
            gcNhom.DataSource = DanhMuc.TableNhom();
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (panelThemNhom.Visible)
            {
                panelThemNhom.Visible = false;
            }
            else
            {
                panelThemNhom.Visible = true;
            }
        }

        #endregion



        #region Quản Lý Danh Mục

        private void gvDanhMuc_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // ---- Thay đổi vị trí button theo dòng chọn
            btnXoaDanhMuc.Location = new Point(btnXoaDanhMuc.Location.X,
                134 + gvDanhMuc.GetFocusedDataSourceRowIndex()*19);
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            // ---- Nếu panel Thêm mới chưa hiện thì bật ngược lại tắt
            if (!panelThem.Visible)
            {
                panelThem.Visible = true;
            }
            else
            {
                panelThem.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //try
            //{
                // ---- Gọi phương thức thêm Danh Mục
                DanhMuc.AddDanhMuc(_nhom, textTen.Text.Trim(),  int.Parse(textGia.EditValue.ToString()));
                // ---- Chuyển con trỏ vào ô Tên Danh Mục
                textTen.Focus();
                // ---- Bôi đen toàn bộ text
                textTen.SelectAll();
                // ---- Cập nhật lại danh sách danh mục
                gcDanhMuc.DataSource = DanhMuc.GetDanhMuc(_nhom);
            //}
            //catch
            //{
            //    MessageBox.Show("Không thêm danh mục được! Thử lại sau!");
            //    textTen.Focus();
            //}

        }

        // ---- Sự kiện thì giá trị một dòng bị thay đổi
        private void gvDanhMuc_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            // ---- Lấy giá trị dòng vừa thay đổi
            var row = gvDanhMuc.GetFocusedDataRow();
            // ---- Gọi phương thức cập nhật danh mục nếu không thành công thì thông báo
            if (!DanhMuc.UpdateDanhMuc((int) row["DanhMucID"], (int) row["Nhom"], row["Ten"].ToString(),
                (long) row["DonGia"]))
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            // ---- Cập nhật lại danh sách danh mục
            gcDanhMuc.DataSource = DanhMuc.GetDanhMuc(_nhom);
            gcDanhMuc.RefreshDataSource();

        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            // ---- Lấy id Danh mục vừa được chọn
            var id = (int) gvDanhMuc.GetFocusedRowCellValue(DanhMucID);
            // ---- Gọi phương thức xóa danh mục nếu thất bại thì thông báo
            if (!DanhMuc.DelDanhMuc(id))
            {
                MessageBox.Show("Danh mục đã được đưa vào thùng rác!\n Bạn có thể vào thùng rác để phục hồi nó!");
            }
            // ---- Cập nhật lại danh sách danh mục
            gcDanhMuc.DataSource = DanhMuc.GetDanhMuc(_nhom);

        }

        private void textTen_Click(object sender, EventArgs e)
        {
            // ---- Bôi toàn bộ text trong ô
            textTen.SelectAll();
        }

        private void textTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ---- Nếu nhấn enter thì tự động nhảy sang ô giá
            if (e.KeyChar == 13)
                textGia.Focus();
        }

        private void textGia_Click(object sender, EventArgs e)
        {
            // ---- Bôi toàn bộ text
            textTen.SelectAll();
        }

        private void textGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ---- Enter thì gọi nut thêm
            if (e.KeyChar == 13)
            {
                btnThem_Click(null, null);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            // ---- Đóng form thêm danh mục mới
            panelThem.Visible = false;
        }


        #endregion

      

    }
}