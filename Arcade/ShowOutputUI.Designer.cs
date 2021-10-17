namespace UserInterface
{
    partial class ShowOutPutUI
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
            this.outPutGridView = new Telerik.WinControls.UI.RadGridView();
            this.newPersonButton = new Telerik.WinControls.UI.RadButton();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.outPutGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outPutGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // outPutGridView
            // 
            this.outPutGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outPutGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.outPutGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.outPutGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.outPutGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outPutGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.outPutGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // outPutGridView
            // 
            this.outPutGridView.MasterTemplate.AllowAddNewRow = false;
            this.outPutGridView.MasterTemplate.AllowColumnReorder = false;
            this.outPutGridView.MasterTemplate.AllowDeleteRow = false;
            this.outPutGridView.MasterTemplate.AllowDragToGroup = false;
            this.outPutGridView.MasterTemplate.AllowEditRow = false;
            this.outPutGridView.MasterTemplate.AllowRowResize = false;
            this.outPutGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه ";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "شناسه نوع هزینه";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "EventId";
            gridViewTextBoxColumn2.Width = 152;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "عنوان";
            gridViewTextBoxColumn3.Name = "EventTitle";
            gridViewTextBoxColumn3.Width = 285;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "قیمت";
            gridViewTextBoxColumn4.Name = "Price";
            gridViewTextBoxColumn4.Width = 196;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "تاریخ";
            gridViewTextBoxColumn5.Name = "Date";
            gridViewTextBoxColumn5.Width = 227;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "توضیحات";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "Description";
            gridViewTextBoxColumn6.Width = 47;
            this.outPutGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.outPutGridView.MasterTemplate.EnableFiltering = true;
            this.outPutGridView.MasterTemplate.EnableGrouping = false;
            this.outPutGridView.Name = "outPutGridView";
            this.outPutGridView.ReadOnly = true;
            this.outPutGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.outPutGridView.Size = new System.Drawing.Size(728, 317);
            this.outPutGridView.TabIndex = 0;
            this.outPutGridView.ThemeName = "Office2010Blue";
            this.outPutGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.outPutGridView_CellDoubleClick);
            // 
            // newPersonButton
            // 
            this.newPersonButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPersonButton.Location = new System.Drawing.Point(12, 323);
            this.newPersonButton.Name = "newPersonButton";
            this.newPersonButton.Size = new System.Drawing.Size(156, 24);
            this.newPersonButton.TabIndex = 1;
            this.newPersonButton.Text = "ثبت خروجی جدید";
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
            // ShowOutPutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 377);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.newPersonButton);
            this.Controls.Add(this.outPutGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowOutPutUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات پرداخت هزینه ها";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.outPutGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outPutGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView outPutGridView;
        private Telerik.WinControls.UI.RadButton newPersonButton;
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
    }
}
