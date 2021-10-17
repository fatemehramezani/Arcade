using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class EditEstateTypeUI
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
            this.groupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.titleTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.militaryStatusTitleLabel = new Telerik.WinControls.UI.RadLabel();
            this.militaryStatusIdLabel = new Telerik.WinControls.UI.RadLabel();
            this.idTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.editButton = new Telerik.WinControls.UI.RadButton();
            this.deleteButton = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusIdLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.titleTextBox);
            this.groupBox.Controls.Add(this.militaryStatusTitleLabel);
            this.groupBox.Controls.Add(this.militaryStatusIdLabel);
            this.groupBox.Controls.Add(this.idTextBox);
            this.groupBox.HeaderText = "";
            this.groupBox.Location = new System.Drawing.Point(3, 7);
            this.groupBox.Name = "groupBox";
            // 
            // 
            // 
            this.groupBox.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.groupBox.Size = new System.Drawing.Size(404, 96);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.ThemeName = "Office2010Blue";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.titleTextBox.Location = new System.Drawing.Point(14, 52);
            this.titleTextBox.MaxLength = 128;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.NullText = "اجباری";
            this.titleTextBox.Size = new System.Drawing.Size(310, 19);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TabStop = false;
            this.titleTextBox.ThemeName = "Office2010Blue";
            // 
            // militaryStatusTitleLabel
            // 
            this.militaryStatusTitleLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.militaryStatusTitleLabel.Location = new System.Drawing.Point(327, 53);
            this.militaryStatusTitleLabel.Name = "militaryStatusTitleLabel";
            this.militaryStatusTitleLabel.Size = new System.Drawing.Size(73, 17);
            this.militaryStatusTitleLabel.TabIndex = 6;
            this.militaryStatusTitleLabel.Text = "عنوان وضعیت:";
            this.militaryStatusTitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.militaryStatusTitleLabel.ThemeName = "Office2010Blue";
            // 
            // militaryStatusIdLabel
            // 
            this.militaryStatusIdLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.militaryStatusIdLabel.Location = new System.Drawing.Point(340, 23);
            this.militaryStatusIdLabel.Name = "militaryStatusIdLabel";
            this.militaryStatusIdLabel.Size = new System.Drawing.Size(59, 17);
            this.militaryStatusIdLabel.TabIndex = 5;
            this.militaryStatusIdLabel.Text = "کد وضعیت:";
            this.militaryStatusIdLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.militaryStatusIdLabel.ThemeName = "Office2010Blue";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.idTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idTextBox.Location = new System.Drawing.Point(224, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idTextBox.Size = new System.Drawing.Size(100, 19);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TabStop = false;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.idTextBox.ThemeName = "Office2010Blue";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(17, 112);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.ThemeName = "Office2010Blue";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.editButton.Location = new System.Drawing.Point(102, 112);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "ویرایش";
            this.editButton.ThemeName = "Office2010Blue";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.deleteButton.Location = new System.Drawing.Point(187, 112);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "حذف";
            this.deleteButton.ThemeName = "Office2010Blue";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.noticeLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 149);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(411, 21);
            this.radStatusStrip1.TabIndex = 15;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2010Blue";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.ForeColor = System.Drawing.Color.Red;
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // noticeLabel
            // 
            this.noticeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.noticeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noticeLabel.Name = "noticeLabel";
            this.radStatusStrip1.SetSpring(this.noticeLabel, false);
            this.noticeLabel.Text = "";
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.TextWrap = true;
            this.noticeLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditEstateTypeUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(411, 170);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEstateTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش نوع ملک";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditEstateTypeUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusIdLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox groupBox;
        private RadTextBox titleTextBox;
        private Telerik.WinControls.UI.RadLabel militaryStatusTitleLabel;
        private Telerik.WinControls.UI.RadLabel militaryStatusIdLabel;
        private RadTextBox idTextBox;
        private RadButton cancelButton;
        private RadButton editButton;
        private RadButton deleteButton;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private RadLabelElement noticeLabel;
    }
}
