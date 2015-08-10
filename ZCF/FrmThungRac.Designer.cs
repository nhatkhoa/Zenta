namespace ZCF
{
    partial class FrmThungRac
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThungRac));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraThungRac = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabDanhMuc = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDanhMucPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabNguoiDung = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gcNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnNguoiDungPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraThungRac)).BeginInit();
            this.xtraThungRac.SuspendLayout();
            this.xtraTabDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.xtraTabNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(10, 10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(533, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(485, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(41, 38);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Exit";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thùng Rác Hệ Thống";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.xtraThungRac);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(10, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(533, 276);
            this.panelControl2.TabIndex = 0;
            // 
            // xtraThungRac
            // 
            this.xtraThungRac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraThungRac.Location = new System.Drawing.Point(0, 0);
            this.xtraThungRac.Name = "xtraThungRac";
            this.xtraThungRac.SelectedTabPage = this.xtraTabDanhMuc;
            this.xtraThungRac.Size = new System.Drawing.Size(533, 276);
            this.xtraThungRac.TabIndex = 0;
            this.xtraThungRac.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabDanhMuc,
            this.xtraTabNguoiDung});
            // 
            // xtraTabDanhMuc
            // 
            this.xtraTabDanhMuc.Controls.Add(this.panelControl4);
            this.xtraTabDanhMuc.Controls.Add(this.panelControl3);
            this.xtraTabDanhMuc.Name = "xtraTabDanhMuc";
            this.xtraTabDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.xtraTabDanhMuc.Size = new System.Drawing.Size(527, 248);
            this.xtraTabDanhMuc.Text = "Thùng Rác Danh Mục";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.gcDanhMuc);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(3, 3);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(488, 242);
            this.panelControl4.TabIndex = 0;
            // 
            // gcDanhMuc
            // 
            this.gcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.gcDanhMuc.MainView = this.gvDanhMuc;
            this.gcDanhMuc.Name = "gcDanhMuc";
            this.gcDanhMuc.Size = new System.Drawing.Size(488, 242);
            this.gcDanhMuc.TabIndex = 1;
            this.gcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvDanhMuc.GridControl = this.gcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsBehavior.Editable = false;
            this.gvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.gvDanhMuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhMuc_FocusedRowChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.btnDanhMucPhucHoi);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(491, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(33, 242);
            this.panelControl3.TabIndex = 0;
            // 
            // btnDanhMucPhucHoi
            // 
            this.btnDanhMucPhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucPhucHoi.Image")));
            this.btnDanhMucPhucHoi.Location = new System.Drawing.Point(5, 21);
            this.btnDanhMucPhucHoi.Name = "btnDanhMucPhucHoi";
            this.btnDanhMucPhucHoi.Size = new System.Drawing.Size(24, 23);
            this.btnDanhMucPhucHoi.TabIndex = 0;
            this.btnDanhMucPhucHoi.Click += new System.EventHandler(this.btnDanhMucPhucHoi_Click);
            // 
            // xtraTabNguoiDung
            // 
            this.xtraTabNguoiDung.Controls.Add(this.panelControl5);
            this.xtraTabNguoiDung.Controls.Add(this.panelControl6);
            this.xtraTabNguoiDung.Name = "xtraTabNguoiDung";
            this.xtraTabNguoiDung.Size = new System.Drawing.Size(642, 248);
            this.xtraTabNguoiDung.Text = "Thùng Rác Người Dùng";
            // 
            // panelControl5
            // 
            this.panelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl5.Appearance.Options.UseBackColor = true;
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.gcNguoiDung);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(609, 248);
            this.panelControl5.TabIndex = 1;
            // 
            // gcNguoiDung
            // 
            this.gcNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.gcNguoiDung.MainView = this.gvNguoiDung;
            this.gcNguoiDung.Name = "gcNguoiDung";
            this.gcNguoiDung.Size = new System.Drawing.Size(609, 248);
            this.gcNguoiDung.TabIndex = 1;
            this.gcNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.GridControl = this.gcNguoiDung;
            this.gvNguoiDung.Name = "gvNguoiDung";
            this.gvNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNguoiDung.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNguoiDung_FocusedRowChanged);
            // 
            // panelControl6
            // 
            this.panelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl6.Appearance.Options.UseBackColor = true;
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.btnNguoiDungPhucHoi);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(609, 0);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(33, 248);
            this.panelControl6.TabIndex = 2;
            // 
            // btnNguoiDungPhucHoi
            // 
            this.btnNguoiDungPhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnNguoiDungPhucHoi.Image")));
            this.btnNguoiDungPhucHoi.Location = new System.Drawing.Point(5, 21);
            this.btnNguoiDungPhucHoi.Name = "btnNguoiDungPhucHoi";
            this.btnNguoiDungPhucHoi.Size = new System.Drawing.Size(24, 23);
            this.btnNguoiDungPhucHoi.TabIndex = 1;
            this.btnNguoiDungPhucHoi.Click += new System.EventHandler(this.btnNguoiDungPhucHoi_Click);
            // 
            // FrmThungRac
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 350);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThungRac";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmThungRac";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraThungRac)).EndInit();
            this.xtraThungRac.ResumeLayout(false);
            this.xtraTabDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.xtraTabNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabControl xtraThungRac;
        private DevExpress.XtraTab.XtraTabPage xtraTabDanhMuc;
        private DevExpress.XtraTab.XtraTabPage xtraTabNguoiDung;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDanhMucPhucHoi;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraGrid.GridControl gcNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguoiDung;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnNguoiDungPhucHoi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}