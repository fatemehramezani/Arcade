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

    public partial class EditMilitaryStatusUI : RadForm
    {
        private MilitaryStatusBLL _MilitaryStatusBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;



        
        public EditMilitaryStatusUI()
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            titleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _MilitaryStatusBLL = new MilitaryStatusBLL();
            getMaxId();
        }
        public EditMilitaryStatusUI(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            InitializeComponent();
            titleTextBox.Enter += setFarsiKeyboard_Enter;
            formMode = FormMode.Update;
            titleTextBox.Focus();
            _MilitaryStatusBLL = new MilitaryStatusBLL();
            fillTextBoxes(_MilitaryStatusBOL);
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
            idTextBox.Text = _MilitaryStatusBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            idTextBox.Text = _MilitaryStatusBOL.Id.ToString();
            titleTextBox.Text = _MilitaryStatusBOL.Title;
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
            byte? militaryStatusId;
            try
            {
                militaryStatusId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string militaryStatusTitle = titleTextBox.Text;
            MilitaryStatusBOL _MilitaryStatusBOL = new MilitaryStatusBOL(militaryStatusId, militaryStatusTitle);
            if (formMode == FormMode.Insert)
                _MilitaryStatusBLL.Insert(_MilitaryStatusBOL);
            else
                _MilitaryStatusBLL.Update(_MilitaryStatusBOL);
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
                byte? militaryStatusId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
                MilitaryStatusBOL _MilitaryStatusBOL = new MilitaryStatusBOL(militaryStatusId);
                _MilitaryStatusBLL.Delete(_MilitaryStatusBOL);
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
        private void EditMilitaryStatusUI_KeyDown(object sender, KeyEventArgs e)
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
