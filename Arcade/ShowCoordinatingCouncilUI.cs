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
    public partial class ShowCoordinatingCouncilUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        CoordinatingCouncilBLL _CoordinatingCouncilBLL = new CoordinatingCouncilBLL();
        CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        private void SetResourceManager()
        {

        }
        public ShowCoordinatingCouncilUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillCoordinatingCouncilGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillCoordinatingCouncilGridView()
        {
            coordinatingCouncilGridView.Rows.Clear();
            try
            {
                _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
                CoordinatingCouncilBOL[] coordinatingCouncilBOLs = _CoordinatingCouncilBLL.Select(_CoordinatingCouncilBOL);
                if (coordinatingCouncilBOLs != null)
                    for (int index = 0; index < coordinatingCouncilBOLs.Length; index++)
                        coordinatingCouncilGridView.Rows.Add(coordinatingCouncilBOLs[index].Id, coordinatingCouncilBOLs[index].FirstName, coordinatingCouncilBOLs[index].LastName, coordinatingCouncilBOLs[index].FatherName, coordinatingCouncilBOLs[index].MembershipDate, coordinatingCouncilBOLs[index].NationalCode, coordinatingCouncilBOLs[index].QuitDate);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void coordinatingCouncilGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (coordinatingCouncilGridView.CurrentRow != null)
                        if (coordinatingCouncilGridView.CurrentRow.Index > -1)
                            if (coordinatingCouncilGridView.CurrentRow.Group == null)
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
                _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
                _CoordinatingCouncilBOL.Id = DataConvertor.ConvertToInt(coordinatingCouncilGridView.CurrentRow.Cells["Id"].Value);
                _CoordinatingCouncilBOL.FirstName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["FirstName"].Value);
                _CoordinatingCouncilBOL.LastName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["LastName"].Value);
                _CoordinatingCouncilBOL.FatherName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["FatherName"].Value);
                _CoordinatingCouncilBOL.MembershipDate = DataConvertor.ConvertToDateTime(coordinatingCouncilGridView.CurrentRow.Cells["MembershipDate"].Value);
                _CoordinatingCouncilBOL.NationalCode = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["NationalCode"].Value);
                _CoordinatingCouncilBOL.QuitDate = DataConvertor.ConvertToDateTime(coordinatingCouncilGridView.CurrentRow.Cells["QuitDate"].Value);
               
                new EditCoordinatingCouncilUI(_CoordinatingCouncilBOL).ShowDialog();
                FillCoordinatingCouncilGridView();
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
                new EditCoordinatingCouncilUI().ShowDialog();
                FillCoordinatingCouncilGridView();
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
