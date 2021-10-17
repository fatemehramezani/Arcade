namespace UserInterface
{
    partial class InfoListReportUI
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.reportButton = new Telerik.WinControls.UI.RadButton();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.personalInfoGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(10, 430);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(156, 24);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "مشاهده گزارش";
            this.reportButton.ThemeName = "Office2010Blue";
            this.reportButton.Click += new System.EventHandler(this.newPersonButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 462);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(1101, 21);
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
            // personalInfoGridView
            // 
            this.personalInfoGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.personalInfoGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.personalInfoGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.personalInfoGridView.EnableCustomGrouping = true;
            this.personalInfoGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.personalInfoGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.personalInfoGridView.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Accordion;
            this.personalInfoGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.personalInfoGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // personalInfoGridView
            // 
            this.personalInfoGridView.MasterTemplate.AllowAddNewRow = false;
            this.personalInfoGridView.MasterTemplate.AllowDeleteRow = false;
            this.personalInfoGridView.MasterTemplate.AllowEditRow = false;
            this.personalInfoGridView.MasterTemplate.AllowRowResize = false;
            this.personalInfoGridView.MasterTemplate.EnableCustomGrouping = true;
            this.personalInfoGridView.EnableFiltering = true;
            this.personalInfoGridView.MasterTemplate.EnableFiltering = true;
            this.personalInfoGridView.MasterTemplate.EnableGrouping = false;
            this.personalInfoGridView.MasterTemplate.MultiSelect = true;
            this.personalInfoGridView.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.PropertyName = "RFID";
            this.personalInfoGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.personalInfoGridView.Name = "personalInfoGridView";
            this.personalInfoGridView.ReadOnly = true;
            this.personalInfoGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personalInfoGridView.ShowGroupPanel = false;
            this.personalInfoGridView.Size = new System.Drawing.Size(1101, 422);
            this.personalInfoGridView.TabIndex = 152;
            this.personalInfoGridView.ThemeName = "Office2010Blue";
            // 
            // InfoListReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1101, 483);
            this.Controls.Add(this.personalInfoGridView);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.reportButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoListReportUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات داوطلب ";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.reportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton reportButton;
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private Telerik.WinControls.UI.RadGridView personalInfoGridView;
        
    }
}
