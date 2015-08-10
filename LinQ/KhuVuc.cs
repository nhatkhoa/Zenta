using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DAL;

namespace BAL
{
    public class KhuVuc
    {
        
        public static DataTable GetKhuVuc()
        {
            using (var db = new DB())
            {
                return DAL.Convert.CreateTable(db.KhuVucs.Select(p => new
                {
                    p.KhuVucID,
                    p.Ten,
                    p.SoBan,

                }));
            }
        }

        public static Dictionary<int, string> ListKhuVuc()
        {
            using (var db = new DB())
            {
                return db.KhuVucs.ToDictionary(p => p.KhuVucID, t => t.Ten);
            }
        }

        public static void AddKhuVuc(string ten, int soBan)
        {
            // ---- Tạo mới một đối tượng Khu Vực
            var kv = new DAL.KhuVuc()
            {
                Ten = ten,
                SoBan = soBan
            };

            // ---- Khai báo sử dụng biến db là đối tượng DB linq
            using (var db = new DB())
            {
                // ---- Gọi phương thức thêm mới một đối tượng khu vực
                db.KhuVucs.InsertOnSubmit(kv);
                // ---- Cập nhật vào cơ sở dữ liệu
                db.SubmitChanges();
            }
            
        }

        public static void UpdateKhuVuc(int id, string ten, int soBan)
        {
            using (var db = new DB())
            {
                try
                {
                    // ---- Truy vấn đến đối tượng (đầu tiên) có id trùng với id truyền vào
                    var kv = db.KhuVucs.Single(p => p.KhuVucID.Equals(id));
                    // ---- Thay đổi giá trị 
                    kv.Ten = ten;
                    kv.SoBan = soBan;
                    // ---- Cập nhật vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
                catch
                {
                    // ---- Trường hợp cơ sở dữ liệu không tồn tại id trùng
                }
                
            }
        }

        public static bool DelKhuVuc(int id)
        {
            using (var db = new DB())
            {
                try
                {
                    // ---- Truy vấn đến đối tượng (đầu tiên) có id trùng với id truyền vào
                    var kv = db.KhuVucs.Single(p => p.KhuVucID.Equals(id));
                    // ---- Gọi phương thức xóa kv trên
                    db.KhuVucs.DeleteOnSubmit(kv);
                    // ---- Cập nhật lên cơ sở dữ liệu
                    db.SubmitChanges();
                    // ---- Báo xóa thành công
                    return true;
                }
                catch (SqlException)
                {
                    // ---- Trường hợp cơ sở dữ liệu không tồn tại id trùng
                    // ---- Trường hợp không xóa được do SQL error
                    // ---- Báo xóa không thành công
                    return false;
                }

            }
        }
    }
}
