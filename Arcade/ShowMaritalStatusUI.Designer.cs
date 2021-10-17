using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowMaritalStatusUI
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
            this.maritalStatusDataGridView = new RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newMaritalStatusButton = new RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMaritalStatusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // maritalStatusDataGridView
            // 
            this.maritalStatusDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.maritalStatusDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maritalStatusDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // maritalStatusDataGridView
            // 
            this.maritalStatusDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.maritalStatusDataGridView.MasterTemplate.AllowColumnReorder = false;
            this.maritalStatusDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "شناسه وضعیت تاهل";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 202;
            gridViewTextBoxColumn2.HeaderText = "وضعیت تاهل";
            gridViewTextBoxColumn2.Name = "Title";
            gridViewTextBoxColumn2.Width = 402;
            this.maritalStatusDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.maritalStatusDataGridView.MasterTemplate.EnableFiltering = true;
            this.maritalStatusDataGridView.Name = "maritalStatusDataGridView";
            this.maritalStatusDataGridView.ReadOnly = true;
            this.maritalStatusDataGridView.ShowGroupPanel = false;
            this.maritalStatusDataGridView.Size = new System.Drawing.Size(424, 269);
            this.maritalStatusDataGridView.TabIndex = 0;
            this.maritalStatusDataGridView.Text = "radGridView1";
            this.maritalStatusDataGridView.ThemeName = "Office2010Blue";
            this.maritalStatusDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MaritalStatusDataGridView_CellDoubleClick);
            this.maritalStatusDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaritalStatusdataGridView_KeyDown);
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
            // newMaritalStatusButton
            // 
            this.newMaritalStatusButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newMaritalStatusButton.Location = new System.Drawing.Point(12, 278);
            this.newMaritalStatusButton.Name = "newMaritalStatusButton";
            this.newMaritalStatusButton.Size = new System.Drawing.Size(170, 23);
            this.newMaritalStatusButton.TabIndex = 12;
            this.newMaritalStatusButton.Text = "وضعیت تاهل جدید";
            this.newMaritalStatusButton.ThemeName = "Office2010Blue";
            this.newMaritalStatusButton.Click += new System.EventHandler(this.newMaritalStatusButton_Click);
            // 
            // ShowMaritalStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newMaritalStatusButton);
            this.Controls.Add(this.maritalStatusDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowMaritalStatusUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات وضعیت تاهل";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowMaritalStatusUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMaritalStatusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView maritalStatusDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newMaritalStatusButton;
    }
}
