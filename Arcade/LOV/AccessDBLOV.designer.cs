namespace UserInterface
{
    partial class CheckLOV
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
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancleButton = new Telerik.WinControls.UI.RadButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 379);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(842, 21);
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
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.acceptButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 64);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات چک";
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancleButton.Location = new System.Drawing.Point(6, 23);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(93, 23);
            this.cancleButton.TabIndex = 13;
            this.cancleButton.Text = "انصراف";
            this.cancleButton.ThemeName = "Office2010Black";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(226, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(361, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.acceptButton.Location = new System.Drawing.Point(105, 23);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(95, 23);
            this.acceptButton.TabIndex = 17;
            this.acceptButton.Text = "تایید";
            this.acceptButton.ThemeName = "Office2010Black";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "شماره چک-شماره حساب-تاریخ-در وجه";
            // 
            // checkGridView
            // 
            this.checkGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.checkGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.checkGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // checkGridView
            // 
            this.checkGridView.MasterTemplate.AllowAddNewRow = false;
            this.checkGridView.MasterTemplate.AllowColumnReorder = false;
            this.checkGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه چک";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 202;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "شماره چک";
            gridViewTextBoxColumn2.Name = "Number";
            gridViewTextBoxColumn2.Width = 159;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "شماره حساب";
            gridViewTextBoxColumn3.Name = "AccountNumber";
            gridViewTextBoxColumn3.Width = 129;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "تاریخ";
            gridViewTextBoxColumn4.Name = "Date";
            gridViewTextBoxColumn4.Width = 117;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "نام دارنده حساب";
            gridViewTextBoxColumn5.Name = "AccountName";
            gridViewTextBoxColumn5.Width = 132;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "نام بانک";
            gridViewTextBoxColumn6.Name = "BankName";
            gridViewTextBoxColumn6.Width = 86;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "در وجه ";
            gridViewTextBoxColumn7.Name = "ForWhom";
            gridViewTextBoxColumn7.Width = 96;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "مبلغ";
            gridViewTextBoxColumn8.Name = "Price";
            gridViewTextBoxColumn8.Width = 107;
            this.checkGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.checkGridView.MasterTemplate.EnableFiltering = true;
            this.checkGridView.Name = "checkGridView";
            this.checkGridView.ReadOnly = true;
            this.checkGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkGridView.ShowGroupPanel = false;
            this.checkGridView.Size = new System.Drawing.Size(842, 269);
            this.checkGridView.TabIndex = 153;
            this.checkGridView.Text = "اطلاعات چک";
            this.checkGridView.ThemeName = "Office2010Blue";
            // 
            // CheckLOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 400);
            this.Controls.Add(this.checkGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CheckLOV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات چک";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton cancleButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private Telerik.WinControls.UI.RadButton acceptButton;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView checkGridView;
    }
}
