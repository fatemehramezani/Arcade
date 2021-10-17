using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowPersonalRoleUI
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.PersonalRoleDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newPersonalRoleButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalRoleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalRoleDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonalRoleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalRoleDataGridView
            // 
            this.PersonalRoleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalRoleDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalRoleDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // PersonalRoleDataGridView
            // 
            this.PersonalRoleDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.PersonalRoleDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.HeaderText = "شناسه شغل";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Id";
            gridViewTextBoxColumn7.VisibleInColumnChooser = false;
            gridViewTextBoxColumn7.Width = 202;
            gridViewTextBoxColumn8.HeaderText = "شناسه نقش";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "RoleTypeId";
            gridViewTextBoxColumn8.Width = 32;
            gridViewTextBoxColumn9.HeaderText = "عنوان نقش";
            gridViewTextBoxColumn9.Name = "RoleTypeTitle";
            gridViewTextBoxColumn9.Width = 110;
            gridViewTextBoxColumn10.HeaderText = "شناسه فرد";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "PersonalInfoId";
            gridViewTextBoxColumn10.Width = 36;
            gridViewTextBoxColumn11.HeaderText = "نام";
            gridViewTextBoxColumn11.Name = "FirstName";
            gridViewTextBoxColumn11.Width = 140;
            gridViewTextBoxColumn12.HeaderText = "نام خانودادگی";
            gridViewTextBoxColumn12.Name = "LastName";
            gridViewTextBoxColumn12.Width = 154;
            this.PersonalRoleDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.PersonalRoleDataGridView.MasterTemplate.EnableFiltering = true;
            this.PersonalRoleDataGridView.MasterTemplate.EnableGrouping = false;
            this.PersonalRoleDataGridView.Name = "PersonalRoleDataGridView";
            this.PersonalRoleDataGridView.ReadOnly = true;
            this.PersonalRoleDataGridView.ShowGroupPanel = false;
            this.PersonalRoleDataGridView.Size = new System.Drawing.Size(424, 269);
            this.PersonalRoleDataGridView.TabIndex = 0;
            this.PersonalRoleDataGridView.Text = "radGridView1";
            this.PersonalRoleDataGridView.ThemeName = "Office2010Blue";
            this.PersonalRoleDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.PersonalRoleDataGridView_CellDoubleClick);
            this.PersonalRoleDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PersonalRoledataGridView_KeyDown);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 311);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(424, 21);
            this.radStatusStrip1.TabIndex = 13;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2010Blue";
            // 
            // noticeLabel
            // 
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Name = "noticeLabel";
            this.radStatusStrip1.SetSpring(this.noticeLabel, false);
            this.noticeLabel.Text = "";
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.TextWrap = true;
            this.noticeLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // newPersonalRoleButton
            // 
            this.newPersonalRoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newPersonalRoleButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newPersonalRoleButton.Location = new System.Drawing.Point(12, 278);
            this.newPersonalRoleButton.Name = "newPersonalRoleButton";
            this.newPersonalRoleButton.Size = new System.Drawing.Size(117, 23);
            this.newPersonalRoleButton.TabIndex = 12;
            this.newPersonalRoleButton.Text = "ثبت نقش  جدید";
            this.newPersonalRoleButton.ThemeName = "Office2010Blue";
            this.newPersonalRoleButton.Click += new System.EventHandler(this.newPersonalRoleButton_Click);
            // 
            // ShowPersonalRoleUI
            // 
            this.AcceptButton = this.newPersonalRoleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newPersonalRoleButton);
            this.Controls.Add(this.PersonalRoleDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowPersonalRoleUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات نقش";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowPersonalRoleUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalRoleDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalRoleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPersonalRoleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView PersonalRoleDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newPersonalRoleButton;
    }
}
