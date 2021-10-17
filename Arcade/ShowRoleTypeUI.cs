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

    public partial class ShowRoleTypeUI : RadForm
    {
        RoleTypeBLL _RoleTypeBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowRoleTypeUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newRoleTypeButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _RoleTypeBLL = new RoleTypeBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            RoleTypeBOL _RoleTypeBOL = new RoleTypeBOL();
            try
            {
                RoleTypeBOL[] RoleTypeRecords = _RoleTypeBLL.Select(_RoleTypeBOL);
                roleTypeDataGridView.Rows.Clear();
                if (RoleTypeRecords != null)
                    for (int index = 0; index < RoleTypeRecords.Length; index++)
                        roleTypeDataGridView.Rows.Add(RoleTypeRecords[index].Id, RoleTypeRecords[index].Title);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void RoleTypeDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                byte? roleTypeId = DataConvertor.DataConvertor.ConvertToByte(roleTypeDataGridView.Rows[selectedIndex].Cells["roleTypeId"].Value);
                string roleTypeTitle = DataConvertor.DataConvertor.ConvertToString(roleTypeDataGridView.Rows[selectedIndex].Cells["roleTypeTitle"].Value);
                RoleTypeBOL _RoleTypeBOL = new RoleTypeBOL(roleTypeId, roleTypeTitle);
                new EditRoleTypeUI(_RoleTypeBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void RoleTypedataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (roleTypeDataGridView.Rows.Count != 0)
                    ItemSelected(roleTypeDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newRoleTypeButton_Click(object sender, EventArgs e)
        {
            new EditRoleTypeUI().ShowDialog();
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
        private void ShowRoleTypeUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
