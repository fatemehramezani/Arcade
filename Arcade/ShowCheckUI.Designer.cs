using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowCheckUI
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.checkGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newCheckButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCheckButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // checkGridView
            // 
            this.checkGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.checkGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.checkGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // checkGridView
            // 
            this.checkGridView.MasterTemplate.AllowAddNewRow = false;
            this.checkGridView.MasterTemplate.AllowColumnReorder = false;
            this.checkGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه چک";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 157;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "شماره چک";
            gridViewTextBoxColumn2.Name = "Number";
            gridViewTextBoxColumn2.Width = 155;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "شماره حساب";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "AccountNumber";
            gridViewTextBoxColumn3.Width = 110;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "تاریخ";
            gridViewTextBoxColumn4.Name = "Date";
            gridViewTextBoxColumn4.Width = 201;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "نام دارنده حساب";
            gridViewTextBoxColumn5.Name = "AccountName";
            gridViewTextBoxColumn5.Width = 149;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "نام بانک";
            gridViewTextBoxColumn6.Name = "BankName";
            gridViewTextBoxColumn6.Width = 91;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "در وجه ";
            gridViewTextBoxColumn7.Name = "ForWhom";
            gridViewTextBoxColumn7.Width = 124;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "مبلغ";
            gridViewTextBoxColumn8.Name = "Price";
            gridViewTextBoxColumn8.Width = 111;
            this.checkGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.checkGridView.MasterTemplate.EnableFiltering = true;
            this.checkGridView.Name = "checkGridView";
            this.checkGridView.ReadOnly = true;
            this.checkGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkGridView.ShowGroupPanel = false;
            this.checkGridView.Size = new System.Drawing.Size(848, 269);
            this.checkGridView.TabIndex = 0;
            this.checkGridView.Text = "اطلاعات چک";
            this.checkGridView.ThemeName = "Office2010Blue";
            this.checkGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CheckDataGridView_CellDoubleClick);
            this.checkGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckdataGridView_KeyDown);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 311);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(848, 21);
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
            // newCheckButton
            // 
            this.newCheckButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newCheckButton.Location = new System.Drawing.Point(12, 278);
            this.newCheckButton.Name = "newCheckButton";
            this.newCheckButton.Size = new System.Drawing.Size(117, 23);
            this.newCheckButton.TabIndex = 12;
            this.newCheckButton.Text = "ثبت چک جدید";
            this.newCheckButton.ThemeName = "Office2010Blue";
            this.newCheckButton.Click += new System.EventHandler(this.newCheckButton_Click);
            // 
            // ShowCheckUI
            // 
            this.AcceptButton = this.newCheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(848, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newCheckButton);
            this.Controls.Add(this.checkGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowCheckUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات چک";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowCheckUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCheckButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView militaryStatusDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newCheckButton;
        private RadGridView checkGridView;
    }
}
