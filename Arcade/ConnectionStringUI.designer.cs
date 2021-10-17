using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ConnectionStringUI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.label2 = new Telerik.WinControls.UI.RadLabel();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.label3 = new Telerik.WinControls.UI.RadLabel();
            this.securityGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.passwordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.userNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.serversComboBox = new Telerik.WinControls.UI.RadDropDownList();
            this.setButton = new RadButton();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabel();
            this.cancelButton = new RadButton();
            this.databaseComboBox = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new Telerik.WinControls.UI.RadLabel();
            this.acceptButton = new RadButton();
            this.reqErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityGroupBox)).BeginInit();
            this.securityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(443, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمز عبور:";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(423, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "انتخاب سرور:";
            this.label2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(434, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام کاربری:";
            this.label3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // securityGroupBox
            // 
            this.securityGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.securityGroupBox.Controls.Add(this.passwordTextBox);
            this.securityGroupBox.Controls.Add(this.userNameTextBox);
            this.securityGroupBox.Controls.Add(this.serversComboBox);
            this.securityGroupBox.Controls.Add(this.label2);
            this.securityGroupBox.Controls.Add(this.setButton);
            this.securityGroupBox.Controls.Add(this.label3);
            this.securityGroupBox.Controls.Add(this.label1);
            this.securityGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.securityGroupBox.HeaderText = "تنظیمات امنیتی";
            this.securityGroupBox.Location = new System.Drawing.Point(12, 3);
            this.securityGroupBox.Name = "securityGroupBox";
            this.securityGroupBox.Size = new System.Drawing.Size(500, 101);
            this.securityGroupBox.TabIndex = 0;
            this.securityGroupBox.TabStop = false;
            this.securityGroupBox.Text = "تنظیمات امنیتی";
            this.securityGroupBox.ThemeName = "Office2010Blue";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(236, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.Size = new System.Drawing.Size(152, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.ThemeName = "Office2010Blue";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(236, 45);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TabStop = false;
            this.userNameTextBox.ThemeName = "Office2010Blue";
            // 
            // serversComboBox
            // 
            this.serversComboBox.AllowShowFocusCues = false;
            this.serversComboBox.Location = new System.Drawing.Point(22, 19);
            this.serversComboBox.Name = "serversComboBox";
            this.serversComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serversComboBox.Size = new System.Drawing.Size(366, 20);
            this.serversComboBox.TabIndex = 0;
            this.serversComboBox.ThemeName = "Office2010Blue";
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.setButton.Location = new System.Drawing.Point(22, 69);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(80, 23);
            this.setButton.TabIndex = 3;
            this.setButton.Text = "تنظیم";
            this.setButton.ThemeName = "Office2010Blue";
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.noticeLabel.Location = new System.Drawing.Point(183, 139);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(2, 2);
            this.noticeLabel.TabIndex = 4;
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(12, 139);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.ThemeName = "Office2010Blue";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // databaseComboBox
            // 
            this.databaseComboBox.AllowShowFocusCues = false;
            this.databaseComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.databaseComboBox.Enabled = false;
            this.databaseComboBox.Location = new System.Drawing.Point(34, 112);
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.databaseComboBox.Size = new System.Drawing.Size(366, 20);
            this.databaseComboBox.TabIndex = 1;
            this.databaseComboBox.ThemeName = "Office2010Blue";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(419, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "انتخاب بانک داده:";
            this.label4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.acceptButton.Location = new System.Drawing.Point(98, 139);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(80, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "تایید";
            this.acceptButton.ThemeName = "Office2010Blue";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // reqErrorProvider
            // 
            this.reqErrorProvider.ContainerControl = this;
            // 
            // ConnectionStringUI
            // 
            this.AcceptButton = this.setButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(519, 179);
            this.ControlBox = false;
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databaseComboBox);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.securityGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(527, 212);
            this.MinimumSize = new System.Drawing.Size(527, 212);
            this.Name = "ConnectionStringUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(527, 212);
            this.Text = "تنظیمات بانک داده";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.DatabaseSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatabaseSettingUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityGroupBox)).EndInit();
            this.securityGroupBox.ResumeLayout(false);
            this.securityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadLabel label2;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadLabel label3;
        private Telerik.WinControls.UI.RadGroupBox securityGroupBox;
        private RadButton setButton;
        private RadButton cancelButton;
        private Telerik.WinControls.UI.RadLabel noticeLabel;
        private Telerik.WinControls.UI.RadTextBox passwordTextBox;
        private Telerik.WinControls.UI.RadTextBox userNameTextBox;
        private Telerik.WinControls.UI.RadDropDownList serversComboBox;
        private Telerik.WinControls.UI.RadDropDownList databaseComboBox;
        private Telerik.WinControls.UI.RadLabel label4;
        private RadButton acceptButton;
        private System.Windows.Forms.ErrorProvider reqErrorProvider;
    }
}