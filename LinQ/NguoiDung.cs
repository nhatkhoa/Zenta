using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using DAL;

namespace BAL
{
    public class NguoiDung
    {
        public static int DaDangNhap;

        public static object[] GetObjectNguoiDung(int id)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Truy vấn toàn bộ danh sách người dùng
                    var nd = db.NguoiDungs.Single(p => p.NguoiDungID.Equals(id));

                    // ---- Khởi tạo một Mảng Object để chứa thông tin
                    var obj= new Object[]
                    {
                        nd.NguoiDungID,
                        nd.HoTen,
                        nd.TaiKhoan,
                        nd.TaiKhoan,
                        nd.MatKhau,
                        nd.QuanTri
                    };
                    
                   

                    // ---- Trả về dưới dạng data table
                    return obj;
                }
            }
            catch
            {
                return null;
            }
        }
        public static DataTable GetListNguoiDung()
        {
            using (var db = new DB())
            {
                // ---- Truy vấn toàn bộ danh sách người dùng chưa bị xoá
                var nd = db.NguoiDungs.Where(p=> !p.Xoa.Value)
                    .Select(p => new
                {
                    p.NguoiDungID,
                    p.HoTen,
                    p.TaiKhoan,
                    p.MatKhau,
                    p.QuanTri,
                    AD = p.NguoiDungID == CauHinh.AdminChinh()
                });
                // ---- Trả về dưới dạng data table
                return DAL.Convert.CreateTable(nd);
            }
        }

        public static DataTable GetThungRac()
        {
            using (var db = new DB())
            {
                // ---- Truy vấn toàn bộ danh sách người dùng đã bị xoá
                var nd = db.NguoiDungs.Where(p => p.Xoa.Value)
                    .Select(p => new
                    {
                        p.NguoiDungID,
                        p.HoTen,
                        p.TaiKhoan,
                        p.QuanTri
                    });
                // ---- Trả về dưới dạng data table
                return DAL.Convert.CreateTable(nd);
            }
        }

        public static void PhucHoi(int id)
        {
            using (var db = new DB())
            {
                // ---- Truy vấn đến người dùng có id trùng với id truyền vào
                var nd = db.NguoiDungs.Single(p => p.NguoiDungID.Equals(id));
                // ---- Đặt lại cờ xoá bằng =false
                nd.Xoa = false;
                // ---- Cập nhật thay đổi CSDL
                db.SubmitChanges();
                // 
            }
        }

        public static int Login(string taiKhoan, string matKhau)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- truy vấn đến người dùng có tài khoản trùng và chưa bị xoá
                    var nd = db.NguoiDungs
                        .Single(p => !p.Xoa.Value && p.TaiKhoan.Equals(taiKhoan) && p.MatKhau.Equals(matKhau));
                    // ---- Gán id người đã đăng nhập bằng id mới
                    DaDangNhap = nd.NguoiDungID;
                    // ---- Trả về true nếu có tồn tại người dùng trong truy vấn
                    return nd.NguoiDungID;
                }
            }
            catch
            {
                return 0;
            }

        }
        public static Dictionary<string,object> GetNguoiDung(int id)
        {
            try
            {
                using (var db = new DB())
                {
                    // ---- Truy vấn toàn bộ danh sách người dùng
                    var nd = db.NguoiDungs.Single(p => p.NguoiDungID.Equals(id));

                    // ---- Khởi tạo một dictionary để chứa thông tin
                    var dic = new Dictionary<string, object>
                    {
                        {"ID", nd.NguoiDungID},
                        {"HoTen", nd.HoTen},
                        {"TaiKhoan", nd.TaiKhoan},
                        {"MatKhau", nd.MatKhau},
                        {"QuanTri", nd.QuanTri}
                    };

                    // ---- Trả về dưới dạng data table
                    return dic;
                }
            }
            catch
            {
                // ---- Lỗi trả về người dùng null
                var dic = new Dictionary<string, object>
                    {
                        {"ID", -1},
                        {"HoTen", "Không có người dùng"},
                        {"TaiKhoan", "None"},
                        {"MatKhau", ""},
                        {"QuanTri", "false"}
                    };

                // ---- Trả về dưới dạng data table
                return dic;
            }
        }
        public static void AddNguoiDung(string hoTen, string taiKhoan, string matKhau, bool quanTri)
        {
            using (var db = new DB())
            {
               // ---- Khởi tạo một đối tượng Người Dùng mới
                var nd = new DAL.NguoiDung()
                {
                    HoTen = hoTen,
                    TaiKhoan = taiKhoan,
                    MatKhau = matKhau,
                    QuanTri = quanTri,
                    Xoa = false
                };
                // ---- Thêm vào CSDL
                db.NguoiDungs.InsertOnSubmit(nd);

                // ---- Cập nhật thay đổi lên CSDL
                db.SubmitChanges();
            }
        }

        public static void UpdateNguoiDung(int id, string hoTen, string taiKhoan, string matKhau, bool quanTri)
        {
            using (var db = new DB())
            {
                // ---- Truy vấn người dùng (đầu tiên) có id truyền vào
                var nd = db.NguoiDungs.Single(p => p.NguoiDungID.Equals(id));
                // ---- Thay đổi giá trị
                nd.HoTen = hoTen;
                nd.TaiKhoan = taiKhoan;
                nd.MatKhau = matKhau;
                nd.QuanTri = quanTri;
                // ---- Cập nhật thay đổi lên CSDL
                db.SubmitChanges();
            }
        }

        public static bool DelNguoiDung(int id)
        {
            // ---- Nếu người dùng là Admin quản trị chính thì không xoá và trả về false 
            if (CauHinh.AdminChinh() == id)
                return true;
            try
            {
                using (var db = new DB())
                {
                    // ---- Truy vấn đến người dùng có id trùng với id truyền vào
                    var nd = db.NguoiDungs.Single(p => p.NguoiDungID.Equals(id));
                    // ---- Gọi phương thức xóa
                    db.NguoiDungs.DeleteOnSubmit(nd);
                    // ---- Cập nhật thay đổi CSDL
                    db.SubmitChanges();
                    // 
                    return true;
                }
            }
            catch (SqlException)
            {
                using (var db = new DB())
                {
                    // ---- trường hợp không thể xóa do không tồn tại hoặc đang sử dụng
                    // ---- Truy vấn đến người dùng có id trùng với id truyền vào
                    var nd = db.NguoiDungs.Single(p => p.NguoiDungID.Equals(id));
                    // ---- Đưa vào thùng rác (Đặt cờ xoá = true)
                    nd.Xoa = true;
                    // ---- Cập nhật thay đổi CSDL
                    db.SubmitChanges();
                    // 
                }
                return false;
            }

        }
    }
}
