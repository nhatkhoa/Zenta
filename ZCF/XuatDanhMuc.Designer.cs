namespace ZCF
{
    partial class XuatDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.maDanhMuc = new DevExpress.XtraReports.UI.XRTableCell();
            this.tenDanhMuc = new DevExpress.XtraReports.UI.XRTableCell();
            this.donGia = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.LabelNhom = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.evenRow = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.EvenStyleName = "evenRow";
            this.Detail.ForeColor = System.Drawing.Color.DimGray;
            this.Detail.HeightF = 23.12501F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseForeColor = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.ForeColor = System.Drawing.Color.DimGray;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(1.589457E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 23.12499F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.maDanhMuc,
            this.tenDanhMuc,
            this.donGia});
            this.xrTableRow2.ForeColor = System.Drawing.Color.DimGray;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseForeColor = false;
            this.xrTableRow2.Weight = 1D;
            // 
            // maDanhMuc
            // 
            this.maDanhMuc.ForeColor = System.Drawing.Color.DimGray;
            this.maDanhMuc.Name = "maDanhMuc";
            this.maDanhMuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.maDanhMuc.StylePriority.UseForeColor = false;
            this.maDanhMuc.StylePriority.UsePadding = false;
            this.maDanhMuc.Text = "maDanhMuc";
            this.maDanhMuc.Weight = 0.92708328247070293D;
            // 
            // tenDanhMuc
            // 
            this.tenDanhMuc.ForeColor = System.Drawing.Color.DimGray;
            this.tenDanhMuc.Name = "tenDanhMuc";
            this.tenDanhMuc.StylePriority.UseForeColor = false;
            this.tenDanhMuc.Text = "tenDanhMuc";
            this.tenDanhMuc.Weight = 3.2916667175292971D;
            // 
            // donGia
            // 
            this.donGia.ForeColor = System.Drawing.Color.DimGray;
            this.donGia.Name = "donGia";
            this.donGia.StylePriority.UseForeColor = false;
            xrSummary1.FormatString = "{0:000 000 000 VNĐ}";
            this.donGia.Summary = xrSummary1;
            this.donGia.Text = "donGia";
            this.donGia.Weight = 2.28125D;
            // 
            // TopMargin
            // 
            this.TopMargin.ForeColor = System.Drawing.Color.DimGray;
            this.TopMargin.HeightF = 14.58333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseForeColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.ForeColor = System.Drawing.Color.DimGray;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseForeColor = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrLine1,
            this.LabelNhom});
            this.GroupHeader1.ForeColor = System.Drawing.Color.DimGray;
            this.GroupHeader1.HeightF = 76.9583F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StylePriority.UseForeColor = false;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.ForeColor = System.Drawing.Color.DimGray;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.33328F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 30.62502F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseForeColor = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.ForeColor = System.Drawing.Color.DimGray;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseForeColor = false;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ForeColor = System.Drawing.Color.DimGray;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.Text = "ID";
            this.xrTableCell1.Weight = 0.92708335876464842D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ForeColor = System.Drawing.Color.DimGray;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.Text = "Tên Danh Mục";
            this.xrTableCell2.Weight = 3.2916666412353512D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ForeColor = System.Drawing.Color.DimGray;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.Text = "Đơn Giá";
            this.xrTableCell3.Weight = 2.28125D;
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.DimGray;
            this.xrLine1.LineWidth = 4;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.33329F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 4F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // LabelNhom
            // 
            this.LabelNhom.BackColor = System.Drawing.Color.RosyBrown;
            this.LabelNhom.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhom.ForeColor = System.Drawing.Color.White;
            this.LabelNhom.LocationFloat = new DevExpress.Utils.PointFloat(313.5416F, 0F);
            this.LabelNhom.Name = "LabelNhom";
            this.LabelNhom.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LabelNhom.SizeF = new System.Drawing.SizeF(336.4584F, 42.54166F);
            this.LabelNhom.StylePriority.UseBackColor = false;
            this.LabelNhom.StylePriority.UseFont = false;
            this.LabelNhom.StylePriority.UseForeColor = false;
            this.LabelNhom.StylePriority.UseTextAlignment = false;
            this.LabelNhom.Text = "  [CategoryName]";
            this.LabelNhom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3});
            this.GroupFooter1.ForeColor = System.Drawing.Color.DimGray;
            this.GroupFooter1.HeightF = 30.20833F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StylePriority.UseForeColor = false;
            // 
            // xrLine3
            // 
            this.xrLine3.ForeColor = System.Drawing.Color.DimGray;
            this.xrLine3.LineWidth = 4;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(650F, 4F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // evenRow
            // 
            this.evenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.evenRow.ForeColor = System.Drawing.Color.Black;
            this.evenRow.Name = "evenRow";
            this.evenRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // XuatDanhMuc
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 15, 0);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.evenRow});
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel LabelNhom;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell maDanhMuc;
        private DevExpress.XtraReports.UI.XRTableCell tenDanhMuc;
        private DevExpress.XtraReports.UI.XRTableCell donGia;
        private DevExpress.XtraReports.UI.XRControlStyle evenRow;
    }
}
