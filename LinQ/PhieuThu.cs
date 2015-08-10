using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Linq;
using DAL;
using Convert = DAL.Convert;

namespace BAL

{
    public class PhieuThu
    {

        public static DataTable GetPhieuThu(bool thanhToan = false)
        {
            try
            {
                using (var db = new DB())
                {
                    return Convert.CreateTable(db.PhieuThus.Where(p => p.ThanhToan.Equals(thanhToan)).Select(p=> new
                    {
                        p.PhieuThuID,
                        p.ThoiGian,
                        NguoiDung = p.NguoiDung1.HoTen,
                        p.TongTien,
                        p.TienNhan,
                        p.KhuVuc,
                        p.SoNguoi
                    }));
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GetChiTiet(int phieuThu)
        {
            try
            {
                using (var db = new DB())
                {
                // ---- Join Danh mục với nhóm danh mục
                var danhMuc = db.DanhMucs.Join(db.NhomDMs, dm => dm.Nhom, nhom => nhom.NhomID, (dm, nhom) => new
                {
                    dm.DanhMucID,
                    Nhom = nhom.Ten,
                    dm.Ten,
                    dm.DonGia

                });
                
                    // ----- Join 3 bảng chi tiết, danh mục, nhóm danh mục
                    return Convert.CreateTable(db.ChiTietPTs.Where(p => p.PhieuThu.Equals(phieuThu))
                        .Join(danhMuc, ct => ct.DanhMuc, dm => dm.DanhMucID,
                            (ct, dm) => new
                            {
                                dm.DanhMucID,
                                dm.Nhom,
                                dm.Ten,
                                dm.DonGia,
                                ct.SoLuong,
                                ThanhTien = ct.SoLuong*dm.DonGia,
                                ThaoTac = 0,
                            }));
                }
            }
            catch
            {
                return null;
            }
        }

        public static int AddPhieuThu(int nguoiDung, int khuVuc)
        {
            using (var db = new DB())
            {
                // ---- Tạo mới một đối tượng phiếu thu
                var phieuThu = new DAL.PhieuThu()
                {
                    NguoiDung = nguoiDung,
                    KhuVuc = khuVuc,
                    // ---- Lấy thời gian hiện tại
                    ThoiGian = DateTime.Now,
                    // ---- Tổng tiền ban đầu bằng 0 khi thêm chi tiết sẽ tự cập nhật
                    TongTien = 0,
                    // ---- Tiền nhận cập nhật khi thanh toán phiếu thu
                    TienNhan = 0,
                    SoNguoi = 1,
                    ThanhToan = false,
                };
                // ---- Thêm phiếu thu vào cơ sở dữ liệu
                db.PhieuThus.InsertOnSubmit(phieuThu);
                // ---- Cập nhật thay đổi
                db.SubmitChanges();
                // ---- Trả về PhieuThuID mới thêm vào
                return phieuThu.PhieuThuID;
            }
        }

        public static void UpdateChiTiet(int phieuThu, DataTable chiTiet)
        {
            using (var db = new DB())
            {
                // ---- Lấy danh sách items thuộc nhóm chính => số người
                var soNguoi =
                    chiTiet.Select()
                        .Where(p => p["Nhom"].Equals(DanhMuc.GetTenNhom(CauHinh.NhomChinh())))
                        .Sum(p => (int) p["SoLuong"]);
                // ---- Chuyển toàn bộ table chi tiết qua danh sách ChiTietPT
                var listMoi = chiTiet.Select().Select(p => new ChiTietPT()
                {
                    PhieuThu = phieuThu,
                    DanhMuc = (int) p["DanhMucID"],
                    SoLuong = (int) p["SoLuong"]
                });
                // ---- Danh sách các danh mục từ ChiTiet mới
                var danhMucMoi = listMoi.Select(p => p.DanhMuc);

                // ---- Truy vấn danh sách chi tiết gốc
                var listCu = db.ChiTietPTs.Where(p => p.PhieuThu.Equals(phieuThu));
                // ---- CDanh sách danh mục từ chi tiết gốc
                var danhMucCu = listCu.Select(p => p.DanhMuc);


                // ---- Nếu DS cũ rỗng thì thêm toàn bộ chi tiết trong list vào cơ sở dữ liệu
                if (listCu.Count() == 0)
                {
                    db.ChiTietPTs.InsertAllOnSubmit(listMoi);
                    db.SubmitChanges();
                }
                else
                {
                    // ------- Truy vấn danh sách phần tử trong danh sách cũ không tồn tại trong danh sách mới
                    var del = listCu.Where(p => !danhMucMoi.Contains(p.DanhMuc));
                    // ---- Xóa danh sách del khỏi CSDL
                    db.ChiTietPTs.DeleteAllOnSubmit(del);
                    // ---- Cập nhật thay đổi
                    db.SubmitChanges();

                    // ---- Truy vấn những phần tử trong list mới mà không tồn tại trong danh sách cũ
                    var neW = listMoi.Where(p => !danhMucCu.Contains(p.DanhMuc));
                    // ---- Thêm vào CSDL
                    db.ChiTietPTs.InsertAllOnSubmit(neW);
                    // ---- Cập nhật thay đổi
                    db.SubmitChanges();

                    // ---- Truy vấn những phần tử trong list mới mà danh mục nó tồn tại trong DS cũ nhưng khác về số lượng
                    var update = listMoi.Where(p =>listCu.Any(t=>t.DanhMuc.Equals(p.DanhMuc) && !t.SoLuong.Equals(p.SoLuong)));
                    foreach (var i in update)
                    {
                        
                        // ---- Với mỗi chi tiết trùng thì cập nhật số lượng mới
                        db.ChiTietPTs.Single(p => i.DanhMuc.Equals(p.DanhMuc) && p.PhieuThu.Equals(phieuThu)).SoLuong = i.SoLuong;
                        // ---- Cập nhật thay đổi
                        db.SubmitChanges();
                    }
                }

                // ----- Cập nhật Tổng tiền cho phiếu thu vừa thao tác
                var pt = db.PhieuThus.Single(p => p.PhieuThuID.Equals(phieuThu));
                pt.TongTien = chiTiet.Select().Sum(p => (long) p["ThanhTien"]);
                pt.SoNguoi = soNguoi > 0 ? soNguoi : 1;
                // ----- Cập nhật thay đổi
                db.SubmitChanges();
            }

        }

        public static bool UpdateKhuVuc(int phieuThu, int khuVuc)
        {
            try
            {
                using (var db = new DB())
                {
                    // ----  Truy vấn đến phiếu thu cần xóa
                    var pt = db.PhieuThus.Single(p => p.PhieuThuID.Equals(phieuThu));
                    // --- Thay đổi giá trị
                    pt.KhuVuc = khuVuc;
                    // ---- Cập nhật thay đổi
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ThanhToanPhieuThu(int phieuThu, int tienNhan)
        {
            try
            {
                using (var db = new DB())
                {
                    // ----  Truy vấn đến phiếu thu cần xóa
                    var pt = db.PhieuThus.Single(p => p.PhieuThuID.Equals(phieuThu));
                    // ---- Thay đổi cờ thanh toán
                    pt.ThanhToan = true;
                    if (tienNhan > 0)
                    {
                        pt.TienNhan = tienNhan;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    // ---- Cập nhật thay đổi
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DelPhieuThu(int phieuThu)
        {
            try
            {
                using (var db = new DB())
                {
                    // ----  Truy vấn đến phiếu thu cần xóa
                    var del = db.PhieuThus.Single(p => p.PhieuThuID.Equals(phieuThu));
                    // ---- Xóa khỏi CSDL
                    db.PhieuThus.DeleteOnSubmit(del);
                    // ---- Cập nhật thay đổi
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

