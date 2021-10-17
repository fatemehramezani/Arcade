using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    using Telerik.WinControls.UI;

    public partial class ShowJobUI : RadForm
    {
        JobBLL _JobBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowJobUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newJobButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _JobBLL = new JobBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            JobBOL _JobBOL = new JobBOL();
            try
            {
                JobBOL[] JobRecords = _JobBLL.Select(_JobBOL);
                JobDataGridView.Rows.Clear();
                if (JobRecords != null)
                    for (int index = 0; index < JobRecords.Length; index++)
                        JobDataGridView.Rows.Add(JobRecords[index].Id, JobRecords[index].Title);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void JobDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                if (e.RowIndex != -1 && _AccessMode == AccessMode.Complete)
                    ItemSelected(e.RowIndex);
                if (_AccessMode != AccessMode.Complete)
                {
                    _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                    noticeLabel.ForeColor = Color.Red;
                    noticeLabel.Text = _ExceptionHandlerBOL.Title;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ItemSelected(int selectedIndex)
        {
            try
            {
                byte? Id = DataConvertor.DataConvertor.ConvertToByte(JobDataGridView.Rows[selectedIndex].Cells["Id"].Value);
                string Title = DataConvertor.DataConvertor.ConvertToString(JobDataGridView.Rows[selectedIndex].Cells["Title"].Value );

                JobBOL _JobBOL = new JobBOL(Id, Title);
                new EditJobUI(_JobBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void JobdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (JobDataGridView.Rows.Count != 0)
                    ItemSelected(JobDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newJobButton_Click(object sender, EventArgs e)
        {
            new EditJobUI().ShowDialog();
            fillDataGridView();
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                noticeLabel.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }

        private void ShowJobUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
