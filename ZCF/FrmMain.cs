using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Navigation;
using BAL;
using DevExpress.Charts.Model;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using Series = DevExpress.XtraCharts.Series;


namespace ZCF
{
    public partial class FrmMain : RibbonForm
    {
        // ---- Bảng chi tiết phiếu thu
        private DataTable _chiTiet;
      
        // ---- Cờ selected nhóm danh mục
        private int _nhom = 0;

        // ---- Cờ khu vực : dùng trong tạo mới
        private int _khuVuc = 1;

        // ---- Cờ đã thanh toán hay chưa
        private bool thanhToan = false;

        // ---- Cờ chế độ 0: Xem, 1: Thêm Mới, -1: Chỉnh sửa
        private int _cheDo = 0;
        // ---- Người dùng đăng nhập
        public Dictionary<string,object> _nguoiDung;

        // ---- Cờ selected PhieuThu
        private int _indexPhieuThu;


        public FrmMain()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgbiSkins, true);
            InitDatabase();
            InitDanhMuc();
            InitPhieuThu();
            Login();

            // ---- Thiết lập chế độ
            Set();
            
        }

      

        #region Báo Cáo Thống Kê

        private void InitThongKe()
        {
            _cheDo = 2;
            // ---- Cái đặt cho pivot và chart
            chartTheoThang.DataSource = pivotTheoThang;
            // Change this property to transpose the chart.
            pivotTheoThang.OptionsChartDataSource.ProvideDataByColumns = false;
            // ---- Thiết lập pivot
            pivotTheoThang.BeginUpdate();
            pivotTheoThang.DataSource = BAL.Report.GetPhieuThu();
            // ---- Lấy tên các khu vực trong hệ thống
            var list = BAL.KhuVuc.ListKhuVuc().Select(p => (object)p.Value).ToArray();
            // ---- Khởi tạo các bộ lọc ban đầu
            TK_fieldKhuVuc.FilterValues.SetValues(list, PivotFilterType.Included, true);
            
            pivotTheoThang.EndUpdate();
            // ---- Quét chọn tất cả các col ngay từ đầu
              pivotTheoThang.Cells.Selection = new Rectangle(0, 0, pivotTheoThang.Cells.ColumnCount,
                pivotTheoThang.Cells.RowCount);
            Set();
        }

        private void bbtnLuongKhachTheoKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            TK_fieldSoNguoi.FieldName = "SoNguoi";
            TK_fieldSoNguoi.Caption = "Số Người";
            // ---- Chọn nhóm theo
            TK_fieldThang.GroupInterval = PivotGroupInterval.DateMonth;
            TK_fieldThang.Caption = "Chọn Tháng";

            // ---- Chế độ lọc theo Ngày
            TK_fieldNgay.GroupInterval = PivotGroupInterval.DateDay;
            TK_fieldNgay.Caption = "Ngày";

            // ---- Chế độ lọc trong ngày hôm nay
            TK_fieldThang.FilterValues.SetValues(new object[] { DateTime.Now.Month }, PivotFilterType.Included, true);

            pivotTheoThang.RefreshData();
            pivotTheoThang.Cells.Selection = new Rectangle(0, 0, 100, 100);

            _cheDo = 2;
            Set();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            TK_fieldSoNguoi.FieldName = "TongTien";
            TK_fieldSoNguoi.Caption = "Tổng Tiền";

            // ---- Chọn nhóm theo
            TK_fieldThang.GroupInterval = PivotGroupInterval.DateMonth;
            TK_fieldThang.Caption = "Lọc theo tháng";


            // ---- Chế độ lọc theo Ngày
            TK_fieldNgay.GroupInterval = PivotGroupInterval.DateDay;
            TK_fieldNgay.Caption = "Lọc theo ngày";


            // ---- Chế độ lọc trong ngày hôm nay
            TK_fieldThang.FilterValues.SetValues(new object[] { DateTime.Now.Month }, PivotFilterType.Included, true);

            pivotTheoThang.RefreshData();

            pivotTheoThang.Cells.Selection = new Rectangle(0, 0, 100, 100);

            _cheDo = 2;
            Set();
        }

        private void bbtnLuongKhachTheoGio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            // ---- Chọn cột lấy giá trị là SoNguoi
            TK_fieldSoNguoi.FieldName = "SoNguoi";
            TK_fieldSoNguoi.Caption = "Số Người";

            // ---- Chọn nhóm theo
            TK_fieldThang.GroupInterval = PivotGroupInterval.DateDay;
            TK_fieldThang.Caption = "Chọn Ngày";


            // ---- Chế độ lọc theo giờ
            TK_fieldNgay.GroupInterval = PivotGroupInterval.Hour;
            TK_fieldNgay.Caption = "Lọc Theo Giờ";

            // ---- Chế độ lọc trong ngày hôm nay
           // TK_fieldThang.FilterValues.SetValues(new object[] { DateTime.Now.Day }, PivotFilterType.Included, true);

            pivotTheoThang.RefreshData();
            pivotTheoThang.Cells.Selection = new Rectangle(0, 0, 100, 100);

            _cheDo = 2;
            Set();

        }

        

        #endregion


        // ---- Phương thức đăng nhập và khởi tạo chức năng hệ thống theo quên tài khoản
        private void Login()
        {
            // ---- Thoát khỏi người dùng trước nếu có 
            _nguoiDung = null;

            // ---- Thực hiện đăng nhập hệ thống

            var dangNhap = ShowForm<FrmLogin>();

            // ---- Lấy dữ liệu tài khoản đăng nhập
            _nguoiDung = NguoiDung.GetNguoiDung((dangNhap as FrmLogin).id);
            if (_nguoiDung != null)
            {
                try
                {
                    // ---- Đổi tên người dùng dưới thanh trạng thái
                    btnNguoiDung.Caption = _nguoiDung["HoTen"].ToString();
                    siCapQuanLy.Caption = ((bool) _nguoiDung["QuanTri"] ? "Quản trị viên" : "Nhân viên bán hàng");
                    // ----- Khởi tạo quyền sử dụng hệ thống
                    rbPageQuanTriHeThong.Visible  = (bool) _nguoiDung["QuanTri"];

                    if ((bool) _nguoiDung["QuanTri"])
                    {
                        // ---- Khởi tạo dữ liệu cho dock thống kê
                        InitThongKe();
                        // ----- Chỉnh lại chế độ
                        _cheDo = 2;

                        // ---- Hiện thông báo chào mừng
                        XtraMessageBox.Show("Chào mừng Quản Trị Viên "+ _nguoiDung["HoTen"] +" đã trở lại!");

                    }
                    else
                    {
                        // ---- Nếu không thì chế độ bình thường của người bán hàng
                        _cheDo = 0;
                        Set();
                        // ---- Hiện thông báo chào mừng
                        XtraMessageBox.Show("Chào mừng " + _nguoiDung["HoTen"] + " đến với hệ thống quản lý bán hàng!");
                    }

                }
                catch (InvalidCastException)
                {
                    // ----Không đăng nhập thành công
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }

            

        }
        public void InitDatabase()
        {
            // ----  Khởi tạo khung table cho _chiTiet
            _chiTiet = new DataTable();
            _chiTiet.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("DanhMucID", typeof (int)),
                new DataColumn("Nhom", typeof (string)),
                new DataColumn("Ten", typeof (string)),
                new DataColumn("DonGia", typeof (long)),
                new DataColumn("SoLuong", typeof (int)),
                new DataColumn("ThanhTien", typeof (long)),
            });
        }


        // --------------------
        // ===============================================================================
        // --------------------

        #region Quản lý chức năng

        private void Set()
        {
            // ---- Khi ở chế độ bình thường
            if (_cheDo == 0)
            {
                tabTrangChinh.Visible = false;
                dockPhieuThu.Enabled = true;
                rbGiaoTac.Enabled = false;
                rbQuanLyPhieu.Enabled = true;
                bbtnThanhToan.Enabled = btnThanhToan.Enabled = !gvPhieuThu.IsEmpty;
                try { gvDanhMuc.HideFindPanel(); }
                catch { }
                panelContainer1.Show();

                // --- chọn lại tab
                danhMuc.SelectedTabIndex = danhMuc.Items.FirstTabIndex + 1 ;
            }
            // ----- Khi ở chế độ chỉnh sửa phiếu thu
            if (_cheDo == -1)
            {
                tabTrangChinh.Visible = false;
                dockPhieuThu.Enabled = false;
                rbGiaoTac.Enabled = true;
                rbQuanLyPhieu.Enabled = false;
                gvDanhMuc.ShowFindPanel();
                panelContainer1.Show();

                // --- chọn lại tab
                danhMuc.SelectedTabIndex = danhMuc.Items.FirstTabIndex + 1;
            }
            // ---- Khi ở chế độ tạo mới
            if (_cheDo == 1)
            {
                tabTrangChinh.Visible = false;
                dockPhieuThu.Enabled = false;
                rbGiaoTac.Enabled = true;
                rbQuanLyPhieu.Enabled = false;
                gvDanhMuc.ShowFindPanel();
                panelContainer1.Show();
 

                // --- chọn lại tab
                danhMuc.SelectedTabIndex = danhMuc.Items.FirstTabIndex + 1;
            }

            // ---- Chế độ xem thống kê
            if (_cheDo == 2 && (bool)_nguoiDung["QuanTri"])
            {
                
                try
                {
                    panelContainer1.Hide();
                    danhMuc.SelectedTabIndex = danhMuc.Items.FirstTabIndex;
                    // ---- Chuyển sang tab Quản lý Phiếu Thu
                    ribbonControl.SelectedPage = rbPageQuanTriHeThong;
                }
                catch { }

                tabTrangChinh.Visible = true;
            }
            
            
        }

        // ---- Sử dụng generic truyền vào một kiểu (Vd FrmMain cũng là một kiểu 'type')
        public Form ShowForm<T>() where T : Form, new()
        {
            // ---- tạo một form chức năng làm phong nền cho Form 
            var back = new Form();
            back.ShowIcon = false;
            back.ShowInTaskbar = false;
            // ---- Size = parent để che toàn bộ
            back.Size = new Size(this.Width, this.Height);
            back.WindowState = FormWindowState.Maximized;
            // ---- Vị trí đè hoàn toàn Parent
            back.StartPosition = FormStartPosition.CenterScreen;
            // ---- Chỉnh độ trong suốt
            back.Opacity = 0.5;
            // ---- Chình màu nền
            back.BackColor = Color.Black;
            // ---- Chỉnh kiểu khung cho Form
            back.FormBorderStyle = FormBorderStyle.None;
            // ---- Hiện form nền
            back.Show();

            // ---- Tạo form mới theo kiểu T ban đầu truyền vào
            T form = new T();
            // ---- Sự kiện khi đóng form T lại thì cũng đóng form nền (dùng delegate thay cho một phương thức)
            form.FormClosed += delegate
            {
                // ---- Đóng phong nền đồng thời
                back.Close();
              this.SendToBack();
            };

            // ----- Khi bị mất focus thì tự focus lại
            form.LostFocus += delegate
            {
                form.Focus();
                
            };

           

            // ---- Hiện form dưới dạng nổi 
            form.ShowDialog() ;

            

            // ---- Trả về đối tượng form đang hiện
            return form;
        }

        // ----- Quản lý người dùng
        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Hiện popup quản lý Tài Khoản
            popupQuanLyTaiKhoan.ShowPopup(new Point(Location.X + 81, Location.Y + Bottom - 220));
            // ---- Đưa thông tin lên Text BoxtextMaND.Text = _nguoiDung["ID"].ToString();
            textHoTen.Text = _nguoiDung["HoTen"].ToString();
            textTaiKhoan.Text = _nguoiDung["TaiKhoan"].ToString();
            textMatKhau.Text = _nguoiDung["MatKhau"].ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //---- Gọi phương thức update người dùng
            NguoiDung.UpdateNguoiDung((int)_nguoiDung["ID"], _nguoiDung["HoTen"].ToString(),
                _nguoiDung["TaiKhoan"].ToString(), _nguoiDung["MatKhau"].ToString(), (bool)_nguoiDung["QuanTri"]);
            // ---- Khóa button lưu
            btnLuuLai.Enabled = false;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!btnLuuLai.Enabled)
            {
                btnLuuLai.Enabled = true;
            }
            else
            {
                btnLuuLai.Enabled = false;
            }
        }

        #endregion


        // --------------------
        // ===============================================================================
        // --------------------


        #region Quản lý Ribbon

        private void bbtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            Login();

        }

        private void bbtnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- tạo một form chức năng làm phong nền cho Form 
            var back = new Form();
            // ---- Size = parent để che toàn bộ
            back.Size = new Size(this.Width, this.Height);
            // ---- Vị trí đè hoàn toàn Parent
            back.StartPosition = FormStartPosition.CenterScreen;
            // ---- Chỉnh độ trong suốt
            back.Opacity = 0.7;
            // ---- Chình màu nền
            back.BackColor = Color.Black;
            // ---- Chỉnh kiểu khung cho Form
            back.FormBorderStyle = FormBorderStyle.None;
            // ---- Hiện form nền
            back.Show();

            // ---- Tạo form mới 
            var form = new OptionKhuVuc();
            // ---- Sự kiện khi đóng form Khu Vực lại thì cũng đóng form nền (dùng delegate thay cho một phương thức)
            form.FormClosed += delegate
            {
                // ---- Đóng phong nền đồng thời
                back.Close();
                SendToBack();
            };

            // ----- Khi bị mất focus thì tự focus lại
            form.LostFocus += delegate
            {
                form.Focus();
            };


            if (form.ShowDialog() == DialogResult.OK)
            {
                // ---- Chuyển chế độ sang thao tác tạo mới
                _cheDo = 1;
                // ---- Mở và khóa chức năng ứng với chế độ tạo mới
                Set();

                _khuVuc = form._khuVuc;
                // ---- Làm trống table chi tiết và gán datasource của GridChiTiet vào _chiTiet 
                _chiTiet.Clear();
                gcChiTiet.DataSource = _chiTiet;
            }
            
        }


        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<FrmKhuVuc>();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<FrmNguoiDung>();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Chuyển sang tab Quản lý Phiếu Thu
            ribbonControl.SelectedPage = pageQuanLyPhieu;
            // ---- THoát khỏi chế độ thống kê
            _cheDo = 0;
            Set();
        }


        private void bbtnThungRac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<FrmThungRac>();
        }



        // ---- Nút cập nhật thay đổi
        private void bbtnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Khai báo phiếu thu
            int phieuThu = 0;

            // ---- Nếu Cờ tạo mới được bật 
            if (_cheDo == 1)
            {
                // ---- Tạo phiếu thu mới trong csdl
                phieuThu = PhieuThu.AddPhieuThu((int)_nguoiDung["ID"], _khuVuc);
              
            }
            // ---- Nếu cờ chỉnh sửa được bật
            if (_cheDo == -1)
            {
                phieuThu = (int) gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo);
            }

            // ---- Cập nhật chi tiết 
            PhieuThu.UpdateChiTiet(phieuThu, _chiTiet);
            // ---- Chuyển về chế độ ban đầu : Xem
            _cheDo = 0;
            // ---- Thay đổi tổng tiên trong danh sách phiếu thu
            gvPhieuThu.SetFocusedRowCellValue(PT_colTongTien,CT_colThanhTien.Summary[0].SummaryValue);
            // ---- Cập nhật lại các nút chức năng
            Set();


        }

        private void bbtnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _cheDo = 0;
            // ---- Thiết lập lại các nút chức năng
            Set();
            try
            {
                // ---- Danh sách chi tiết về mặc định
                gcChiTiet.DataSource = PhieuThu.GetChiTiet((int)gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo));
            }
            catch
            {
                // Trường hợp không có dòng nào trong danh sách phiếu thu
            }
        }

        // ---- nút chức năng hủy phiếu thu
        private void bbtnHuyPhieuThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Nếu cờ xem bật mới được xóa
            if (_cheDo == 0)
            {
                // ----- Nếu phiếu thu là rỗng mới được phép xóa
                if (gvChiTiet.IsEmpty)
                {
                    if (DialogResult.Yes ==
                    MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn đang chọn ?", "Cảnh Báo!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning))
                    {
                        // ---- Lấy mã phiếu thu đang chọn
                        var phieuThu = (int)gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo);
                        if (PhieuThu.DelPhieuThu(phieuThu))
                        {
                            XtraMessageBox.Show("Đã xóa thành công!");
                            // ----- Làm mới lại danh sách phiếu thu
                            gcPhieuThu.DataSource = PhieuThu.GetPhieuThu(thanhToan);
                            gcPhieuThu.RefreshDataSource();
                        }
                    }
                }
            }
        }

        // ---- Nút chỉnh sửa
        private void bbtnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Nếu danh sách phiếu thu không rỗng
            if (!gvPhieuThu.IsEmpty)
            {

                // ---- Bật cờ chỉnh sửa
                _cheDo = -1;
                // ---- Thiết lập các nút chức năng
                Set();
                // ---- Nếu chi tiết phiếu thu không rỗng 
                if (!gvChiTiet.IsEmpty)
                {
                    // ---- Lấy mã phiếu thu đang chọn
                    var phieuThu =
                        (int) gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo);
                    // ---- Tạo bản sao chi tiết vào _chiTiet để chỉnh sửa
                    _chiTiet = PhieuThu.GetChiTiet(phieuThu);
                    // ---- Chuyển nguồn dữ liệu của gcChiTiet sang _chiTiet
                    gcChiTiet.DataSource = _chiTiet;
                    gcChiTiet.RefreshDataSource();
                }
                else
                {
                    // ---- Tạo mới một table chi tiết
                    InitDatabase();

                    // ---- Chuyển nguồn dữ liệu của gcChiTiet sang _chiTiet
                    gcChiTiet.DataSource = _chiTiet;
                    gcChiTiet.RefreshDataSource();
                }
            }

        }

        private void bbtnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Lấy dữ liệu dòng vừa nhấn
            var tongTien = gvPhieuThu.GetFocusedRowCellValue(PT_colTongTien);
            // ---- Đưa dữ liệu vào popup
            txtTongTien.Text = tongTien.ToString();

            // ---- Hiện popup thanh toán theo vị trí ô chọn
            popupThanhToan.ShowPopup(new Point(danhMuc.Size.Width + 200, danhMuc.Size.Height + 170));

            
        }
      

        private void bbtnXuatPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ---- Lấy ra giá trị dòng được chọn
            var row = gvPhieuThu.GetFocusedDataRow();

            // ---- Hiện Form xuất phiếu
            var ptt = new PhieuThanhToan((int) row["PhieuThuID"]);
            ptt.Parameters["PhieuThuID"].Value = (int) row["PhieuThuID"];
            ptt.Parameters["TongCong"].Value = (long) row["TongTien"];
            ptt.Parameters["NgayKhoiTao"].Value = DateTime.Now;
            ptt.Parameters["ThuNgan"].Value = _nguoiDung["HoTen"].ToString();
            ptt.ShowPreview();
        }

        #endregion


        // --------------------
        // ===============================================================================
        // --------------------



        #region Quản Lí Danh Mục

        public void InitDanhMuc()
        {

            try
            {
                // ---- Thêm tab mới cho Main Danh Mục với mỗi tab sẽ có 1 tab riêng
                foreach (var i in DanhMuc.GetNhom())
                {
                    // ---- với mỗi nhóm danh mục sẽ có một tab ứng với nó
                    DM_AddTab(i.Key, i.Value);
                }

                // ---- Thêm sự kiện click cho button add
                btnAdd.Click += delegate
                {

                    // ---- Nếu chế độ trong quá trình tạo mới Phiếu Thu
                    if (_cheDo != 0)
                    {
                        // ---- Nếu trong phiếu thu chưa tồn tại menu này (Hàm đếm trả về 0)

                        if (_chiTiet.Select().Count(p => p["DanhMucID"].Equals(gvDanhMuc.GetFocusedRowCellValue(DM_colID))) == 0)
                        {
                            // ---- Tạo row mới

                            _chiTiet.Rows.Add(new object[]
                        {
                            // ---- Lấy giá trị cột Danh Mục ID ứng với hàng đang nhấn
                            gvDanhMuc.GetFocusedRowCellValue(DM_colID),
                            // ---- Lấy tên nhóm
                            DanhMuc.GetNhom()[_nhom],
                            // ---- Lấy tên danh mục từ 
                            gvDanhMuc.GetFocusedRowCellValue(DM_colTen),
                            // ---- Lấy đơn giá 
                            gvDanhMuc.GetFocusedRowCellValue(DM_colDonGia),
                            1,
                            // ---- Thành tiền ban đâu = đơn giá
                            gvDanhMuc.GetFocusedRowCellValue(DM_colDonGia)

                            // ---- Với các DM_col..... là các tên columns trong lúc tạo gvDanhMuc
                        });
                            // ---- Cập nhật thay đổi table
                            _chiTiet.AcceptChanges();
                        }
                        else
                        {
                            // ---- Truy vấn đến phần tử trùng
                            var trung =
                                _chiTiet.Select()
                                    .Single(p => p["DanhMucID"].Equals(gvDanhMuc.GetFocusedRowCellValue(DM_colID)));
                            // ---- Tăng số lượng lên 1 đơn vị
                            trung["SoLuong"] = (int)trung["SoLuong"] + 1;
                            // ---- Công thêm Thành tiền
                            trung["ThanhTien"] = (long)trung["ThanhTien"] + (long)trung["DonGia"];
                            // ---- Cập nhật thay đổi table
                            _chiTiet.AcceptChanges();
                        }

                    }
                };
            }
            catch (NullReferenceException)
            {
                // ---- Bắt lỗi khi trong dữ liệu không có danh mục
                // ---- Gọi Form tạo danh mục trước tiên
                ShowForm<FrmDanhMuc>();
            }

        }

        private void DM_AddTab(int index, string caption)
        {
            // 
            // tabViewNew
            // 
            var tabViewNew = new BackstageViewClientControl
            {
                Location = new Point(154, 0),
                Name = "tabView",
                Size = new Size(430, 525),
                TabIndex = 0
            };
            // 
            // tabNew
            // 
            var tabNew = new BackstageViewTabItem
            {
                Caption = caption,
                ContentControl = tabViewNew,
                // ---- Sử dụng ImageIndex để lưu biến cờ để nhận biết mã nhóm trong quá trình sự kiện click
                ImageIndex = index,
                Selected = false
            };
            //
            // ------ Thêm tab mới vào trong Danh Mục
            //danhMuc.Items.Add(new BackstageViewItemSeparator());
            danhMuc.Items.Add(tabNew);
        }

        private void danhMuc_SelectedTabChanged(object sender, BackstageViewItemEventArgs e)
        {
            // ---- Hoạt động này sẽ không tác dụng với tab Danh Mục
            if (e.Item !=null)
            {
                // ----- panelGCDanhMuc là panel chứa gcDanhMuc, chuyển panel này sang tab mới khi nhấn vào tab mới
                (e.Item as BackstageViewTabItem).ContentControl.Controls.Add(panelGCDanhMuc);
                // ---- Chuyển nguồn dữ liệu ứng với tab danh mục vừa nhấn
                gcDanhMuc.DataSource = DanhMuc.GetDanhMuc(e.Item.ImageIndex);
                // ---- Thay đổi cờ nhóm danh mục
                _nhom = e.Item.ImageIndex;
            }
        }

        private void bbtnSuaDanhMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<FrmDanhMuc>();
        }

        #endregion


        // --------------------
        // ===============================================================================
        // --------------------


        #region Quản lí Dock Phiếu Thu

        public void InitPhieuThu()
        {
            // ---- Đổ dữ liệu vào Combo khu vực
            comboKhuVuc.DataSource = BAL.KhuVuc.GetKhuVuc();
            comboKhuVuc.ValueMember = "KhuVucID";
            comboKhuVuc.DisplayMember = "Ten";

            // ---- Gán nguồn dữ liệu cho Danh sách phiếu thu
            gcPhieuThu.DataSource = PhieuThu.GetPhieuThu();

            // ---- Khởi tạo sự kiện click cho button xóa 'Del'
            btnDel.Click += delegate
            {
                // ---- Đang ở chế độ chỉnh sửa hoạc thêm mới 
                if (_cheDo != 0 && !gvChiTiet.IsEmpty)
                {
                    // Xóa hàng có index = hàng vừa nhấn button del
                    _chiTiet.Rows.RemoveAt(gvChiTiet.GetFocusedDataSourceRowIndex());
                    // ---- Cập nhật thay đổi
                    _chiTiet.AcceptChanges();
                }
            };
        }


        // ---- Khi một dòng trong Danh Sách phiếu thu được focus
        private void gvPhieuThu_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // ---- Dòng vừa nhấn không phải là dòng mới và chế độ Xem đang bật
            if (!gvPhieuThu.IsNewItemRow(e.FocusedRowHandle) && _cheDo == 0 ) 
            {
                try
                {
                    // ---- Đặt cờ phiếu thu được nhấn
                    _indexPhieuThu = e.FocusedRowHandle;
                    // ---- Thay đổi nguồn dữ liệu của danh sách chi tiết ứng với với hóa đơn vừa nhấn
                    gcChiTiet.DataSource = PhieuThu.GetChiTiet((int) (gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo)));

                    // ---- Bật chức năng xem
                    Set();
                }
                catch
                {
                    // ---- trường hợp không có dòng nào trong danh sách phiếu thu và không bật filter
                    if(!gvPhieuThu.ActiveFilterEnabled)
                        MessageBox.Show("Danh sách phiếu thu trống ! Tạo phiếu thu mới!");
                }

                // ----- Nếu phiếu thu trống không có items thì được phép xoá
                bbtnHuyPhieuThu.Enabled = btnHuyPhieuThu.Enabled = gvChiTiet.IsEmpty;

                // ----- Nếu tab Phiếu thu ở Tab đã thanh toán thì khoá btn thanh toán
                bbtnThanhToan.Enabled = btnThanhToan.Enabled = xtraTabPhieuThu.SelectedTabPageIndex == 0;


            }


        }

        private void gvPhieuThu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // ---- Khi nhấn chuột vào row thì hiện popup quản lý tại vị trí con trỏ
            popupPhieuThu.ShowPopup(new Point(danhMuc.Size.Width + 30, MousePosition.Y - 10));
        }

        private void gcPhieuThu_Enter(object sender, EventArgs e)
        {
            // ---- Chuyển sang tab Quản lý Phiếu Thu
            ribbonControl.SelectedPage = pageQuanLyPhieu;
        }


        private void xtraTabPhieuThu_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabPhieuThu.SelectedTabPageIndex == 1)
            {
                xtraToanBo.Controls.Add(gcPhieuThu);
                thanhToan = true;
            }
            else
            {
                xtraChuaThanhToan.Controls.Add(gcPhieuThu);
                thanhToan = false;
            }
            gcPhieuThu.DataSource = PhieuThu.GetPhieuThu(thanhToan);
        }


        private void btnChinhSuaPT_Click(object sender, EventArgs e)
        {
            bbtnChinhSua_ItemClick(null, null);
        }

        private void btnHuyPhieuThu_Click(object sender, EventArgs e)
        {
            bbtnHuyPhieuThu_ItemClick(null, null);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bbtnThanhToan_ItemClick(null, null);
        }

        private void calcTienNhan_EditValueChanged(object sender, EventArgs e)
        {
            txtTienTra.Text = (calcTienNhan.Value - Decimal.Parse(txtTongTien.Text)).ToString();
        }
        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            bbtnXuatPhieu_ItemClick(null, null);
        }

        private void pbtnThanTOan_Click(object sender, EventArgs e)
        {
            // ---- Lấy ID phiếu thu yêu cầu thành toán
            var id = (int)gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo);
            // ---- nếu số tiền trả không âm thì gọi phương thức thanh toán
            if (int.Parse(txtTienTra.Text) >= 0)
            {
                BAL.PhieuThu.ThanhToanPhieuThu(id, (int)calcTienNhan.Value);
            }
            else
            {
                MessageBox.Show("Chưa nhận đủ tiền! Xin kiểm tra lại!");
            }
            // ---- Reload lại danh sách phiếu thu
            InitPhieuThu();
            // ---- Ẩn popup Thanh Toán
            popupThanhToan.HidePopup();
        }

        private void comboKhuVuc_EditValueChanged(object sender, EventArgs e)
        {
            // ---- Lấy ID phiếu thu dòng vừa thay đổi khu vực
            var id = (int)gvPhieuThu.GetFocusedRowCellValue(PT_colMaSo);
            // ---- Lấy giá trị mới của khu vực
            var khuVuc = (int)(sender as GridLookUpEdit).EditValue;
            // ---- Gọi phương thức updateKhuVuc
            BAL.PhieuThu.UpdateKhuVuc(id, khuVuc);

        }

        private void pbtnTimKiem_Click(object sender, EventArgs e)
        {
            // ---- Hiện panel tìm kiếm
            gvPhieuThu.ShowFindPanel();

        }

        #endregion


        // --------------------
        // ===============================================================================
        // --------------------


        #region Quản Lý Chi Tiết Phiếu Thu


        // ---- Sự kiện khi giá trị một ô đang thay đổi
        private void gvChiTiet_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            // ---- Nếu người dùng đang thay đổi ô số lượng
            if (e.Column == CT_colSoLuong && _cheDo != 0)
            {
                // ---- Lấy đơn giá ứng với hàng đang thay đổi 
                var donGia = (long)gvChiTiet.GetFocusedRowCellValue(CT_colDonGia);
                // ---- Thanh tiền = Đơn giá * số lượng mới
                long thanhTien = int.Parse(e.Value.ToString()) >= 0 ? donGia * int.Parse(e.Value.ToString()) : donGia;
                // ---- Thay đổi trong gvChiTiet
                gvChiTiet.SetRowCellValue(e.RowHandle, CT_colThanhTien, thanhTien);
            }

        }

        #endregion

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var danhMuc = new XuatDanhMuc();
            danhMuc.ShowPreview();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var danhMuc = new ReportDoanhThu();
            danhMuc.ShowPreview();
        }

        private void gvPhieuThu_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

       

 

    


        // --------------------
        // ===============================================================================
        // --------------------


    

      


    
       
       

        

       
       

      
        
    }
}