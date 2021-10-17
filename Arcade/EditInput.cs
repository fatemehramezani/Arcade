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
    public partial class EditInputUI : Telerik.WinControls.UI.RadForm
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
        InputBOL _InputBOL = new InputBOL();
        InputBLL _InputBLL = new InputBLL();
        public EditInputUI()
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
               datePersianDateTimePicker.GeoDate = DateTime.Today;
                _FormMode = FormMode.Insert;
                SetInputUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_InputBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public EditInputUI(InputBOL InputBOL)
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                _InputBOL = InputBOL;
                SetInputUpdateVisibility(true);
                LoadInput(_InputBOL);
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
        private void LoadInput(InputBOL _InputBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetInputUpdateVisibility(true);
                LoadInput();
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
                EstateComboBoxBind();
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
        private void EditInputUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }

        #region Input
        private void LoadInput()
        {
            try
            {
              
                idTextBox.Text = _InputBOL.Id.ToString();
                descriptionTextBox.Text = _InputBOL.Description;
                priceTextBox.Text = _InputBOL.Price.ToString().Remove(_InputBOL.Price.ToString().LastIndexOf('.'));
                ListItem _EventListItem = new ListItem(_InputBOL.EventId, _InputBOL.EventTitle);
                eventTitleComboBox.SelectedIndex = ComboBoxSelectedIndex(eventTitleComboBox, _EventListItem);
                ListItem _EstateListItem = new ListItem(_InputBOL.EstateId, _InputBOL.Title);
                titleComboBox.SelectedIndex = ComboBoxSelectedIndex(titleComboBox, _EstateListItem);
                if (_InputBOL.Date == null || _InputBOL.Date == DateTime.MinValue)
                    ((MaskedTextBox)datePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)datePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                    datePersianDateTimePicker.GeoDate = (DateTime)_InputBOL.Date;
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
            //for (int index = 0; index < _ComboBox.Items.Count; index++)
            //{
            //    if (_ComboBox.Items[index].ToString() == _ListItem.Value.ToString())
            //        return index;
            //}
            //return -1;
        }
        private void SetInputUpdateVisibility(bool visibility)
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
                        InsertInput();
                }
                else
                {
                    if (DialogResult.OK == _JntMsgBoxFarsi.Show(UpdateConfirmation, InsertText, JntStyle.OkCancel))
                    {
                       // _InputBLL.Insert(_InputBOL);
                        CloseForm();
                    }
                }
                
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertInput()
        {
            try
            {

                _InputBOL.Id = new InputBLL().SelectMaxId();
                _InputBOL.EventId = DataConvertor.ConvertToInt(eventTitleComboBox.SelectedValue);
                _InputBOL.EstateId = DataConvertor.ConvertToInt(titleComboBox.SelectedValue);
                _InputBOL.Description = descriptionTextBox.Text;
                _InputBOL.Price = DataConvertor.ConvertToDecimal(priceTextBox.Text);
                _InputBOL.Date = DataConvertor.ConvertToDateTime(datePersianDateTimePicker.GeoDate);
                if (DialogResult.OK == _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel))
                {
                    _InputBLL.Insert(_InputBOL);
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
                    UpdateInput();
            }
        }
        private void UpdateInput()
        {

            try
            {
                _InputBOL.EventId = DataConvertor.ConvertToInt(eventTitleComboBox.SelectedValue);
                _InputBOL.EstateId = DataConvertor.ConvertToInt(titleComboBox.SelectedValue);
                _InputBOL.Description = descriptionTextBox.Text;
                _InputBOL.Price = DataConvertor.ConvertToDecimal(priceTextBox.Text);
                _InputBOL.Date = DataConvertor.ConvertToDateTime(datePersianDateTimePicker.GeoDate);
                _InputBLL.Update(_InputBOL);
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
                DeleteInput();
        }
        private void DeleteInput()
        {
            try
            {
                _InputBLL.Delete(_InputBOL);
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
                errorProvider.SetError(priceTextBox, "لطفا هزینه دریافتی را وارد کنید");
                priceTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(eventTitleComboBox.Text))
            {
                errorProvider.SetError(eventTitleComboBox, "لطفا عنوان هزینه را وارد کنید");
                eventTitleComboBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(titleComboBox.Text))
            {
                errorProvider.SetError(titleComboBox, "لطفا ملک مورد نظر را انتخاب کنید");
                titleComboBox.Focus();
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

        private void EditInputUI_KeyDown_1(object sender, KeyEventArgs e)
        {
               if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
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