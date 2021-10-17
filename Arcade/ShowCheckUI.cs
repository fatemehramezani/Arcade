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

    public partial class ShowCheckUI : RadForm
    {
        CheckBLL _CheckBLL;
        CheckBOL _CheckBOL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowCheckUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newCheckButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _CheckBLL = new CheckBLL();
            FillCheckGridView();
        }
        private void FillCheckGridView()
        {
            checkGridView.Rows.Clear();
            try
            {
                _CheckBOL = new CheckBOL();
                CheckBOL[] checkBOLs = _CheckBLL.Select(_CheckBOL);
                if (checkBOLs != null)
                    for (int index = 0; index < checkBOLs.Length; index++)
                        checkGridView.Rows.Add(checkBOLs[index].Id, checkBOLs[index].Number, checkBOLs[index].AccountNumber, checkBOLs[index].Date, checkBOLs[index].AccountName,checkBOLs[index].BankName,checkBOLs[index].ForWhom,checkBOLs[index].Price);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CheckDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                int? Id = DataConvertor.DataConvertor.ConvertToInt(checkGridView.Rows[selectedIndex].Cells["Id"].Value);
                string Number = DataConvertor.DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["Number"].Value);
                string AccountNumber = DataConvertor.DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["AccountNumber"].Value);
                DateTime? Date= DataConvertor.DataConvertor.ConvertToDateTime(checkGridView.Rows[selectedIndex].Cells["Date"].Value);
                string AccountName = DataConvertor.DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["AccountName"].Value);
                decimal? Price = DataConvertor.DataConvertor.ConvertToDecimal(checkGridView.Rows[selectedIndex].Cells["Price"].Value);
                string BankName = DataConvertor.DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["BankName"].Value);
                string ForWhom = DataConvertor.DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["ForWhom"].Value);
                CheckBOL _CheckBOL = new CheckBOL(Id, Number, AccountNumber, Date, AccountName,Price,BankName,ForWhom);
                new EditCheckUI(_CheckBOL).ShowDialog();
                FillCheckGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CheckdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (checkGridView.Rows.Count != 0)
                    ItemSelected(checkGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newCheckButton_Click(object sender, EventArgs e)
        {
            new EditCheckUI().ShowDialog();
            FillCheckGridView();
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
        private void ShowCheckUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
