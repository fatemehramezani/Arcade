using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowEstateReportUI
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
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.estateReportDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newEstateReportButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.estateReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateReportDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEstateReportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // estateReportDataGridView
            // 
            this.estateReportDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.estateReportDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.estateReportDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.estateReportDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.estateReportDataGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.estateReportDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.estateReportDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // estateReportDataGridView
            // 
            this.estateReportDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.estateReportDataGridView.MasterTemplate.AllowColumnReorder = false;
            this.estateReportDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.estateReportDataGridView.MasterTemplate.EnableFiltering = true;
            this.estateReportDataGridView.MasterTemplate.MultiSelect = true;
            this.estateReportDataGridView.Name = "estateReportDataGridView";
            this.estateReportDataGridView.ReadOnly = true;
            this.estateReportDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.estateReportDataGridView.ShowGroupPanel = false;
            this.estateReportDataGridView.Size = new System.Drawing.Size(868, 382);
            this.estateReportDataGridView.TabIndex = 0;
            this.estateReportDataGridView.Text = "radGridView1";
            this.estateReportDataGridView.ThemeName = "Office2010Blue";
            this.estateReportDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.EstateReportDataGridView_CellDoubleClick);
            this.estateReportDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EstateReportdataGridView_KeyDown);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 417);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(868, 21);
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
            // newEstateReportButton
            // 
            this.newEstateReportButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newEstateReportButton.Location = new System.Drawing.Point(12, 388);
            this.newEstateReportButton.Name = "newEstateReportButton";
            this.newEstateReportButton.Size = new System.Drawing.Size(117, 23);
            this.newEstateReportButton.TabIndex = 12;
            this.newEstateReportButton.Text = "مشاهده گزارش";
            this.newEstateReportButton.ThemeName = "Office2010Blue";
            this.newEstateReportButton.Click += new System.EventHandler(this.newEstateReportButton_Click);
            // 
            // ShowEstateReportUI
            // 
            this.AcceptButton = this.newEstateReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(868, 438);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newEstateReportButton);
            this.Controls.Add(this.estateReportDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowEstateReportUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش ملک";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowEstateReportUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.estateReportDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEstateReportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView estateReportDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newEstateReportButton;
    }
}
