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

    public partial class ShowEstateTypeUI : RadForm
    {
        EstateTypeBLL _EstateTypeBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowEstateTypeUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newEstateTypeButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _EstateTypeBLL = new EstateTypeBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            EstateTypeBOL _EstateTypeBOL = new EstateTypeBOL();
            try
            {
                EstateTypeBOL[] EstateTypeRecords = _EstateTypeBLL.Select(_EstateTypeBOL);
                EstateTypeDataGridView.Rows.Clear();
                if (EstateTypeRecords != null)
                    for (int index = 0; index < EstateTypeRecords.Length; index++)
                        EstateTypeDataGridView.Rows.Add(EstateTypeRecords[index].Id, EstateTypeRecords[index].Title);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EstateTypeDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                byte? EstateTypeId = DataConvertor.DataConvertor.ConvertToByte(EstateTypeDataGridView.Rows[selectedIndex].Cells["EstateTypeId"].Value);
                string EstateTypeTitle = DataConvertor.DataConvertor.ConvertToString(EstateTypeDataGridView.Rows[selectedIndex].Cells["EstateTypeTitle"].Value);
                EstateTypeBOL _EstateTypeBOL = new EstateTypeBOL(EstateTypeId, EstateTypeTitle);
                new EditEstateTypeUI(_EstateTypeBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EstateTypedataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (EstateTypeDataGridView.Rows.Count != 0)
                    ItemSelected(EstateTypeDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newEstateTypeButton_Click(object sender, EventArgs e)
        {
            new EditEstateTypeUI().ShowDialog();
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
        private void ShowEstateTypeUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
