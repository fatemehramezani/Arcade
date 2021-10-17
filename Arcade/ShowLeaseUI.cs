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
    public partial class ShowLeaseUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        LeaseBLL _LeaseBLL = new LeaseBLL();
        LeaseBOL _LeaseBOL = new LeaseBOL();
        private void SetResourceManager()
        {

        }
        public ShowLeaseUI()
        { 
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillLeaseGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillLeaseGridView()
        {
            leaseGridView.Rows.Clear();
            try
            {
                _LeaseBOL = new LeaseBOL();
                LeaseBOL[] leaseBOLs = _LeaseBLL.Select(_LeaseBOL);
                if (leaseBOLs != null)
                    for (int index = 0; index < leaseBOLs.Length; index++)
                        leaseGridView.Rows.Add(leaseBOLs[index].Id, leaseBOLs[index].LandLordId, leaseBOLs[index].LandLordFirstName, leaseBOLs[index].LandLordLastName, leaseBOLs[index].TanentPersonalInfo, leaseBOLs[index].TanentFirstName, leaseBOLs[index].TanentLastName, leaseBOLs[index].Leasehold, leaseBOLs[index].LeaseMounth, leaseBOLs[index].FromDate, leaseBOLs[index].ToDate, leaseBOLs[index].Charge, leaseBOLs[index].LateCharge, leaseBOLs[index].CouncilId, leaseBOLs[index].CouncilFirstName, leaseBOLs[index].CouncilLastName, leaseBOLs[index].JobId, leaseBOLs[index].JobTitle, leaseBOLs[index].PaymentType, leaseBOLs[index].Prepayment, leaseBOLs[index].Witness, leaseBOLs[index].Code, leaseBOLs[index].AmountInWords);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void leaseGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (leaseGridView.CurrentRow != null)
                        if (leaseGridView.CurrentRow.Index > -1)
                            if (leaseGridView.CurrentRow.Group == null)
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

                 
                _LeaseBOL = new LeaseBOL();
                _LeaseBOL.Id = DataConvertor.ConvertToInt(leaseGridView.CurrentRow.Cells["Id"].Value);
                _LeaseBOL.LandLordId = DataConvertor.ConvertToInt(leaseGridView.CurrentRow.Cells["LandLordId"].Value);
                _LeaseBOL.LandLordFirstName = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["LandLordFirstName"].Value);
                _LeaseBOL.LandLordLastName = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["LandLordLastName"].Value);
                _LeaseBOL.TanentPersonalInfo = DataConvertor.ConvertToInt(leaseGridView.CurrentRow.Cells["TanentPersonalInfo"].Value);
                _LeaseBOL.TanentFirstName = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["TanentFirstName"].Value);
                _LeaseBOL.TanentLastName = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["TanentLastName"].Value);
                _LeaseBOL.Leasehold = DataConvertor.ConvertToDecimal(leaseGridView.CurrentRow.Cells["Leasehold"].Value);
                _LeaseBOL.LeaseMounth = DataConvertor.ConvertToByte(leaseGridView.CurrentRow.Cells["LeaseMounth"].Value);
                _LeaseBOL.FromDate = DataConvertor.ConvertToDateTime(leaseGridView.CurrentRow.Cells["FromDate"].Value);
                _LeaseBOL.ToDate = DataConvertor.ConvertToDateTime(leaseGridView.CurrentRow.Cells["ToDate"].Value);
                _LeaseBOL.Charge = DataConvertor.ConvertToDecimal(leaseGridView.CurrentRow.Cells["Charge"].Value);
                _LeaseBOL.LateCharge = DataConvertor.ConvertToDecimal(leaseGridView.CurrentRow.Cells["LateCharge"].Value);
                _LeaseBOL.CouncilId = DataConvertor.ConvertToInt(leaseGridView.CurrentRow.Cells["CouncilId"].Value);
                _LeaseBOL.CouncilFirstName = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["CouncilFirstName"].Value);
                _LeaseBOL.CouncilLastName = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["CouncilLastName"].Value);
                _LeaseBOL.JobId = DataConvertor.ConvertToByte(leaseGridView.CurrentRow.Cells["JobId"].Value);
                _LeaseBOL.JobTitle = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["JobTitle"].Value);
                _LeaseBOL.PaymentType = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["PaymentType"].Value);
                _LeaseBOL.Prepayment = DataConvertor.ConvertToDecimal(leaseGridView.CurrentRow.Cells["Prepayment"].Value);
                _LeaseBOL.Witness = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["Witness"].Value);
                _LeaseBOL.Code = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["Code"].Value);
                _LeaseBOL.AmountInWords = DataConvertor.ConvertToString(leaseGridView.CurrentRow.Cells["AmountInWords"].Value);

                new EditLeaseUI(_LeaseBOL).ShowDialog();
                FillLeaseGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
       
        private void newleaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                new EditLeaseUI().ShowDialog();
                FillLeaseGridView();
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
