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
    public partial class LandLordLOV : Telerik.WinControls.UI.RadForm
    {

        public LandLordBOL _LandLordBOL = new LandLordBOL();
        private LandLordBLL _LandLordBLL = new LandLordBLL();
        public int? LandLordId;
        public string LandLordName;

        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public LandLordLOV()
        {
            InitializeComponent();
            FillLandLordGridView();
            acceptButton.Visible = false;

        }
        public LandLordLOV(LandLordBOL _LandLordBOL)
        {
            InitializeComponent();
          //  FillLandLordGridView(_LandLordBOL);
            acceptButton.Visible = false;

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
                        landLordGridView.Rows.Add(landLordBOLs[index].Id, landLordBOLs[index].PersonalInfoId, landLordBOLs[index].FirstName, landLordBOLs[index].LastName, landLordBOLs[index].Share, landLordBOLs[index].EstateId, landLordBOLs[index].Title, landLordBOLs[index].Type);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        //private void FillLandLordGridView(LandLordBOL _LandLordBOL)
        //{
        //    landLordGridView.Rows.Clear();
        //    try
        //    {
        //        _LandLordBOL = new LandLordBOL();
        //        LandLordBOL[] landLordBOLs = _LandLordBLL.SelectLandlord(_LandLordBOL);
        //        if (landLordBOLs != null)
        //            for (int index = 0; index < landLordBOLs.Length; index++)
        //                landLordGridView.Rows.Add(landLordBOLs[index].Id, landLordBOLs[index].PersonalInfoId, landLordBOLs[index].FirstName, landLordBOLs[index].LastName, landLordBOLs[index].Share, landLordBOLs[index].EstateId, landLordBOLs[index].Title, landLordBOLs[index].Type);
        //    }
        //    catch (Exception exception)
        //    {
        //        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
        //        noticeLabel.ForeColor = Color.Red;
        //        noticeLabel.Text = _ExceptionHandlerBOL.Title;
        //    }
        //}
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
        private void landLordDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
        private void LandLordLOV_Load(object sender, EventArgs e)
        {
            FillLandLordGridView();
        }
        private void LandLordLOV_KeyDown(object sender, KeyEventArgs e)
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
                nameTextBox.Text = string.Format("{0} {1}", _LandLordBOL.FirstName, _LandLordBOL.LastName);
                    acceptButton.Visible = true;
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

        private void acceptButton_Click_1(object sender, EventArgs e)
        {

        }

    }
}



