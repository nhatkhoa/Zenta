using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class CauHinh
    {
        public static int NhomChinh()
        {
            using (var db = new DB())
            {
                var tuyChinh = db.CauHinhs.Single(p => p.TenCauHinh.Equals("Nhóm Chính")).TuyChinh;
                if (tuyChinh != null)
                {
                    return tuyChinh.Value;

                }
                db.CauHinhs.InsertOnSubmit(new DAL.CauHinh() {TenCauHinh = "Nhóm Chính", TuyChinh = 1});
                return db.CauHinhs.Single(p => p.TenCauHinh.Equals("Nhóm Chính")).TuyChinh.Value;
            }
        }
        public static int AdminChinh()
        {
            using (var db = new DB())
            {
                var tuyChinh = db.CauHinhs.Single(p => p.TenCauHinh.Equals("Master Admin")).TuyChinh;
                if (tuyChinh != null)
                {
                    return tuyChinh.Value;

                }
                db.CauHinhs.InsertOnSubmit(new DAL.CauHinh() { TenCauHinh = "Master Admin", TuyChinh = 1 });
                return db.CauHinhs.Single(p => p.TenCauHinh.Equals("Master Admin")).TuyChinh.Value;
            }
        }

        public static void SetAdminChinh(int admin)
        {
            using (var db = new DB())
            {
                var ad = db.CauHinhs.Single(p => p.TenCauHinh.Contains("Master Admin"));
                if (ad != null)
                {
                    ad.TuyChinh = admin;
                    db.SubmitChanges();
                }
                else
                {
                    db.CauHinhs.InsertOnSubmit(new DAL.CauHinh()
                    {
                        TenCauHinh = "Master Admin",
                        TuyChinh = admin
                    });
                    db.SubmitChanges();
                    
                }
                db.SubmitChanges();
            }
        }
    }
}
