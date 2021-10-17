namespace UserInterface
{
    partial class AccessUI
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessUI));
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.pageGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.securityGridEX = new Telerik.WinControls.UI.RadGridView();
            this.roleGridEX = new Telerik.WinControls.UI.RadGridView();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupBox)).BeginInit();
            this.pageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityGridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityGridEX.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridEX.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 362);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(500, 21);
            this.mainRibbonStatusBar.TabIndex = 150;
            this.mainRibbonStatusBar.Text = "ribbonStatusBar1";
            this.mainRibbonStatusBar.ThemeName = "Office2010Black";
            this.mainRibbonStatusBar.UseCompatibleTextRendering = false;
            // 
            // noticeLabel
            // 
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Name = "noticeLabel";
            this.mainRibbonStatusBar.SetSpring(this.noticeLabel, false);
            this.noticeLabel.Text = "";
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.TextWrap = true;
            this.noticeLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(339, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 157;
            this.label1.Text = "نقش های موجود در سیستم:";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.label1.ThemeName = "Office2010Black";
            // 
            // pageGroupBox
            // 
            this.pageGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.pageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.pageGroupBox.Controls.Add(this.securityGridEX);
            this.pageGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.pageGroupBox.HeaderText = "نوع دسترسی به صفحات";
            this.pageGroupBox.Location = new System.Drawing.Point(16, 132);
            this.pageGroupBox.Name = "pageGroupBox";
            // 
            // 
            // 
            this.pageGroupBox.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.pageGroupBox.Size = new System.Drawing.Size(468, 199);
            this.pageGroupBox.TabIndex = 160;
            this.pageGroupBox.Text = "نوع دسترسی به صفحات";
            this.pageGroupBox.ThemeName = "Office2010Black";
            // 
            // securityGridEX
            // 
            this.securityGridEX.Location = new System.Drawing.Point(5, 21);
            // 
            // securityGridEX
            // 
            this.securityGridEX.MasterTemplate.AllowAddNewRow = false;
            this.securityGridEX.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.HeaderText = "column1";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "PageId";
            gridViewTextBoxColumn2.HeaderText = "عنوان صفحه";
            gridViewTextBoxColumn2.Name = "PageTitle";
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.HeaderText = "کد دسترسی";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "AccessId";
            gridViewComboBoxColumn1.DisplayMember = "";
            gridViewComboBoxColumn1.FieldName = "Access";
            gridViewComboBoxColumn1.HeaderText = "نوع دسترسی";
            gridViewComboBoxColumn1.Name = "Access";
            gridViewComboBoxColumn1.ValueMember = "";
            gridViewComboBoxColumn1.Width = 240;
            this.securityGridEX.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn1});
            this.securityGridEX.MasterTemplate.EnableGrouping = false;
            this.securityGridEX.Name = "securityGridEX";
            this.securityGridEX.Size = new System.Drawing.Size(458, 169);
            this.securityGridEX.TabIndex = 0;
            this.securityGridEX.Text = "radGridView1";
            this.securityGridEX.ThemeName = "Office2010Black";
            this.securityGridEX.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.securityGridEX_CellBeginEdit);
            this.securityGridEX.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.securityGridEX_CellEndEdit);
            this.securityGridEX.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.securityGridEX_CellValueChanged);
            // 
            // roleGridEX
            // 
            this.roleGridEX.Location = new System.Drawing.Point(16, 28);
            // 
            // roleGridEX
            // 
            this.roleGridEX.MasterTemplate.AllowAddNewRow = false;
            this.roleGridEX.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "RoleID";
            gridViewTextBoxColumn5.HeaderText = "عنوان نقش";
            gridViewTextBoxColumn5.Name = "RoleTitle";
            gridViewTextBoxColumn5.Width = 180;
            gridViewTextBoxColumn6.HeaderText = "توضیحات";
            gridViewTextBoxColumn6.Name = "Description";
            gridViewTextBoxColumn6.Width = 250;
            this.roleGridEX.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.roleGridEX.MasterTemplate.EnableGrouping = false;
            this.roleGridEX.Name = "roleGridEX";
            this.roleGridEX.ReadOnly = true;
            this.roleGridEX.Size = new System.Drawing.Size(469, 98);
            this.roleGridEX.TabIndex = 3;
            this.roleGridEX.Text = "radGridView1";
            this.roleGridEX.ThemeName = "Office2010Black";
            this.roleGridEX.SelectionChanged += new System.EventHandler(this.roleGridEX_SelectionChanged);
            // 
            // AccessUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(500, 383);
            this.Controls.Add(this.roleGridEX);
            this.Controls.Add(this.pageGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 416);
            this.MinimumSize = new System.Drawing.Size(508, 416);
            this.Name = "AccessUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(508, 416);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دسترسی";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.AccessUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccessUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupBox)).EndInit();
            this.pageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.securityGridEX.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityGridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridEX.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadGroupBox pageGroupBox;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private Telerik.WinControls.UI.RadGridView roleGridEX;
        private Telerik.WinControls.UI.RadGridView securityGridEX;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
    }
}