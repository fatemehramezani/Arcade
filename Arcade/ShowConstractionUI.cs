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

    public partial class ShowConstractionUI : RadForm
    {
        ConstractionBLL _ConstractionBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowConstractionUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newConstractionButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _ConstractionBLL = new ConstractionBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            ConstractionBOL _ConstractionBOL = new ConstractionBOL();
            try
            {
                ConstractionBOL[] ConstractionRecords = _ConstractionBLL.Select(_ConstractionBOL);
                militaryStatusDataGridView.Rows.Clear();
                if (ConstractionRecords != null)
                    for (int index = 0; index < ConstractionRecords.Length; index++)
                    {
                        militaryStatusDataGridView.Rows.Add(ConstractionRecords[index].Id, ConstractionRecords[index].ConstractorName, ConstractionRecords[index].StartDate, ConstractionRecords[index].DeliveryDate, ConstractionRecords[index].EstateFloor, ConstractionRecords[index].UnitNumber);
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ConstractionDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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

                int? ConstractionId = DataConvertor.DataConvertor.ConvertToInt(militaryStatusDataGridView.Rows[selectedIndex].Cells["ConstractorId"].Value);
                DateTime? ConstractionStartDate = DataConvertor.DataConvertor.ConvertToDateTime(militaryStatusDataGridView.Rows[selectedIndex].Cells["StartDate"].Value);
                DateTime? ConstractionDeliveryDate = DataConvertor.DataConvertor.ConvertToDateTime(militaryStatusDataGridView.Rows[selectedIndex].Cells["DeliveryDate"].Value);
                int? ConstractionUnitNumber = DataConvertor.DataConvertor.ConvertToInt(militaryStatusDataGridView.Rows[selectedIndex].Cells["UnitNumber"].Value);
                //int? EstateId = DataConvertor.DataConvertor.ConvertToInt(militaryStatusDataGridView.Rows[selectedIndex].Cells["ConstractorEstateId"]);
                //byte? EstateTypeId = DataConvertor.DataConvertor.ConvertToByte(militaryStatusDataGridView.Rows[selectedIndex].Cells["ConstractorEstateTypeId"]);
                int? ConstractionFloor = DataConvertor.DataConvertor.ConvertToInt(militaryStatusDataGridView.Rows[selectedIndex].Cells["FloorNumber"].Value);
                string ConstractionConstractorName = DataConvertor.DataConvertor.ConvertToString(militaryStatusDataGridView.Rows[selectedIndex].Cells["ConstractorName"].Value);
                //string EstateTypeTitle = DataConvertor.DataConvertor.ConvertToString(militaryStatusDataGridView.Rows[selectedIndex].Cells["ConstractorIdEstateTypeTitle"]);

                ConstractionBOL _ConstractionBOL = new ConstractionBOL(ConstractionId,ConstractionStartDate,ConstractionDeliveryDate,ConstractionUnitNumber,null,null,ConstractionFloor,ConstractionConstractorName,null);
                
                new EditConstractionUI(_ConstractionBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ConstractiondataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (militaryStatusDataGridView.Rows.Count != 0)
                    ItemSelected(militaryStatusDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newConstractionButton_Click(object sender, EventArgs e)
        {
            new EditConstractionUI().ShowDialog();
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
        private void ShowConstractionUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
