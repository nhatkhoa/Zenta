namespace ZCF
{
    partial class FrmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung));
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelThem = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.textHoTen = new DevExpress.XtraEditors.TextEdit();
            this.gcNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTextMatKhau = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuanTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toggleSwishQuanTri = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.AD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSetAdmin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelThem)).BeginInit();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTextMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwishQuanTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(502, 8);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(40, 37);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Exit";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(5, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm Người Dùng Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(70, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(368, 29);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Quản Lý Người Dùng Hệ Thống";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelThem);
            this.panelControl1.Controls.Add(this.gcNguoiDung);
            this.panelControl1.Location = new System.Drawing.Point(17, 94);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(490, 225);
            this.panelControl1.TabIndex = 4;
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.btnClose);
            this.panelThem.Controls.Add(this.btnAdd);
            this.panelThem.Controls.Add(this.labelControl2);
            this.panelThem.Controls.Add(this.labelControl4);
            this.panelThem.Controls.Add(this.textMatKhau);
            this.panelThem.Controls.Add(this.labelControl1);
            this.panelThem.Controls.Add(this.textTaiKhoan);
            this.panelThem.Controls.Add(this.textHoTen);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThem.Location = new System.Drawing.Point(0, 172);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(490, 53);
            this.panelThem.TabIndex = 4;
            this.panelThem.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(121, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Họ Tên :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(266, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mật Khẩu :";
            // 
            // textMatKhau
            // 
            this.textMatKhau.EditValue = "123456";
            this.textMatKhau.Location = new System.Drawing.Point(325, 28);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Properties.PasswordChar = '|';
            this.textMatKhau.Size = new System.Drawing.Size(160, 20);
            this.textMatKhau.TabIndex = 2;
            this.textMatKhau.Click += new System.EventHandler(this.textMatKhau_Click);
            this.textMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMatKhau_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(244, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Tài Khoản :";
            // 
            // textTaiKhoan
            // 
            this.textTaiKhoan.EditValue = "Tên để đăng nhập hệ thống . . .";
            this.textTaiKhoan.Location = new System.Drawing.Point(325, 5);
            this.textTaiKhoan.Name = "textTaiKhoan";
            this.textTaiKhoan.Size = new System.Drawing.Size(160, 20);
            this.textTaiKhoan.TabIndex = 1;
            this.textTaiKhoan.Click += new System.EventHandler(this.textTaiKhoan_Click);
            this.textTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTaiKhoan_KeyPress);
            // 
            // textHoTen
            // 
            this.textHoTen.EditValue = "Nhập họ tên người dùng . . .";
            this.textHoTen.Location = new System.Drawing.Point(52, 5);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(174, 20);
            this.textHoTen.TabIndex = 0;
            this.textHoTen.Click += new System.EventHandler(this.textHoTen_Click);
            this.textHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHoTen_KeyPress);
            // 
            // gcNguoiDung
            // 
            this.gcNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.gcNguoiDung.MainView = this.gvNguoiDung;
            this.gcNguoiDung.Name = "gcNguoiDung";
            this.gcNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colTextMatKhau,
            this.toggleSwishQuanTri,
            this.adCheckBox});
            this.gcNguoiDung.Size = new System.Drawing.Size(490, 225);
            this.gcNguoiDung.TabIndex = 3;
            this.gcNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.HoTen,
            this.MatKhau,
            this.TaiKhoan,
            this.QuanTri,
            this.AD});
            this.gvNguoiDung.GridControl = this.gcNguoiDung;
            this.gvNguoiDung.Name = "gvNguoiDung";
            this.gvNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNguoiDung.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvNguoiDung.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhuVuc_FocusedRowChanged);
            this.gvNguoiDung.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvNguoiDung_RowUpdated);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.DisplayFormat.FormatString = "ND{0:000}";
            this.ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ID.FieldName = "NguoiDungID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 43;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 130;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật Khẩu";
            this.MatKhau.ColumnEdit = this.colTextMatKhau;
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 3;
            this.MatKhau.Width = 88;
            // 
            // colTextMatKhau
            // 
            this.colTextMatKhau.AutoHeight = false;
            this.colTextMatKhau.Name = "colTextMatKhau";
            this.colTextMatKhau.PasswordChar = '|';
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Caption = "Tài Khoản";
            this.TaiKhoan.FieldName = "TaiKhoan";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Visible = true;
            this.TaiKhoan.VisibleIndex = 2;
            this.TaiKhoan.Width = 105;
            // 
            // QuanTri
            // 
            this.QuanTri.Caption = "Quản Trị";
            this.QuanTri.ColumnEdit = this.toggleSwishQuanTri;
            this.QuanTri.FieldName = "QuanTri";
            this.QuanTri.Name = "QuanTri";
            this.QuanTri.Visible = true;
            this.QuanTri.VisibleIndex = 4;
            this.QuanTri.Width = 71;
            // 
            // toggleSwishQuanTri
            // 
            this.toggleSwishQuanTri.AutoHeight = false;
            this.toggleSwishQuanTri.Name = "toggleSwishQuanTri";
            this.toggleSwishQuanTri.OffText = "Nhân Viên Quản Lý";
            this.toggleSwishQuanTri.OnText = "Quản Trị Viên";
            // 
            // AD
            // 
            this.AD.Caption = "AD";
            this.AD.ColumnEdit = this.adCheckBox;
            this.AD.FieldName = "AD";
            this.AD.Name = "AD";
            this.AD.Visible = true;
            this.AD.VisibleIndex = 5;
            this.AD.Width = 35;
            // 
            // adCheckBox
            // 
            this.adCheckBox.AutoHeight = false;
            this.adCheckBox.Caption = "Check";
            this.adCheckBox.Name = "adCheckBox";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(513, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(24, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.Location = new System.Drawing.Point(350, 5);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(103, 23);
            this.btnReLoad.TabIndex = 6;
            this.btnReLoad.Text = "Reload";
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Controls.Add(this.btnSetAdmin);
            this.panelControl2.Controls.Add(this.btnReLoad);
            this.panelControl2.Location = new System.Drawing.Point(17, 55);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(489, 33);
            this.panelControl2.TabIndex = 9;
            // 
            // btnSetAdmin
            // 
            this.btnSetAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnSetAdmin.Image")));
            this.btnSetAdmin.Location = new System.Drawing.Point(213, 5);
            this.btnSetAdmin.Name = "btnSetAdmin";
            this.btnSetAdmin.Size = new System.Drawing.Size(131, 23);
            this.btnSetAdmin.TabIndex = 6;
            this.btnSetAdmin.Text = "Set Admin Chính";
            this.btnSetAdmin.Click += new System.EventHandler(this.btnSetAdmin_Click);
            // 
            // FrmNguoiDung
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 343);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelThem)).EndInit();
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTextMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwishQuanTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelThem;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textTaiKhoan;
        private DevExpress.XtraEditors.TextEdit textHoTen;
        private DevExpress.XtraGrid.GridControl gcNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn TaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn QuanTri;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colTextMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textMatKhau;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch toggleSwishQuanTri;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSetAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn AD;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit adCheckBox;
    }
}