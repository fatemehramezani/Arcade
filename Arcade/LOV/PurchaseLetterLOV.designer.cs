namespace UserInterface
{
    partial class PurchaseLetterLOV
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancleButton = new Telerik.WinControls.UI.RadButton();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseLetterGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseLetterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseLetterGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 467);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(1112, 24);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancleButton);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.acceptButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 79);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مبایعه نامه ";
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancleButton.Location = new System.Drawing.Point(29, 27);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(93, 23);
            this.cancleButton.TabIndex = 13;
            this.cancleButton.Text = "انصراف";
            this.cancleButton.ThemeName = "Office2010Black";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(287, 30);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(577, 20);
            this.codeTextBox.TabIndex = 15;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.acceptButton.Location = new System.Drawing.Point(128, 27);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(95, 23);
            this.acceptButton.TabIndex = 17;
            this.acceptButton.Text = "تایید";
            this.acceptButton.ThemeName = "Office2010Black";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "شماره و تاریخ مبایعه نامه:";
            // 
            // purchaseLetterGridView
            // 
            this.purchaseLetterGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseLetterGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.purchaseLetterGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.purchaseLetterGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.purchaseLetterGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.purchaseLetterGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.purchaseLetterGridView.Location = new System.Drawing.Point(0, -1);
            // 
            // purchaseLetterGridView
            // 
            this.purchaseLetterGridView.MasterTemplate.AllowAddNewRow = false;
            this.purchaseLetterGridView.MasterTemplate.AllowColumnReorder = false;
            this.purchaseLetterGridView.MasterTemplate.AllowDeleteRow = false;
            this.purchaseLetterGridView.MasterTemplate.AllowDragToGroup = false;
            this.purchaseLetterGridView.MasterTemplate.AllowEditRow = false;
            this.purchaseLetterGridView.MasterTemplate.AllowRowResize = false;
            this.purchaseLetterGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه ";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "تاریخ دریافت";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "DeliveryDate";
            gridViewTextBoxColumn2.Width = 447;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "انتقال دهنده";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Transmiter";
            gridViewTextBoxColumn3.Width = 28;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ContarctDate";
            gridViewTextBoxColumn4.Width = 28;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "شناسه فروشنده";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "SellerId";
            gridViewTextBoxColumn5.Width = 58;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "نام فروشنده";
            gridViewTextBoxColumn6.Name = "SellerFirstName";
            gridViewTextBoxColumn6.Width = 147;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "نام خانودگی فروشنده";
            gridViewTextBoxColumn7.Name = "SellerLastName";
            gridViewTextBoxColumn7.Width = 260;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "شناسه خریدار";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "CostumerId";
            gridViewTextBoxColumn8.Width = 34;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.HeaderText = "نام خریدار";
            gridViewTextBoxColumn9.Name = "CostumerFirstName";
            gridViewTextBoxColumn9.Width = 239;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.HeaderText = "نام خانوادگی خریدار";
            gridViewTextBoxColumn10.Name = "CostumerLastName";
            gridViewTextBoxColumn10.Width = 294;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.HeaderText = "قیمت ملک";
            gridViewTextBoxColumn11.Name = "Price";
            gridViewTextBoxColumn11.Width = 155;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.HeaderText = "شناسه شورای هماهنگی";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "CouncilId";
            gridViewTextBoxColumn12.Width = 36;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.HeaderText = "نام شورای هماهنگی";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "CouncilFirstName";
            gridViewTextBoxColumn13.Width = 36;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.HeaderText = "نام خانوادگی شورای هماهنگی";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "CouncilLastName";
            gridViewTextBoxColumn14.Width = 65;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.HeaderText = "پیش پرداخت";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "Prepayment";
            gridViewTextBoxColumn15.Width = 74;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.HeaderText = "خسارت انتقال";
            gridViewTextBoxColumn16.IsVisible = false;
            gridViewTextBoxColumn16.Name = "TransforRedress";
            gridViewTextBoxColumn16.Width = 40;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.HeaderText = "column1";
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "CommitmentRedress";
            gridViewTextBoxColumn17.Width = 40;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.HeaderText = "شاهد1";
            gridViewTextBoxColumn18.IsVisible = false;
            gridViewTextBoxColumn18.Name = "WitnessName1";
            gridViewTextBoxColumn18.Width = 83;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.HeaderText = "شاهد2";
            gridViewTextBoxColumn19.IsVisible = false;
            gridViewTextBoxColumn19.Name = "WitnessName2";
            gridViewTextBoxColumn19.Width = 83;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.HeaderText = "شماره مبایعه نامه";
            gridViewTextBoxColumn20.IsVisible = false;
            gridViewTextBoxColumn20.Name = "Code";
            gridViewTextBoxColumn20.Width = 48;
            this.purchaseLetterGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20});
            this.purchaseLetterGridView.MasterTemplate.EnableFiltering = true;
            this.purchaseLetterGridView.MasterTemplate.EnableGrouping = false;
            this.purchaseLetterGridView.Name = "purchaseLetterGridView";
            this.purchaseLetterGridView.ReadOnly = true;
            this.purchaseLetterGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.purchaseLetterGridView.Size = new System.Drawing.Size(1112, 361);
            this.purchaseLetterGridView.TabIndex = 18;
            this.purchaseLetterGridView.ThemeName = "Office2010Blue";
            this.purchaseLetterGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.purchaseLetterDataGridView_CellDoubleClick);
            // 
            // PurchaseLetterLOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 491);
            this.Controls.Add(this.purchaseLetterGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PurchaseLetterLOV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات مبایعه نامه";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.PurchaseLetterLOV_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseLetterGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseLetterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton cancleButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private Telerik.WinControls.UI.RadButton acceptButton;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView purchaseLetterGridView;
    }
}
