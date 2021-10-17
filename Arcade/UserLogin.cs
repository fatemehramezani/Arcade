using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;

    public partial class UserLogin : Telerik.WinControls.UI.RadForm
    {
        UserBLL _UserBLL = new UserBLL();
        UserBOL _UserBOL = new UserBOL();
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        private ExceptionHandlerBOL _ExceptionHandlerBOL;

        public UserLogin()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
                LoginUser();
        }
        private bool ValidateItem()
        {
            bool isValid = true;
            if (userNameTextBox.Text == string.Empty)
            {
                reqErrorProvider.SetError(userNameTextBox, "*");
                isValid = false;
            }
            if (passwordTextBox.Text == string.Empty)
            {
                reqErrorProvider.SetError(passwordTextBox, "*");
                isValid = false;
            }
            return isValid;
        }
        private void LoginUser()
        {
            _UserBOL.UserName = userNameTextBox.Text.ToString();
            _UserBOL.Password = Encryptor.EncryptedString(passwordTextBox.Text.ToString());
            try
            {
                bool isValidUser = _UserBLL.CheckUserValid(_UserBOL);
                if (isValidUser)
                {

                    _UserBLL.LoadUserProfile(_UserBOL);
                    this.Visible = false;
                    new MainUI().ShowDialog();
                }
                else
                {
                    noticeLabel.Text = _ResourceManager.GetString("IncorrectUser");
                    passwordTextBox.Focus();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                SetExceptionMessage(_ExceptionHandlerBOL);
            }
        }
        private void SetExceptionMessage(ExceptionHandlerBOL _ExceptionHandlerBOL)
        {
            noticeLabel.Text = _ExceptionHandlerBOL.Title;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void textBoxes_Leave(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL == null)
                noticeLabel.Text = string.Empty;
        }
        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL == null)
                noticeLabel.Text = string.Empty;
        }
        private void setEnglishKeyboard_Enter(object sender, EventArgs e)
        {
            try
            {
                KeyboardControler.SetEnglishKeyboard();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                SetExceptionMessage(_ExceptionHandlerBOL);
            }
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

        private void databaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ConnectionStringUI("UserInterface.Properties.Settings.ConnectionString").ShowDialog();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                SetExceptionMessage(_ExceptionHandlerBOL);
            }
        }
    }
}