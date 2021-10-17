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
    public partial class CheckLOV : Telerik.WinControls.UI.RadForm
    {

        public CheckBOL _CheckBOL = new CheckBOL();
        private CheckBLL _CheckBLL = new CheckBLL();
        public byte? Id;
        public string name;

        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public CheckLOV()
        {
            InitializeComponent();
            FillCheckGridView();
            acceptButton.Visible = false;

        }
        private void FillCheckGridView()
        {
            checkGridView.Rows.Clear();
            try
            {
                _CheckBOL = new CheckBOL();
                CheckBOL[] checkBOLs = _CheckBLL.Select(_CheckBOL);
                if (checkBOLs != null)
                    for (int index = 0; index < checkBOLs.Length; index++)
                        checkGridView.Rows.Add(checkBOLs[index].Id, checkBOLs[index].Number, checkBOLs[index].AccountNumber, checkBOLs[index].Date, checkBOLs[index].AccountName, checkBOLs[index].BankName, checkBOLs[index].ForWhom, checkBOLs[index].Price);
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
        private void checkDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
        private void CheckLOV_Load(object sender, EventArgs e)
        {
            FillCheckGridView();
        }
        private void CheckLOV_KeyDown(object sender, KeyEventArgs e)
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
            if (checkGridView.CurrentRow.Index > -1)
            {

                _CheckBOL = new CheckBOL();
                _CheckBOL.Id = DataConvertor.ConvertToInt(checkGridView.CurrentRow.Cells["Id"].Value);
                _CheckBOL.Number = DataConvertor.ConvertToString(checkGridView.CurrentRow.Cells["Number"].Value);
                _CheckBOL.AccountNumber = DataConvertor.ConvertToString(checkGridView.CurrentRow.Cells["AccountNumber"].Value);
                _CheckBOL.Date = DataConvertor.ConvertToDateTime(checkGridView.CurrentRow.Cells["Date"].Value);
                _CheckBOL.AccountName = DataConvertor.ConvertToString(checkGridView.CurrentRow.Cells["AccountName"].Value);
                _CheckBOL.BankName = DataConvertor.ConvertToString(checkGridView.CurrentRow.Cells["BankName"].Value);
                _CheckBOL.ForWhom = DataConvertor.ConvertToString(checkGridView.CurrentRow.Cells["ForWhom"].Value);
               
                  nameTextBox.Text = string.Format("{0} {1} {2} {3}", _CheckBOL.Number, _CheckBOL.AccountNumber, DataConvertor.ConvertToPersianDate( _CheckBOL.Date), _CheckBOL.ForWhom);
                    acceptButton.Visible = true;
               

            }
        }

        
       

    }
}



