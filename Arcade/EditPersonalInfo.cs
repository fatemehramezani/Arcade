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
    public partial class EditPersonalInfoUI : Telerik.WinControls.UI.RadForm
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
        PersonalInfoBOL _PersonalInfoBOL = new PersonalInfoBOL();
        PersonalInfoBLL _PersonalInfoBLL = new PersonalInfoBLL();
        JobBOL _JobBOL;
        JobBLL _JobBLL = new JobBLL();
        public EditPersonalInfoUI()
        {
            try
            {
                InitializeComponent();
                birthdayPersianDateTimePicker.GeoDate = DateTime.Today;
                ComboBoxBind();
                _FormMode = FormMode.Insert;
                SetPersonalInfoUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_PersonalInfoBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public EditPersonalInfoUI(PersonalInfoBOL personalInfoBOL)
        {
            try
            {
                InitializeComponent();
                _PersonalInfoBOL = personalInfoBOL;
               
             //   _JobBOL = _JobBLL.Select(new JobBOL { Id = _PersonalInfoBOL.Id }) == null ? null : _JobBLL.Select(new JobBOL { PersonalInfoId = _PersonalInfoBOL.Id })[0];
                ComboBoxBind();
                SetPersonalInfoUpdateVisibility(true);
                LoadPersonalInfo(_PersonalInfoBOL);

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadPersonalInfo(PersonalInfoBOL _PersonalInfoBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetPersonalInfoUpdateVisibility(true);
                LoadPersonalInfo();
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
                MilitaryStatusComboBoxBind();
                MaritalStatusComboBoxBind();
                JobComboBoxBind();
               
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
       private void MilitaryStatusComboBoxBind()
        {
            try
            {
                MilitaryStatusBOL[] MilitaryStatusRecords = new MilitaryStatusBLL().SelectComboBox();
                militaryStatusComboBox.Items.Clear();
                if (MilitaryStatusRecords != null)
                    for (int index = 0; index < MilitaryStatusRecords.Length; index++)
                    {
                        militaryStatusComboBox.Items.Add(new RadListDataItem(MilitaryStatusRecords[index].Title, MilitaryStatusRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            militaryStatusComboBox.SelectedIndex = 0;
        }
        private void MaritalStatusComboBoxBind()
        {
            try
            {
                MaritalStatusBOL[] MaritalStatusRecords = new MaritalStatusBLL().SelectComboBox();
                maritalStatusComboBox.Items.Clear();
                if (MaritalStatusRecords != null)
                    for (int index = 0; index < MaritalStatusRecords.Length; index++)
                    {
                        maritalStatusComboBox.Items.Add(new RadListDataItem(MaritalStatusRecords[index].Title, MaritalStatusRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            maritalStatusComboBox.SelectedIndex = 0;
        }
        private void JobComboBoxBind()
        {
            try
            {
                JobBOL[] JobRecords = new JobBLL().SelectComboBox();
                jobComboBox.Items.Clear();
                if (JobRecords != null)
                    for (int index = 0; index < JobRecords.Length; index++)
                    {
                        jobComboBox.Items.Add(new RadListDataItem(JobRecords[index].Title, JobRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            jobComboBox.SelectedIndex = 0;
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
        private void EditPersonalInfoUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }

        #region PersonalInfo
        private void LoadPersonalInfo()
        {
            try
            {
                idTextBox.Text = _PersonalInfoBOL.Id.ToString();
                firstNameTextBox.Text = _PersonalInfoBOL.FirstName;
                lastNameTextBox.Text = _PersonalInfoBOL.LastName;
                fatherNameTextBox.Text = _PersonalInfoBOL.FatherName;
                nationalCodeTextBox.Text = _PersonalInfoBOL.NationalCode;
                zipeCodeTextBox.Text = _PersonalInfoBOL.ZipeCode;
                homeAddressTextBox.Text = _PersonalInfoBOL.Address;
                jobAddressTextBox.Text = _PersonalInfoBOL.CompanyAddress;
                companyNameTextBox.Text = _PersonalInfoBOL.CompanyName;
                companyPhoneTextBox.Text = _PersonalInfoBOL.CompanyPhone;
                isLegalRadioButton.IsChecked = _PersonalInfoBOL.IsLegal != null && bool.Parse(_PersonalInfoBOL.IsLegal.ToString());
                isntLegalRadioButton.IsChecked = _PersonalInfoBOL.IsLegal != null && !bool.Parse(_PersonalInfoBOL.IsLegal.ToString());
                certificateTextBox.Text = _PersonalInfoBOL.Cetificate;
                issuancePlaceTextBox.Text = _PersonalInfoBOL.IssuancePlace;
                birthPlaceTextBox.Text = _PersonalInfoBOL.BirthPlace;
                if (_PersonalInfoBOL.Birthday == null || _PersonalInfoBOL.Birthday == DateTime.MinValue)
                    ((MaskedTextBox)birthdayPersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)birthdayPersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                birthdayPersianDateTimePicker.GeoDate = (DateTime)_PersonalInfoBOL.Birthday;
                isMaleRadioButton.IsChecked = _PersonalInfoBOL.IsMale != null && bool.Parse(_PersonalInfoBOL.IsMale.ToString());
                isFemaleRadioButton.IsChecked = _PersonalInfoBOL.IsMale != null && !bool.Parse(_PersonalInfoBOL.IsMale.ToString());
                phoneTextBox.Text = _PersonalInfoBOL.Phone;
                mobileTextBox.Text = _PersonalInfoBOL.Mobile;
                ListItem _MilitaryStatusListItem = new ListItem(_PersonalInfoBOL.MilitaryStatuseId, _PersonalInfoBOL.MilitaryStatuseTitle);
                militaryStatusComboBox.SelectedIndex = ComboBoxSelectedIndex(militaryStatusComboBox, _MilitaryStatusListItem);
                ListItem _MaritalStatusListItem = new ListItem(_PersonalInfoBOL.MaritalStatuseId, _PersonalInfoBOL.MaritalStatuseTitle);
                maritalStatusComboBox.SelectedIndex = ComboBoxSelectedIndex(maritalStatusComboBox, _MaritalStatusListItem);
                ListItem _JobListItem = new ListItem(_PersonalInfoBOL.JobId, _PersonalInfoBOL.JobTitle);
                jobComboBox.SelectedIndex = ComboBoxSelectedIndex(jobComboBox, _JobListItem);
                if (_PersonalInfoBOL.Image != null)
                {
                    byte[] image = _PersonalInfoBOL.Image;
                    string temp = Convert.ToString(DateTime.Now.ToFileTime());
                    FileStream _FileStream = new FileStream(temp, FileMode.CreateNew, FileAccess.Write);
                    _FileStream.Write(image, 0, image.Length);
                    _FileStream.Flush();
                    _FileStream.Close();
                    imagePictureBox.Image = Image.FromFile(temp, true);
                }
               
               
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
        private void SetPersonalInfoUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
                nationalCodeTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text = fatherNameTextBox.Text = certificateTextBox.Text = idTextBox.Text = phoneTextBox.Text = homeAddressTextBox.Text = mobileTextBox.Text  = issuancePlaceTextBox.Text = birthPlaceTextBox.Text = string.Empty;
                ((MaskedTextBox)birthdayPersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)birthdayPersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                
                if (militaryStatusComboBox.Items.Count > 0)
                    militaryStatusComboBox.SelectedIndex = 0;
                if (maritalStatusComboBox.Items.Count > 0)
                    maritalStatusComboBox.SelectedIndex = 0;
                if (jobComboBox.Items.Count > 0)
                    jobComboBox.SelectedIndex = 0;
                isMaleRadioButton.IsChecked = true;
                isLegalRadioButton.IsChecked = true;

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
                        InsertPersonalInfo();
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
        private void InsertPersonalInfo()
        {
            try
            {
                _PersonalInfoBOL.Id = new PersonalInfoBLL().SelectMaxId();
                _PersonalInfoBOL.FirstName = firstNameTextBox.Text;
                _PersonalInfoBOL.LastName = lastNameTextBox.Text;
                _PersonalInfoBOL.FatherName = fatherNameTextBox.Text;
                _PersonalInfoBOL.NationalCode = nationalCodeTextBox.Text;
                _PersonalInfoBOL.Cetificate = certificateTextBox.Text;
                _PersonalInfoBOL.IssuancePlace = issuancePlaceTextBox.Text;
                _PersonalInfoBOL.BirthPlace = birthPlaceTextBox.Text;
                _PersonalInfoBOL.ZipeCode = zipeCodeTextBox.Text;
                _PersonalInfoBOL.CompanyAddress = jobAddressTextBox.Text;
                _PersonalInfoBOL.CompanyName = companyNameTextBox.Text;
                _PersonalInfoBOL.CompanyPhone = companyPhoneTextBox.Text;
                _PersonalInfoBOL.Address = homeAddressTextBox.Text;
                _PersonalInfoBOL.Birthday = DataConvertor.ConvertToDateTime(birthdayPersianDateTimePicker.GeoDate);
                _PersonalInfoBOL.IsMale = DataConvertor.ConvertToBoolean(isMaleRadioButton.IsChecked);
                _PersonalInfoBOL.IsLegal = DataConvertor.ConvertToBoolean(isLegalRadioButton.IsChecked);
                _PersonalInfoBOL.MaritalStatuseId = DataConvertor.ConvertToByte(maritalStatusComboBox.SelectedValue);
                _PersonalInfoBOL.Phone = phoneTextBox.Text;
                _PersonalInfoBOL.Mobile = mobileTextBox.Text;
                _PersonalInfoBOL.MilitaryStatuseId = DataConvertor.ConvertToByte(militaryStatusComboBox.SelectedValue);
                _PersonalInfoBOL.JobId = DataConvertor.ConvertToByte(jobComboBox.SelectedValue);

                if (imagePictureBox.Image != null)
                {
                    MemoryStream stream = new MemoryStream();
                    imagePictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] image = stream.ToArray();
                    _PersonalInfoBOL.Image = image;
                }
                if (DialogResult.OK == _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel))
                {
                    _PersonalInfoBLL.Insert(_PersonalInfoBOL);
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
                    UpdatePersonalInfo();
            }
        }
        private void UpdatePersonalInfo()
        {
            try
            {
              //  _PersonalInfoBOL.Id = new PersonalInfoBLL().SelectMaxId();
                _PersonalInfoBOL.FirstName = firstNameTextBox.Text;
                _PersonalInfoBOL.LastName = lastNameTextBox.Text;
                _PersonalInfoBOL.FatherName = fatherNameTextBox.Text;
                _PersonalInfoBOL.NationalCode = nationalCodeTextBox.Text;
                _PersonalInfoBOL.Cetificate = certificateTextBox.Text;
                _PersonalInfoBOL.IssuancePlace = issuancePlaceTextBox.Text;
                _PersonalInfoBOL.BirthPlace = birthPlaceTextBox.Text;
                _PersonalInfoBOL.CompanyAddress = jobAddressTextBox.Text;
                _PersonalInfoBOL.CompanyName = companyNameTextBox.Text;
                _PersonalInfoBOL.ZipeCode = zipeCodeTextBox.Text;

                _PersonalInfoBOL.CompanyPhone = companyPhoneTextBox.Text;
                _PersonalInfoBOL.Address = homeAddressTextBox.Text;
                _PersonalInfoBOL.Birthday = DataConvertor.ConvertToDateTime(birthdayPersianDateTimePicker.GeoDate);
                _PersonalInfoBOL.IsMale = DataConvertor.ConvertToBoolean(isMaleRadioButton.IsChecked);
                _PersonalInfoBOL.IsLegal = DataConvertor.ConvertToBoolean(isLegalRadioButton.IsChecked);
                _PersonalInfoBOL.MaritalStatuseId = DataConvertor.ConvertToByte(maritalStatusComboBox.SelectedValue);
                _PersonalInfoBOL.Phone = phoneTextBox.Text;
                _PersonalInfoBOL.Mobile = mobileTextBox.Text;
                _PersonalInfoBOL.MilitaryStatuseId = DataConvertor.ConvertToByte(militaryStatusComboBox.SelectedValue);
                _PersonalInfoBOL.JobId = DataConvertor.ConvertToByte(jobComboBox.SelectedValue);

                if (imagePictureBox.Image != null)
                {
                    MemoryStream stream = new MemoryStream();
                    imagePictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] image = stream.ToArray();
                    _PersonalInfoBOL.Image = image;
                }
                _PersonalInfoBLL.Update(_PersonalInfoBOL);
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
                DeletePersonalInfo();
        }
        private void DeletePersonalInfo()
        {
            try
            {
                _PersonalInfoBLL.Delete(_PersonalInfoBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void insertPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = GetImage(128, 128);
                imagePictureBox.Image = image;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private Image GetImage(int width, int height)
        {
                OpenFileDialog _OpenFileDialog = new OpenFileDialog();
                _OpenFileDialog.DefaultExt = "jpg";
                _OpenFileDialog.Filter = "Images (*.bmp;*.jpg;*.gif)|*.jpg;*.bmp;*.gif|All Files (*.*)|*.*";
                DialogResult _DialogResult = _OpenFileDialog.ShowDialog();
                if (_DialogResult == DialogResult.No)
                    return null;
                if (_OpenFileDialog.FileName == null || _OpenFileDialog.FileName == string.Empty)
                    return null;
                Image imageImage = Image.FromFile(_OpenFileDialog.FileName);
                imageImage = Helper.ResizeImage(_OpenFileDialog.FileName, Math.Min(width, imageImage.Width), Math.Min(height, imageImage.Height), false);
                return imageImage;
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
            if (string.IsNullOrEmpty(fatherNameTextBox.Text))
            {
                errorProvider.SetError(fatherNameTextBox, "لطفا نام پدر را وارد کنید");
                fatherNameTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nationalCodeTextBox.Text) ||
                nationalCodeTextBox.Text.Length <10 ||!Validate(nationalCodeTextBox.Text)
                )
            {
                errorProvider.SetError(nationalCodeTextBox, "لطفا کد ملی معتبر وارد کنید");
                nationalCodeTextBox.Focus();
                //mainInfoPageView.SelectedPage = informationPageViewPage;
                return false;
            }
            if ((nationalCodeTextBox.Text.Length < 10) || (nationalCodeTextBox.Text.Length > 10))
            {
                errorProvider.SetError(nationalCodeTextBox, "لطفا شماره ملی معتبر را وارد کنید");
                nationalCodeTextBox.Focus();
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

        private void isLegalRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if
               (isLegalRadioButton.IsChecked == true)
            {

                LegalGroupBox.Enabled = true;

            }
            else
                LegalGroupBox.Enabled = false;
        }
         private bool Validate(string nationalCode)
        {
            switch (nationalCode)
            {
                case "0000000000":
                case "1111111111":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                    return false;
                    break;
            }
            Int64 number;
            int sum = 0, temp;
            Int64.TryParse(nationalCode, out number);
            if (Math.Log10(number) > 6 && Math.Log10(number) < 10)
            {
                temp = Convert.ToInt16(number % 10);
                number /= 10;
                for (int i = 2; i < 11; i++)
                {
                    sum += Convert.ToInt16(i * (number % 10));
                    number /= 10;
                }
                if (((sum % 11 < 2) && (sum % 11 == temp)) || ((sum % 11 >= 2) && ((11 - sum % 11) == temp)))
                    return true;
            }
            return false;
        }
    }
}