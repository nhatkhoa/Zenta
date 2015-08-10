namespace ZCF
{
    partial class FrmKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuVuc));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelThem = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBan = new DevExpress.XtraEditors.TextEdit();
            this.textTen = new DevExpress.XtraEditors.TextEdit();
            this.gcKhuVuc = new DevExpress.XtraGrid.GridControl();
            this.gvKhuVuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemKhuVuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelThem)).BeginInit();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelThem);
            this.panelControl1.Controls.Add(this.gcKhuVuc);
            this.panelControl1.Location = new System.Drawing.Point(26, 86);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(375, 225);
            this.panelControl1.TabIndex = 0;
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.btnClose);
            this.panelThem.Controls.Add(this.btnAdd);
            this.panelThem.Controls.Add(this.labelControl2);
            this.panelThem.Controls.Add(this.labelControl1);
            this.panelThem.Controls.Add(this.textBan);
            this.panelThem.Controls.Add(this.textTen);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThem.Location = new System.Drawing.Point(0, 193);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(375, 32);
            this.panelThem.TabIndex = 4;
            this.panelThem.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(302, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(243, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(145, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Số Bàn :";
            // 
            // textBan
            // 
            this.textBan.EditValue = "1";
            this.textBan.Location = new System.Drawing.Point(191, 5);
            this.textBan.Name = "textBan";
            this.textBan.Size = new System.Drawing.Size(46, 20);
            this.textBan.TabIndex = 1;
            this.textBan.Click += new System.EventHandler(this.textBan_Click);
            this.textBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBan_KeyPress);
            // 
            // textTen
            // 
            this.textTen.EditValue = "Nhập tên khu vực . ";
            this.textTen.Location = new System.Drawing.Point(36, 5);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(100, 20);
            this.textTen.TabIndex = 0;
            this.textTen.Click += new System.EventHandler(this.textTen_Click);
            this.textTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTen_KeyPress);
            // 
            // gcKhuVuc
            // 
            this.gcKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhuVuc.Location = new System.Drawing.Point(0, 0);
            this.gcKhuVuc.MainView = this.gvKhuVuc;
            this.gcKhuVuc.Name = "gcKhuVuc";
            this.gcKhuVuc.Size = new System.Drawing.Size(375, 225);
            this.gcKhuVuc.TabIndex = 3;
            this.gcKhuVuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhuVuc});
            // 
            // gvKhuVuc
            // 
            this.gvKhuVuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Ten,
            this.SoBan});
            this.gvKhuVuc.GridControl = this.gcKhuVuc;
            this.gvKhuVuc.Name = "gvKhuVuc";
            this.gvKhuVuc.OptionsView.ShowGroupPanel = false;
            this.gvKhuVuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhuVuc_FocusedRowChanged);
            this.gvKhuVuc.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvKhuVuc_RowUpdated);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.DisplayFormat.FormatString = "KV{0:000}";
            this.ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ID.FieldName = "KhuVucID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 56;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên Khu Vực";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 204;
            // 
            // SoBan
            // 
            this.SoBan.Caption = "Số Bàn";
            this.SoBan.FieldName = "SoBan";
            this.SoBan.Name = "SoBan";
            this.SoBan.Visible = true;
            this.SoBan.VisibleIndex = 2;
            this.SoBan.Width = 97;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(62, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(303, 29);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Quản Lý Khu Vực Trà Sữa";
            // 
            // btnThemKhuVuc
            // 
            this.btnThemKhuVuc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhuVuc.Image")));
            this.btnThemKhuVuc.Location = new System.Drawing.Point(5, 5);
            this.btnThemKhuVuc.Name = "btnThemKhuVuc";
            this.btnThemKhuVuc.Size = new System.Drawing.Size(180, 23);
            this.btnThemKhuVuc.TabIndex = 2;
            this.btnThemKhuVuc.Text = "Thêm Khu Vực Mới";
            this.btnThemKhuVuc.Click += new System.EventHandler(this.btnThemKhuVuc_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(404, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(39, 37);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Exit";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(407, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(24, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.Location = new System.Drawing.Point(293, 5);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(77, 23);
            this.btnReLoad.TabIndex = 7;
            this.btnReLoad.Text = "Reload";
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThemKhuVuc);
            this.panelControl2.Controls.Add(this.btnReLoad);
            this.panelControl2.Location = new System.Drawing.Point(26, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(375, 33);
            this.panelControl2.TabIndex = 8;
            // 
            // FrmKhuVuc
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 337);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmKhuVuc";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelThem)).EndInit();
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelThem;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textBan;
        private DevExpress.XtraEditors.TextEdit textTen;
        private DevExpress.XtraGrid.GridControl gcKhuVuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn SoBan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnThemKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}