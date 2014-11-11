﻿namespace PullingStatusTool.UserControl
{
    partial class UC_UploadRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.retailer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.downloadpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uploadpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uploadtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.issla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isongoing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filetype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.Rdg_ongoing = new DevExpress.XtraEditors.RadioGroup();
            this.Rdg_SLA = new DevExpress.XtraEditors.RadioGroup();
            this.txt_EDtime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rdg_ongoing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rdg_SLA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EDtime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EDtime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(866, 428);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.retailer,
            this.vendor,
            this.downloadpath,
            this.uploadpath,
            this.uploadtime,
            this.issla,
            this.isongoing,
            this.filetype,
            this.filename,
            this.id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // retailer
            // 
            this.retailer.Caption = "Retailer";
            this.retailer.FieldName = "c_retailer";
            this.retailer.Name = "retailer";
            this.retailer.OptionsColumn.AllowEdit = false;
            this.retailer.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.retailer.Visible = true;
            this.retailer.VisibleIndex = 0;
            this.retailer.Width = 53;
            // 
            // vendor
            // 
            this.vendor.Caption = "Vendor";
            this.vendor.FieldName = "c_vendor";
            this.vendor.Name = "vendor";
            this.vendor.OptionsColumn.AllowEdit = false;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 1;
            this.vendor.Width = 45;
            // 
            // downloadpath
            // 
            this.downloadpath.Caption = "DownloadPath";
            this.downloadpath.FieldName = "c_downloadpath";
            this.downloadpath.Name = "downloadpath";
            this.downloadpath.OptionsColumn.AllowEdit = false;
            this.downloadpath.Visible = true;
            this.downloadpath.VisibleIndex = 2;
            this.downloadpath.Width = 147;
            // 
            // uploadpath
            // 
            this.uploadpath.Caption = "UploadPath";
            this.uploadpath.FieldName = "c_uploadpath";
            this.uploadpath.Name = "uploadpath";
            this.uploadpath.OptionsColumn.AllowEdit = false;
            this.uploadpath.Visible = true;
            this.uploadpath.VisibleIndex = 3;
            this.uploadpath.Width = 153;
            // 
            // uploadtime
            // 
            this.uploadtime.Caption = "UploadTime";
            this.uploadtime.FieldName = "c_uploadtime";
            this.uploadtime.Name = "uploadtime";
            this.uploadtime.OptionsColumn.AllowEdit = false;
            this.uploadtime.Visible = true;
            this.uploadtime.VisibleIndex = 4;
            this.uploadtime.Width = 72;
            // 
            // issla
            // 
            this.issla.Caption = "isSLA";
            this.issla.FieldName = "c_issla";
            this.issla.Name = "issla";
            this.issla.OptionsColumn.AllowEdit = false;
            this.issla.Visible = true;
            this.issla.VisibleIndex = 5;
            this.issla.Width = 46;
            // 
            // isongoing
            // 
            this.isongoing.Caption = "isOngoing";
            this.isongoing.FieldName = "c_isongoing";
            this.isongoing.Name = "isongoing";
            this.isongoing.OptionsColumn.AllowEdit = false;
            this.isongoing.Visible = true;
            this.isongoing.VisibleIndex = 6;
            this.isongoing.Width = 40;
            // 
            // filetype
            // 
            this.filetype.Caption = "FileType";
            this.filetype.FieldName = "c_filetype";
            this.filetype.Name = "filetype";
            this.filetype.OptionsColumn.AllowEdit = false;
            this.filetype.Visible = true;
            this.filetype.VisibleIndex = 7;
            this.filetype.Width = 40;
            // 
            // filename
            // 
            this.filename.Caption = "fileName";
            this.filename.FieldName = "c_filename";
            this.filename.Name = "filename";
            this.filename.OptionsColumn.AllowEdit = false;
            this.filename.Visible = true;
            this.filename.VisibleIndex = 8;
            this.filename.Width = 140;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "c_id";
            this.id.Name = "id";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(281, 43);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Rdg_ongoing
            // 
            this.Rdg_ongoing.Location = new System.Drawing.Point(12, 12);
            this.Rdg_ongoing.Name = "Rdg_ongoing";
            this.Rdg_ongoing.Properties.Columns = 3;
            this.Rdg_ongoing.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "ongoing"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "history")});
            this.Rdg_ongoing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdg_ongoing.Size = new System.Drawing.Size(209, 24);
            this.Rdg_ongoing.TabIndex = 13;
            // 
            // Rdg_SLA
            // 
            this.Rdg_SLA.Location = new System.Drawing.Point(12, 42);
            this.Rdg_SLA.Name = "Rdg_SLA";
            this.Rdg_SLA.Properties.Columns = 3;
            this.Rdg_SLA.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "isSLA"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "missSLA")});
            this.Rdg_SLA.Size = new System.Drawing.Size(209, 24);
            this.Rdg_SLA.TabIndex = 12;
            // 
            // txt_EDtime
            // 
            this.txt_EDtime.EditValue = null;
            this.txt_EDtime.Location = new System.Drawing.Point(256, 13);
            this.txt_EDtime.Name = "txt_EDtime";
            this.txt_EDtime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_EDtime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_EDtime.Size = new System.Drawing.Size(100, 20);
            this.txt_EDtime.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(227, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Date";
            // 
            // UC_UploadRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.Rdg_ongoing);
            this.Controls.Add(this.Rdg_SLA);
            this.Controls.Add(this.txt_EDtime);
            this.Controls.Add(this.labelControl2);
            this.Name = "UC_UploadRecord";
            this.Size = new System.Drawing.Size(888, 503);
            this.Tag = "None Target Data Upload Record";
            this.Load += new System.EventHandler(this.Frm_UploadRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rdg_ongoing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rdg_SLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EDtime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EDtime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn retailer;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn downloadpath;
        private DevExpress.XtraGrid.Columns.GridColumn uploadpath;
        private DevExpress.XtraGrid.Columns.GridColumn uploadtime;
        private DevExpress.XtraGrid.Columns.GridColumn issla;
        private DevExpress.XtraGrid.Columns.GridColumn isongoing;
        private DevExpress.XtraGrid.Columns.GridColumn filetype;
        private DevExpress.XtraGrid.Columns.GridColumn filename;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.RadioGroup Rdg_ongoing;
        private DevExpress.XtraEditors.RadioGroup Rdg_SLA;
        private DevExpress.XtraEditors.DateEdit txt_EDtime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}