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
    using ComplexDataType;
    using JntMsgBox;
    using System.Reflection;
    using System.Resources;
    using Telerik.WinControls.UI;

    public partial class EditRoleTypeUI : RadForm
    {
        private RoleTypeBLL _RoleTypeBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditRoleTypeUI()
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            titleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _RoleTypeBLL = new RoleTypeBLL();
            getMaxId();
        }
        public EditRoleTypeUI(RoleTypeBOL _RoleTypeBOL)
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            formMode = FormMode.Update;
            titleTextBox.Focus();
            _RoleTypeBLL = new RoleTypeBLL();
            fillTextBoxes(_RoleTypeBOL);
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
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void getMaxId()
        {
            idTextBox.Text = _RoleTypeBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(RoleTypeBOL _RoleTypeBOL)
        {
            idTextBox.Text = _RoleTypeBOL.Id.ToString();
            titleTextBox.Text = _RoleTypeBOL.Title;
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
            if (ValidateItem())
                GetEditConfirmtion();
        }
        private void GetEditConfirmtion()
        {
            try
            {
                if (formMode == FormMode.Update)
                {
                    SetResourceManager();
                    JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                    DialogResult result = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.YesNo);
                    if (result == DialogResult.No)
                        return;
                }
                Edit();
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            finally { }
        }
        private void Edit()
        {
            byte? roleTypeId;
            try
            {
                roleTypeId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string roleTypeTitle = titleTextBox.Text;
            RoleTypeBOL _RoleTypeBOL = new RoleTypeBOL(roleTypeId, roleTypeTitle);
            if (formMode == FormMode.Insert)
                _RoleTypeBLL.Insert(_RoleTypeBOL);
            else
                _RoleTypeBLL.Update(_RoleTypeBOL);
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
                byte? roleTypeId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
                RoleTypeBOL _RoleTypeBOL = new RoleTypeBOL(roleTypeId);
                _RoleTypeBLL.Delete(_RoleTypeBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            finally { }
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
            noticeLabel.Text = string.Empty;
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
        private Boolean ValidateItem()
        {
            errorProvider.Clear();
            if (titleTextBox.Text == null || titleTextBox.Text == string.Empty)
            {
                errorProvider.SetError(titleTextBox, "لطفا عنوان را وارد کنید");
                titleTextBox.Focus();
                return false;
            }
            return true;
        }
        private void EditRoleTypeUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
    }
}
