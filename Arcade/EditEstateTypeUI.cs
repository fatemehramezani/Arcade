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

    public partial class EditEstateTypeUI : RadForm
    {
        private EstateTypeBLL _EstateTypeBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditEstateTypeUI()
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            titleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _EstateTypeBLL = new EstateTypeBLL();
            getMaxId();
        }
        public EditEstateTypeUI(EstateTypeBOL _EstateTypeBOL)
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            formMode = FormMode.Update;
            titleTextBox.Focus();
            _EstateTypeBLL = new EstateTypeBLL();
            fillTextBoxes(_EstateTypeBOL);
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
            idTextBox.Text = _EstateTypeBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(EstateTypeBOL _EstateTypeBOL)
        {
            idTextBox.Text = _EstateTypeBOL.Id.ToString();
            titleTextBox.Text = _EstateTypeBOL.Title;
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
            byte? EstateTypeId;
            try
            {
                EstateTypeId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string EstateTypeTitle = titleTextBox.Text;
            EstateTypeBOL _EstateTypeBOL = new EstateTypeBOL(EstateTypeId, EstateTypeTitle);
            if (formMode == FormMode.Insert)
                _EstateTypeBLL.Insert(_EstateTypeBOL);
            else
                _EstateTypeBLL.Update(_EstateTypeBOL);
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
                byte? EstateTypeId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
                EstateTypeBOL _EstateTypeBOL = new EstateTypeBOL(EstateTypeId);
                _EstateTypeBLL.Delete(_EstateTypeBOL);
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
        private void EditEstateTypeUI_KeyDown(object sender, KeyEventArgs e)
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
