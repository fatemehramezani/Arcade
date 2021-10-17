namespace UserInterface
{
    partial class EditSettingUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettingUI));
            this.descriptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabel();
            this.groupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.keyTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.descriptionLabel = new Telerik.WinControls.UI.RadLabel();
            this.valueTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.ValueLabel = new Telerik.WinControls.UI.RadLabel();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.editButton = new Telerik.WinControls.UI.RadButton();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.reqErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AutoSize = false;
            this.descriptionTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.reqErrorProvider.SetIconAlignment(this.descriptionTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.reqErrorProvider.SetIconPadding(this.descriptionTextBox, 5);
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 63);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(479, 51);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.TabStop = false;
            this.descriptionTextBox.ThemeName = "Office2010Black";
            this.descriptionTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Location = new System.Drawing.Point(183, 154);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(2, 2);
            this.noticeLabel.TabIndex = 3;
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // groupBox
            // 
            this.groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.keyTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.descriptionTextBox);
            this.groupBox.Controls.Add(this.descriptionLabel);
            this.groupBox.Controls.Add(this.valueTextBox);
            this.groupBox.Controls.Add(this.ValueLabel);
            this.groupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox.HeaderText = "";
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Name = "groupBox";
            // 
            // 
            // 
            this.groupBox.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.groupBox.Size = new System.Drawing.Size(592, 125);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.ThemeName = "Office2010Black";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.reqErrorProvider.SetIconAlignment(this.keyTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.reqErrorProvider.SetIconPadding(this.keyTextBox, 5);
            this.keyTextBox.Location = new System.Drawing.Point(10, 9);
            this.keyTextBox.MaxLength = 64;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(479, 19);
            this.keyTextBox.TabIndex = 9;
            this.keyTextBox.TabStop = false;
            this.keyTextBox.ThemeName = "Office2010Black";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(511, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "کد خصوصیت :";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.label1.ThemeName = "Office2010Black";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.descriptionLabel.Location = new System.Drawing.Point(529, 66);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(55, 17);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "توضیحات :";
            this.descriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.descriptionLabel.ThemeName = "Office2010Black";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.reqErrorProvider.SetIconAlignment(this.valueTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.reqErrorProvider.SetIconPadding(this.valueTextBox, 5);
            this.valueTextBox.Location = new System.Drawing.Point(10, 36);
            this.valueTextBox.MaxLength = 256;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(479, 19);
            this.valueTextBox.TabIndex = 1;
            this.valueTextBox.TabStop = false;
            this.valueTextBox.ThemeName = "Office2010Black";
            this.valueTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // ValueLabel
            // 
            this.ValueLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ValueLabel.Location = new System.Drawing.Point(498, 39);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(86, 17);
            this.ValueLabel.TabIndex = 6;
            this.ValueLabel.Text = "مقدار خصوصیت :";
            this.ValueLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.ValueLabel.ThemeName = "Office2010Black";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(12, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.ThemeName = "Office2010Black";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.editButton.Location = new System.Drawing.Point(97, 154);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "ویرایش";
            this.editButton.ThemeName = "Office2010Black";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "*.jpg|*.jpeg|*.png|*.gif";
            // 
            // reqErrorProvider
            // 
            this.reqErrorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "*.jpg|*.jpeg|*.png|*.gif";
            // 
            // EditSettingUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(614, 188);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditSettingUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش خصوصیت";
            this.ThemeName = "Office2010Black";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox descriptionTextBox;
        private Telerik.WinControls.UI.RadLabel noticeLabel;
        private Telerik.WinControls.UI.RadGroupBox groupBox;
        private Telerik.WinControls.UI.RadLabel descriptionLabel;
        private Telerik.WinControls.UI.RadButton  cancelButton;
        private Telerik.WinControls.UI.RadButton editButton;
        private Telerik.WinControls.UI.RadTextBox valueTextBox;
        private Telerik.WinControls.UI.RadLabel ValueLabel;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.ErrorProvider reqErrorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Telerik.WinControls.UI.RadTextBox keyTextBox;
        private Telerik.WinControls.UI.RadLabel label1;
    }
}