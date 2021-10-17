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

    public partial class EditConstractionUI : RadForm
    {
        private ConstractionBLL _ConstractionBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditConstractionUI()
        {
            InitializeComponent();
            floorNumericUpDown.Enter += setFarsiKeyboard_Enter;
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            floorNumericUpDown.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _ConstractionBLL = new ConstractionBLL();
            getMaxId();
        }
        public EditConstractionUI(ConstractionBOL _ConstractionBOL)
        {
            InitializeComponent();
            floorNumericUpDown.Enter += setFarsiKeyboard_Enter;
            formMode = FormMode.Update;
            floorNumericUpDown.Focus();
            _ConstractionBLL = new ConstractionBLL();
            fillTextBoxes(_ConstractionBOL);
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
            idTextBox.Text = _ConstractionBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(ConstractionBOL _ConstractionBOL)
        {
            idTextBox.Text = _ConstractionBOL.Id.ToString();
            floorNumericUpDown.Text = _ConstractionBOL.UnitNumber.ToString();
           // startPersianDateTimePicker.GeoDate = _ConstractionBOL.StartDate.Value;
            startPersianDateTimePicker.GeoDate = DataConvertor.DataConvertor.ConvertToDateTime(_ConstractionBOL.StartDate);
            deliveryDatePicker.GeoDate = DataConvertor.DataConvertor.ConvertToDateTime(_ConstractionBOL.DeliveryDate);
            ConstractorNameTextBox.Text = DataConvertor.DataConvertor.ConvertToString(_ConstractionBOL.ConstractorName);

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
            int? constractionId;
            try
            {
                constractionId = DataConvertor.DataConvertor.ConvertToInt(idTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }

            DateTime? constractionStartDate;
            try
            {
                constractionStartDate = DataConvertor.DataConvertor.ConvertToDateTime(startPersianDateTimePicker.GeoDate);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            DateTime? constractionDeliveryDate;
            try
            {
                constractionDeliveryDate = DataConvertor.DataConvertor.ConvertToDateTime(deliveryDatePicker.GeoDate);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }

            int? constractionUnitNumber;
            try
            {
                constractionUnitNumber = DataConvertor.DataConvertor.ConvertToInt(floorNumericUpDown.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            
            string constractionName;            
            try
            {
                constractionName= DataConvertor.DataConvertor.ConvertToString(ConstractorNameTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }

            ConstractionBOL _ConstractionBOL = new ConstractionBOL(constractionId,constractionStartDate,constractionDeliveryDate,constractionUnitNumber,null,null,null,constractionName,null);
            if (formMode == FormMode.Insert)
                _ConstractionBLL.Insert(_ConstractionBOL);
            else
                _ConstractionBLL.Update(_ConstractionBOL);
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
                byte? constractionId = DataConvertor.DataConvertor.ConvertToByte(idTextBox.Text);
                ConstractionBOL _ConstractionBOL = new ConstractionBOL(constractionId);
                _ConstractionBLL.Delete(_ConstractionBOL);
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
            if (floorNumericUpDown.Text == null || floorNumericUpDown.Text == string.Empty)
            {
                errorProvider.SetError(floorNumericUpDown, "لطفا تعداد واحدها را وارد کنید");
                floorNumericUpDown.Focus();
                return false;
            }
            return true;
        }
        private void EditConstractionUI_KeyDown(object sender, KeyEventArgs e)
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
