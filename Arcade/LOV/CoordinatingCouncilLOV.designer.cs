namespace UserInterface
{
    partial class CoordinatingCouncilLOV
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
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancleButton = new Telerik.WinControls.UI.RadButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.coordinatingCouncilGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 373);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(620, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 64);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات فرد ";
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancleButton.Location = new System.Drawing.Point(26, 20);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(93, 23);
            this.cancleButton.TabIndex = 13;
            this.cancleButton.Text = "انصراف";
            this.cancleButton.ThemeName = "Office2010Black";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(241, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(124, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.acceptButton.Location = new System.Drawing.Point(125, 20);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(95, 23);
            this.acceptButton.TabIndex = 17;
            this.acceptButton.Text = "تایید";
            this.acceptButton.ThemeName = "Office2010Black";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام و نام خانوادگی :";
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
            this.coordinatingCouncilGridView.Location = new System.Drawing.Point(0, -1);
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
            gridViewTextBoxColumn2.HeaderText = "نام";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "نام اعضای شورا";
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.Width = 364;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "نام پدر";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "FatherName";
            gridViewTextBoxColumn4.Width = 74;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "تاریخ عضویت";
            gridViewTextBoxColumn5.Name = "membershipDate";
            gridViewTextBoxColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn5.Width = 117;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "کد ملی";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "NationalCode";
            gridViewTextBoxColumn6.Width = 48;
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
            this.coordinatingCouncilGridView.MasterTemplate.MultiSelect = true;
            sortDescriptor1.PropertyName = "membershipDate";
            this.coordinatingCouncilGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.coordinatingCouncilGridView.Name = "coordinatingCouncilGridView";
            this.coordinatingCouncilGridView.ReadOnly = true;
            this.coordinatingCouncilGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coordinatingCouncilGridView.Size = new System.Drawing.Size(620, 274);
            this.coordinatingCouncilGridView.TabIndex = 153;
            this.coordinatingCouncilGridView.ThemeName = "Office2010Blue";
            this.coordinatingCouncilGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.coordinatingCouncilDataGridView_CellDoubleClick);
            // 
            // CoordinatingCouncilLOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 397);
            this.Controls.Add(this.coordinatingCouncilGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CoordinatingCouncilLOV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات فرد";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatingCouncilGridView)).EndInit();
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
        private Telerik.WinControls.UI.RadGridView coordinatingCouncilGridView;
    }
}
