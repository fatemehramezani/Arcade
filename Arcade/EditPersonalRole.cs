using System;
using System.Drawing;
using System.Windows.Forms;
using ComplexDataType;
using System.Resources;
using BusinessObjectLayer;
using System.Reflection;
using BusinessLogicLayer;
using JntMsgBox;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Security.AccessControl;

namespace UserInterface
{
    using DataConvertor;
    using Telerik.WinControls.UI;
    using BusinessObjectLayer;
    public partial class EditPersonalRoleUI : Telerik.WinControls.UI.RadForm
    {
        FormMode _FormMode = FormMode.Insert;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        string CancelText;
        string UpdateText;
        string InsertText;
        string DeleteText;
        string AccessText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        string AccessConfirmation;
        string Successed;
        public int? personalInfoId;

        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        PersonalRoleBOL _PersonalRoleBOL = new PersonalRoleBOL();
        PersonalRoleBLL _PersonalRoleBLL = new PersonalRoleBLL();
        JobBOL _JobBOL;

        JobBLL _JobBLL = new JobBLL();
        public EditPersonalRoleUI()
        {
            try
            {
                InitializeComponent();
                personalInfoId =_PersonalRoleBOL.PersonalInfoId;
                _FormMode = FormMode.Insert;
                ComboBoxBind();
                SetPersonalRoleUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_PersonalRoleBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public EditPersonalRoleUI(PersonalRoleBOL personalRoleBOL)
        {
            try
            {
                InitializeComponent();
                _PersonalRoleBOL = personalRoleBOL;
                ComboBoxBind();
                SetPersonalRoleUpdateVisibility(true);
                LoadPersonalRole(_PersonalRoleBOL);

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadPersonalRole(PersonalRoleBOL _PersonalRoleBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetPersonalRoleUpdateVisibility(true);
                LoadPersonalRole();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ComboBoxBind()
        {
            try
            {
                SetResourceManager();
                RoleTypeComboBoxBind();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void RoleTypeComboBoxBind()
        {
            try
            {
                RoleTypeBOL[] RoleTypeRecords = new RoleTypeBLL().SelectComboBox();
                roleTypeComboBox.Items.Clear();
                if (RoleTypeRecords != null)
                    for (int index = 0; index < RoleTypeRecords.Length; index++)
                    {
                        roleTypeComboBox.Items.Add(new RadListDataItem(RoleTypeRecords[index].Title, RoleTypeRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            roleTypeComboBox.SelectedIndex = 0;
        }
        private void SetResourceManager()
        {
            CancelText = _ResourceManager.GetString("Cancel");
            UpdateText = _ResourceManager.GetString("Update");
            InsertText = _ResourceManager.GetString("Insert");
            DeleteText = _ResourceManager.GetString("Delete");
            AccessText = _ResourceManager.GetString("Access");
            UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
            DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
            AccessConfirmation = _ResourceManager.GetString("AccessConfirmation");
            Successed = _ResourceManager.GetString("Successed");
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
        private void EditPersonalRoleUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }



        #region PersonalRole
        private void LoadPersonalRole()
        {
            try
            {
                idTextBox.Text = _PersonalRoleBOL.Id.ToString();
                nameTextBox.Text = string.Format("{0} {1}", _PersonalRoleBOL.FirstName, _PersonalRoleBOL.LastName);
                ListItem _RoleTypeListItem = new ListItem(_PersonalRoleBOL.RoleTypeId, _PersonalRoleBOL.RoleTypeTitle);
                roleTypeComboBox.SelectedIndex = ComboBoxSelectedIndex(roleTypeComboBox, _RoleTypeListItem);

              
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private int ComboBoxSelectedIndex(RadDropDownList _ComboBox, ListItem _ListItem)
        {
            for (int index = 0; index < _ComboBox.Items.Count; index++)
            {
                if (DataConvertor.ConvertToShort(((RadListDataItem)_ComboBox.Items[index]).Value) == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        private void SetPersonalRoleUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
                if (visibility)
                {
                    insertCancelButton.Text = CancelText;
                    _FormMode = FormMode.Update;
                }
                else
                {
                    insertCancelButton.Text = InsertText;
                    _FormMode = FormMode.Insert;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void insertCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_FormMode == FormMode.Insert)
                {
                    if (ValidateItem())
                        InsertPersonalRole();
                }
             
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertPersonalRole()
        {
            try
            {
                _PersonalRoleBOL.Id = new PersonalRoleBLL().SelectMaxId();
                _PersonalRoleBOL.PersonalInfoId = personalInfoId;
                _PersonalRoleBOL.RoleTypeId = DataConvertor.ConvertToByte(roleTypeComboBox.SelectedValue);
                _PersonalRoleBLL.Insert(_PersonalRoleBOL);
                _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }//////////?
        private void CloseForm()
        {
            this.Close();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
                if (_DialogResult == DialogResult.OK)
                    UpdatePersonalRole();
            }
        }
        private void UpdatePersonalRole()
        {

            try
            {
              //  _PersonalRoleBOL.Id = new PersonalRoleBLL().SelectMaxId();
                _PersonalRoleBOL.PersonalInfoId = personalInfoId;
                _PersonalRoleBOL.RoleTypeId = DataConvertor.ConvertToByte(roleTypeComboBox.SelectedValue);
                _PersonalRoleBLL.Update(_PersonalRoleBOL);
                _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;

            }
        }///////////////؟
            
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeletePersonalRole();
        }
        private void DeletePersonalRole()
        {
            try
            {
                _PersonalRoleBLL.Delete(_PersonalRoleBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void sellerLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                PersonalInfoLOV _PersonalInfoLOV = new PersonalInfoLOV();
                if (_PersonalInfoLOV.ShowDialog() == DialogResult.OK)
                {
                    if (_PersonalInfoLOV._PersonalInfoBOL.Id > 0)
                    {
                        nameTextBox.Text = string.Format("{0} {1}", _PersonalInfoLOV._PersonalInfoBOL.FirstName, _PersonalInfoLOV._PersonalInfoBOL.LastName);
                        personalInfoId = _PersonalInfoLOV._PersonalInfoBOL.Id;
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private bool ValidateItem()
        {
            //errorProvider.Clear();
            //if (string.IsNullOrEmpty(personalNameTextBox.Text))
            //{
            //    errorProvider.SetError(personalNameTextBox, "لطفا نام ونام خانوداگی را وارد کنید");
            //    personalNameTextBox.Focus();
            //    return false;
            //}
            ////if (string.IsNullOrEmpty(landlordNameTextBox.Text))
            ////{
            ////    errorProvider.SetError(landlordNameTextBox, "لطفا نام ونام خانوداگی را وارد کنید");
            ////    landlordNameTextBox.Focus();
            ////    return false;
            ////}
            ////if (string.IsNullOrEmpty(prepaymentTextBox.Text))
            ////{
            ////    errorProvider.SetError(prepaymentTextBox, "لطفا پیش پرداخت را وارد کنید");
            ////    prepaymentTextBox.Focus();
            ////    return false;
            ////}
           
            return true;
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        #endregion

      

    }
}