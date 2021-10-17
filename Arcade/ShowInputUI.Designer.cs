namespace UserInterface
{
    partial class ShowInputUI
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
            this.landLordGridView = new Telerik.WinControls.UI.RadGridView();
            this.newPersonButton = new Telerik.WinControls.UI.RadButton();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.landLordGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landLordGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // landLordGridView
            // 
            this.landLordGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.landLordGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.landLordGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.landLordGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.landLordGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.landLordGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // landLordGridView
            // 
            this.landLordGridView.MasterTemplate.AllowAddNewRow = false;
            this.landLordGridView.MasterTemplate.AllowColumnReorder = false;
            this.landLordGridView.MasterTemplate.AllowDeleteRow = false;
            this.landLordGridView.MasterTemplate.AllowDragToGroup = false;
            this.landLordGridView.MasterTemplate.AllowEditRow = false;
            this.landLordGridView.MasterTemplate.AllowRowResize = false;
            this.landLordGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه ";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "شناسه ملک";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "EstateId";
            gridViewTextBoxColumn2.Width = 447;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "اطلاعات ملک";
            gridViewTextBoxColumn3.Name = "Title";
            gridViewTextBoxColumn3.Width = 617;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "شناسه ورودی";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "EventId";
            gridViewTextBoxColumn4.Width = 126;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "عنوان ورودی";
            gridViewTextBoxColumn5.Name = "EventTitle";
            gridViewTextBoxColumn5.Width = 141;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "هزینه";
            gridViewTextBoxColumn6.Name = "Price";
            gridViewTextBoxColumn6.Width = 148;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "تاریخ دریافت";
            gridViewTextBoxColumn7.Name = "Date";
            gridViewTextBoxColumn7.Width = 209;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "توضیحات";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Description";
            gridViewTextBoxColumn8.Width = 46;
            this.landLordGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.landLordGridView.MasterTemplate.EnableFiltering = true;
            this.landLordGridView.MasterTemplate.EnableGrouping = false;
            this.landLordGridView.Name = "landLordGridView";
            this.landLordGridView.ReadOnly = true;
            this.landLordGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.landLordGridView.Size = new System.Drawing.Size(1134, 360);
            this.landLordGridView.TabIndex = 0;
            this.landLordGridView.ThemeName = "Office2010Blue";
            this.landLordGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.landLordGridView_CellDoubleClick);
            // 
            // newPersonButton
            // 
            this.newPersonButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPersonButton.Location = new System.Drawing.Point(12, 382);
            this.newPersonButton.Name = "newPersonButton";
            this.newPersonButton.Size = new System.Drawing.Size(156, 24);
            this.newPersonButton.TabIndex = 1;
            this.newPersonButton.Text = "ثبت ورودی جدید";
            this.newPersonButton.ThemeName = "Office2010Blue";
            this.newPersonButton.Click += new System.EventHandler(this.newPersonButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 419);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(1134, 21);
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
            // ShowInputUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 440);
            this.Controls.Add(this.landLordGridView);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.newPersonButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowInputUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات دریافتی ها";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.landLordGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landLordGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView landLordGridView;
        private Telerik.WinControls.UI.RadButton newPersonButton;
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
    }
}
