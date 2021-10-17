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
    public partial class ShowInputUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        InputBLL _InputBLL = new InputBLL();
        InputBOL _InputBOL = new InputBOL();
        private void SetResourceManager()
        {

        }
        public ShowInputUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillInputGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillInputGridView()
        {
            landLordGridView.Rows.Clear();
            try
            {
                _InputBOL = new InputBOL();
                InputBOL[] landLordBOLs = _InputBLL.Select(_InputBOL);
                if (landLordBOLs != null)
                    for (int index = 0; index < landLordBOLs.Length; index++)
                        landLordGridView.Rows.Add(landLordBOLs[index].Id, landLordBOLs[index].EstateId, landLordBOLs[index].Title, landLordBOLs[index].EventId, landLordBOLs[index].EventTitle, landLordBOLs[index].Price, landLordBOLs[index].Date,landLordBOLs[index].Description);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void landLordGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (landLordGridView.CurrentRow != null)
                        if (landLordGridView.CurrentRow.Index > -1)
                            if (landLordGridView.CurrentRow.Group == null)
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
                _InputBOL = new InputBOL();
                _InputBOL.Id = DataConvertor.ConvertToInt(landLordGridView.CurrentRow.Cells["Id"].Value);
                _InputBOL.EstateId = DataConvertor.ConvertToInt(landLordGridView.CurrentRow.Cells["EstateId"].Value);
                _InputBOL.Title = DataConvertor.ConvertToString(landLordGridView.CurrentRow.Cells["Title"].Value);
                _InputBOL.EventId = DataConvertor.ConvertToInt(landLordGridView.CurrentRow.Cells["EventId"].Value);
                _InputBOL.EventTitle = DataConvertor.ConvertToString(landLordGridView.CurrentRow.Cells["EventTitle"].Value);
                _InputBOL.Price = DataConvertor.ConvertToDecimal(landLordGridView.CurrentRow.Cells["Price"].Value);
                _InputBOL.Date = DataConvertor.ConvertToDateTime(landLordGridView.CurrentRow.Cells["Date"].Value);
                _InputBOL.Description = DataConvertor.ConvertToString(landLordGridView.CurrentRow.Cells["Description"].Value);
                new EditInputUI(_InputBOL).ShowDialog();
                FillInputGridView();
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
                new EditInputUI().ShowDialog();
                FillInputGridView();
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
