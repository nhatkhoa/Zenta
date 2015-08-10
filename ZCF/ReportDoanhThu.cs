using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ZCF
{
    public partial class ReportDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDoanhThu()
        {
            InitializeComponent();
            InitialData();
        }

        private void InitialData()
        {
            Thang.Value = 5;
            DataSource = BAL.Report.DoanhThu((int)Thang.RawValue);

            ID.DataBindings.Add("Text", DataSource, "PhieuThuID");
            ThoiGian.DataBindings.Add("Text", DataSource, "ThoiGian");
            KhuVuc.DataBindings.Add("Text", DataSource, "KhuVuc");
            ThuNgan.DataBindings.Add("Text", DataSource, "NguoiTao");
            TongTien.DataBindings.Add("Text", DataSource, "TongTien", "{0:n0} VNĐ");
            

            GroupHeader1.SortingSummary.FieldName = "TongTien";
            TongCong.DataBindings.Add("Text", DataSource, "TongTien", "{0:n0} VNĐ");

            NgayTao.DataBindings.Add("Text", DataSource, "Ngay");


            Detail.SortFields.Add(new GroupField("Ngay"));
            GroupHeader1.GroupFields.Add(new GroupField("Ngay"));
        }

    }
}
