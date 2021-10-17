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

    public partial class ShowEventUI : RadForm
    {
        EventBLL _EventBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowEventUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newEventButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _EventBLL = new EventBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            EventBOL _EventBOL = new EventBOL();
            try
            {
                EventBOL[] EventRecords = _EventBLL.Select(_EventBOL);
                EventDataGridView.Rows.Clear();
                if (EventRecords != null)
                    for (int index = 0; index < EventRecords.Length; index++)
                        EventDataGridView.Rows.Add(EventRecords[index].Id, EventRecords[index].Title, EventRecords[index].Description, EventRecords[index].EstateIds);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EventDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                int? Id = DataConvertor.DataConvertor.ConvertToInt(EventDataGridView.Rows[selectedIndex].Cells["Id"].Value);
                string Title = DataConvertor.DataConvertor.ConvertToString(EventDataGridView.Rows[selectedIndex].Cells["Title"].Value );
                string Description = DataConvertor.DataConvertor.ConvertToString(EventDataGridView.Rows[selectedIndex].Cells["Description"].Value);
                string EstateIds = DataConvertor.DataConvertor.ConvertToString(EventDataGridView.Rows[selectedIndex].Cells["EstateIds"].Value);
                EventBOL _EventBOL = new EventBOL(Id, Title,Description,EstateIds);
                new EditEventUI(_EventBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EventdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (EventDataGridView.Rows.Count != 0)
                    ItemSelected(EventDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newEventButton_Click(object sender, EventArgs e)
        {
            new EditEventUI().ShowDialog();
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

        private void ShowEventUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
