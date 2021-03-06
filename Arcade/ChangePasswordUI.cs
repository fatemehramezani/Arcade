using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    public partial class ChangePasswordUI : Telerik.WinControls.UI.RadForm
    {
        private UserBLL _UserBLL = new UserBLL();
        private UserBOL _UserBOL = new UserBOL();
        private ResourceManager resourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        private ExceptionHandlerBOL _ExceptionHandlerBOL;

        public ChangePasswordUI()
        {
            InitializeComponent();            
            oldPasswordTextBox.Focus();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePassword();
        }
        private void changePassword()
        {
            try
            {
                if (oldPasswordTextBox.Text != null && oldPasswordTextBox.Text != string.Empty)
                {
                    if (newPasswordTextBox.Text == conFirmNewPasswordTextBox.Text)
                    {
                        if (newPasswordTextBox.Text == null || newPasswordTextBox.Text == string.Empty)
                        {
                            newPasswordTextBox.Focus();
                            noticeLabel.Text = resourceManager.GetString("PasswordCanNotBeNull");
                            return;
                        }
                        if (newPasswordTextBox.Text.Length < 5)
                        {
                            newPasswordTextBox.Focus();
                            noticeLabel.Text = resourceManager.GetString("InvalidLength");
                            return;
                        }
                        _UserBOL.UserId = UserProfile.UserID;
                        _UserBOL.UserName = UserProfile.UserName;
                        _UserBOL.NewPassword = Encryptor.EncryptedString(newPasswordTextBox.Text.ToString());
                        _UserBOL.Password = Encryptor.EncryptedString(oldPasswordTextBox.Text.ToString());
                        bool isUserValid = _UserBLL.CheckUserValid(_UserBOL);
                        if (isUserValid == true)
                        {
                            _UserBLL.ChangePassword(_UserBOL);
                            MessageBox.Show(resourceManager.GetString("PasswordChanged"), resourceManager.GetString("PasswordChangedTitle"));
                            this.closeForm();
                        }
                        else
                        {
                            oldPasswordTextBox.Focus();
                            noticeLabel.Text = resourceManager.GetString("IncorrectOldPassword");
                        }
                    }
                    else
                    {
                        newPasswordTextBox.Focus();
                        noticeLabel.Text = resourceManager.GetString("IncorrectNewPassword");
                    }
                }
                else
                {
                    oldPasswordTextBox.Focus();
                    noticeLabel.Text = resourceManager.GetString("OldPasswordCanNotBeNull");
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
            noticeLabel.ForeColor = Color.Red;
            noticeLabel.Text = _ExceptionHandlerBOL.Title;
        }
        private void ChangePasswordUI_Load(object sender, EventArgs e)
        {
            userNameShowLabel.Text = UserProfile.UserName;
        }
        private void ChangePasswordUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
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
        private void noticeLabel_Click(object sender, EventArgs e)
        {

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
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
    }
}