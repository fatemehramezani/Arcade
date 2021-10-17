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

    public partial class EditCheckUI : RadForm
    {
        private CheckBLL _CheckBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        public int? IdText;
        public string NumberText;
        public string AccountNumberText;
        public string PriceText;
        public string ForwhomText;
        public string BankNameText;
        public string AccountNameText;
        public DateTime? DateCheck;
        public EditCheckUI()
        {
            InitializeComponent();
            NumberTextBox.Enter += setFarsiKeyboard_Enter;
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            NumberTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _CheckBLL = new CheckBLL();
            getMaxId();
        }
        public EditCheckUI(CheckBOL _CheckBOL)
        {
            InitializeComponent();
            NumberTextBox.Enter += setFarsiKeyboard_Enter;
            formMode = FormMode.Update;
            NumberTextBox.Focus();
            _CheckBLL = new CheckBLL();
            fillTextBoxes(_CheckBOL);
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
            idTextBox.Text = _CheckBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(CheckBOL _CheckBOL)
        {
            idTextBox.Text = _CheckBOL.Id.ToString();
            NumberTextBox.Text = _CheckBOL.Number;
            checkAccountNametextbox.Text = _CheckBOL.AccountName;
            chekAccountNumberTextBox.Text = _CheckBOL.AccountNumber;
            if (_CheckBOL.Price.ToString().LastIndexOf('.') > 0)
                PriceNumericUpDown.Text = _CheckBOL.Price.ToString().Remove(_CheckBOL.Price.ToString().LastIndexOf('.'));
            else
                PriceNumericUpDown.Text = _CheckBOL.Price.ToString();
            ForWhoTextBox.Text = _CheckBOL.ForWhom;
            BankNameTextBox.Text = _CheckBOL.BankName;
            checkPersianDateTimePicker.GeoDate=DataConvertor.DataConvertor.ConvertToDateTime(_CheckBOL.Date);

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
                IdText = DataConvertor.DataConvertor.ConvertToInt(idTextBox.Text);
                NumberText = NumberTextBox.Text;
                AccountNumberText = chekAccountNumberTextBox.Text;
                DateCheck =checkPersianDateTimePicker.GeoDate;
                PriceText = PriceNumericUpDown.Text;
                ForwhomText = ForWhoTextBox.Text;
                BankNameText = BankNameTextBox.Text;
                AccountNameText = checkAccountNametextbox.Text;
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
            int? Id;
            try
            {
                Id = DataConvertor.DataConvertor.ConvertToInt(idTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string CheckNumber = NumberTextBox.Text;
            string CheckAccountNumber = chekAccountNumberTextBox.Text;
            string CheckAccountName = checkAccountNametextbox.Text;
            string BankName=BankNameTextBox.Text;
            string ForWho=ForWhoTextBox.Text;
            DateTime? Date;
            try
            {
                Date = DataConvertor.DataConvertor.ConvertToDateTime(checkPersianDateTimePicker.GeoDate);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }

            decimal? Price;
            try
            {
                Price = DataConvertor.DataConvertor.ConvertToDecimal(PriceNumericUpDown.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            CheckBOL _CheckBOL = new CheckBOL(Id, CheckNumber, CheckAccountNumber, Date, CheckAccountName, Price,BankName,ForWho);////////////////////////////////////
            if (formMode == FormMode.Insert)
                _CheckBLL.Insert(_CheckBOL);
            else
                _CheckBLL.Update(_CheckBOL);
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
                int? Id = DataConvertor.DataConvertor.ConvertToInt(idTextBox.Text);
                CheckBOL _CheckBOL = new CheckBOL(Id);
                _CheckBLL.Delete(_CheckBOL);
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
            if (NumberTextBox.Text == null || NumberTextBox.Text == string.Empty)
            {
                errorProvider.SetError(NumberTextBox, "لطفا شماره چک را وارد کنید");
                NumberTextBox.Focus();
                return false;
            }
            return true;
        }
        private void EditCheckUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }

        private void EditCheckUI_Load(object sender, EventArgs e)
        {

        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void chekAccountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void PriceNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
