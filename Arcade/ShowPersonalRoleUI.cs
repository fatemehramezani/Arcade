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

    public partial class ShowPersonalRoleUI : RadForm
    {
        PersonalRoleBLL _PersonalRoleBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowPersonalRoleUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newPersonalRoleButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _PersonalRoleBLL = new PersonalRoleBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            PersonalRoleBOL _PersonalRoleBOL = new PersonalRoleBOL();
            try
            {
                PersonalRoleBOL[] PersonalRoleRecords = _PersonalRoleBLL.Select(_PersonalRoleBOL);
                PersonalRoleDataGridView.Rows.Clear();
                if (PersonalRoleRecords != null)
                    for (int index = 0; index < PersonalRoleRecords.Length; index++)
                        PersonalRoleDataGridView.Rows.Add(PersonalRoleRecords[index].Id, PersonalRoleRecords[index].RoleTypeId, PersonalRoleRecords[index].RoleTypeTitle, PersonalRoleRecords[index].PersonalInfoId, PersonalRoleRecords[index].FirstName, PersonalRoleRecords[index].LastName);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void PersonalRoleDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                //noticeLabel.Text = string.Empty;
                //if (e.RowIndex != -1 && _AccessMode == AccessMode.Complete)
                    ItemSelected(e.RowIndex);
                //if (_AccessMode != AccessMode.Complete)
                //{
                //    _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                //    noticeLabel.ForeColor = Color.Red;
                //    noticeLabel.Text = _ExceptionHandlerBOL.Title;
                //}
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
                byte? Id = DataConvertor.DataConvertor.ConvertToByte(PersonalRoleDataGridView.Rows[selectedIndex].Cells["Id"].Value);
                byte? RoleTypeId = DataConvertor.DataConvertor.ConvertToByte(PersonalRoleDataGridView.Rows[selectedIndex].Cells["RoleTypeId"].Value);
                string RoleTypeTitle = DataConvertor.DataConvertor.ConvertToString(PersonalRoleDataGridView.Rows[selectedIndex].Cells["RoleTypeTitle"].Value);
                int? PersonalInfoId = DataConvertor.DataConvertor.ConvertToInt(PersonalRoleDataGridView.Rows[selectedIndex].Cells["PersonalInfoId"].Value);
                string FirstName = DataConvertor.DataConvertor.ConvertToString(PersonalRoleDataGridView.Rows[selectedIndex].Cells["FirstName"].Value);
                string LastName = DataConvertor.DataConvertor.ConvertToString(PersonalRoleDataGridView.Rows[selectedIndex].Cells["LastName"].Value);

                PersonalRoleBOL _PersonalRoleBOL = new PersonalRoleBOL(Id,RoleTypeId,RoleTypeTitle,PersonalInfoId,FirstName,LastName);
                new EditPersonalRoleUI(_PersonalRoleBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void PersonalRoledataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (PersonalRoleDataGridView.Rows.Count != 0)
                    ItemSelected(PersonalRoleDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newPersonalRoleButton_Click(object sender, EventArgs e)
        {
            new EditPersonalRoleUI().ShowDialog();
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

        private void ShowPersonalRoleUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
