using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowConstractionUI
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
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.militaryStatusDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newConstractionButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newConstractionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryStatusDataGridView
            // 
            this.militaryStatusDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.militaryStatusDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.militaryStatusDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.militaryStatusDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.militaryStatusDataGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.militaryStatusDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.militaryStatusDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // militaryStatusDataGridView
            // 
            this.militaryStatusDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.militaryStatusDataGridView.MasterTemplate.AllowColumnReorder = false;
            this.militaryStatusDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "شناسه وضعیت ساخت";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ConstractorId";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 202;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "نام کارفرما";
            gridViewTextBoxColumn2.Name = "ConstractorName";
            gridViewTextBoxColumn2.Width = 91;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "تاریخ شروع";
            gridViewTextBoxColumn3.Name = "StartDate";
            gridViewTextBoxColumn3.Width = 110;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "تاریخ تحویل";
            gridViewTextBoxColumn4.Name = "DeliveryDate";
            gridViewTextBoxColumn4.Width = 118;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "تعداد طبقه";
            gridViewTextBoxColumn5.Name = "FloorNumber";
            gridViewTextBoxColumn5.Width = 66;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "تعداد واحد";
            gridViewTextBoxColumn6.Name = "UnitNumber";
            gridViewTextBoxColumn6.Width = 66;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "نوع ملک";
            gridViewTextBoxColumn7.Name = "EstateType";
            gridViewTextBoxColumn7.Width = 77;
            this.militaryStatusDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.militaryStatusDataGridView.MasterTemplate.EnableFiltering = true;
            this.militaryStatusDataGridView.Name = "militaryStatusDataGridView";
            this.militaryStatusDataGridView.ReadOnly = true;
            this.militaryStatusDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.militaryStatusDataGridView.ShowGroupPanel = false;
            this.militaryStatusDataGridView.Size = new System.Drawing.Size(545, 269);
            this.militaryStatusDataGridView.TabIndex = 0;
            this.militaryStatusDataGridView.Text = "radGridView1";
            this.militaryStatusDataGridView.ThemeName = "Office2010Blue";
            this.militaryStatusDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ConstractionDataGridView_CellDoubleClick);
            this.militaryStatusDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConstractiondataGridView_KeyDown);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.noticeLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 311);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(545, 21);
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
            // newConstractionButton
            // 
            this.newConstractionButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newConstractionButton.Location = new System.Drawing.Point(12, 278);
            this.newConstractionButton.Name = "newConstractionButton";
            this.newConstractionButton.Size = new System.Drawing.Size(131, 23);
            this.newConstractionButton.TabIndex = 12;
            this.newConstractionButton.Text = "ثبت وضعیت ساخت جدید";
            this.newConstractionButton.ThemeName = "Office2010Blue";
            this.newConstractionButton.Click += new System.EventHandler(this.newConstractionButton_Click);
            // 
            // ShowConstractionUI
            // 
            this.AcceptButton = this.newConstractionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newConstractionButton);
            this.Controls.Add(this.militaryStatusDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowConstractionUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات وضعیت ساخت";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowConstractionUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newConstractionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView militaryStatusDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newConstractionButton;
    }
}
