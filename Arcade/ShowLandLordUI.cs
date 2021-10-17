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
    public partial class ShowLandLordUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        LandLordBLL _LandLordBLL = new LandLordBLL();
        LandLordBOL _LandLordBOL = new LandLordBOL();
        private void SetResourceManager()
        {

        }
        public ShowLandLordUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillLandLordGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillLandLordGridView()
        {
            landLordGridView.Rows.Clear();
            try
            {
                _LandLordBOL = new LandLordBOL();
                _LandLordBOL.IsLandLord = true;
                LandLordBOL[] landLordBOLs = _LandLordBLL.Select(_LandLordBOL);
                if (landLordBOLs != null)
                    for (int index = 0; index < landLordBOLs.Length; index++)
                        landLordGridView.Rows.Add(landLordBOLs[index].Id, landLordBOLs[index].PersonalInfoId, landLordBOLs[index].FirstName, landLordBOLs[index].LastName, landLordBOLs[index].Share, landLordBOLs[index].EstateId, landLordBOLs[index].Title,landLordBOLs[index].Type,landLordBOLs[index].IsLandLord);
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
                _LandLordBOL = new LandLordBOL();
                _LandLordBOL.Id = DataConvertor.ConvertToInt(landLordGridView.CurrentRow.Cells["Id"].Value);
                _LandLordBOL.PersonalInfoId = DataConvertor.ConvertToInt(landLordGridView.CurrentRow.Cells["PersonalInfoId"].Value);
                _LandLordBOL.FirstName = DataConvertor.ConvertToString(landLordGridView.CurrentRow.Cells["FirstName"].Value);
                _LandLordBOL.LastName = DataConvertor.ConvertToString(landLordGridView.CurrentRow.Cells["LastName"].Value);
                _LandLordBOL.Share = DataConvertor.ConvertToByte(landLordGridView.CurrentRow.Cells["Share"].Value);
                _LandLordBOL.EstateId = DataConvertor.ConvertToInt(landLordGridView.CurrentRow.Cells["EstateId"].Value);
                _LandLordBOL.Title = DataConvertor.ConvertToString(landLordGridView.CurrentRow.Cells["Title"].Value);
                _LandLordBOL.Type = DataConvertor.ConvertToBoolean(landLordGridView.CurrentRow.Cells["Type"].Value);
                _LandLordBOL.IsLandLord = DataConvertor.ConvertToBoolean(landLordGridView.CurrentRow.Cells["IsLandLord"].Value);


                
                new EditLandLordUI(_LandLordBOL).ShowDialog();
                FillLandLordGridView();
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
                new EditLandLordUI().ShowDialog();
                FillLandLordGridView();
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
