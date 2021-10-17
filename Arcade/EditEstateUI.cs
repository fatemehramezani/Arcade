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
    public partial class EditEstateUI : Telerik.WinControls.UI.RadForm
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
        EstateBOL _EstateBOL = new EstateBOL();
        EstateBLL _EstateBLL = new EstateBLL();
        JobBOL _JobBOL;
        JobBLL _JobBLL = new JobBLL();
        public EditEstateUI()
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                _FormMode = FormMode.Insert;
                SetEstateUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_EstateBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        public EditEstateUI(EstateBOL estateBOL)
        {
            try
            {
                InitializeComponent();
                _EstateBOL = estateBOL;
                ComboBoxBind();
               
                SetEstateUpdateVisibility(true);
                LoadEstate(_EstateBOL);

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
                EstateTypeComboBoxBind();
          

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EstateTypeComboBoxBind()
        {
            try
            {
                EstateTypeBOL[] EstateTypeRecords = new EstateTypeBLL().SelectComboBox();
                estateTypeComboBox.Items.Clear();
                if (EstateTypeRecords != null)
                    for (int index = 0; index < EstateTypeRecords.Length; index++)
                    {
                        estateTypeComboBox.Items.Add(new RadListDataItem(EstateTypeRecords[index].Title, EstateTypeRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            estateTypeComboBox.SelectedIndex = 0;
        }
        private void LoadEstate(EstateBOL _EstateBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetEstateUpdateVisibility(true);
                LoadEstate();
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
        private void EditEstateUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }

        #region Estate
        private void LoadEstate()
        {
            try
            {
                idTextBox.Text = _EstateBOL.Id.ToString();
                zipCodeTextBox.Text = _EstateBOL.ZipCode;
                areaTextBox.Text = _EstateBOL.Area.ToString();
                floorTextBox.Text = _EstateBOL.Floor.ToString();
                facilitiesTextBox.Text = _EstateBOL.Facilities;
                nameTextBox.Text = _EstateBOL.Name;
                addressTextBox.Text = _EstateBOL.Address;
                phoneTextBox.Text = _EstateBOL.Phone;
                ListItem _EstateTypeListItem = new ListItem(_EstateBOL.EstateTypeId, _EstateBOL.EstateTypeTitle);
                estateTypeComboBox.SelectedIndex = ComboBoxSelectedIndex(estateTypeComboBox, _EstateTypeListItem);

               
 
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
        private void SetEstateUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
                nameTextBox.Text = zipCodeTextBox.Text = areaTextBox.Text = floorTextBox.Text  = idTextBox.Text = phoneTextBox.Text = addressTextBox.Text  = string.Empty;
                
               
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
                        InsertEstate();
                }
            
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertEstate()
        {
            try
            {
                _EstateBOL.Id = new EstateBLL().SelectMaxId();
                _EstateBOL.ZipCode = zipCodeTextBox.Text;
                _EstateBOL.Area =DataConvertor.ConvertToInt( areaTextBox.Text);
                _EstateBOL.Floor =DataConvertor.ConvertToByte( floorTextBox.Text);
                _EstateBOL.Facilities = facilitiesTextBox.Text;
                _EstateBOL.Name = nameTextBox.Text;
                _EstateBOL.Phone = phoneTextBox.Text;
                _EstateBOL.Address = addressTextBox.Text;
                _EstateBOL.EstateTypeId = DataConvertor.ConvertToByte(estateTypeComboBox.SelectedValue);
                if(_JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel)==DialogResult.OK)
                {
                    _EstateBLL.Insert(_EstateBOL);
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
                    UpdateEstate();
            }
        }
        private void UpdateEstate()
        {
            try
            {
                //_EstateBOL.Id = new EstateBLL().SelectMaxId();
                _EstateBOL.ZipCode = zipCodeTextBox.Text;
                _EstateBOL.Area = DataConvertor.ConvertToInt(areaTextBox.Text);
                _EstateBOL.Floor = DataConvertor.ConvertToByte(floorTextBox.Text);
                _EstateBOL.Facilities = facilitiesTextBox.Text;
                _EstateBOL.Name = nameTextBox.Text;
                _EstateBOL.Phone = phoneTextBox.Text;
                _EstateBOL.Address = addressTextBox.Text;
                _EstateBOL.EstateTypeId = DataConvertor.ConvertToByte(estateTypeComboBox.SelectedValue);
                if (_JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel) == DialogResult.OK)
                {
                    _EstateBLL.Insert(_EstateBOL);
                    CloseForm();
                }

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
                DeleteEstate();
        }
        private void DeleteEstate()
        {
            try
            {
                _EstateBLL.Delete(_EstateBOL);
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
            if (string.IsNullOrEmpty(zipCodeTextBox.Text))
            {
                errorProvider.SetError(zipCodeTextBox, "لطفا کدپستی را وارد کنید");
                zipCodeTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(areaTextBox.Text))
            {
                errorProvider.SetError(areaTextBox, "لطفا مساحت را وارد کنید");
                areaTextBox.Focus();
                return false;
            } 
            if (string.IsNullOrEmpty(floorTextBox.Text))
            {
                errorProvider.SetError(floorTextBox, "لطفا مساحت را وارد کنید");
                floorTextBox.Focus();
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

        private void EditEstateUI_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel13_Click(object sender, EventArgs e)
        {

        }

        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void areaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }


      

    }
}