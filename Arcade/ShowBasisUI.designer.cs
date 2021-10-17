using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowBasisUI
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
            this.BasisDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newBasisButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.BasisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasisDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBasisButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BasisDataGridView
            // 
            this.BasisDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasisDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasisDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // BasisDataGridView
            // 
            this.BasisDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.BasisDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.BasisDataGridView.MasterTemplate.EnableFiltering = true;
            this.BasisDataGridView.MasterTemplate.EnableGrouping = false;
            this.BasisDataGridView.Name = "BasisDataGridView";
            this.BasisDataGridView.ReadOnly = true;
            this.BasisDataGridView.ShowGroupPanel = false;
            this.BasisDataGridView.Size = new System.Drawing.Size(424, 269);
            this.BasisDataGridView.TabIndex = 0;
            this.BasisDataGridView.Text = "radGridView1";
            this.BasisDataGridView.ThemeName = "Office2010Blue";
            this.BasisDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.BasisDataGridView_CellDoubleClick);
            this.BasisDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BasisdataGridView_KeyDown);
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
            // newBasisButton
            // 
            this.newBasisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newBasisButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newBasisButton.Location = new System.Drawing.Point(12, 278);
            this.newBasisButton.Name = "newBasisButton";
            this.newBasisButton.Size = new System.Drawing.Size(117, 23);
            this.newBasisButton.TabIndex = 12;
            this.newBasisButton.Text = "ثبت شغل جدید";
            this.newBasisButton.ThemeName = "Office2010Blue";
            this.newBasisButton.Click += new System.EventHandler(this.newBasisButton_Click);
            // 
            // ShowBasisUI
            // 
            this.AcceptButton = this.newBasisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newBasisButton);
            this.Controls.Add(this.BasisDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowBasisUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات شغل";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowBasisUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BasisDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBasisButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView BasisDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newBasisButton;
    }
}
