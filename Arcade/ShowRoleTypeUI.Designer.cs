using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowRoleTypeUI
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
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.roleTypeDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newRoleTypeButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypeDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRoleTypeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // roleTypeDataGridView
            // 
            this.roleTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.roleTypeDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTypeDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // roleTypeDataGridView
            // 
            this.roleTypeDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.roleTypeDataGridView.MasterTemplate.AllowColumnReorder = false;
            this.roleTypeDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "شناسه نوع نقش";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "roleTypeId";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 202;
            gridViewTextBoxColumn2.HeaderText = "نوع نقش";
            gridViewTextBoxColumn2.Name = "roleTypeTitle";
            gridViewTextBoxColumn2.Width = 402;
            this.roleTypeDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.roleTypeDataGridView.MasterTemplate.EnableFiltering = true;
            this.roleTypeDataGridView.Name = "roleTypeDataGridView";
            this.roleTypeDataGridView.ReadOnly = true;
            this.roleTypeDataGridView.ShowGroupPanel = false;
            this.roleTypeDataGridView.Size = new System.Drawing.Size(424, 269);
            this.roleTypeDataGridView.TabIndex = 0;
            this.roleTypeDataGridView.Text = "radGridView1";
            this.roleTypeDataGridView.ThemeName = "Office2010Blue";
            this.roleTypeDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.RoleTypeDataGridView_CellDoubleClick);
            this.roleTypeDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RoleTypedataGridView_KeyDown);
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
            this.noticeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Name = "noticeLabel";
            this.radStatusStrip1.SetSpring(this.noticeLabel, false);
            this.noticeLabel.Text = "";
            this.noticeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.noticeLabel.TextWrap = true;
            this.noticeLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // newRoleTypeButton
            // 
            this.newRoleTypeButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newRoleTypeButton.Location = new System.Drawing.Point(12, 278);
            this.newRoleTypeButton.Name = "newRoleTypeButton";
            this.newRoleTypeButton.Size = new System.Drawing.Size(117, 23);
            this.newRoleTypeButton.TabIndex = 12;
            this.newRoleTypeButton.Text = "ثبت نوع جدید";
            this.newRoleTypeButton.ThemeName = "Office2010Blue";
            this.newRoleTypeButton.Click += new System.EventHandler(this.newRoleTypeButton_Click);
            // 
            // ShowRoleTypeUI
            // 
            this.AcceptButton = this.newRoleTypeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newRoleTypeButton);
            this.Controls.Add(this.roleTypeDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowRoleTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات نوع نقش";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowRoleTypeUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.roleTypeDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRoleTypeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView roleTypeDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newRoleTypeButton;
    }
}
