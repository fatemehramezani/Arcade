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
    public partial class EditPurchaseLetterUI : Telerik.WinControls.UI.RadForm
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
         private AccessMode _AccessMode;

        CoordinatingCouncilBLL _CoordinatingCouncilBLL = new CoordinatingCouncilBLL();
        CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        PurchaseLetterBOL _PurchaseLetterBOL = new PurchaseLetterBOL();
        PurchaseLetterBLL _PurchaseLetterBLL = new PurchaseLetterBLL();
        JobBOL _JobBOL;
        JobBLL _JobBLL = new JobBLL();
        public EditPurchaseLetterUI()
        {
            try
            {
                InitializeComponent();
                ComboBoxBind();
                contarctPersianDateTimePicker.GeoDate = DateTime.Today;
                _FormMode = FormMode.Insert;
                SetPurchaseLetterUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_PurchaseLetterBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private string SetTransmiter()
        {
            string Transmitters = string.Empty;
            //List<PatientDiseasesBOL> _PatientDiseasesBOLs = new List<PatientDiseasesBOL>();
            IEnumerator _IEnumerator = transmiterCheckedListBox.CheckedItems.GetEnumerator();
            while (_IEnumerator.MoveNext() != false)
            {
                short? TransmiterId = DataConvertor.ConvertToShort(((ListItem)_IEnumerator.Current).Id);
                Transmitters += string.Format("{0}{1}", TransmiterId.ToString(), spliter[0]);
                //_PatientDiseasesBOLs.Add(new PatientDiseasesBOL(DiseasesId, _PatientBOL.PatientId));
            }
            return Transmitters;
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
        public EditPurchaseLetterUI(PurchaseLetterBOL purchaseLetterBOL)
        {
            try
            {
                InitializeComponent();
                _PurchaseLetterBOL = purchaseLetterBOL;
                SetPurchaseLetterUpdateVisibility(true);
                SellerManId = _PurchaseLetterBOL.SellerId;
                CostumerManId = _PurchaseLetterBOL.CostumerId;
                CoordinatingCouncilId = _PurchaseLetterBOL.CouncilId;
                ComboBoxBind();                
                LoadPurchaseLetter(_PurchaseLetterBOL);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadPurchaseLetter(PurchaseLetterBOL _PurchaseLetterBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetPurchaseLetterUpdateVisibility(true);
                LoadPurchaseLetter();
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
               TransmitterCheckedListBoxBind();

            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void TransmiterBind()
        {
            

                string transmiter = _PurchaseLetterBOL.Transmiter;
                if (transmiter != string.Empty && transmiter != null)
                {
                    string[] sponsorSet = transmiter.Split(spliter[0]);
                    if (sponsorSet.Length > 0)
                    {

                        int indexOfItem = -1;
                        foreach (string item in sponsorSet)
                            if (item != string.Empty && item != null)
                            {
                                ListItem _ListItem = new ListItem(DataConvertor.ConvertToShort(item), string.Empty);
                                indexOfItem = CheckBoxListSelectedIndex(transmiterCheckedListBox, _ListItem);
                                if (indexOfItem > -1)
                                    transmiterCheckedListBox.SetItemChecked(indexOfItem, true);
                            }

                    }
                }
            
        }
        private void TransmitterCheckedListBoxBind()
        {
            try
            {
                RoleTypeBOL _RoleTypeBOL = new RoleTypeBOL();
                RoleTypeBOL[] _RoleTypeBOLs = new RoleTypeBLL().Select(_RoleTypeBOL);
                transmiterCheckedListBox.Items.Clear();
                if (_RoleTypeBOLs != null)
                    for (int index = 0; index < _RoleTypeBOLs.Length; index++)
                    {
                        transmiterCheckedListBox.Items.Add(new ListItem(_RoleTypeBOLs[index].Id, _RoleTypeBOLs[index].Title), false);
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
        private void EditPurchaseLetterUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }




        #region PurchaseLetter
        private void LoadPurchaseLetter()
        {
            try
            {

                PurchaseLetterLOV _PurchaseLetterLov = new PurchaseLetterLOV();
                idTextBox.Text = _PurchaseLetterBOL.Id.ToString();
                priceTextBox.Text = _PurchaseLetterBOL.Price. ToString().Remove(_PurchaseLetterBOL.Price.ToString().LastIndexOf('.'));
                codeTextBox.Text = _PurchaseLetterBOL.Code;
                costumerNameTextBox.Text = string.Format("{0} {1}", _PurchaseLetterBOL.CostumerFirstName, _PurchaseLetterBOL.CostumerLastName);
                sellerNameTextBox.Text = string.Format("{0} {1}", _PurchaseLetterBOL.SellerFirstName, _PurchaseLetterBOL.SellerLastName);
                councilNameTextBox.Text = string.Format("{0}", _PurchaseLetterBOL.CouncilFirstName);
                prepaymentTextBox.Text = _PurchaseLetterBOL.Prepayment.ToString().Remove(_PurchaseLetterBOL.Prepayment.ToString().LastIndexOf('.'));
                amountInWordsTextBox.Text = _PurchaseLetterBOL.AmountInWords;
                transforRedressTextBox.Text = _PurchaseLetterBOL.TransforRedress.ToString().Remove(_PurchaseLetterBOL.TransforRedress.ToString().LastIndexOf('.'));
                commitmentRedressTextBox.Text = _PurchaseLetterBOL.CommitmentRedress.ToString().Remove(_PurchaseLetterBOL.CommitmentRedress.ToString().LastIndexOf('.'));
                witness1TextBox.Text = _PurchaseLetterBOL.WitnessName1;
                witness2TextBox.Text = _PurchaseLetterBOL.WitnessName2;
              //  ListItem _EstateListItem = new ListItem(_PurchaseLetterBOL.EstateId, _PurchaseLetterBOL.Title);
                TransmiterBind();
                CheckBind();
                if (_PurchaseLetterBOL.ContarctDate == null || _PurchaseLetterBOL.ContarctDate == DateTime.MinValue)
                    ((MaskedTextBox)contarctPersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)contarctPersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                contarctPersianDateTimePicker.GeoDate = (DateTime)_PurchaseLetterBOL.ContarctDate;

                if (_PurchaseLetterBOL.DeliveryDate == null || _PurchaseLetterBOL.DeliveryDate == DateTime.MinValue)
                    ((MaskedTextBox)deliveryPersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)deliveryPersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();
                else
                    deliveryPersianDateTimePicker.GeoDate = (DateTime)_PurchaseLetterBOL.DeliveryDate;
                FillEstate(_PurchaseLetterBOL.SellerId);
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
        private void SetPurchaseLetterUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;
                ////transforRedressTextBox.Text = costumerNameTextBox.Text = sellerNameTextBox.Text = prepaymentTextBox.Text  = landlordIdTextBox.Text = witness2TextBox.Text = witness1TextBox.Text = commitmentRedressTextBox.Text = string.Empty;
                ((MaskedTextBox)deliveryPersianDateTimePicker.Controls[1]).Text = ((MaskedTextBox)contarctPersianDateTimePicker.Controls[1]).TextMaskFormat.ToString();

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
                        InsertPurchaseLetter();
                }
                else
                {
                    if (DialogResult.OK == _JntMsgBoxFarsi.Show("آیا میخواهید این عملیات را لغو کنید؟", InsertText, JntStyle.OkCancel))
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
        private void InsertPurchaseLetter()
        {
            try
            {
                _PurchaseLetterBOL.Id = new PurchaseLetterBLL().SelectMaxId();
                _PurchaseLetterBOL.Prepayment =DataConvertor.ConvertToDecimal (prepaymentTextBox.Text);
                _PurchaseLetterBOL.TransforRedress =DataConvertor.ConvertToDecimal ( transforRedressTextBox.Text);
                _PurchaseLetterBOL.WitnessName1 = witness1TextBox.Text;
                _PurchaseLetterBOL.CostumerId = CostumerManId;
                _PurchaseLetterBOL.SellerId = SellerManId;
                _PurchaseLetterBOL.AmountInWords = amountInWordsTextBox.Text;
                _PurchaseLetterBOL.CouncilId = CoordinatingCouncilId;
                _PurchaseLetterBOL.Code = codeTextBox.Text;
                _PurchaseLetterBOL.Price = DataConvertor.ConvertToDecimal(priceTextBox.Text);
                _PurchaseLetterBOL.Transmiter = SetTransmiter();
                _PurchaseLetterBOL.CheckNumbers = string.Empty;
                _PurchaseLetterBOL.CommitmentRedress=DataConvertor.ConvertToDecimal(commitmentRedressTextBox.Text);
                for (int i=0; i<checkGridView.Rows.Count; i++)
                {
                    string Id = DataConvertor.ConvertToString(checkGridView.Rows[i].Cells["Id"].Value);
                    _PurchaseLetterBOL.CheckNumbers += Id + ';';
                }
                //if(checkGridView.Rows.Count>0)
                   // _PurchaseLetterBOL.CheckId = DataConvertor.ConvertToInt(checkGridView.Rows[0].Cells["Id"].Value);

                _PurchaseLetterBOL.ContarctDate = DataConvertor.ConvertToDateTime(contarctPersianDateTimePicker.GeoDate);
                _PurchaseLetterBOL.DeliveryDate = DataConvertor.ConvertToDateTime(deliveryPersianDateTimePicker.GeoDate);
                _PurchaseLetterBOL.WitnessName2 = witness2TextBox.Text;
                if (DialogResult.OK == _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel))
                {
                    _PurchaseLetterBLL.Insert(_PurchaseLetterBOL);
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
                    UpdatePurchaseLetter();
            }
        }
        private void UpdatePurchaseLetter()
        {

            try
            {
                _PurchaseLetterBOL.WitnessName1 = witness1TextBox.Text;
                _PurchaseLetterBOL.CostumerId = CostumerManId;
                _PurchaseLetterBOL.CouncilId = CoordinatingCouncilId;
                _PurchaseLetterBOL.Code = codeTextBox.Text;
                _PurchaseLetterBOL.Price = DataConvertor.ConvertToDecimal(priceTextBox.Text);
                _PurchaseLetterBOL.SellerId = SellerManId;
                _PurchaseLetterBOL.Prepayment = DataConvertor.ConvertToDecimal(prepaymentTextBox.Text);
                _PurchaseLetterBOL.TransforRedress = DataConvertor.ConvertToDecimal(transforRedressTextBox.Text);
                _PurchaseLetterBOL.WitnessName1 = witness1TextBox.Text;
                _PurchaseLetterBOL.Transmiter = SetTransmiter();
                _PurchaseLetterBOL.AmountInWords = amountInWordsTextBox.Text;
                _PurchaseLetterBOL.CommitmentRedress = DataConvertor.ConvertToDecimal(commitmentRedressTextBox.Text);
                _PurchaseLetterBOL.ContarctDate = DataConvertor.ConvertToDateTime(contarctPersianDateTimePicker.GeoDate);
                _PurchaseLetterBOL.DeliveryDate = DataConvertor.ConvertToDateTime(deliveryPersianDateTimePicker.GeoDate);
                _PurchaseLetterBOL.WitnessName2 = witness2TextBox.Text;
                _PurchaseLetterBOL.CheckNumbers = string.Empty;
                if (checkGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < checkGridView.Rows.Count; i++)
                    {
                        string Id = DataConvertor.ConvertToString(checkGridView.Rows[i].Cells["Id"].Value);
                        _PurchaseLetterBOL.CheckNumbers += Id + ';';
                    }
                }
                    _PurchaseLetterBLL.Update(_PurchaseLetterBOL);
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
                DeletePurchaseLetter();
        }
        private void DeletePurchaseLetter()
        {
            try
            {
                _PurchaseLetterBLL.Delete(_PurchaseLetterBOL);
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
            if (string.IsNullOrEmpty(councilNameTextBox.Text))
            {
                errorProvider.SetError(councilNameTextBox, "لطفا نام ونام خانوداگی را وارد کنید");
                councilNameTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prepaymentTextBox.Text))
            {
                errorProvider.SetError(prepaymentTextBox, "لطفا پیش پرداخت را وارد کنید");
                prepaymentTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                errorProvider.SetError(priceTextBox, "لطفا قیمت را وارد کنید");
                priceTextBox.Focus();
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
                        councilNameTextBox.Text = string.Format("{0}", _CoordinatingCouncilLOV._CoordinatingCouncilBOL.FirstName);
                        CoordinatingCouncilId = _CoordinatingCouncilLOV._CoordinatingCouncilBOL.Id;
                    }
                }
            }
            //try
            //{

            //    //CoordinatingCouncilLOV _CoordinatingCouncilLOV = new CoordinatingCouncilLOV();
            //    //if (_CoordinatingCouncilLOV.ShowDialog() == DialogResult.OK)
            //    //{
            //    CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
            //    CoordinatingCouncilBOL[] _CoordinatingCouncilBOLs = _CoordinatingCouncilBLL.Select(_CoordinatingCouncilBOL);
            //        if (_CoordinatingCouncilBOLs.Length > 0)
            //        {
            //            councilNameTextBox.Text = string.Empty;
            //            foreach (CoordinatingCouncilBOL item in _CoordinatingCouncilBOLs)
            //            {
            //                councilNameTextBox.Text += string.Format("{0} {1} | ", item.FirstName, item.LastName);
            //                CoordinatingCouncilId += item.Id.ToString();
            //            }
            //        }
            //    //}
            //}
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            EditCheckUI Check = new EditCheckUI();
            Check.ShowDialog();
            if(Check.IdText!=null)
                checkGridView.Rows.Add(Check.IdText, Check.NumberText, Check.AccountNumberText, Check.DateCheck, Check.AccountNameText, Check.BankNameText, Check.ForwhomText, Check.PriceText);

        }
        private void checkGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                if (e.RowIndex != -1)
                    ItemSelected(e.RowIndex);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ItemSelected(int selectedIndex)
        {
            try
            {
                int? Id = DataConvertor.ConvertToInt(checkGridView.Rows[selectedIndex].Cells["Id"].Value);
                string Number = DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["Number"].Value);
                string AccountNumber = DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["AccountNumber"].Value);
                DateTime? Date = DataConvertor.ConvertToDateTime(checkGridView.Rows[selectedIndex].Cells["Date"].Value);
                string AccountName = DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["AccountName"].Value);
                decimal? Price = DataConvertor.ConvertToDecimal(checkGridView.Rows[selectedIndex].Cells["Price"].Value);
                string BankName = DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["BankName"].Value);
                string ForWhom = DataConvertor.ConvertToString(checkGridView.Rows[selectedIndex].Cells["ForWhom"].Value);
                CheckBOL _CheckBOL = new CheckBOL(Id, Number, AccountNumber, Date, AccountName, Price, BankName, ForWhom);
                new EditCheckUI(_CheckBOL).ShowDialog();
                LoadPurchaseLetter();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CheckBind()
        {
            checkGridView.Rows.Clear();
            CheckBLL _CheckBLL=new CheckBLL();
            string CheckId = _PurchaseLetterBOL.CheckNumbers;
            if (CheckId != string.Empty && CheckId != null)
            {
                string[] sponsorSet = CheckId.Split(spliter[0]);
                if (sponsorSet.Length > 0)
                {

                    foreach (string item in sponsorSet)
                        if (item != string.Empty && item != null)
                        {
                            CheckBOL _CheckBOL=new CheckBOL();
                            _CheckBOL.Id = DataConvertor.ConvertToInt(item);
                            CheckBOL[] _CheckBOLs = _CheckBLL.Select(_CheckBOL);
                            if(_CheckBOLs!=null)
                            {
                                for (int index = 0; index < _CheckBOLs.Length; index++)
                                    checkGridView.Rows.Add(_CheckBOLs[index].Id, _CheckBOLs[index].Number, _CheckBOLs[index].AccountNumber, _CheckBOLs[index].Date, _CheckBOLs[index].AccountName, _CheckBOLs[index].BankName, _CheckBOLs[index].ForWhom, _CheckBOLs[index].Price);
                            }
                        }

                }
            }

        }

        //private void CouncilBind()
        //{

        //    CoordinatingCouncilBLL _CoordinatingCouncilBLL = new CoordinatingCouncilBLL();
        //    string CouncilId = _PurchaseLetterBOL.CouncilId;
        //    if (CouncilId != string.Empty && CouncilId != null)
        //    {
        //        string[] sponsorSet = CouncilId.Split(spliter[0]);
        //        if (sponsorSet.Length > 0)
        //        {

        //            foreach (string item in sponsorSet)
        //                if (item != string.Empty && item != null)
        //                {
        //                    CoordinatingCouncilBOL _CoordinatinCouncilBOL = new CoordinatingCouncilBOL();
        //                    _CoordinatinCouncilBOL.Id = DataConvertor.ConvertToInt(item);
        //                    CoordinatingCouncilBOL[] _CoordinatingCouncilBOLs = _CoordinatingCouncilBLL.Select(_CoordinatinCouncilBOL);
        //                    if (_CoordinatingCouncilBOLs != null)
        //                    {
        //                      //  for (int index = 0; index < _CoordinatingCouncilBOLs.Length; index++)
        //                           // checkGridView.Rows.Add(_CoordinatingCouncilBOLs[index].Id, _CoordinatingCouncilBOLs[index].FirstName, _CoordinatingCouncilBOLs[index].LastName, _CoordinatingCouncilBOLs[index].FatherName, _CoordinatingCouncilBOLs[index].MembershipDate, _CoordinatingCouncilBOLs[index].NationalCode, _CoordinatingCouncilBOLs[index].QuitDate);
        //                    }
        //                }

        //        }
        //    }

        //}
        private void FillEstate(int? LandLoardId)
        {
            LandLordBOL _LandLordBOL = new LandLordBLL().Select(new LandLordBOL { Id = LandLoardId })[0];
            EstateBOL _EstateBOL = new EstateBOL();
            _EstateBOL = new EstateBLL().Select(new EstateBOL { Id = _LandLordBOL.EstateId })[0];
            string phone ;
            if (_EstateBOL.Phone == null)
                phone = "تلفن :";
            else
                phone = "";
            titleTextBox.Text = string.Format("کد ملک: {0} ، آدرس:{1} ، کد پستی: {2} ، طبقه : {3} مساحت : {4} {5}", _EstateBOL.Name, _EstateBOL.Address, _EstateBOL.ZipCode, _EstateBOL.Floor.ToString(), _EstateBOL.Area.ToString(), _EstateBOL.Phone, phone);
            
        }

        private void prepaymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void commitmentRedressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

       
        
    }
}