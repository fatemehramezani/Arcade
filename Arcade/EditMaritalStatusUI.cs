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

    public partial class EditMaritalStatusUI : RadForm
    {
        private MaritalStatusBLL _MaritalStatusBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditMaritalStatusUI()
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            titleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _MaritalStatusBLL = new MaritalStatusBLL();
            getMaxId();
        }
        public EditMaritalStatusUI(MaritalStatusBOL _MaritalStatusBOL)
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            formMode = FormMode.Update;
            titleTextBox.Focus();
            _MaritalStatusBLL = new MaritalStatusBLL();
            fillTextBoxes(_MaritalStatusBOL);
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
            idTextBox.Text = _MaritalStatusBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(MaritalStatusBOL _MaritalStatusBOL)
        {
            idTextBox.Text = _MaritalStatusBOL.Id.ToString();
            titleTextBox.Text = _MaritalStatusBOL.Title;
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
            byte? maritalStatusId;
            try
            {
                maritalStatusId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string maritalStatusTitle = titleTextBox.Text;
            MaritalStatusBOL _MaritalStatusBOL = new MaritalStatusBOL(maritalStatusId, maritalStatusTitle);
            if (formMode == FormMode.Insert)
                _MaritalStatusBLL.Insert(_MaritalStatusBOL);
            else
                _MaritalStatusBLL.Update(_MaritalStatusBOL);
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
                byte? maritalStatusId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
                MaritalStatusBOL _MaritalStatusBOL = new MaritalStatusBOL(maritalStatusId);
                _MaritalStatusBLL.Delete(_MaritalStatusBOL);
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
        private void EditMaritalStatusUI_KeyDown(object sender, KeyEventArgs e)
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
