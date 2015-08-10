namespace ZCF
{
    partial class FrmDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMuc));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupDanhMuc = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DanhMucID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panelThem = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.textGia = new DevExpress.XtraEditors.TextEdit();
            this.textTen = new DevExpress.XtraEditors.TextEdit();
            this.groupNhom = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcNhom = new DevExpress.XtraGrid.GridControl();
            this.gvNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelThemNhom = new DevExpress.XtraEditors.PanelControl();
            this.btnNewNhom = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnDongNhom = new DevExpress.XtraEditors.SimpleButton();
            this.textTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNhom = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNhom = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhMuc)).BeginInit();
            this.groupDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThem)).BeginInit();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhom)).BeginInit();
            this.groupNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThemNhom)).BeginInit();
            this.panelThemNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(157, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(289, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "QUẢN LÝ DANH MỤC TRÀ SỮA";
            // 
            // groupDanhMuc
            // 
            this.groupDanhMuc.Controls.Add(this.panelControl1);
            this.groupDanhMuc.Location = new System.Drawing.Point(253, 93);
            this.groupDanhMuc.Name = "groupDanhMuc";
            this.groupDanhMuc.Size = new System.Drawing.Size(293, 322);
            this.groupDanhMuc.TabIndex = 3;
            this.groupDanhMuc.Text = "Danh Mục";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gcDanhMuc);
            this.panelControl1.Controls.Add(this.panelThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(289, 299);
            this.panelControl1.TabIndex = 0;
            // 
            // gcDanhMuc
            // 
            this.gcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.gcDanhMuc.MainView = this.gvDanhMuc;
            this.gcDanhMuc.Name = "gcDanhMuc";
            this.gcDanhMuc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemCalcEdit1});
            this.gcDanhMuc.Size = new System.Drawing.Size(289, 238);
            this.gcDanhMuc.TabIndex = 1;
            this.gcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DanhMucID,
            this.TenDanhMuc,
            this.DonGia});
            this.gvDanhMuc.GridControl = this.gcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsCustomization.AllowGroup = false;
            this.gvDanhMuc.OptionsDetail.EnableMasterViewMode = false;
            this.gvDanhMuc.OptionsDetail.ShowDetailTabs = false;
            this.gvDanhMuc.OptionsDetail.SmartDetailExpand = false;
            this.gvDanhMuc.OptionsView.AllowHtmlDrawGroups = false;
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvDanhMuc.OptionsView.ShowDetailButtons = false;
            this.gvDanhMuc.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.gvDanhMuc.OptionsView.ShowIndicator = false;
            this.gvDanhMuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhMuc_FocusedRowChanged);
            this.gvDanhMuc.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMuc_RowUpdated);
            // 
            // DanhMucID
            // 
            this.DanhMucID.Caption = "ID";
            this.DanhMucID.DisplayFormat.FormatString = "DM{0:000}";
            this.DanhMucID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DanhMucID.FieldName = "DanhMucID";
            this.DanhMucID.Name = "DanhMucID";
            this.DanhMucID.OptionsColumn.AllowEdit = false;
            this.DanhMucID.Visible = true;
            this.DanhMucID.VisibleIndex = 0;
            this.DanhMucID.Width = 47;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.Caption = "Tên Danh Mục";
            this.TenDanhMuc.FieldName = "Ten";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.Visible = true;
            this.TenDanhMuc.VisibleIndex = 1;
            this.TenDanhMuc.Width = 108;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.ColumnEdit = this.repositoryItemCalcEdit1;
            this.DonGia.DisplayFormat.FormatString = "{0:N0} VNĐ";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Mask.EditMask = "n0";
            this.repositoryItemCalcEdit1.Mask.PlaceHolder = '0';
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.ValidateOnEnterKey = true;
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.labelControl3);
            this.panelThem.Controls.Add(this.labelControl2);
            this.panelThem.Controls.Add(this.btnDong);
            this.panelThem.Controls.Add(this.btnThem);
            this.panelThem.Controls.Add(this.textGia);
            this.panelThem.Controls.Add(this.textTen);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThem.Location = new System.Drawing.Point(0, 238);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(289, 61);
            this.panelThem.TabIndex = 0;
            this.panelThem.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(176, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Giá";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên";
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(160, 33);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(124, 23);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng lại";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(29, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm Vào";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textGia
            // 
            this.textGia.EditValue = "1000";
            this.textGia.Location = new System.Drawing.Point(197, 7);
            this.textGia.Name = "textGia";
            this.textGia.Properties.DisplayFormat.FormatString = "{0:n0} VNĐ";
            this.textGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.textGia.Properties.Mask.EditMask = "n0";
            this.textGia.Size = new System.Drawing.Size(87, 20);
            this.textGia.TabIndex = 0;
            this.textGia.Click += new System.EventHandler(this.textGia_Click);
            this.textGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textGia_KeyPress);
            // 
            // textTen
            // 
            this.textTen.EditValue = "Nhập tên danh mục";
            this.textTen.Location = new System.Drawing.Point(29, 7);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(125, 20);
            this.textTen.TabIndex = 0;
            this.textTen.Click += new System.EventHandler(this.textTen_Click);
            this.textTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTen_KeyPress);
            // 
            // groupNhom
            // 
            this.groupNhom.Controls.Add(this.panelControl2);
            this.groupNhom.Location = new System.Drawing.Point(30, 93);
            this.groupNhom.Name = "groupNhom";
            this.groupNhom.Size = new System.Drawing.Size(188, 324);
            this.groupNhom.TabIndex = 4;
            this.groupNhom.Text = "Nhóm Danh Mục";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.gcNhom);
            this.panelControl2.Controls.Add(this.panelThemNhom);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(184, 301);
            this.panelControl2.TabIndex = 0;
            // 
            // gcNhom
            // 
            this.gcNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhom.Location = new System.Drawing.Point(0, 0);
            this.gcNhom.MainView = this.gvNhom;
            this.gcNhom.Name = "gcNhom";
            this.gcNhom.Size = new System.Drawing.Size(184, 238);
            this.gcNhom.TabIndex = 1;
            this.gcNhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhom});
            // 
            // gvNhom
            // 
            this.gvNhom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvNhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenNhom});
            this.gvNhom.GridControl = this.gcNhom;
            this.gvNhom.Name = "gvNhom";
            this.gvNhom.OptionsView.ShowGroupPanel = false;
            this.gvNhom.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhom_FocusedRowChanged);
            this.gvNhom.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvNhom_RowUpdated);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "NhomID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 30;
            // 
            // TenNhom
            // 
            this.TenNhom.Caption = "Tên Nhóm";
            this.TenNhom.FieldName = "Ten";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Visible = true;
            this.TenNhom.VisibleIndex = 1;
            this.TenNhom.Width = 136;
            // 
            // panelThemNhom
            // 
            this.panelThemNhom.Controls.Add(this.btnNewNhom);
            this.panelThemNhom.Controls.Add(this.labelControl4);
            this.panelThemNhom.Controls.Add(this.btnDongNhom);
            this.panelThemNhom.Controls.Add(this.textTenNhom);
            this.panelThemNhom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThemNhom.Location = new System.Drawing.Point(0, 238);
            this.panelThemNhom.Name = "panelThemNhom";
            this.panelThemNhom.Size = new System.Drawing.Size(184, 63);
            this.panelThemNhom.TabIndex = 0;
            this.panelThemNhom.Visible = false;
            // 
            // btnNewNhom
            // 
            this.btnNewNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNhom.Image")));
            this.btnNewNhom.Location = new System.Drawing.Point(5, 35);
            this.btnNewNhom.Name = "btnNewNhom";
            this.btnNewNhom.Size = new System.Drawing.Size(89, 23);
            this.btnNewNhom.TabIndex = 1;
            this.btnNewNhom.Text = "Thêm Vào";
            this.btnNewNhom.Click += new System.EventHandler(this.btnNewNhom_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tên";
            // 
            // btnDongNhom
            // 
            this.btnDongNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnDongNhom.Image")));
            this.btnDongNhom.Location = new System.Drawing.Point(100, 35);
            this.btnDongNhom.Name = "btnDongNhom";
            this.btnDongNhom.Size = new System.Drawing.Size(79, 23);
            this.btnDongNhom.TabIndex = 1;
            this.btnDongNhom.Text = "Đóng lại";
            this.btnDongNhom.Click += new System.EventHandler(this.btnDongNhom_Click);
            // 
            // textTenNhom
            // 
            this.textTenNhom.EditValue = "Nhập tên nhóm . . .";
            this.textTenNhom.Location = new System.Drawing.Point(42, 7);
            this.textTenNhom.Name = "textTenNhom";
            this.textTenNhom.Size = new System.Drawing.Size(125, 20);
            this.textTenNhom.TabIndex = 0;
            this.textTenNhom.Click += new System.EventHandler(this.textTenNhom_Click);
            this.textTenNhom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTenNhom_KeyPress);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(534, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(41, 38);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Exit";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnReLoad);
            this.panelControl3.Controls.Add(this.btnThemDanhMuc);
            this.panelControl3.Controls.Add(this.btnThemNhom);
            this.panelControl3.Location = new System.Drawing.Point(30, 50);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(516, 35);
            this.panelControl3.TabIndex = 6;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.Location = new System.Drawing.Point(432, 7);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(77, 23);
            this.btnReLoad.TabIndex = 8;
            this.btnReLoad.Text = "Reload";
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDanhMuc.Image")));
            this.btnThemDanhMuc.Location = new System.Drawing.Point(225, 7);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(181, 23);
            this.btnThemDanhMuc.TabIndex = 6;
            this.btnThemDanhMuc.Text = "Thêm Danh Mục Mới";
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.Location = new System.Drawing.Point(5, 7);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(181, 23);
            this.btnThemNhom.TabIndex = 6;
            this.btnThemNhom.Text = "Thêm Nhóm Danh Mục";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.Location = new System.Drawing.Point(222, 134);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(24, 23);
            this.btnXoaNhom.TabIndex = 7;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDanhMuc.Image")));
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(552, 134);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(24, 23);
            this.btnXoaDanhMuc.TabIndex = 7;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // FrmDanhMuc
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 446);
            this.Controls.Add(this.btnXoaDanhMuc);
            this.Controls.Add(this.btnXoaNhom);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.groupNhom);
            this.Controls.Add(this.groupDanhMuc);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhMuc";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhMuc)).EndInit();
            this.groupDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThem)).EndInit();
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhom)).EndInit();
            this.groupNhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThemNhom)).EndInit();
            this.panelThemNhom.ResumeLayout(false);
            this.panelThemNhom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupDanhMuc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupNhom;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelThem;
        private DevExpress.XtraGrid.GridControl gcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn DanhMucID;
        private DevExpress.XtraGrid.Columns.GridColumn TenDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit textGia;
        private DevExpress.XtraEditors.TextEdit textTen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnXoaNhom;
        private DevExpress.XtraEditors.SimpleButton btnXoaDanhMuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.SimpleButton btnThemDanhMuc;
        private DevExpress.XtraEditors.SimpleButton btnThemNhom;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraGrid.GridControl gcNhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhom;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhom;
        private DevExpress.XtraEditors.PanelControl panelThemNhom;
        private DevExpress.XtraEditors.SimpleButton btnNewNhom;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnDongNhom;
        private DevExpress.XtraEditors.TextEdit textTenNhom;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;

    }
}