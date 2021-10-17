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
    public partial class EditOutPutUI : Telerik.WinControls.UI.RadForm
    {
        FormMode _FormMode = FormMode.Insert;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        string CancelText;
        string UpdateText;
        string InsertText;
        char[] spliter = { ';', ':' };
        string DeleteText;
        string AccessText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        string AccessConfirmation;
        string Successed;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        OutPutBOL _OutPutBOL = new OutPutBOL();
        OutPutBLL _OutPutBLL = new OutPutBLL();
        public EditOutPutUI()
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
               datePersianDateTimePicker.GeoDate = DateTime.Today;
                _FormMode = FormMode.Insert;
                SetOutPutUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_OutPutBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
 
        private int CheckBoxListSelectedIndex(CheckedListBox _CheckedListBox, ListItem _ListItem)
        {
            for (int index = 0; index < _CheckedListBox.Items.Count; index++)
            {
                if (((ListItem)_CheckedListBox.Items[index]).Id == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        public EditOutPutUI(OutPutBOL outPutBOL)
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                _OutPutBOL = outPutBOL;
                SetOutPutUpdateVisibility(true);
                LoadOutPut(_OutPutBOL);
                
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadOutPut(OutPutBOL _OutPutBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetOutPutUpdateVisibility(true);
                LoadOutPut();
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
                EventComboBoxBind();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
     
        private void EventComboBoxBind()
        {
            try
            {
                EventBOL[] EventRecords = new EventBLL().SelectComboBox();
                eventTitleComboBox.Items.Clear();
                if (EventRecords != null)
                    for (int index = 0; index < EventRecords.Length; index++)
                    {
                        eventTitleComboBox.Items.Add(new RadListDataItem(EventRecords[index].Title, EventRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            eventTitleComboBox.SelectedIndex = 0;
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
        private void EditOutPutUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }

        #region OutPut
        private void LoadOutPut()
        {
            try
            {
                
                idTextBox.Text = _OutPutBOL.Id.ToString();
                priceTextBox.Text = _OutPutBOL.Price.ToString().Remove(_OutPutBOL.Price.ToString().LastIndexOf('.'));
                descriptionTextBox.Text = _OutPutBOL.Description;
                ListItem _EventListItem = new ListItem(_OutPutBOL.EventId, _OutPutBOL.EventTitle);
                eventTitleComboBox.SelectedIndex = ComboBoxSelectedIndex(eventTitleComboBox, _EventListItem);
             
                if (_OutPutBOL.Date == null || _OutPutBOL.Date == DateTime.MinValue)
                    ((MaskedTextBox)datePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)datePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                    datePersianDateTimePicker.GeoDate = (DateTime)_OutPutBOL.Date;
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
        private void SetOutPutUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
                ((MaskedTextBox)datePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();

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
                        InsertOutPut();
                }
                
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertOutPut()
        {
            try
            {

                _OutPutBOL.Id = new OutPutBLL().SelectMaxId();
                _OutPutBOL.EventId = DataConvertor.ConvertToInt(eventTitleComboBox.SelectedValue);
                _OutPutBOL.Description = descriptionTextBox.Text;
                _OutPutBOL.Price = DataConvertor.ConvertToDecimal(priceTextBox.Text);
                _OutPutBOL.Date = DataConvertor.ConvertToDateTime(datePersianDateTimePicker.GeoDate);
                if (_JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel) == DialogResult.OK)
                {
                    _OutPutBLL.Insert(_OutPutBOL);
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
                    UpdateOutPut();
            }
        }
        private void UpdateOutPut()
        {

            try
            {
                _OutPutBOL.EventId = DataConvertor.ConvertToInt(eventTitleComboBox.SelectedValue);
                _OutPutBOL.Description = descriptionTextBox.Text;
                _OutPutBOL.Price = DataConvertor.ConvertToDecimal(priceTextBox.Text);
                _OutPutBOL.Date = DataConvertor.ConvertToDateTime(datePersianDateTimePicker.GeoDate);
                _OutPutBLL.Update(_OutPutBOL);
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
                DeleteOutPut();
        }
        private void DeleteOutPut()
        {
            try
            {
                _OutPutBLL.Delete(_OutPutBOL);
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
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                errorProvider.SetError(priceTextBox, "لطفا هزینه پرداختی را وارد کنید");
                priceTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(eventTitleComboBox.Text))
            {
                errorProvider.SetError(eventTitleComboBox, "لطفا عنوان هزینه را وارد کنید");
                eventTitleComboBox.Focus();
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
        #endregion

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        
       

    }
}