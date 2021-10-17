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
    public partial class EditCoordinatingCouncilUI : Telerik.WinControls.UI.RadForm
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
        
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        CoordinatingCouncilBLL _CoordinatingCouncilBLL = new CoordinatingCouncilBLL();
        JobBOL _JobBOL;
        JobBLL _JobBLL = new JobBLL();
        public EditCoordinatingCouncilUI()
        {
            try
            {
                InitializeComponent();
                membershipDatePersianDateTimePicker.GeoDate = DateTime.Today;
                quitDatePersianDateTimePicker.GeoDate = DateTime.Today;
                SetResourceManager();
                _FormMode = FormMode.Insert;
                SetCoordinatingCouncilUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_CoordinatingCouncilBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public EditCoordinatingCouncilUI(CoordinatingCouncilBOL coordinatingCouncilBOL)
        {
            try
            {
                InitializeComponent();
                _CoordinatingCouncilBOL = coordinatingCouncilBOL;
                SetResourceManager();
                SetCoordinatingCouncilUpdateVisibility(true);
                LoadCoordinatingCouncil(_CoordinatingCouncilBOL);

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadCoordinatingCouncil(CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetCoordinatingCouncilUpdateVisibility(true);
                LoadCoordinatingCouncil();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
        private void EditCoordinatingCouncilUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }

        #region CoordinatingCouncil
        private void LoadCoordinatingCouncil()
        {
            try
            {
                idTextBox.Text = _CoordinatingCouncilBOL.Id.ToString();
                firstNameTextBox.Text = _CoordinatingCouncilBOL.FirstName;
                lastNameTextBox.Text = _CoordinatingCouncilBOL.LastName;
                //fatherNameTextBox.Text = _CoordinatingCouncilBOL.FatherName;
                //nationalCodeTextBox.Text = _CoordinatingCouncilBOL.NationalCode;
                if (_CoordinatingCouncilBOL.MembershipDate == null || _CoordinatingCouncilBOL.MembershipDate == DateTime.MinValue)
                    ((MaskedTextBox)membershipDatePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)membershipDatePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                    membershipDatePersianDateTimePicker.GeoDate = (DateTime)_CoordinatingCouncilBOL.QuitDate;

                if (_CoordinatingCouncilBOL.QuitDate == null || _CoordinatingCouncilBOL.MembershipDate == DateTime.MinValue)
                    ((MaskedTextBox)quitDatePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)quitDatePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                    quitDatePersianDateTimePicker.GeoDate = (DateTime)_CoordinatingCouncilBOL.QuitDate;
 
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
        private void SetCoordinatingCouncilUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
             //   nationalCodeTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = fatherNameTextBox.Text = idTextBox.Text = string.Empty;
                ((MaskedTextBox)membershipDatePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)membershipDatePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                
               
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
                        InsertCoordinatingCouncil();
                }
              
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertCoordinatingCouncil()
        {
            try
            {
                _CoordinatingCouncilBOL.Id = new CoordinatingCouncilBLL().SelectMaxId();
                _CoordinatingCouncilBOL.FirstName = firstNameTextBox.Text;
                _CoordinatingCouncilBOL.LastName = lastNameTextBox.Text;
                //_CoordinatingCouncilBOL.FatherName = " ";// fatherNameTextBox.Text;
                //_CoordinatingCouncilBOL.NationalCode = " ";//nationalCodeTextBox.Text;
                _CoordinatingCouncilBOL.QuitDate = DataConvertor.ConvertToDateTime(quitDatePersianDateTimePicker.GeoDate);
                _CoordinatingCouncilBOL.MembershipDate = DataConvertor.ConvertToDateTime(membershipDatePersianDateTimePicker.GeoDate);
                if (DialogResult.OK == _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel))
                {
                    _CoordinatingCouncilBLL.Insert(_CoordinatingCouncilBOL);
                    CloseForm();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
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
                    UpdateCoordinatingCouncil();
            }
        }
        private void UpdateCoordinatingCouncil()
        {
            try
            {
              //  _CoordinatingCouncilBOL.Id = new CoordinatingCouncilBLL().SelectMaxId();
                _CoordinatingCouncilBOL.FirstName = firstNameTextBox.Text;
                _CoordinatingCouncilBOL.LastName = lastNameTextBox.Text;
                //_CoordinatingCouncilBOL.FatherName = fatherNameTextBox.Text;
                //_CoordinatingCouncilBOL.NationalCode = nationalCodeTextBox.Text;
                _CoordinatingCouncilBOL.QuitDate = DataConvertor.ConvertToDateTime(quitDatePersianDateTimePicker.GeoDate);
                _CoordinatingCouncilBOL.MembershipDate = DataConvertor.ConvertToDateTime(membershipDatePersianDateTimePicker.GeoDate);
                _CoordinatingCouncilBLL.Update(_CoordinatingCouncilBOL);
                _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeleteCoordinatingCouncil();
        }
        private void DeleteCoordinatingCouncil()
        {
            try
            {
                _CoordinatingCouncilBLL.Delete(_CoordinatingCouncilBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
      
        private bool ValidateItem()
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                errorProvider.SetError(firstNameTextBox, "لطفا نام را وارد کنید");
                firstNameTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                errorProvider.SetError(lastNameTextBox, "لطفا نام خانوادگی را وارد کنید");
                lastNameTextBox.Focus();
                return false;
            }
            //if (string.IsNullOrEmpty(fatherNameTextBox.Text))
            //{
            //    errorProvider.SetError(fatherNameTextBox, "لطفا نام پدر را وارد کنید");
            //    fatherNameTextBox.Focus();
            //    return false;
            //}
         
            //if ((nationalCodeTextBox.Text.Length < 10) || (nationalCodeTextBox.Text.Length > 10))
            //{
            //    errorProvider.SetError(nationalCodeTextBox, "لطفا شماره ملی معتبر را وارد کنید");
            //    nationalCodeTextBox.Focus();
            //    return false;
            //}
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

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditCoordinatingCouncilUI_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

      

    }
}