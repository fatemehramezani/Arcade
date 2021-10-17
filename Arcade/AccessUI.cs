using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    using BusinessObjectLayer;
    using JntMsgBox;
    using ComplexDataType;
    using System.Resources;
    using System.Reflection;
    using BusinessLogicLayer;
    using DataConvertor;
    using Telerik.WinControls.UI;

    public partial class AccessUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        RoleBOL _RoleBOL = new RoleBOL();
        RoleBLL _RoleBLL = new RoleBLL();
        SecurityBOL _SecurityBOL = new SecurityBOL();
        SecurityBLL _SecurityBLL = new SecurityBLL();
        bool cellValueChanged = false;
        public AccessUI()
        {
            InitializeComponent();
        }
        private void FillAccessDropDown()
        {
            try
            {
                DataTable _DataTable = AccessBLL.SelectComboBox();
                ((GridViewComboBoxColumn)securityGridEX.Columns["Access"]).DataSource = _DataTable;
                ((GridViewComboBoxColumn)securityGridEX.Columns["Access"]).DisplayMember = "AccessTitle";
                ((GridViewComboBoxColumn)securityGridEX.Columns["Access"]).ValueMember = "AccessTitle";
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void FillRoleGridEX()
        {
            try
            {
                roleGridEX.Rows.Clear();
                RoleBOL[] _RoleBOL = _RoleBLL.Select();
                if (_RoleBOL != null)
                    for (int index = 0; index < _RoleBOL.Length; index++)
                        roleGridEX.Rows.Add(_RoleBOL[index].RoleId, _RoleBOL[index].RoleTitle, _RoleBOL[index].Description);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void roleGridEX_SelectionChanged(object sender, EventArgs e)
        {
            _SecurityBOL.RoleId = (short)DataConvertor.ConvertToShort(roleGridEX.CurrentRow.Cells["ROLEID"].Value);
            FillSecurityGridEX();
        }
        private void FillSecurityGridEX()
        {
            securityGridEX.Rows.Clear();
            try
            {
                SecurityBOL[] _SecurityBOLs = _SecurityBLL.Select(_SecurityBOL);
                if (_SecurityBOL != null)
                    for (int index = 0; index < _SecurityBOLs.Length; index++)
                        securityGridEX.Rows.Add(_SecurityBOLs[index].PageId, _SecurityBOLs[index].PageTitle, _SecurityBOLs[index].AccessId, _SecurityBOLs[index].AccessTitle);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void AccessUI_Load(object sender, EventArgs e)
        {
            try
            {
                FillRoleGridEX();
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
        private void securityGridEX_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            cellValueChanged = true;
        }
        private void AccessUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }

        private void securityGridEX_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (cellValueChanged && e.Column.Name == "Access")
                {
                    //securityGridEX.SetValue("AccessID", securityGridEX.GetValue(e.Column));
                    //securityGridEX.SetValue("AccessTitle", securityGridEX.GetValue(e.Column));
                    _SecurityBOL.AccessId = Convert.ToInt16(securityGridEX.CurrentRow.Cells["AccessID"].Value);
                    _SecurityBOL.PageId = Convert.ToInt16(securityGridEX.CurrentRow.Cells["PageID"].Value);
                    _SecurityBLL.InsertUpdate(_SecurityBOL);
                    cellValueChanged = false;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void securityGridEX_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            try
            {
                if (((GridViewComboBoxColumn)securityGridEX.Columns["Access"]).DataSource == null)
                    FillAccessDropDown();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
    }
}
