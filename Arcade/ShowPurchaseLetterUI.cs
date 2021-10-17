       
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
    public partial class ShowPurchaseLetterUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        PurchaseLetterBLL _PurchaseLetterBLL = new PurchaseLetterBLL();
        PurchaseLetterBOL _PurchaseLetterBOL = new PurchaseLetterBOL();
        private void SetResourceManager()
        {

        }
        public ShowPurchaseLetterUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillPurchaseLetterGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillPurchaseLetterGridView()
        {
            purchaseLetterGridView.Rows.Clear();
            try
            {
                _PurchaseLetterBOL = new PurchaseLetterBOL();
                PurchaseLetterBOL[] purchaseLetterBOLs = _PurchaseLetterBLL.Select(_PurchaseLetterBOL);
                if (purchaseLetterBOLs != null)
                    for (int index = 0; index < purchaseLetterBOLs.Length; index++)
                    {
                       LandLordBOL _LandLordBOL = new LandLordBLL().Select(new LandLordBOL { Id = purchaseLetterBOLs[index].SellerId })[0];
                        EstateBOL _EstateBOL = new EstateBOL();
                        _EstateBOL = new EstateBLL().Select(new EstateBOL { Id = _LandLordBOL.EstateId })[0];
                        purchaseLetterGridView.Rows.Add(purchaseLetterBOLs[index].Id, purchaseLetterBOLs[index].DeliveryDate, purchaseLetterBOLs[index].Transmiter, purchaseLetterBOLs[index].ContarctDate, purchaseLetterBOLs[index].SellerId, purchaseLetterBOLs[index].SellerFirstName, purchaseLetterBOLs[index].SellerLastName, purchaseLetterBOLs[index].CostumerId, purchaseLetterBOLs[index].CostumerFirstName, purchaseLetterBOLs[index].CostumerLastName, purchaseLetterBOLs[index].Price, purchaseLetterBOLs[index].CouncilId, purchaseLetterBOLs[index].CouncilFirstName, purchaseLetterBOLs[index].CouncilLastName, purchaseLetterBOLs[index].Prepayment, purchaseLetterBOLs[index].TransforRedress, purchaseLetterBOLs[index].CommitmentRedress, purchaseLetterBOLs[index].WitnessName1, purchaseLetterBOLs[index].WitnessName2,purchaseLetterBOLs[index].Code, purchaseLetterBOLs[index].AmountInWords, purchaseLetterBOLs[index].CheckNumbers,string.Format("آدرس : {0}، کدپستی : {1}، طبقه : {2}، مساحت : {3}، تلفن :{4} ", _EstateBOL.Address, _EstateBOL.ZipCode, _EstateBOL.Floor.ToString(), _EstateBOL.Area.ToString(), _EstateBOL.Phone));
            
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void purchaseLetterGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (purchaseLetterGridView.CurrentRow != null)
                        if (purchaseLetterGridView.CurrentRow.Index > -1)
                            if (purchaseLetterGridView.CurrentRow.Group == null)
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
                _PurchaseLetterBOL = new PurchaseLetterBOL();
                _PurchaseLetterBOL.Id = DataConvertor.ConvertToInt(purchaseLetterGridView.CurrentRow.Cells["Id"].Value);
                _PurchaseLetterBOL.DeliveryDate = DataConvertor.ConvertToDateTime(purchaseLetterGridView.CurrentRow.Cells["DeliveryDate"].Value);
               _PurchaseLetterBOL.Transmiter = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["Transmiter"].Value);
                _PurchaseLetterBOL.ContarctDate = DataConvertor.ConvertToDateTime(purchaseLetterGridView.CurrentRow.Cells["ContarctDate"].Value);
                _PurchaseLetterBOL.SellerId = DataConvertor.ConvertToInt(purchaseLetterGridView.CurrentRow.Cells["SellerId"].Value);
                _PurchaseLetterBOL.SellerFirstName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["SellerFirstName"].Value);
                _PurchaseLetterBOL.SellerLastName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["SellerLastName"].Value);
                _PurchaseLetterBOL.CostumerId = DataConvertor.ConvertToInt(purchaseLetterGridView.CurrentRow.Cells["CostumerId"].Value);
                _PurchaseLetterBOL.CostumerFirstName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CostumerFirstName"].Value);
                _PurchaseLetterBOL.CostumerLastName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CostumerLastName"].Value);
                _PurchaseLetterBOL.Price = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["Price"].Value);
                _PurchaseLetterBOL.CouncilId = DataConvertor.ConvertToInt(purchaseLetterGridView.CurrentRow.Cells["CouncilId"].Value);
                _PurchaseLetterBOL.CouncilFirstName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CouncilFirstName"].Value);
                _PurchaseLetterBOL.CouncilLastName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CouncilLastName"].Value);
                _PurchaseLetterBOL.Prepayment = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["Prepayment"].Value);
                _PurchaseLetterBOL.TransforRedress = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["TransforRedress"].Value);
                _PurchaseLetterBOL.CommitmentRedress = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["CommitmentRedress"].Value);
                _PurchaseLetterBOL.WitnessName1 = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["WitnessName1"].Value);
                _PurchaseLetterBOL.WitnessName2 = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["WitnessName2"].Value);
               _PurchaseLetterBOL.Code = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["Code"].Value);
                _PurchaseLetterBOL.AmountInWords = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["AmountInWords"].Value);
                _PurchaseLetterBOL.CheckNumbers = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CheckNumbers"].Value);

                new EditPurchaseLetterUI(_PurchaseLetterBOL).ShowDialog();
                FillPurchaseLetterGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
       
        private void newPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                new EditPurchaseLetterUI().ShowDialog();
                FillPurchaseLetterGridView();
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
