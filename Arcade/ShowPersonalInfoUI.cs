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
    using DataConvertor;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using BusinessLogicLayer;
    using System.Diagnostics;
    using System.Security.AccessControl;
    using Telerik.WinControls.UI;
    using Telerik.WinControls.UI.Localization;
    using UserInterface.Localization;
    using BusinessObjectLayer;
    using System.Resources;
    using System.Reflection;
    public partial class ShowPersonalInfoUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        PersonalInfoBLL _PersonalInfoBLL = new PersonalInfoBLL();
        PersonalInfoBOL _PersonalInfoBOL = new PersonalInfoBOL();
        private void SetResourceManager()
        {

        }
        public ShowPersonalInfoUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillPersonalInfoGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillPersonalInfoGridView()
        {
            personalInfoGridView.Rows.Clear();
            try
            {
                _PersonalInfoBOL = new PersonalInfoBOL();
                PersonalInfoBOL[] personalInfoBOLs = _PersonalInfoBLL.Select(_PersonalInfoBOL);
                if (personalInfoBOLs != null)
                    for (int index = 0; index < personalInfoBOLs.Length; index++)
                        personalInfoGridView.Rows.Add(personalInfoBOLs[index].Id, personalInfoBOLs[index].FirstName, personalInfoBOLs[index].LastName, personalInfoBOLs[index].FatherName, personalInfoBOLs[index].NationalCode, personalInfoBOLs[index].Cetificate, personalInfoBOLs[index].IssuancePlace, personalInfoBOLs[index].BirthPlace, personalInfoBOLs[index].Birthday == null ? string.Empty : DataConvertor.ConvertToPersianDate(personalInfoBOLs[index].Birthday), personalInfoBOLs[index].IsMale, personalInfoBOLs[index].MaritalStatuseId, personalInfoBOLs[index].MaritalStatuseTitle, personalInfoBOLs[index].Phone, personalInfoBOLs[index].Mobile, personalInfoBOLs[index].Image, personalInfoBOLs[index].MilitaryStatuseId, personalInfoBOLs[index].MilitaryStatuseTitle, personalInfoBOLs[index].Address, personalInfoBOLs[index].JobId, personalInfoBOLs[index].JobTitle, personalInfoBOLs[index].CompanyName, personalInfoBOLs[index].CompanyAddress, personalInfoBOLs[index].CompanyPhone, personalInfoBOLs[index].IsLegal, personalInfoBOLs[index].ZipeCode);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void personalInfoGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (personalInfoGridView.CurrentRow != null)
                        if (personalInfoGridView.CurrentRow.Index > -1)
                            if (personalInfoGridView.CurrentRow.Group == null)
                            {
                                ItemSelected();
                            }
                
                else
                {
                    _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                    noticeLabel.ForeColor = Color.Red;
                    noticeLabel.Text = _ExceptionHandlerBOL.Title;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void ItemSelected()
        {
            try
            {
                _PersonalInfoBOL = new PersonalInfoBOL();
                _PersonalInfoBOL.Id = DataConvertor.ConvertToInt(personalInfoGridView.CurrentRow.Cells["Id"].Value);
                _PersonalInfoBOL.FirstName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["FirstName"].Value);
                _PersonalInfoBOL.LastName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["LastName"].Value);
                _PersonalInfoBOL.FatherName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["FatherName"].Value);
                _PersonalInfoBOL.NationalCode = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["NationalCode"].Value);
                _PersonalInfoBOL.Cetificate = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Cetificate"].Value);
                _PersonalInfoBOL.IssuancePlace = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["IssuancePlace"].Value);
                _PersonalInfoBOL.BirthPlace = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["BirthPlace"].Value);
                _PersonalInfoBOL.Birthday = DataConvertor.ConvertToDateTime(personalInfoGridView.CurrentRow.Cells["Birthday"].Value);
                _PersonalInfoBOL.IsMale = DataConvertor.ConvertToBoolean(personalInfoGridView.CurrentRow.Cells["IsMale"].Value);
                _PersonalInfoBOL.MaritalStatuseId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["MaritalStatuseId"].Value);
                _PersonalInfoBOL.MaritalStatuseTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["MaritalStatuseTitle"].Value);            
                _PersonalInfoBOL.Phone = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Phone"].Value);
                _PersonalInfoBOL.Mobile = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Mobile"].Value);
                _PersonalInfoBOL.MilitaryStatuseId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["MilitaryStatuseId"].Value);
                _PersonalInfoBOL.MilitaryStatuseTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["MilitaryStatuseTitle"].Value);
                _PersonalInfoBOL.Address = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Address"].Value);
                _PersonalInfoBOL.JobId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["JobId"].Value);
                _PersonalInfoBOL.JobTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["JobTitle"].Value);
                _PersonalInfoBOL.CompanyName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["CompanyName"].Value);
                _PersonalInfoBOL.CompanyAddress = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["CompanyAddress"].Value);
                _PersonalInfoBOL.CompanyPhone = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["CompanyPhone"].Value);
                _PersonalInfoBOL.IsLegal = DataConvertor.ConvertToBoolean(personalInfoGridView.CurrentRow.Cells["IsLegal"].Value);
                _PersonalInfoBOL.ZipeCode = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["ZipeCode"].Value);

                if (personalInfoGridView.CurrentRow.Cells["Image"].Value != null)
                {
                    byte[] image = ImageToByte((Bitmap)personalInfoGridView.CurrentRow.Cells["Image"].Value);
                    _PersonalInfoBOL.Image = image;
                }
                else
                    _PersonalInfoBOL.Image = null;
                new EditPersonalInfoUI(_PersonalInfoBOL).ShowDialog();
                FillPersonalInfoGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void newPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                new EditPersonalInfoUI().ShowDialog();
                FillPersonalInfoGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
    }
}
