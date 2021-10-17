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
    public partial class ShowEstateUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        EstateBLL _EstateBLL = new EstateBLL();
        EstateBOL _EstateBOL = new EstateBOL();
        private AccessMode accessMode;
        private void SetResourceManager()
        {

        }
        public ShowEstateUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillEstateGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

       

        private void FillEstateGridView()
        {
            estateGridView.Rows.Clear();
            try
            {
                _EstateBOL = new EstateBOL();
                EstateBOL[] estateBOLs = _EstateBLL.Select(_EstateBOL);
                if (estateBOLs != null)
                    for (int index = 0; index < estateBOLs.Length; index++)
                        estateGridView.Rows.Add(estateBOLs[index].Id, estateBOLs[index].ZipCode, estateBOLs[index].Area, estateBOLs[index].Facilities, estateBOLs[index].Floor, estateBOLs[index].Address, estateBOLs[index].Phone, estateBOLs[index].EstateTypeId, estateBOLs[index].EstateTypeTitle, estateBOLs[index].Name);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void estateGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (estateGridView.CurrentRow != null)
                        if (estateGridView.CurrentRow.Index > -1)
                            if (estateGridView.CurrentRow.Group == null)
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
                _EstateBOL = new EstateBOL();
                _EstateBOL.Id = DataConvertor.ConvertToInt(estateGridView.CurrentRow.Cells["Id"].Value);
                _EstateBOL.ZipCode = DataConvertor.ConvertToString(estateGridView.CurrentRow.Cells["ZipCode"].Value);
                _EstateBOL.Area = DataConvertor.ConvertToInt(estateGridView.CurrentRow.Cells["Area"].Value);
                _EstateBOL.Facilities = DataConvertor.ConvertToString(estateGridView.CurrentRow.Cells["Facilities"].Value);
                _EstateBOL.Floor = DataConvertor.ConvertToByte(estateGridView.CurrentRow.Cells["Floor"].Value);
                _EstateBOL.Address = DataConvertor.ConvertToString(estateGridView.CurrentRow.Cells["Address"].Value);
                _EstateBOL.Phone = DataConvertor.ConvertToString(estateGridView.CurrentRow.Cells["Phone"].Value);
                _EstateBOL.EstateTypeId = DataConvertor.ConvertToByte(estateGridView.CurrentRow.Cells["EstateTypeId"].Value);
                _EstateBOL.EstateTypeTitle = DataConvertor.ConvertToString(estateGridView.CurrentRow.Cells["EstateTypeTitle"].Value);
                _EstateBOL.Name = DataConvertor.ConvertToString(estateGridView.CurrentRow.Cells["Name"].Value);

                new EditEstateUI(_EstateBOL).ShowDialog();
                FillEstateGridView();
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
                new EditEstateUI().ShowDialog();
                FillEstateGridView();
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
