namespace UserInterface
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.loginButton = new Telerik.WinControls.UI.RadButton();
            this.passwordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.userNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabel();
            this.reqErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.databaseButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(73, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.loginButton.Location = new System.Drawing.Point(154, 153);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "ورود";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.reqErrorProvider.SetError(this.passwordTextBox, "*");
            this.reqErrorProvider.SetIconAlignment(this.passwordTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.reqErrorProvider.SetIconPadding(this.passwordTextBox, 5);
            this.passwordTextBox.Location = new System.Drawing.Point(73, 104);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.Size = new System.Drawing.Size(92, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            this.passwordTextBox.Enter += new System.EventHandler(this.setEnglishKeyboard_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // userNameTextBox
            // 
            this.reqErrorProvider.SetError(this.userNameTextBox, "*");
            this.reqErrorProvider.SetIconAlignment(this.userNameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.reqErrorProvider.SetIconPadding(this.userNameTextBox, 5);
            this.userNameTextBox.Location = new System.Drawing.Point(73, 78);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameTextBox.Size = new System.Drawing.Size(92, 20);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TabStop = false;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            this.userNameTextBox.Enter += new System.EventHandler(this.setEnglishKeyboard_Enter);
            this.userNameTextBox.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // noticeLabel
            // 
            this.noticeLabel.BackColor = System.Drawing.Color.Transparent;
            this.noticeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Location = new System.Drawing.Point(143, 196);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(2, 2);
            this.noticeLabel.TabIndex = 7;
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // reqErrorProvider
            // 
            this.reqErrorProvider.ContainerControl = this;
            // 
            // databaseButton
            // 
            this.databaseButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.databaseButton.Location = new System.Drawing.Point(235, 153);
            this.databaseButton.Name = "databaseButton";
            this.databaseButton.Size = new System.Drawing.Size(75, 23);
            this.databaseButton.TabIndex = 8;
            this.databaseButton.Text = "بانک داده";
            this.databaseButton.Click += new System.EventHandler(this.databaseButton_Click);
            // 
            // UserLogin
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(457, 323);
            this.ControlBox = false;
            this.Controls.Add(this.databaseButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سیستم";
            this.ThemeName = "Office2010Black";
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton  cancelButton;
        private Telerik.WinControls.UI.RadButton  loginButton;
        private Telerik.WinControls.UI.RadTextBox passwordTextBox;
        private Telerik.WinControls.UI.RadTextBox userNameTextBox;
        private Telerik.WinControls.UI.RadLabel noticeLabel;
        private System.Windows.Forms.ErrorProvider reqErrorProvider;
        private Telerik.WinControls.UI.RadButton databaseButton;

    }
}

