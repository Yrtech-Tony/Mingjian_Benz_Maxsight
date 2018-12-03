namespace XHX.View
{
    partial class ShopReportUpload
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
            this.grcShop = new DevExpress.XtraGrid.GridControl();
            this.grvShop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcShopCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRecordUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboSubjectTypeExam = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.grdShop = new DevExpress.XtraEditors.PanelControl();
            this.btnCharterSale = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnModule = new DevExpress.XtraEditors.ButtonEdit();
            this.txtShopName = new DevExpress.XtraEditors.TextEdit();
            this.btnShopCode = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboProject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblProject = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubjectTypeExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).BeginInit();
            this.grdShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShopName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShopCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcShop
            // 
            this.grcShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcShop.Location = new System.Drawing.Point(4, 86);
            this.grcShop.MainView = this.grvShop;
            this.grcShop.Name = "grcShop";
            this.grcShop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboSubjectTypeExam,
            this.repositoryItemDateEdit1});
            this.grcShop.Size = new System.Drawing.Size(990, 523);
            this.grcShop.TabIndex = 14;
            this.grcShop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvShop});
            // 
            // grvShop
            // 
            this.grvShop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcShopCode,
            this.gcShopName,
            this.gcRecordUrl,
            this.gcPassword,
            this.gcInDateTime});
            this.grvShop.GridControl = this.grcShop;
            this.grvShop.Name = "grvShop";
            this.grvShop.OptionsView.ColumnAutoWidth = false;
            this.grvShop.OptionsView.ShowGroupPanel = false;
            // 
            // gcShopCode
            // 
            this.gcShopCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gcShopCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcShopCode.Caption = "经销商代码";
            this.gcShopCode.FieldName = "ShopCode";
            this.gcShopCode.Name = "gcShopCode";
            this.gcShopCode.OptionsColumn.AllowFocus = false;
            this.gcShopCode.OptionsColumn.ReadOnly = true;
            this.gcShopCode.Visible = true;
            this.gcShopCode.VisibleIndex = 0;
            this.gcShopCode.Width = 220;
            // 
            // gcShopName
            // 
            this.gcShopName.AppearanceHeader.Options.UseTextOptions = true;
            this.gcShopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcShopName.Caption = "经销商名称";
            this.gcShopName.FieldName = "ShopName";
            this.gcShopName.Name = "gcShopName";
            this.gcShopName.OptionsColumn.AllowFocus = false;
            this.gcShopName.OptionsColumn.ReadOnly = true;
            this.gcShopName.Visible = true;
            this.gcShopName.VisibleIndex = 1;
            this.gcShopName.Width = 345;
            // 
            // gcRecordUrl
            // 
            this.gcRecordUrl.AppearanceCell.Options.UseTextOptions = true;
            this.gcRecordUrl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcRecordUrl.AppearanceHeader.Options.UseTextOptions = true;
            this.gcRecordUrl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcRecordUrl.Caption = "单店报告上传日期";
            this.gcRecordUrl.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gcRecordUrl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcRecordUrl.FieldName = "UploadDate";
            this.gcRecordUrl.Name = "gcRecordUrl";
            this.gcRecordUrl.Visible = true;
            this.gcRecordUrl.VisibleIndex = 2;
            this.gcRecordUrl.Width = 162;
            // 
            // gcPassword
            // 
            this.gcPassword.AppearanceHeader.Options.UseTextOptions = true;
            this.gcPassword.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPassword.Caption = "综合报告上传日期";
            this.gcPassword.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gcPassword.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcPassword.FieldName = "UploadDate2";
            this.gcPassword.Name = "gcPassword";
            this.gcPassword.Width = 132;
            // 
            // gcInDateTime
            // 
            this.gcInDateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.gcInDateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcInDateTime.Caption = "日期";
            this.gcInDateTime.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gcInDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcInDateTime.FieldName = "InDateTime";
            this.gcInDateTime.Name = "gcInDateTime";
            this.gcInDateTime.OptionsColumn.ReadOnly = true;
            this.gcInDateTime.Visible = true;
            this.gcInDateTime.VisibleIndex = 3;
            this.gcInDateTime.Width = 150;
            // 
            // cboSubjectTypeExam
            // 
            this.cboSubjectTypeExam.AutoHeight = false;
            this.cboSubjectTypeExam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubjectTypeExam.Name = "cboSubjectTypeExam";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // grdShop
            // 
            this.grdShop.Controls.Add(this.btnCharterSale);
            this.grdShop.Controls.Add(this.labelControl1);
            this.grdShop.Controls.Add(this.btnModule);
            this.grdShop.Controls.Add(this.txtShopName);
            this.grdShop.Controls.Add(this.btnShopCode);
            this.grdShop.Controls.Add(this.labelControl2);
            this.grdShop.Controls.Add(this.cboProject);
            this.grdShop.Controls.Add(this.lblProject);
            this.grdShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdShop.Location = new System.Drawing.Point(4, 4);
            this.grdShop.Margin = new System.Windows.Forms.Padding(0);
            this.grdShop.Name = "grdShop";
            this.grdShop.Size = new System.Drawing.Size(990, 82);
            this.grdShop.TabIndex = 13;
            // 
            // btnCharterSale
            // 
            this.btnCharterSale.Location = new System.Drawing.Point(375, 46);
            this.btnCharterSale.Name = "btnCharterSale";
            this.btnCharterSale.Size = new System.Drawing.Size(115, 29);
            this.btnCharterSale.TabIndex = 101;
            this.btnCharterSale.Text = "上传";
            this.btnCharterSale.Click += new System.EventHandler(this.btnCharterSale_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(6, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 100;
            this.labelControl1.Text = "模板路径";
            // 
            // btnModule
            // 
            this.btnModule.EditValue = "";
            this.btnModule.Location = new System.Drawing.Point(60, 48);
            this.btnModule.Name = "btnModule";
            this.btnModule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnModule.Size = new System.Drawing.Size(309, 21);
            this.btnModule.TabIndex = 99;
            this.btnModule.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnModule_ButtonClick);
            // 
            // txtShopName
            // 
            this.txtShopName.Enabled = false;
            this.txtShopName.Location = new System.Drawing.Point(375, 11);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(238, 21);
            this.txtShopName.TabIndex = 6;
            // 
            // btnShopCode
            // 
            this.btnShopCode.EditValue = "";
            this.btnShopCode.Location = new System.Drawing.Point(269, 11);
            this.btnShopCode.Name = "btnShopCode";
            this.btnShopCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnShopCode.Size = new System.Drawing.Size(100, 21);
            this.btnShopCode.TabIndex = 5;
            this.btnShopCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnShopCode_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(227, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "经销商";
            // 
            // cboProject
            // 
            this.cboProject.Location = new System.Drawing.Point(63, 11);
            this.cboProject.Name = "cboProject";
            this.cboProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProject.Size = new System.Drawing.Size(100, 21);
            this.cboProject.TabIndex = 1;
            // 
            // lblProject
            // 
            this.lblProject.Location = new System.Drawing.Point(30, 14);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(24, 14);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "项目";
            // 
            // ShopReportUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcShop);
            this.Controls.Add(this.grdShop);
            this.Name = "ShopReportUpload";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(998, 613);
            ((System.ComponentModel.ISupportInitialize)(this.grcShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubjectTypeExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).EndInit();
            this.grdShop.ResumeLayout(false);
            this.grdShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShopName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShopCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcShop;
        private DevExpress.XtraGrid.Views.Grid.GridView grvShop;
        private DevExpress.XtraGrid.Columns.GridColumn gcShopCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcShopName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboSubjectTypeExam;
        private DevExpress.XtraGrid.Columns.GridColumn gcRecordUrl;
        private DevExpress.XtraEditors.PanelControl grdShop;
        private DevExpress.XtraEditors.ComboBoxEdit cboProject;
        private DevExpress.XtraEditors.LabelControl lblProject;
        private DevExpress.XtraEditors.TextEdit txtShopName;
        private DevExpress.XtraEditors.ButtonEdit btnShopCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gcPassword;
        private DevExpress.XtraGrid.Columns.GridColumn gcInDateTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCharterSale;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnModule;

    }
}