namespace UserInterface
{
    partial class EditUserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserUI));
            this.noticeLabel = new Telerik.WinControls.UI.RadLabel();
            this.deleteButton = new Telerik.WinControls.UI.RadButton();
            this.editButton = new Telerik.WinControls.UI.RadButton();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.userInformationGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.userNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.userNameLabel = new Telerik.WinControls.UI.RadLabel();
            this.userIdLabel = new Telerik.WinControls.UI.RadLabel();
            this.userIdTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.newPasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.confirmPasswordLabel = new Telerik.WinControls.UI.RadLabel();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.confirmPasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.descriptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.descriptionLabel = new Telerik.WinControls.UI.RadLabel();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationGroupBox)).BeginInit();
            this.userInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // noticeLabel
            // 
            this.noticeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.noticeLabel.Location = new System.Drawing.Point(300, 189);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(2, 2);
            this.noticeLabel.TabIndex = 7;
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.deleteButton.Location = new System.Drawing.Point(179, 149);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.ThemeName = "Office2010Blue";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.editButton.Location = new System.Drawing.Point(94, 149);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "ویرایش";
            this.editButton.ThemeName = "Office2010Blue";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(9, 149);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.ThemeName = "Office2010Blue";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // userInformationGroupBox
            // 
            this.userInformationGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.userInformationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.userInformationGroupBox.Controls.Add(this.userNameTextBox);
            this.userInformationGroupBox.Controls.Add(this.userNameLabel);
            this.userInformationGroupBox.Controls.Add(this.userIdLabel);
            this.userInformationGroupBox.Controls.Add(this.userIdTextBox);
            this.userInformationGroupBox.Controls.Add(this.newPasswordTextBox);
            this.userInformationGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.userInformationGroupBox.Controls.Add(this.label1);
            this.userInformationGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.userInformationGroupBox.Controls.Add(this.descriptionTextBox);
            this.userInformationGroupBox.Controls.Add(this.descriptionLabel);
            this.userInformationGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.userInformationGroupBox.HeaderText = "اطلاعات کاربر";
            this.userInformationGroupBox.Location = new System.Drawing.Point(4, 1);
            this.userInformationGroupBox.Name = "userInformationGroupBox";
            // 
            // 
            // 
            this.userInformationGroupBox.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.userInformationGroupBox.Size = new System.Drawing.Size(463, 142);
            this.userInformationGroupBox.TabIndex = 1;
            this.userInformationGroupBox.TabStop = false;
            this.userInformationGroupBox.Text = "اطلاعات کاربر";
            this.userInformationGroupBox.ThemeName = "Office2010Blue";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.userNameTextBox.Location = new System.Drawing.Point(14, 15);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 19);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TabStop = false;
            this.userNameTextBox.ThemeName = "Office2010Blue";
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.userNameLabel.Location = new System.Drawing.Point(165, 18);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 17);
            this.userNameLabel.TabIndex = 47;
            this.userNameLabel.Text = "نام کاربری :";
            this.userNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.userNameLabel.ThemeName = "Office2010Black";
            // 
            // userIdLabel
            // 
            this.userIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.userIdLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.userIdLabel.Location = new System.Drawing.Point(392, 19);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(50, 17);
            this.userIdLabel.TabIndex = 46;
            this.userIdLabel.Text = "کد کاربر :";
            this.userIdLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.userIdLabel.ThemeName = "Office2010Black";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Enabled = false;
            this.userIdTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.userIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userIdTextBox.Location = new System.Drawing.Point(235, 15);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userIdTextBox.Size = new System.Drawing.Size(100, 19);
            this.userIdTextBox.TabIndex = 0;
            this.userIdTextBox.TabStop = false;
            this.userIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userIdTextBox.ThemeName = "Office2010Blue";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newPasswordTextBox.Location = new System.Drawing.Point(235, 41);
            this.newPasswordTextBox.MaxLength = 64;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 19);
            this.newPasswordTextBox.TabIndex = 4;
            this.newPasswordTextBox.TabStop = false;
            this.newPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newPasswordTextBox.ThemeName = "Office2010Blue";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.confirmPasswordLabel.Location = new System.Drawing.Point(143, 44);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(83, 17);
            this.confirmPasswordLabel.TabIndex = 43;
            this.confirmPasswordLabel.Text = "تایید کلمه عبور :";
            this.confirmPasswordLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.confirmPasswordLabel.ThemeName = "Office2010Black";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(356, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "کلمه عبور جدید :";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.label1.ThemeName = "Office2010Black";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(14, 41);
            this.confirmPasswordTextBox.MaxLength = 64;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(100, 19);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.TabStop = false;
            this.confirmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.confirmPasswordTextBox.ThemeName = "Office2010Blue";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AutoSize = false;
            this.descriptionTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 68);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(321, 53);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.TabStop = false;
            this.descriptionTextBox.ThemeName = "Office2010Blue";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.descriptionLabel.Location = new System.Drawing.Point(386, 69);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(55, 17);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "توضیحات :";
            this.descriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.descriptionLabel.ThemeName = "Office2010Black";
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement2});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 178);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(469, 21);
            this.mainRibbonStatusBar.TabIndex = 152;
            this.mainRibbonStatusBar.Text = "ribbonStatusBar1";
            this.mainRibbonStatusBar.ThemeName = "Office2010Blue";
            this.mainRibbonStatusBar.UseCompatibleTextRendering = false;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.Name = "radLabelElement2";
            this.mainRibbonStatusBar.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "";
            this.radLabelElement2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // EditUserUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(469, 199);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.userInformationGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EditUserUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش کاربر";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationGroupBox)).EndInit();
            this.userInformationGroupBox.ResumeLayout(false);
            this.userInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel noticeLabel;
        private Telerik.WinControls.UI.RadButton  deleteButton;
        private Telerik.WinControls.UI.RadButton  editButton;
        private Telerik.WinControls.UI.RadButton  cancelButton;
        private Telerik.WinControls.UI.RadGroupBox userInformationGroupBox;
        private Telerik.WinControls.UI.RadTextBox descriptionTextBox;
        private Telerik.WinControls.UI.RadLabel descriptionLabel;
        private Telerik.WinControls.UI.RadTextBox newPasswordTextBox;
        private Telerik.WinControls.UI.RadLabel confirmPasswordLabel;
        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadTextBox confirmPasswordTextBox;
        private Telerik.WinControls.UI.RadTextBox userNameTextBox;
        private Telerik.WinControls.UI.RadLabel userNameLabel;
        private Telerik.WinControls.UI.RadLabel userIdLabel;
        private Telerik.WinControls.UI.RadTextBox userIdTextBox;
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
    }
}