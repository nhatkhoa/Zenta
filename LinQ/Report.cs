using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Convert = DAL.Convert;

namespace BAL
{
    public class Report
    {

        public static DataTable ReportDanhMuc()
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Lấy danh mục trùng nhóm truyền vào và chưa xoá
                    return DAL.Convert.CreateTable(db.DanhMucs.Where(p => !p.Xoa.Value)
                        .Select(p => new
                        {
                            p.DanhMucID,
                            TenNhom = p.NhomDM.Ten,
                            p.Ten,
                            p.DonGia
                        }));
                }
            }
            catch
            {
                return null;
            }
        }
        public static DataTable GetPhieuThu()
        {
            try
            {
                using (var db = new DB())
                {
                    return Convert.CreateTable(db.PhieuThus.Select(p => new
                    {
                        p.PhieuThuID,
                        p.ThoiGian,
                        Nam = p.ThoiGian.Value.Year, 
                        Thang = p.ThoiGian.Value.Month,
                        Ngay = p.ThoiGian.Value.Day,
                        Gio = p.ThoiGian.Value.Hour,
                        Person = p.NguoiDung1.HoTen,
                        KhuVuc = p.KhuVuc1.Ten,
                        p.TongTien,
                        p.SoNguoi
                    }));
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GetLuongKhachTheoKhuVuc()
        {
            try
            {
                using (var db = new DB())
                {
                    return Convert.CreateTable(db.PhieuThus.Where(p=>!p.ThanhToan.Value).Select(p => new
                    {
                        p.PhieuThuID,
                        KhuVuc = p.KhuVuc1.Ten,
                        p.TongTien,
                        p.SoNguoi
                    }));
                }
            }
            catch
            {
                return null;
            }
        }
    
        public static DataTable DoanhThu(int thang)
        {
            try
            {
                using (var db = new DB())
                {
                    var doanhThu = db.PhieuThus
                        .Where(p=> p.ThoiGian.Value.Month.Equals(thang) && p.ThoiGian.Value.Year.Equals(DateTime.Now.Year))
                        .Select(p => new
                    {
                        p.PhieuThuID,
                        Ngay = p.ThoiGian.Value.Day,
                        p.ThoiGian,
                        NguoiTao = p.NguoiDung1.HoTen,
                        p.TongTien,
                        p.SoNguoi,
                        KhuVuc = p.KhuVuc1.Ten
                    });
                    return Convert.CreateTable(doanhThu);
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataTable PhieuThu(int phieuThu)
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
                            dm.Ten,
                            dm.DonGia,
                            ct.SoLuong,
                            ThanhTien = ct.SoLuong * dm.DonGia,
                        }));
            }

        }

        public static DataTable DoanhThuTheoKhuVuc(int khuVuc)
        {
            try
            {
                using (var db = new DB())
                {
                    var temp = db.PhieuThus.Where(p=>p.KhuVuc.Equals(khuVuc) && p.ThoiGian.Value.Day == DateTime.Now.Day)
                        .Select(p => new
                    {
                        p.ThoiGian.Value.Hour,
                        p.TongTien
                    })
                    .GroupBy(p => p.Hour)
                    .Select(p => new
                    {
                        Hour = p.Key,
                        TongTien = p.Sum(t => t.TongTien).Value
                    });

                    return Convert.CreateTable(temp);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
