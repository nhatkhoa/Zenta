namespace ZCF
{
    partial class OptionKhuVuc
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcKhuVuc = new DevExpress.XtraGrid.GridControl();
            this.gvKhuVuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoBan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(27, 283);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Tạo Phiếu Thu";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(164, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy Thao Tác";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(27, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hãy chọn khu vực của khách ngồi !";
            // 
            // gcKhuVuc
            // 
            this.gcKhuVuc.Location = new System.Drawing.Point(27, 37);
            this.gcKhuVuc.MainView = this.gvKhuVuc;
            this.gcKhuVuc.Name = "gcKhuVuc";
            this.gcKhuVuc.Size = new System.Drawing.Size(256, 240);
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
            this.gvKhuVuc.OptionsBehavior.Editable = false;
            this.gvKhuVuc.OptionsView.ShowGroupPanel = false;
            this.gvKhuVuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhuVuc_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.DisplayFormat.FormatString = "KV{0:000}";
            this.ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ID.FieldName = "KhuVucID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 56;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 119;
            // 
            // SoBan
            // 
            this.SoBan.Caption = "Số Bàn";
            this.SoBan.FieldName = "SoBan";
            this.SoBan.Name = "SoBan";
            this.SoBan.Visible = true;
            this.SoBan.VisibleIndex = 2;
            this.SoBan.Width = 63;
            // 
            // OptionKhuVuc
            // 
            this.AcceptButton = this.btnOk;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(309, 330);
            this.Controls.Add(this.gcKhuVuc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OptionKhuVuc";
            ((System.ComponentModel.ISupportInitialize)(this.gcKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcKhuVuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn SoBan;
    }
}