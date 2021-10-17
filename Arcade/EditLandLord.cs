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
    public partial class EditLandLordUI : Telerik.WinControls.UI.RadForm
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
        public int? purchaseLetterId;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        LandLordBOL _LandLordBOL = new LandLordBOL();
        LandLordBLL _LandLordBLL = new LandLordBLL();
        PersonalInfoBLL _PersonalInfoBLL = new PersonalInfoBLL();
        PersonalInfoBOL _PersonalInfoBOL = new PersonalInfoBOL();
        public EditLandLordUI()
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                _FormMode = FormMode.Insert;
                SetLandLordUpdateVisibility(false);
               idTextBox.Text = DataConvertor.ConvertToString(_LandLordBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public EditLandLordUI(LandLordBOL landLordBOL)
        {
            try
            {
                InitializeComponent();
                _LandLordBOL = landLordBOL;
                ComboBoxBind();
                SetLandLordUpdateVisibility(true);
                LoadLandLord(_LandLordBOL);
                personalInfoId = _LandLordBOL.PersonalInfoId;

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadLandLord(LandLordBOL _LandLordBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetLandLordUpdateVisibility(true);
                LoadLandLord();
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
                EstateComboBoxBind();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EstateComboBoxBind()
        {
            try
            {
                EstateBOL[] EstateRecords = new EstateBLL().SelectComboBox();
                titleComboBox.Items.Clear();
                if (EstateRecords != null)
                    for (int index = 0; index < EstateRecords.Length; index++)
                    {
                        titleComboBox.Items.Add(new RadListDataItem(EstateRecords[index].Title, EstateRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            titleComboBox.SelectedIndex = 0;
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
        private void EditLandLordUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }
        #region LandLord
        private int ComboBoxSelectedIndex(RadDropDownList _ComboBox, ListItem _ListItem)
        {
            for (int index = 0; index < _ComboBox.Items.Count; index++)
            {
                if (DataConvertor.ConvertToShort(((RadListDataItem)_ComboBox.Items[index]).Value) == _ListItem.Id)
                    return index;
            }
            return -1;
        }

        private void LoadLandLord()
        {
            try
            {
                idTextBox.Text = _LandLordBOL.Id.ToString();
                dangiRadioButton.IsChecked = _LandLordBOL.Type != null && bool.Parse(_LandLordBOL.Type.ToString());
                nodangiRadioButton.IsChecked = _LandLordBOL.Type != null && !bool.Parse(_LandLordBOL.Type.ToString());
                shareTextBox.Text = _LandLordBOL.Share.ToString();
                nameTextBox.Text = string.Format("{0} {1} ", _LandLordBOL.FirstName, _LandLordBOL.LastName);
                ListItem _EstateListItem = new ListItem(_LandLordBOL.EstateId, _LandLordBOL.Title);
                titleComboBox.SelectedIndex = ComboBoxSelectedIndex(titleComboBox, _EstateListItem);
               
               
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void SetLandLordUpdateVisibility(bool visibility)
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
                        InsertLandLord();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertLandLord()
        {
            try
            {
                _LandLordBOL.Id = new LandLordBLL().SelectMaxId();
                _LandLordBOL.Type = DataConvertor.ConvertToBoolean(dangiRadioButton.IsChecked);
                _LandLordBOL.PersonalInfoId = personalInfoId;
                _LandLordBOL.EstateId = DataConvertor.ConvertToInt(titleComboBox.SelectedValue);
                _LandLordBOL.Share =DataConvertor.ConvertToDecimal( shareTextBox.Text);
                _LandLordBOL.IsLandLord = true;
                
                if(DialogResult.OK==_JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel))
                {
                    _LandLordBLL.Insert(_LandLordBOL);
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
                    UpdateLandLord();
            }
        }
        private void UpdateLandLord()
        {

            try
            {
                _LandLordBOL.Type = DataConvertor.ConvertToBoolean(dangiRadioButton.IsChecked);
                _LandLordBOL.PersonalInfoId = personalInfoId;
                _LandLordBOL.Share = DataConvertor.ConvertToDecimal(shareTextBox.Text);
                _LandLordBOL.EstateId = DataConvertor.ConvertToInt(titleComboBox.SelectedValue);
                _LandLordBOL.IsLandLord = true;
                _LandLordBLL.Update(_LandLordBOL);
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
                DeleteLandLord();
        }
        private void DeleteLandLord()
        {
            try
            {
                _LandLordBLL.Delete(_LandLordBOL);
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
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                errorProvider.SetError(nameTextBox, "لطفا نام ونام خانوداگی مالک را وارد کنید");
                nameTextBox.Focus();
                return false;
            }
           
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
        private void personalInfoLOVButton_Click(object sender, EventArgs e)
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
        //private void purchaseLetterLOVButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PurchaseLetterLOV _PurchaseLetterLOV = new PurchaseLetterLOV();
        //        if (_PurchaseLetterLOV.ShowDialog() == DialogResult.OK)
        //        {
        //            if (_PurchaseLetterLOV._PurchaseLetterBOL.Id > 0)
        //            {
        //                codeTextBox.Text = string.Format("{0} {1}", _PurchaseLetterLOV._PurchaseLetterBOL.Code,DataConvertor.ConvertToPersianDate( _PurchaseLetterLOV._PurchaseLetterBOL.ContarctDate));
        //                purchaseLetterId = _PurchaseLetterLOV._PurchaseLetterBOL.Id;
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
        //        noticeLabel.Text = _ExceptionHandlerBOL.Title;
        //    }
        //}
       
      
      
        #endregion
        private void dangiRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if
               (dangiRadioButton.IsChecked == true)
            {

                shareTextBox.Enabled = true;
                shareTextBox.Value = 1;
                shareTextBox.DecimalPlaces = 1;
            }
            else
            {
                shareTextBox.Enabled = false;
                shareTextBox.Value = 0;
                shareTextBox.DecimalPlaces = 0;
            }
        }

        private void EditLandLordUI_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.CloseForm();
        }

      
    }
}