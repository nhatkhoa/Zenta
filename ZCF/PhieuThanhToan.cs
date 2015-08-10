using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using BAL;
using DevExpress.XtraReports.UI;

namespace ZCF
{
    public partial class PhieuThanhToan : DevExpress.XtraReports.UI.XtraReport
    {
        private DataSet ds=new DataSet();
        public PhieuThanhToan(int phieuThu) 
        {
            InitializeComponent();


            DataSource = BAL.Report.PhieuThu(phieuThu);

            xrTableCell4.DataBindings.Add("Text", DataSource, "Ten");
            xrTableCell5.DataBindings.Add("Text", DataSource, "DonGia");

            xrTableCell6.DataBindings.Add("Text", DataSource, "SoLuong");
            xrTableCell7.DataBindings.Add("Text", DataSource, "ThanhTien", "{0:n0} VNĐ");
            MaPhieuThu.Text = phieuThu.ToString("PT00000");





        }

    }
}
