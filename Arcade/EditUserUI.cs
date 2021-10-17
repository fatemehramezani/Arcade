using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using JntMsgBox;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    using ComplexDataType;
    using DataConvertor;
    using Telerik.WinControls.UI;

    public partial class EditUserUI : Telerik.WinControls.UI.RadForm
    {
        private UserBLL _UserBLL = new UserBLL();
        private UserBOL _UserBOL = new UserBOL();
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditUserUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewUser");
            userIdTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _UserBLL = new UserBLL();
            getMaxUserId();
        }
        public EditUserUI(UserBOL userBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            _UserBOL = userBOL;
            userIdTextBox.Focus();
            fillUserData(userBOL);
        }
        private void fillUserData(UserBOL _UserBOL)
        {
            userIdTextBox.Text = _UserBOL.UserId.ToString();
            userNameTextBox.Text = _UserBOL.UserName;
            descriptionTextBox.Text = _UserBOL.Description;
        }
        private void SetResourceManager()
        {
            try
            {
                UpdateText = _ResourceManager.GetString("Update");
                DeleteText = _ResourceManager.GetString("Delete");
                UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
                DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                radLabelElement2.ForeColor = Color.Red;
                radLabelElement2.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void getMaxUserId()
        {
            userIdTextBox.Text = _UserBLL.SelectMaxId().ToString(); ;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ValidateItem())
                //{
                    if (formMode == FormMode.Update)
                    {
                        SetResourceManager();
                        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                        DialogResult result = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.YesNo);
                        if (result == DialogResult.Yes && CheckPassword())
                        {
                            UpdateUser();
                            CloseForm();
                        }
                    }
                    else if (CheckPassword())
                    {
                        Insert();
                        CloseForm();
                    }
                //}
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                radLabelElement2.ForeColor = Color.Red;
                radLabelElement2.Text = _ExceptionHandlerBOL.Title;
            }
        }      
        private void Insert()
        {
            _UserBOL.UserId = DataConvertor.ConvertToShort(userIdTextBox.Text);
            _UserBOL.UserName = userNameTextBox.Text;
            _UserBOL.Description = descriptionTextBox.Text;
            _UserBOL.Password = Encryptor.EncryptedString(newPasswordTextBox.Text);
            _UserBLL.Insert(_UserBOL);
        }
        private bool CheckPassword()
        {
            if (newPasswordTextBox.Text == string.Empty || confirmPasswordTextBox.Text == string.Empty)
                throw new Exception("Password Can Not Be Null");
            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
                throw new Exception("New Password Is Not Valid");
            if (newPasswordTextBox.Text.Length < 5 && newPasswordTextBox.Text != string.Empty)
                throw new Exception("Password Length Is Not Valid");
            return true;
        }
        private void UpdateUser()
        {
            _UserBOL.UserName = userNameTextBox.Text;
            _UserBOL.Description = descriptionTextBox.Text;
            _UserBOL.Password = Encryptor.EncryptedString(newPasswordTextBox.Text);
            _UserBLL.Update(_UserBOL);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            GetDeleteConfirmtion();
        }
        private void GetDeleteConfirmtion()
        {
            try
            {
                SetResourceManager();
                JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                DialogResult result = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.YesNo);
                if (result == DialogResult.No)
                    return;
                short userId = Convert.ToInt16(userIdTextBox.Text);
                UserBOL _UserBOL = new UserBOL { UserId = userId };
                _UserBLL.Delete(_UserBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                radLabelElement2.ForeColor = Color.Red;
                radLabelElement2.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void radLabelElement2_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
        }
        private void setFarsiKeyboard_Enter(object sender, EventArgs e)
        {
            try
            {
                KeyboardControler.SetFarsiKeyboard();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                radLabelElement2.ForeColor = Color.Red;
                radLabelElement2.Text = _ExceptionHandlerBOL.Title;
            }
        }
    }
}