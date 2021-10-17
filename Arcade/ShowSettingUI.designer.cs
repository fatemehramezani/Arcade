namespace UserInterface
{
    partial class ShowSettingUI
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.SettingDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingDataGridView
            // 
            this.SettingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // SettingDataGridView
            // 
            this.SettingDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.SettingDataGridView.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.HeaderText = "عنوان";
            gridViewTextBoxColumn1.Name = "key";
            gridViewTextBoxColumn1.Width = 200;
            gridViewTextBoxColumn2.HeaderText = "مقدار";
            gridViewTextBoxColumn2.Name = "value";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.HeaderText = "توضیحات";
            gridViewTextBoxColumn3.Name = "description";
            gridViewTextBoxColumn3.Width = 210;
            this.SettingDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.SettingDataGridView.MasterTemplate.EnableGrouping = false;
            this.SettingDataGridView.Name = "SettingDataGridView";
            this.SettingDataGridView.ReadOnly = true;
            this.SettingDataGridView.Size = new System.Drawing.Size(624, 387);
            this.SettingDataGridView.TabIndex = 10;
            this.SettingDataGridView.Text = "radGridView3";
            this.SettingDataGridView.ThemeName = "Office2010Black";
            this.SettingDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.SettingDataGridView_CellDoubleClick);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 366);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(624, 21);
            this.radStatusStrip1.TabIndex = 11;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2010Black";
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
            // ShowSettingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(624, 387);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.SettingDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowSettingUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات تنظیمات";
            this.ThemeName = "Office2010Black";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView SettingDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
    }
}