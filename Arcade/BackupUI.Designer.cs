namespace UserInterface
{
    partial class BackupUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupUI));
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.backupPathTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.acceptButton = new Telerik.WinControls.UI.RadButton();
            this.mainRibbonStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.browserButton = new Telerik.WinControls.UI.RadButton();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupPathTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(357, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان فایل:";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.label1.ThemeName = "Office2010Black";
            // 
            // backupPathTextBox
            // 
            this.backupPathTextBox.Enabled = false;
            this.backupPathTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.backupPathTextBox.Location = new System.Drawing.Point(45, 11);
            this.backupPathTextBox.Name = "backupPathTextBox";
            this.backupPathTextBox.Size = new System.Drawing.Size(284, 19);
            this.backupPathTextBox.TabIndex = 0;
            this.backupPathTextBox.TabStop = false;
            this.backupPathTextBox.ThemeName = "Office2010Blue";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(10, 39);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.ThemeName = "Office2010Blue";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.acceptButton.Location = new System.Drawing.Point(92, 39);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 42;
            this.acceptButton.Text = "تایید";
            this.acceptButton.ThemeName = "Office2010Blue";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mainRibbonStatusBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 71);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(422, 21);
            this.mainRibbonStatusBar.TabIndex = 149;
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
            // browserButton
            // 
            this.browserButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.browserButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.browserButton.Location = new System.Drawing.Point(10, 10);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(29, 23);
            this.browserButton.TabIndex = 150;
            this.browserButton.Text = "...";
            this.browserButton.ThemeName = "Office2010Blue";
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // BackupUI
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(422, 92);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.backupPathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 125);
            this.MinimumSize = new System.Drawing.Size(430, 125);
            this.Name = "BackupUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(430, 125);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تهیه نسخه پشتیبان";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackupUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupPathTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadTextBox backupPathTextBox;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadButton acceptButton;        
        private Telerik.WinControls.UI.RadStatusStrip mainRibbonStatusBar;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private Telerik.WinControls.UI.RadButton browserButton;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
    }
}