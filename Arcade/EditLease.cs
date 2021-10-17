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
    public partial class EditLeaseUI : Telerik.WinControls.UI.RadForm
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
        public int? SellerManId;
        public int? CoordinatingCouncilId;
        public int? CostumerManId;
        public int? LeaseMounth;
        public string TanentFirstName;
        public string TanentLastName;
        public string LandLordFirstName;
        public string LandLordLastName;
        CoordinatingCouncilBLL _CoordinatingCouncilBLL = new CoordinatingCouncilBLL();
        CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        LeaseBOL _LeaseBOL = new LeaseBOL();
        LeaseBLL _LeaseBLL = new LeaseBLL();
        JobBOL _JobBOL;
        JobBLL _JobBLL = new JobBLL();
        public EditLeaseUI()
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                FromDatePersianDateTimePicker.GeoDate = DateTime.Today;
                _FormMode = FormMode.Insert;
                SetLeaseUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_LeaseBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        //private string SetTransmiter()
        //{
        //    string Transmitters = string.Empty;
        //    //List<PatientDiseasesBOL> _PatientDiseasesBOLs = new List<PatientDiseasesBOL>();
        //    IEnumerator _IEnumerator = transmiterCheckedListBox.CheckedItems.GetEnumerator();
        //    while (_IEnumerator.MoveNext() != false)
        //    {
        //        short? TransmiterId = DataConvertor.ConvertToShort(((ListItem)_IEnumerator.Current).Id);
        //        Transmitters += string.Format("{0}{1}", TransmiterId.ToString(), spliter[0]);
        //        //_PatientDiseasesBOLs.Add(new PatientDiseasesBOL(DiseasesId, _PatientBOL.PatientId));
        //    }
        //    return Transmitters;
        //}
        private int CheckBoxListSelectedIndex(CheckedListBox _CheckedListBox, ListItem _ListItem)
        {
            for (int index = 0; index < _CheckedListBox.Items.Count; index++)
            {
                if (((ListItem)_CheckedListBox.Items[index]).Id == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        public EditLeaseUI(LeaseBOL purchaseLetterBOL)
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                _LeaseBOL = purchaseLetterBOL;
                SetLeaseUpdateVisibility(true);
                LoadLease(_LeaseBOL);
                SellerManId = _LeaseBOL.LandLordId;
                CostumerManId = _LeaseBOL.TanentPersonalInfo;
                CoordinatingCouncilId = _LeaseBOL.CouncilId;
                LeaseMounth = (int)((_LeaseBOL.ToDate.Value.Date - _LeaseBOL.FromDate.Value.Date).TotalDays)/30;

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadLease(LeaseBOL _LeaseBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetLeaseUpdateVisibility(true);
                LoadLease();
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
                JobComboBoxBind();

               TransmitterCheckedListBoxBind();

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
     
        private void JobComboBoxBind()
        {
            try
            {
                JobBOL[] JobRecords = new JobBLL().SelectComboBox();
                jobTitleComboBox.Items.Clear();
                if (JobRecords != null)
                    for (int index = 0; index < JobRecords.Length; index++)
                    {
                        jobTitleComboBox.Items.Add(new RadListDataItem(JobRecords[index].Title, JobRecords[index].Id));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            jobTitleComboBox.SelectedIndex = 0;
        }
        //private void TransmiterBind()
        //{
            

        //        string transmiter = _LeaseBOL.PaymentType;
        //        if (transmiter != string.Empty && transmiter != null)
        //        {
        //            string[] sponsorSet = transmiter.Split(spliter[0]);
        //            if (sponsorSet.Length > 0)
        //            {

        //                int indexOfItem = -1;
        //                foreach (string item in sponsorSet)
        //                    if (item != string.Empty && item != null)
        //                    {
        //                        ListItem _ListItem = new ListItem(DataConvertor.ConvertToShort(item), string.Empty);
        //                        indexOfItem = CheckBoxListSelectedIndex(transmiterCheckedListBox, _ListItem);
        //                        if (indexOfItem > -1)
        //                            transmiterCheckedListBox.SetItemChecked(indexOfItem, true);
        //                    }

        //            }
        //        }
            
        //}
        private void TransmitterCheckedListBoxBind()
        {
            try
            {
                LeaseBOL _LeaseBOL = new LeaseBOL();
                if (YearlyRadioButton.IsChecked)
                {
                    _LeaseBOL.PaymentType = "سالیانه";
                }
                else
                {
                    _LeaseBOL.PaymentType = "ماهیانه";
                }

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
        private void EditLeaseUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }




        #region Lease
        private void LoadLease()
        {
            try
            {
                PurchaseLetterLOV _PurchaseLetterLov = new PurchaseLetterLOV();
                SellerManId = _PurchaseLetterLov._PurchaseLetterBOL.SellerId;
                idTextBox.Text = _LeaseBOL.Id.ToString();
                codeTextBox.Text = _LeaseBOL.Code;
                sellerNameTextBox.Text = string.Format("{0} {1}", _LeaseBOL.LandLordFirstName, _LeaseBOL.LandLordLastName);
                costumerNameTextBox.Text = string.Format("{0} {1}", _LeaseBOL.TanentFirstName, _LeaseBOL.TanentLastName);
                councilNameTextBox.Text = string.Format("{0} ", _LeaseBOL.CouncilFirstName);
                prepaymentTextBox.Text = _LeaseBOL.Prepayment.ToString().Remove(_LeaseBOL.Prepayment.ToString().LastIndexOf('.'));
                LeasHoldTextBox.Text = _LeaseBOL.Leasehold.ToString().Remove(_LeaseBOL.Leasehold.ToString().LastIndexOf('.'));
                LateChargeTextBox.Text = _LeaseBOL.LateCharge.ToString().Remove(_LeaseBOL.LateCharge.ToString().LastIndexOf('.'));
                amountInWordsTextBox.Text = _LeaseBOL.AmountInWords;
                witnessTextBox.Text = _LeaseBOL.Witness;
                ListItem _JobListItem = new ListItem(_LeaseBOL.JobId, _LeaseBOL.JobTitle);
                jobTitleComboBox.SelectedIndex = ComboBoxSelectedIndex(jobTitleComboBox, _JobListItem);
                ChargeTextBox.Text = _LeaseBOL.Charge.ToString().Remove(_LeaseBOL.Charge.ToString().LastIndexOf('.'));
                //TransmiterBind();
                if (_LeaseBOL.PaymentType == "سالیانه")
                    YearlyRadioButton.IsChecked = true;
                else
                    radRadioButton1.IsChecked = true;
                if (_LeaseBOL.FromDate == null || _LeaseBOL.FromDate == DateTime.MinValue)
                    ((MaskedTextBox)FromDatePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)FromDatePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                FromDatePersianDateTimePicker.GeoDate = (DateTime)_LeaseBOL.FromDate;

                if (_LeaseBOL.ToDate == null || _LeaseBOL.ToDate == DateTime.MinValue)
                    ((MaskedTextBox)toDatePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)toDatePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                    toDatePersianDateTimePicker.GeoDate = (DateTime)_LeaseBOL.ToDate;
                FillEstate(_LeaseBOL.TanentPersonalInfo);

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
        private void SetLeaseUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
                ((MaskedTextBox)toDatePersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)FromDatePersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();

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
                        InsertLease();
                }
                if(_FormMode==FormMode.Update)
                {
                    if (DialogResult.OK == _JntMsgBoxFarsi.Show("آیا از اعمال تغییرات مطمئن هستید؟", InsertText, JntStyle.OkCancel))
                    {
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
        private void InsertLease()
        {



            
            try
            {

                _LeaseBOL.Id = new LeaseBLL().SelectMaxId();
                _LeaseBOL.Code = codeTextBox.Text;
                _LeaseBOL.Prepayment =DataConvertor.ConvertToDecimal (prepaymentTextBox.Text);
                _LeaseBOL.LateCharge = DataConvertor.ConvertToDecimal(LateChargeTextBox.Text);
                _LeaseBOL.JobId = DataConvertor.ConvertToByte(jobTitleComboBox.SelectedValue);
                _LeaseBOL.Witness = witnessTextBox.Text;
                _LeaseBOL.Leasehold=DataConvertor.ConvertToDecimal(LeasHoldTextBox.Text);
                _LeaseBOL.TanentPersonalInfo = CostumerManId;
                _LeaseBOL.AmountInWords = amountInWordsTextBox.Text;
                _LeaseBOL.LandLordId = SellerManId;
                _LeaseBOL.CouncilId = CoordinatingCouncilId;
                _LeaseBOL.Charge = DataConvertor.ConvertToDecimal(ChargeTextBox.Text);
                _LeaseBOL.PaymentType = YearlyRadioButton.IsChecked?"سالیانه":"ماهیانه";
                _LeaseBOL.FromDate = DataConvertor.ConvertToDateTime(FromDatePersianDateTimePicker.GeoDate);
                _LeaseBOL.ToDate = DataConvertor.ConvertToDateTime(toDatePersianDateTimePicker.GeoDate);
                _LeaseBOL.LeaseMounth=DataConvertor.ConvertToByte( LeaseMounth);
                if(DialogResult.OK==_JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel))
                {
                    _LeaseBLL.Insert(_LeaseBOL);
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
                    UpdateLease();
            }
        }
        private void UpdateLease()
        {

            try
            {
                _LeaseBOL.Witness = witnessTextBox.Text;
                _LeaseBOL.TanentPersonalInfo = CostumerManId;
                _LeaseBOL.CouncilId = CoordinatingCouncilId;
                _LeaseBOL.LandLordId = SellerManId;
                _LeaseBOL.TanentFirstName = TanentFirstName;
                _LeaseBOL.TanentLastName = TanentLastName;
                _LeaseBOL.AmountInWords = amountInWordsTextBox.Text;
                _LeaseBOL.LandLordFirstName = LandLordFirstName;
                _LeaseBOL.LandLordLastName = LandLordLastName;
                _LeaseBOL.LateCharge = DataConvertor.ConvertToDecimal(LateChargeTextBox.Text);
                _LeaseBOL.Prepayment = DataConvertor.ConvertToDecimal(prepaymentTextBox.Text);
                _LeaseBOL.Leasehold = DataConvertor.ConvertToDecimal(LeasHoldTextBox.Text);
                _LeaseBOL.JobId = DataConvertor.ConvertToByte(jobTitleComboBox.SelectedValue);
                _LeaseBOL.PaymentType = YearlyRadioButton.IsChecked ? "سالیانه" : "ماهیانه";
                _LeaseBOL.FromDate = DataConvertor.ConvertToDateTime(FromDatePersianDateTimePicker.GeoDate);
                _LeaseBOL.ToDate = DataConvertor.ConvertToDateTime(toDatePersianDateTimePicker.GeoDate);
                _LeaseBOL.Charge = DataConvertor.ConvertToDecimal(ChargeTextBox.Text);
                _LeaseBLL.Update(_LeaseBOL);
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
                DeleteLease();
        }
        private void DeleteLease()
        {
            try
            {
                _LeaseBLL.Delete(_LeaseBOL);
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
            if (string.IsNullOrEmpty(costumerNameTextBox.Text))
            {
                errorProvider.SetError(costumerNameTextBox, "لطفا نام ونام خانوداگی را وارد کنید");
                costumerNameTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sellerNameTextBox.Text))
            {
                errorProvider.SetError(sellerNameTextBox, "لطفا نام ونام خانوداگی را وارد کنید");
                sellerNameTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prepaymentTextBox.Text))
            {
                errorProvider.SetError(prepaymentTextBox, "لطفا پیش پرداخت را وارد کنید");
                prepaymentTextBox.Focus();
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
        private void councilLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                CoordinatingCouncilLOV _CoordinatingCouncilLOV = new CoordinatingCouncilLOV();
                if (_CoordinatingCouncilLOV.ShowDialog() == DialogResult.OK)
                {
                    if (_CoordinatingCouncilLOV._CoordinatingCouncilBOL.Id > 0)
                    {
                        councilNameTextBox.Text = string.Format("{0} ", _CoordinatingCouncilLOV._CoordinatingCouncilBOL.FirstName);
                        CoordinatingCouncilId = _CoordinatingCouncilLOV._CoordinatingCouncilBOL.Id;
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        //    try
        //    {
        //        coordinatingcouncillov _coordinatingcouncillov = new coordinatingcouncillov();
        //        if (_coordinatingcouncillov.showdialog() == dialogresult.ok)
        //        {
        //            if (_coordinatingcouncillov._coordinatingcouncilbol.id > 0)
        //            {
        //                councilNameTextBox.Text = string.Format("{0} {1}", _CoordinatingCouncilLOV._CoordinatingCouncilBOL.FirstName, _CoordinatingCouncilLOV._CoordinatingCouncilBOL.LastName);
        //                CoordinatingCouncilId = _CoordinatingCouncilLOV._CoordinatingCouncilBOL.Id;
        //            }
        //        }
        //        CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        //        CoordinatingCouncilBOL[] _CoordinatingCouncilBOLs = _CoordinatingCouncilBLL.Select(_CoordinatingCouncilBOL);
        //        if (_CoordinatingCouncilBOLs.Length > 0)
        //        {
        //            councilNameTextBox.Text = string.Empty;
        //            foreach (CoordinatingCouncilBOL item in _CoordinatingCouncilBOLs)
        //            {
        //                councilNameTextBox.Text += string.Format("{0} {1} | ", item.FirstName, item.LastName);
        //                CoordinatingCouncilId += item.Id.ToString();
        //            }
        //        }
                
        //        //CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        //        //CoordinatingCouncilBOL[] _CoordinatingCouncilBOLs = _CoordinatingCouncilBLL.Select(_CoordinatingCouncilBOL);
        //        //CoordinatingCouncilLOV _CoordinatingCouncilLOV = new CoordinatingCouncilLOV();
        //        //if (_CoordinatingCouncilLOV.ShowDialog() == DialogResult.OK)
        //        //{
        //        //    if (_CoordinatingCouncilLOV._CoordinatingCouncilBOL.Id > 0)
        //        //    {
        //        //        councilNameTextBox.Text = string.Format("{0} {1}", _CoordinatingCouncilLOV._CoordinatingCouncilBOL.FirstName, _CoordinatingCouncilLOV._CoordinatingCouncilBOL.LastName);
        //        //        CoordinatingCouncilId = _CoordinatingCouncilLOV._CoordinatingCouncilBOL.Id;
        //        //    }
        //        //}
        //    }
        //    catch (Exception exception)
        //    {
        //        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
        //        noticeLabel.Text = _ExceptionHandlerBOL.Title;
        //    }
        }
        private void sellerLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                LandLordLOV _LandLordLOV = new LandLordLOV();
                if (_LandLordLOV.ShowDialog() == DialogResult.OK)
                {
                    if (_LandLordLOV._LandLordBOL.Id > 0)
                    {
                        SellerManId = _LandLordLOV._LandLordBOL.Id;
                        sellerNameTextBox.Text = string.Format("{0} {1}", _LandLordLOV._LandLordBOL.FirstName, _LandLordLOV._LandLordBOL.LastName);
                        FillEstate(SellerManId);
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void costumerLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                PersonalInfoLOV _PersonalInfoLOV = new PersonalInfoLOV();
                if (_PersonalInfoLOV.ShowDialog() == DialogResult.OK)
                {
                    if (_PersonalInfoLOV._PersonalInfoBOL.Id > 0)
                    {
                        costumerNameTextBox.Text = string.Format("{0} {1}", _PersonalInfoLOV._PersonalInfoBOL.FirstName, _PersonalInfoLOV._PersonalInfoBOL.LastName);
                        CostumerManId = _PersonalInfoLOV._PersonalInfoBOL.Id;
                        TanentFirstName = _PersonalInfoLOV._PersonalInfoBOL.FirstName;
                        TanentLastName = _PersonalInfoLOV._PersonalInfoBOL.LastName;
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillEstate(int? LandLoardId)
        {
            LandLordBOL _LandLordBOL = new LandLordBLL().Select(new LandLordBOL { Id = LandLoardId })[0];
            EstateBOL _EstateBOL = new EstateBOL();
            _EstateBOL = new EstateBLL().Select(new EstateBOL { Id = _LandLordBOL.EstateId })[0];
            titleTextBox.Text = string.Format("کد ملک : {5} آدرس : {0}، کدپستی : {1}، طبقه : {2}، مساحت : {3}، تلفن :{4} ", _EstateBOL.Address, _EstateBOL.ZipCode, _EstateBOL.Floor.ToString(), _EstateBOL.Area.ToString(), _EstateBOL.Phone, _EstateBOL.Name);

        }

        private void prepaymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void LateChargeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void ChargeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void codeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

      

    }
}