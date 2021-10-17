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

    public partial class ShowMaritalStatusUI : RadForm
    {
        MaritalStatusBLL _MaritalStatusBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowMaritalStatusUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newMaritalStatusButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _MaritalStatusBLL = new MaritalStatusBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            MaritalStatusBOL _MaritalStatusBOL = new MaritalStatusBOL();
            try
            {
                MaritalStatusBOL[] MaritalStatusRecords = _MaritalStatusBLL.Select(_MaritalStatusBOL);
                maritalStatusDataGridView.Rows.Clear();
                if (MaritalStatusRecords != null)
                    for (int index = 0; index < MaritalStatusRecords.Length; index++)
                        maritalStatusDataGridView.Rows.Add(MaritalStatusRecords[index].Id, MaritalStatusRecords[index].Title);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void MaritalStatusDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                byte? maritalStatusId = DataConvertor.DataConvertor.ConvertToByte(maritalStatusDataGridView.Rows[selectedIndex].Cells["Id"].Value);
                string maritalStatusTitle = (maritalStatusDataGridView.Rows[selectedIndex].Cells["Title"].Value == null ? null : maritalStatusDataGridView.Rows[selectedIndex].Cells["Title"].Value.ToString());
                MaritalStatusBOL _MaritalStatusBOL = new MaritalStatusBOL(maritalStatusId, maritalStatusTitle);
                new EditMaritalStatusUI(_MaritalStatusBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void MaritalStatusdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (maritalStatusDataGridView.Rows.Count != 0)
                    ItemSelected(maritalStatusDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newMaritalStatusButton_Click(object sender, EventArgs e)
        {
            new EditMaritalStatusUI().ShowDialog();
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

        private void ShowMaritalStatusUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
