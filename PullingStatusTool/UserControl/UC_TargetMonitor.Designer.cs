﻿namespace PullingStatusTool.UserControl
{
    partial class UC_TargetMonitor
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_MondayStatus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Week = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_month = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_year = new DevExpress.XtraEditors.TextEdit();
            this.drp_DailyDate = new DevExpress.XtraEditors.DateEdit();
            this.GC_PullingFileStatus = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subgroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCountUpload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCountFormatted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DelayReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinishUploaded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinishFormatted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.serverIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.finishTm = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Week.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingFileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Choose Date";
            // 
            // Btn_MondayStatus
            // 
            this.Btn_MondayStatus.Location = new System.Drawing.Point(405, 8);
            this.Btn_MondayStatus.Name = "Btn_MondayStatus";
            this.Btn_MondayStatus.Size = new System.Drawing.Size(75, 23);
            this.Btn_MondayStatus.TabIndex = 34;
            this.Btn_MondayStatus.Text = "Monday";
            this.Btn_MondayStatus.Click += new System.EventHandler(this.Btn_MondayStatus_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(486, 8);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 33;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_Week
            // 
            this.txt_Week.Location = new System.Drawing.Point(372, 11);
            this.txt_Week.Name = "txt_Week";
            this.txt_Week.Size = new System.Drawing.Size(27, 20);
            this.txt_Week.TabIndex = 32;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(339, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "week";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(306, 11);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(27, 20);
            this.txt_month.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(270, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "month";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(188, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "year";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(216, 11);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(48, 20);
            this.txt_year.TabIndex = 27;
            // 
            // drp_DailyDate
            // 
            this.drp_DailyDate.EditValue = null;
            this.drp_DailyDate.Location = new System.Drawing.Point(82, 11);
            this.drp_DailyDate.Name = "drp_DailyDate";
            this.drp_DailyDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.drp_DailyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drp_DailyDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.drp_DailyDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.drp_DailyDate.Size = new System.Drawing.Size(100, 20);
            this.drp_DailyDate.TabIndex = 26;
            // 
            // GC_PullingFileStatus
            // 
            this.GC_PullingFileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_PullingFileStatus.Location = new System.Drawing.Point(3, 37);
            this.GC_PullingFileStatus.MainView = this.gridView1;
            this.GC_PullingFileStatus.Name = "GC_PullingFileStatus";
            this.GC_PullingFileStatus.Size = new System.Drawing.Size(834, 467);
            this.GC_PullingFileStatus.TabIndex = 25;
            this.GC_PullingFileStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendor,
            this.dataType,
            this.subgroup,
            this.fileCountUpload,
            this.fileCountFormatted,
            this.DelayReason,
            this.FinishUploaded,
            this.FinishFormatted,
            this.serverIP,
            this.password,
            this.finishTm});
            this.gridView1.GridControl = this.GC_PullingFileStatus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // vendor
            // 
            this.vendor.Caption = "Vendor";
            this.vendor.FieldName = "c_vendor";
            this.vendor.Name = "vendor";
            this.vendor.OptionsColumn.AllowEdit = false;
            this.vendor.OptionsColumn.AllowSize = false;
            this.vendor.OptionsColumn.ReadOnly = true;
            this.vendor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 0;
            this.vendor.Width = 94;
            // 
            // dataType
            // 
            this.dataType.Caption = "DataType";
            this.dataType.FieldName = "c_datatype";
            this.dataType.Name = "dataType";
            this.dataType.OptionsColumn.AllowEdit = false;
            this.dataType.OptionsColumn.AllowSize = false;
            this.dataType.OptionsColumn.ReadOnly = true;
            this.dataType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.dataType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.dataType.Visible = true;
            this.dataType.VisibleIndex = 1;
            this.dataType.Width = 85;
            // 
            // subgroup
            // 
            this.subgroup.Caption = "Sub Group";
            this.subgroup.FieldName = "c_subgroup";
            this.subgroup.Name = "subgroup";
            this.subgroup.OptionsColumn.AllowEdit = false;
            this.subgroup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.subgroup.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.subgroup.Visible = true;
            this.subgroup.VisibleIndex = 2;
            this.subgroup.Width = 56;
            // 
            // fileCountUpload
            // 
            this.fileCountUpload.Caption = "FileCountUpload";
            this.fileCountUpload.FieldName = "c_filexpectuploaded";
            this.fileCountUpload.Name = "fileCountUpload";
            this.fileCountUpload.OptionsColumn.AllowEdit = false;
            this.fileCountUpload.Visible = true;
            this.fileCountUpload.VisibleIndex = 3;
            this.fileCountUpload.Width = 46;
            // 
            // fileCountFormatted
            // 
            this.fileCountFormatted.Caption = "FileCountFormatted";
            this.fileCountFormatted.FieldName = "c_filexpectformatted";
            this.fileCountFormatted.Name = "fileCountFormatted";
            this.fileCountFormatted.OptionsColumn.AllowEdit = false;
            this.fileCountFormatted.Visible = true;
            this.fileCountFormatted.VisibleIndex = 4;
            this.fileCountFormatted.Width = 53;
            // 
            // DelayReason
            // 
            this.DelayReason.Caption = "delayreason";
            this.DelayReason.FieldName = "c_delayreason";
            this.DelayReason.Name = "DelayReason";
            this.DelayReason.Visible = true;
            this.DelayReason.VisibleIndex = 5;
            this.DelayReason.Width = 150;
            // 
            // FinishUploaded
            // 
            this.FinishUploaded.Caption = "FinishUploaded";
            this.FinishUploaded.FieldName = "c_finishuploaded";
            this.FinishUploaded.Name = "FinishUploaded";
            this.FinishUploaded.OptionsColumn.AllowEdit = false;
            this.FinishUploaded.OptionsColumn.AllowSize = false;
            this.FinishUploaded.OptionsColumn.ReadOnly = true;
            this.FinishUploaded.Visible = true;
            this.FinishUploaded.VisibleIndex = 6;
            this.FinishUploaded.Width = 59;
            // 
            // FinishFormatted
            // 
            this.FinishFormatted.Caption = "FinishFormatted";
            this.FinishFormatted.FieldName = "c_finishformatted";
            this.FinishFormatted.Name = "FinishFormatted";
            this.FinishFormatted.OptionsColumn.AllowEdit = false;
            this.FinishFormatted.Visible = true;
            this.FinishFormatted.VisibleIndex = 7;
            this.FinishFormatted.Width = 57;
            // 
            // serverIP
            // 
            this.serverIP.Caption = "ServerIP";
            this.serverIP.FieldName = "c_serverIP";
            this.serverIP.Name = "serverIP";
            this.serverIP.Visible = true;
            this.serverIP.VisibleIndex = 8;
            this.serverIP.Width = 79;
            // 
            // password
            // 
            this.password.Caption = "PSW";
            this.password.FieldName = "c_password";
            this.password.Name = "password";
            this.password.OptionsColumn.AllowEdit = false;
            // 
            // finishTm
            // 
            this.finishTm.Caption = "FinishTime";
            this.finishTm.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.finishTm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.finishTm.FieldName = "c_finishtime";
            this.finishTm.Name = "finishTm";
            this.finishTm.OptionsColumn.AllowEdit = false;
            this.finishTm.Visible = true;
            this.finishTm.VisibleIndex = 9;
            this.finishTm.Width = 140;
            // 
            // UC_TargetMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Btn_MondayStatus);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_Week);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.drp_DailyDate);
            this.Controls.Add(this.GC_PullingFileStatus);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.Name = "UC_TargetMonitor";
            this.Size = new System.Drawing.Size(849, 507);
            this.Tag = "Target Data Pulling Status";
            this.Load += new System.EventHandler(this.Frm_PullingStatusService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Week.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingFileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_MondayStatus;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.TextEdit txt_Week;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_month;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_year;
        private DevExpress.XtraEditors.DateEdit drp_DailyDate;
        private DevExpress.XtraGrid.GridControl GC_PullingFileStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn subgroup;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountUpload;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountFormatted;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraGrid.Columns.GridColumn FinishUploaded;
        private DevExpress.XtraGrid.Columns.GridColumn FinishFormatted;
        private DevExpress.XtraGrid.Columns.GridColumn serverIP;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraGrid.Columns.GridColumn finishTm;
    }
}
