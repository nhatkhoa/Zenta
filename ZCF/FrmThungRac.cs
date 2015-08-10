using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraEditors;

namespace ZCF
{
    public partial class FrmThungRac : DevExpress.XtraEditors.XtraForm
    {
        public FrmThungRac()
        {
            InitializeComponent();
            InitDanhMuc();
            InitNguoiDung();
            // ----- Nếu cả thùng rác danh mục và người dùng đếu trống thì xuất thống báo
            if (gvNguoiDung.IsEmpty && gvDanhMuc.IsEmpty)
            {
                MessageBox.Show("Không có danh mục hoặc người dùng nào trong thùng rác! ");
                btnDanhMucPhucHoi.Visible = btnNguoiDungPhucHoi.Visible = false;
            }
            else
            {
                // ---- Nếu danh mục trống thì chuyển tab sang Người dùng hoặc ngược lại
                if (gvDanhMuc.IsEmpty)
                    xtraThungRac.SelectedTabPageIndex = 1;
                else
                {
                    xtraThungRac.SelectedTabPageIndex = 0;
                }
            }
        }

        private void InitNguoiDung()
        {
            gcNguoiDung.DataSource = NguoiDung.GetThungRac();
        }

        private void InitDanhMuc()
        {
            gcDanhMuc.DataSource = DanhMuc.GetThungRac();
        }

        private void gvDanhMuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDanhMuc.IsEmpty)
            {
                MessageBox.Show("Danh sách trống!");
                btnDanhMucPhucHoi.Visible = false;
            }

            else
            {
                btnDanhMucPhucHoi.Visible = true;
                // ---- Thay đổi vị trí button xóa theo dòng chọn
                btnDanhMucPhucHoi.Location = new Point(btnDanhMucPhucHoi.Location.X,
                    21 + gvDanhMuc.GetFocusedDataSourceRowIndex()*21);              
            }
        }

        private void btnDanhMucPhucHoi_Click(object sender, EventArgs e)
        {
            // ---- Lấy id Nhóm vừa được chọn
            var id = (int)gvDanhMuc.GetFocusedRowCellValue("DanhMucID");
            // ---- Gọi phương thức phục hồi danh mục nếu thất bại thì thông báo
            DanhMuc.PhucHoi(id);
            // ---- Cập nhật lại danh sách danh mục
            InitDanhMuc();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNguoiDungPhucHoi_Click(object sender, EventArgs e)
        {
            // ---- Lấy id Nhóm vừa được chọn
            var id = (int)gvNguoiDung.GetFocusedRowCellValue("NguoiDungID");
            // ---- Gọi phương thức phục hồi danh mục nếu thất bại thì thông báo
            NguoiDung.PhucHoi(id);
            // ---- Cập nhật lại danh sách danh mục
            InitNguoiDung();
        }

        private void gvNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvNguoiDung.IsEmpty)
            {
                MessageBox.Show("Danh sách trống!");
                btnNguoiDungPhucHoi.Visible = false;
            }

            else
            {
                btnNguoiDungPhucHoi.Visible = true;
                // ---- Thay đổi vị trí button xóa theo dòng chọn
                btnNguoiDungPhucHoi.Location = new Point(btnNguoiDungPhucHoi.Location.X,
                    21 + gvNguoiDung.GetFocusedDataSourceRowIndex() * 21);            
            }
        }
    }
}