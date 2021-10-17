namespace UserInterface
{
    partial class ShowEstateUI
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.estateGridView = new Telerik.WinControls.UI.RadGridView();
            this.newPersonButton = new Telerik.WinControls.UI.RadButton();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.estateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // estateGridView
            // 
            this.estateGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estateGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.estateGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.estateGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.estateGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.estateGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.estateGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // estateGridView
            // 
            this.estateGridView.MasterTemplate.AllowAddNewRow = false;
            this.estateGridView.MasterTemplate.AllowColumnReorder = false;
            this.estateGridView.MasterTemplate.AllowDeleteRow = false;
            this.estateGridView.MasterTemplate.AllowDragToGroup = false;
            this.estateGridView.MasterTemplate.AllowEditRow = false;
            this.estateGridView.MasterTemplate.AllowRowResize = false;
            this.estateGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه ";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "کدپستی";
            gridViewTextBoxColumn2.Name = "ZipCode";
            gridViewTextBoxColumn2.Width = 115;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "مساحت";
            gridViewTextBoxColumn3.Name = "Area";
            gridViewTextBoxColumn3.Width = 86;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "امکانات";
            gridViewTextBoxColumn4.Name = "Facilities";
            gridViewTextBoxColumn4.Width = 222;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "طبقه";
            gridViewTextBoxColumn5.Name = "Floor";
            gridViewTextBoxColumn5.Width = 43;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "آدرس";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "Address";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "تلفن";
            gridViewTextBoxColumn7.Name = "Phone";
            gridViewTextBoxColumn7.Width = 86;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "شناسه نوع ملک";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "EstateTypeId";
            gridViewTextBoxColumn8.Width = 152;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.HeaderText = "نوع ملک";
            gridViewTextBoxColumn9.Name = "EstateTypeTitle";
            gridViewTextBoxColumn9.Width = 59;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.HeaderText = "کد ملک";
            gridViewTextBoxColumn10.Name = "Name";
            gridViewTextBoxColumn10.Width = 101;
            this.estateGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.estateGridView.MasterTemplate.EnableFiltering = true;
            this.estateGridView.MasterTemplate.EnableGrouping = false;
            this.estateGridView.Name = "estateGridView";
            this.estateGridView.ReadOnly = true;
            this.estateGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.estateGridView.Size = new System.Drawing.Size(728, 317);
            this.estateGridView.TabIndex = 0;
            this.estateGridView.ThemeName = "Office2010Blue";
            this.estateGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.estateGridView_CellDoubleClick);
            // 
            // newPersonButton
            // 
            this.newPersonButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPersonButton.Location = new System.Drawing.Point(12, 323);
            this.newPersonButton.Name = "newPersonButton";
            this.newPersonButton.Size = new System.Drawing.Size(156, 24);
            this.newPersonButton.TabIndex = 1;
            this.newPersonButton.Text = "ثبت ملک جدید";
            this.newPersonButton.ThemeName = "Office2010Blue";
            this.newPersonButton.Click += new System.EventHandler(this.newPersonButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 356);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(728, 21);
            this.mainRibbonStatusBar.TabIndex = 151;
            this.mainRibbonStatusBar.Text = "ribbonStatusBar1";
            this.mainRibbonStatusBar.ThemeName = "Office2010Blue";
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
            // ShowEstateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 377);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.newPersonButton);
            this.Controls.Add(this.estateGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowEstateUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات ملک";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.estateGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView estateGridView;
        private Telerik.WinControls.UI.RadButton newPersonButton;
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
    }
}
