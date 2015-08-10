using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ZCF
{
    public partial class XuatDanhMuc : DevExpress.XtraReports.UI.XtraReport
    {
        public XuatDanhMuc()
        {
            InitializeComponent();
            InitialData();
        }

        private void InitialData()
        {
            DataSource = BAL.Report.ReportDanhMuc();

            maDanhMuc.DataBindings.Add("Text", DataSource, "DanhMucID", "DM{0:000}");
            tenDanhMuc.DataBindings.Add("Text", DataSource, "Ten");
            donGia.DataBindings.Add("Text", DataSource, "DonGia", "{0:n0} VNĐ");

            LabelNhom.DataBindings.Add("Text", DataSource, "TenNhom");


            Detail.SortFields.Add(new GroupField("TenNhom"));
            GroupHeader1.GroupFields.Add(new GroupField("TenNhom"));
        }
    }
}
