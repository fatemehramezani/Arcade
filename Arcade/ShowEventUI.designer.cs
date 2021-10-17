using Telerik.WinControls.UI;
namespace UserInterface
{
    partial class ShowEventUI
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
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.EventDataGridView = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.noticeLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.newEventButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEventButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.EventDataGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "شناسه هزینه";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 202;
            gridViewTextBoxColumn2.HeaderText = "عنوان";
            gridViewTextBoxColumn2.Name = "title";
            gridViewTextBoxColumn2.Width = 402;
            gridViewTextBoxColumn3.HeaderText = "توضیحات";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 49;
            gridViewTextBoxColumn4.HeaderText = "column2";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "EstateIds";
            gridViewTextBoxColumn4.Width = 44;
            this.EventDataGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.EventDataGridView.MasterTemplate.EnableFiltering = true;
            this.EventDataGridView.MasterTemplate.EnableGrouping = false;
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.ReadOnly = true;
            this.EventDataGridView.ShowGroupPanel = false;
            this.EventDataGridView.Size = new System.Drawing.Size(424, 269);
            this.EventDataGridView.TabIndex = 0;
            this.EventDataGridView.Text = "radGridView1";
            this.EventDataGridView.ThemeName = "Office2010Blue";
            this.EventDataGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.EventDataGridView_CellDoubleClick);
            this.EventDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventdataGridView_KeyDown);
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
            // newEventButton
            // 
            this.newEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newEventButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newEventButton.Location = new System.Drawing.Point(12, 278);
            this.newEventButton.Name = "newEventButton";
            this.newEventButton.Size = new System.Drawing.Size(117, 23);
            this.newEventButton.TabIndex = 12;
            this.newEventButton.Text = "ثبت هزینه جدید";
            this.newEventButton.ThemeName = "Office2010Blue";
            this.newEventButton.Click += new System.EventHandler(this.newEventButton_Click);
            // 
            // ShowEventUI
            // 
            this.AcceptButton = this.newEventButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.newEventButton);
            this.Controls.Add(this.EventDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowEventUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات هزینه ها";
            this.ThemeName = "Office2010Blue";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowEventUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEventButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private RadGridView EventDataGridView;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement noticeLabel;
        private RadButton newEventButton;
    }
}
