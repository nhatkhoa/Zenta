using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL

{
    public class DanhMuc
    {


        public static Dictionary<int,string> GetNhom()
        {
            try
            {
                using (var db = new DB())
                {
                    return db.NhomDMs.ToDictionary(p => p.NhomID, t => t.Ten);
                }
                
            }
            catch
            {
                return null;
            }
        }

        public static string GetTenNhom(int id)
        {
            try
            {
                using (var db = new DB())
                {
                    return db.NhomDMs.Single(p=>p.NhomID.Equals(id)).Ten;
                }

            }
            catch
            {
                return null;
            }
        }
        public static DataTable TableNhom()
        {
            using (var db = new DB())
            {
                return DAL.Convert.CreateTable(db.NhomDMs.Select(p => new
                {
                    p.NhomID,
                    p.Ten
                }));
            }

        }

        public static void AddNhom(string ten)
        {
            using (var db = new DB())
            {
                // ---- Tạo mới một Nhóm danh mục và thêm nó vào Nhom Table
                db.NhomDMs.InsertOnSubmit(new NhomDM()
                {
                    Ten = ten
                });
                // ---- Cập nhật lên cơ sở dữ liệu
                db.SubmitChanges();
            }
        }

        public static void UpdateNhom(int id, string ten)
        {
            using (var db = new DB())
            {
                // ---- truy vấn đên nhom danh mục trùng tên rồi thay đổi tên của nhóm đó
                db.NhomDMs.Single(p => p.NhomID.Equals(id)).Ten = ten;
                // ---- Cập nhật lên dữ liệu
                db.SubmitChanges();
            }
        }

        public static bool DelNhom(int id)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Xóa nhóm ứng với id
                    db.NhomDMs.DeleteOnSubmit(db.NhomDMs.Single(p => p.NhomID.Equals(id)));
                    //---- Cập nhật
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static DataTable GetThungRac()
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Lấy danh mục trong thùng rác
                    return DAL.Convert.CreateTable(db.DanhMucs.Where(p => p.Xoa.Value)
                        .Select(p => new
                        {
                            p.DanhMucID,
                            Nhom = p.NhomDM.Ten,
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

        public static bool PhucHoi(int id)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Truy vấn đến danh mục trùng với id yêu cầu
                    var danhMuc = db.DanhMucs.Single(p => p.DanhMucID.Equals(id));
                   // ---- Thay đổi cờ xoá
                    danhMuc.Xoa = false;
                    // ---- Cập nhật thay đổi trong cơ sở dữ liệu
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static DataTable GetDanhMuc(int nhom)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Lấy danh mục trùng nhóm truyền vào và chưa xoá
                    return DAL.Convert.CreateTable(db.DanhMucs.Where(p => p.Nhom.Equals(nhom) && !p.Xoa.Value)
                        .Select(p => new
                    {
                        p.DanhMucID,
                        p.Nhom,
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
        public static DataTable GetAllDanhMuc()
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Lấy danh mục trùng nhóm truyền vào và chưa xoá
                    return DAL.Convert.CreateTable(db.DanhMucs.Where(p =>!p.Xoa.Value)
                        .Select(p => new
                        {
                            p.DanhMucID,
                            p.Nhom,
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

        public static void AddDanhMuc(int nhom, string ten, long donGia)
        {
            using (var db = new DB())
            {
                // ---- Khởi tạo một đối tượng linq Danh Mục mới
                var danhMuc = new DAL.DanhMuc()
                {
                    DonGia = donGia,
                    Ten = ten,
                    Nhom = nhom,
                    Xoa = false
                };
                // ---- Thêm danh mục vừa tạo vào Danh Mục Table
                db.DanhMucs.InsertOnSubmit(danhMuc);
                // ---- Cập nhật lno1 lên cơ sở dữ liệu
                db.SubmitChanges();
            }
        }

        public static bool UpdateDanhMuc(int id, int nhom, string ten, long donGia)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Truy vấn đến danh mục trùng với id yêu cầu
                    var danhMuc = db.DanhMucs.Single(p => p.DanhMucID.Equals(id));
                    // ---- Thay đổi giá trị của danh mục tìm thấy
                    danhMuc.Ten = ten;
                    danhMuc.DonGia = donGia;
                    // ---- Cập nhật thay đổi trong cơ sở dữ liệu
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DelDanhMuc(int id)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Truy vấn đến danh mục trùng với id yêu cầu
                    var danhMuc = db.DanhMucs.Single(p => p.DanhMucID.Equals(id));
                    // ---- Xóa nó trong Danh Mục table
                    db.DanhMucs.DeleteOnSubmit(danhMuc);
                    // ---- Cập nhật nó cơ sở dữ liệu
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                // ---- Trường hợp không xoá được do danh mục đang được sử dụng thì thêm nó vào thùng rác

                using (var db = new DB())
                {
                    // ---- Truy vấn đến danh mục trùng với id yêu cầu
                    var danhMuc = db.DanhMucs.Single(p => p.DanhMucID.Equals(id));
                    // ---- Cho nó vào thùng rác chứ không xoá => Đảm bảo hoạt động của các phiếu thu
                    danhMuc.Xoa = true;
                    // ---- Cập nhật nó cơ sở dữ liệu
                    db.SubmitChanges();
                }

                return false;

            }
        }
    }
}
