namespace UserInterface
{
    partial class ShowCoordinatingCouncilUI
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.coordinatingCouncilGridView = new Telerik.WinControls.UI.RadGridView();
            this.newPersonButton = new Telerik.WinControls.UI.RadButton();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // coordinatingCouncilGridView
            // 
            this.coordinatingCouncilGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coordinatingCouncilGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.coordinatingCouncilGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.coordinatingCouncilGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.coordinatingCouncilGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coordinatingCouncilGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coordinatingCouncilGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // coordinatingCouncilGridView
            // 
            this.coordinatingCouncilGridView.MasterTemplate.AllowAddNewRow = false;
            this.coordinatingCouncilGridView.MasterTemplate.AllowColumnReorder = false;
            this.coordinatingCouncilGridView.MasterTemplate.AllowDeleteRow = false;
            this.coordinatingCouncilGridView.MasterTemplate.AllowDragToGroup = false;
            this.coordinatingCouncilGridView.MasterTemplate.AllowEditRow = false;
            this.coordinatingCouncilGridView.MasterTemplate.AllowRowResize = false;
            this.coordinatingCouncilGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه ";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "عنوان شورا";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 138;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "اعضای شورا";
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.VisibleInColumnChooser = false;
            gridViewTextBoxColumn3.Width = 318;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "نام پدر";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "FatherName";
            gridViewTextBoxColumn4.Width = 71;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "تاریخ عضویت";
            gridViewTextBoxColumn5.Name = "membershipDate";
            gridViewTextBoxColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn5.Width = 148;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "کد ملی";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "NationalCode";
            gridViewTextBoxColumn6.Width = 117;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "تاریخ خروج";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "quitDate";
            gridViewTextBoxColumn7.Width = 45;
            this.coordinatingCouncilGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.coordinatingCouncilGridView.MasterTemplate.EnableFiltering = true;
            this.coordinatingCouncilGridView.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "membershipDate";
            this.coordinatingCouncilGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.coordinatingCouncilGridView.Name = "coordinatingCouncilGridView";
            this.coordinatingCouncilGridView.ReadOnly = true;
            this.coordinatingCouncilGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coordinatingCouncilGridView.Size = new System.Drawing.Size(623, 317);
            this.coordinatingCouncilGridView.TabIndex = 0;
            this.coordinatingCouncilGridView.ThemeName = "Office2010Blue";
            this.coordinatingCouncilGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.coordinatingCouncilGridView_CellDoubleClick);
            // 
            // newPersonButton
            // 
            this.newPersonButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPersonButton.Location = new System.Drawing.Point(12, 323);
            this.newPersonButton.Name = "newPersonButton";
            this.newPersonButton.Size = new System.Drawing.Size(156, 24);
            this.newPersonButton.TabIndex = 1;
            this.newPersonButton.Text = "ثبت عضو جدید";
            this.newPersonButton.ThemeName = "Office2010Blue";
            this.newPersonButton.Click += new System.EventHandler(this.newPersonButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 353);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(623, 24);
            this.mainRibbonStatusBar.TabIndex = 151;
            this.mainRibbonStatusBar.Text = "ribbonStatusBar1";
            this.mainRibbonStatusBar.ThemeName = "Office2010Blue";
            this.mainRibbonStatusBar.UseCompatibleTextRendering = false;
            // 
            // noticeLabel
            // 
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Text = "";
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.TextWrap = true;
            this.noticeLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // ShowCoordinatingCouncilUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 377);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.newPersonButton);
            this.Controls.Add(this.coordinatingCouncilGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowCoordinatingCouncilUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات شورای هماهنگی ";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView coordinatingCouncilGridView;
        private Telerik.WinControls.UI.RadButton newPersonButton;
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
    }
}
