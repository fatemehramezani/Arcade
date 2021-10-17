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
    public partial class CoordinatingCouncilLOV : Telerik.WinControls.UI.RadForm
    {

        public CoordinatingCouncilBOL _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
        public CoordinatingCouncilBOL[] CoordinatingCouncilBOLs;//= new CoordinatingCouncilBOL();
        private CoordinatingCouncilBLL _CoordinatingCouncilBLL = new CoordinatingCouncilBLL();
        public byte? Id;
        public string name;

        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public CoordinatingCouncilLOV()
        {
            InitializeComponent();
            FillCoordinatingCouncilGridView();
           // acceptButton.Visible = false;

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
        private void coordinatingCouncilDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
        private void CoordinatingCouncilLOV_Load(object sender, EventArgs e)
        {
            FillCoordinatingCouncilGridView();
        }
        private void CoordinatingCouncilLOV_KeyDown(object sender, KeyEventArgs e)
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
            if (coordinatingCouncilGridView.CurrentRow.Index > -1)
            {

                _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
                _CoordinatingCouncilBOL.Id = DataConvertor.ConvertToInt(coordinatingCouncilGridView.CurrentRow.Cells["Id"].Value);
                _CoordinatingCouncilBOL.FirstName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["FirstName"].Value);
                _CoordinatingCouncilBOL.LastName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["LastName"].Value);
                _CoordinatingCouncilBOL.FatherName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["FatherName"].Value);
                _CoordinatingCouncilBOL.MembershipDate = DataConvertor.ConvertToDateTime(coordinatingCouncilGridView.CurrentRow.Cells["MembershipDate"].Value);
                _CoordinatingCouncilBOL.NationalCode = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["NationalCode"].Value);
                _CoordinatingCouncilBOL.QuitDate = DataConvertor.ConvertToDateTime(coordinatingCouncilGridView.CurrentRow.Cells["QuitDate"].Value);
                 nameTextBox.Text = string.Format("{0} {1}", _CoordinatingCouncilBOL.FirstName, _CoordinatingCouncilBOL.LastName);
                    acceptButton.Visible = true;
            }
        }




        private void acceptButton_Click_1(object sender, EventArgs e)
        {
            _CoordinatingCouncilBOL = new CoordinatingCouncilBOL();
            _CoordinatingCouncilBOL.Id = DataConvertor.ConvertToInt(coordinatingCouncilGridView.CurrentRow.Cells["Id"].Value);
            _CoordinatingCouncilBOL.FirstName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["FirstName"].Value);
            _CoordinatingCouncilBOL.LastName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["LastName"].Value);
            _CoordinatingCouncilBOL.FatherName = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["FatherName"].Value);
            _CoordinatingCouncilBOL.MembershipDate = DataConvertor.ConvertToDateTime(coordinatingCouncilGridView.CurrentRow.Cells["MembershipDate"].Value);
            _CoordinatingCouncilBOL.NationalCode = DataConvertor.ConvertToString(coordinatingCouncilGridView.CurrentRow.Cells["NationalCode"].Value);
            _CoordinatingCouncilBOL.QuitDate = DataConvertor.ConvertToDateTime(coordinatingCouncilGridView.CurrentRow.Cells["QuitDate"].Value);
            nameTextBox.Text = string.Format("{0} {1}", _CoordinatingCouncilBOL.FirstName, _CoordinatingCouncilBOL.LastName);
            acceptButton.Visible = true;
        }

        
       

    }
}



