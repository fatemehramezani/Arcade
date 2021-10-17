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
    public partial class ShowOutPutUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        OutPutBLL _OutPutBLL = new OutPutBLL();
        OutPutBOL _OutPutBOL = new OutPutBOL();
        private AccessMode accessMode;
        private void SetResourceManager()
        {

        }
        public ShowOutPutUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillOutPutGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

       

        private void FillOutPutGridView()
        {
            outPutGridView.Rows.Clear();
            try
            {
                _OutPutBOL = new OutPutBOL();
                OutPutBOL[] outPutBOLs = _OutPutBLL.Select(_OutPutBOL);
                if (outPutBOLs != null)
                    for (int index = 0; index < outPutBOLs.Length; index++)
                        outPutGridView.Rows.Add(outPutBOLs[index].Id, outPutBOLs[index].EventId, outPutBOLs[index].EventTitle, outPutBOLs[index].Price, DataConvertor.ConvertToPersianDate(outPutBOLs[index].Date), outPutBOLs[index].Description);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void outPutGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (outPutGridView.CurrentRow != null)
                        if (outPutGridView.CurrentRow.Index > -1)
                            if (outPutGridView.CurrentRow.Group == null)
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
                _OutPutBOL = new OutPutBOL();
                _OutPutBOL.Id = DataConvertor.ConvertToInt(outPutGridView.CurrentRow.Cells["Id"].Value);
                _OutPutBOL.EventId = DataConvertor.ConvertToInt(outPutGridView.CurrentRow.Cells["EventId"].Value);
                _OutPutBOL.EventTitle = DataConvertor.ConvertToString(outPutGridView.CurrentRow.Cells["EventTitle"].Value);
                _OutPutBOL.Price = DataConvertor.ConvertToDecimal(outPutGridView.CurrentRow.Cells["Price"].Value);
                _OutPutBOL.Date = DataConvertor.ConvertToDateTime(outPutGridView.CurrentRow.Cells["Date"].Value);
                _OutPutBOL.Description = DataConvertor.ConvertToString(outPutGridView.CurrentRow.Cells["Description"].Value);
                new EditOutPutUI(_OutPutBOL).ShowDialog();
                FillOutPutGridView();
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
                new EditOutPutUI().ShowDialog();
                FillOutPutGridView();
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
