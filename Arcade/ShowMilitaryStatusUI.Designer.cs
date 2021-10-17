using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowMilitaryStatusUI
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
            this.militaryStatusDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newMilitaryStatusButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMilitaryStatusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryStatusDataGridView
            // 
            this.militaryStatusDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.militaryStatusDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.militaryStatusDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // militaryStatusDataGridView
            // 
            this.militaryStatusDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.militaryStatusDataGridView.MasterTemplate.AllowColumnReorder = false;
            this.militaryStatusDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "شناسه وضعیت خدمت";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "militaryStatusId";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 202;
            gridViewTextBoxColumn2.HeaderText = "وضعیت خدمت";
            gridViewTextBoxColumn2.Name = "militaryStatusTitle";
            gridViewTextBoxColumn2.Width = 402;
            this.militaryStatusDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.militaryStatusDataGridView.MasterTemplate.EnableFiltering = true;
            this.militaryStatusDataGridView.Name = "militaryStatusDataGridView";
            this.militaryStatusDataGridView.ReadOnly = true;
            this.militaryStatusDataGridView.ShowGroupPanel = false;
            this.militaryStatusDataGridView.Size = new System.Drawing.Size(424, 269);
            this.militaryStatusDataGridView.TabIndex = 0;
            this.militaryStatusDataGridView.Text = "radGridView1";
            this.militaryStatusDataGridView.ThemeName = "Office2010Blue";
            this.militaryStatusDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MilitaryStatusDataGridView_CellDoubleClick);
            this.militaryStatusDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MilitaryStatusdataGridView_KeyDown);
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
            // newMilitaryStatusButton
            // 
            this.newMilitaryStatusButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newMilitaryStatusButton.Location = new System.Drawing.Point(12, 278);
            this.newMilitaryStatusButton.Name = "newMilitaryStatusButton";
            this.newMilitaryStatusButton.Size = new System.Drawing.Size(117, 23);
            this.newMilitaryStatusButton.TabIndex = 12;
            this.newMilitaryStatusButton.Text = "ثبت وضعیت جدید";
            this.newMilitaryStatusButton.ThemeName = "Office2010Blue";
            this.newMilitaryStatusButton.Click += new System.EventHandler(this.newMilitaryStatusButton_Click);
            // 
            // ShowMilitaryStatusUI
            // 
            this.AcceptButton = this.newMilitaryStatusButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newMilitaryStatusButton);
            this.Controls.Add(this.militaryStatusDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowMilitaryStatusUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات وضعیت خدمت";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowMilitaryStatusUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMilitaryStatusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView militaryStatusDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newMilitaryStatusButton;
    }
}
