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
    public partial class PurchaseLetterLOV : Telerik.WinControls.UI.RadForm
    {

        public PurchaseLetterBOL _PurchaseLetterBOL = new PurchaseLetterBOL();
        private PurchaseLetterBLL _PurchaseLetterBLL = new PurchaseLetterBLL();
        public byte? Id;
        public string name;

        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public PurchaseLetterLOV()
        {
            InitializeComponent();
            FillPurchaseLetterGridView();
            acceptButton.Visible = false;

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
                        purchaseLetterGridView.Rows.Add(purchaseLetterBOLs[index].Id, purchaseLetterBOLs[index].DeliveryDate, purchaseLetterBOLs[index].Transmiter, purchaseLetterBOLs[index].ContarctDate, purchaseLetterBOLs[index].SellerId, purchaseLetterBOLs[index].SellerFirstName, purchaseLetterBOLs[index].SellerLastName, purchaseLetterBOLs[index].CostumerId, purchaseLetterBOLs[index].CostumerFirstName, purchaseLetterBOLs[index].CostumerLastName, purchaseLetterBOLs[index].Price, purchaseLetterBOLs[index].CouncilId, purchaseLetterBOLs[index].CouncilFirstName, purchaseLetterBOLs[index].CouncilLastName, purchaseLetterBOLs[index].Prepayment, purchaseLetterBOLs[index].TransforRedress, purchaseLetterBOLs[index].CommitmentRedress, purchaseLetterBOLs[index].WitnessName1, purchaseLetterBOLs[index].WitnessName2, purchaseLetterBOLs[index].Code);
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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            ItemSelected();
            this.Close();
        }
        private void purchaseLetterDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                ItemSelected();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void PurchaseLetterLOV_Load(object sender, EventArgs e)
        {
            FillPurchaseLetterGridView();
        }
        private void PurchaseLetterLOV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void ItemSelected()
        {
            if (purchaseLetterGridView.CurrentRow.Index > -1)
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
                _PurchaseLetterBOL.CouncilId= DataConvertor.ConvertToInt(purchaseLetterGridView.CurrentRow.Cells["CouncilId"].Value);
                _PurchaseLetterBOL.CouncilFirstName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CouncilFirstName"].Value);
                _PurchaseLetterBOL.CouncilLastName = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["CouncilLastName"].Value);
                _PurchaseLetterBOL.Prepayment = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["Prepayment"].Value);
                _PurchaseLetterBOL.TransforRedress = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["TransforRedress"].Value);
                _PurchaseLetterBOL.CommitmentRedress = DataConvertor.ConvertToDecimal(purchaseLetterGridView.CurrentRow.Cells["CommitmentRedress"].Value);
                _PurchaseLetterBOL.WitnessName1 = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["WitnessName1"].Value);
                _PurchaseLetterBOL.WitnessName2 = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["WitnessName2"].Value);
                //_PurchaseLetterBOL.EstateId = DataConvertor.ConvertToInt(purchaseLetterGridView.CurrentRow.Cells["EstateId"].Value);
                //_PurchaseLetterBOL.Title = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["Title"].Value);
                _PurchaseLetterBOL.Code = DataConvertor.ConvertToString(purchaseLetterGridView.CurrentRow.Cells["Code"].Value);
                 codeTextBox.Text = string.Format("{0} {1}", _PurchaseLetterBOL.Code,DataConvertor.ConvertToPersianDate( _PurchaseLetterBOL.ContarctDate));
                    acceptButton.Visible = true;
               

            }
        }

        private void PurchaseLetterLOV_Load_1(object sender, EventArgs e)
        {

        }

        

        
       

    }
}



