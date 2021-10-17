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

    public partial class ShowMilitaryStatusUI : RadForm
    {
        MilitaryStatusBLL _MilitaryStatusBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowMilitaryStatusUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newMilitaryStatusButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _MilitaryStatusBLL = new MilitaryStatusBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            MilitaryStatusBOL _MilitaryStatusBOL = new MilitaryStatusBOL();
            try
            {
                MilitaryStatusBOL[] MilitaryStatusRecords = _MilitaryStatusBLL.Select(_MilitaryStatusBOL);
                militaryStatusDataGridView.Rows.Clear();
                if (MilitaryStatusRecords != null)
                    for (int index = 0; index < MilitaryStatusRecords.Length; index++)
                        militaryStatusDataGridView.Rows.Add(MilitaryStatusRecords[index].Id, MilitaryStatusRecords[index].Title);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void MilitaryStatusDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                byte? militaryStatusId = DataConvertor.DataConvertor.ConvertToByte(militaryStatusDataGridView.Rows[selectedIndex].Cells["militaryStatusId"].Value);
                string militaryStatusTitle = DataConvertor.DataConvertor.ConvertToString(militaryStatusDataGridView.Rows[selectedIndex].Cells["militaryStatusTitle"].Value);
                MilitaryStatusBOL _MilitaryStatusBOL = new MilitaryStatusBOL(militaryStatusId, militaryStatusTitle);
                new EditMilitaryStatusUI(_MilitaryStatusBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void MilitaryStatusdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (militaryStatusDataGridView.Rows.Count != 0)
                    ItemSelected(militaryStatusDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newMilitaryStatusButton_Click(object sender, EventArgs e)
        {
            new EditMilitaryStatusUI().ShowDialog();
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
        private void ShowMilitaryStatusUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
