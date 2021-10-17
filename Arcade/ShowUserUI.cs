using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;


    public partial class ShowUserUI : Telerik.WinControls.UI.RadForm
    {
        UserBLL _UserBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public ShowUserUI()
        {
            InitializeComponent();
            _UserBLL = new UserBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                UserBOL[] _UserBOLs = _UserBLL.Select();
                usersDataGridView.Rows.Clear();
                for (int index = 0; index < _UserBOLs.Length; index++)
                    usersDataGridView.Rows.Add(_UserBOLs[index].UserId, _UserBOLs[index].UserName, _UserBOLs[index].Password, _UserBOLs[index].Description);
                usersDataGridView.Focus();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void newUserButton_Click(object sender, EventArgs e)
        {
            new EditUserUI().ShowDialog();
            fillDataGridView();
        }
        private void usersDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            noticeLabel.Text = string.Empty;
            if (e.RowIndex != -1)
                ItemSelected(e.RowIndex);
        }
        private void ItemSelected(int selectedIndex)
        {
            short userId = Convert.ToInt16(usersDataGridView.Rows[selectedIndex].Cells["userId"].Value);
            string userName = usersDataGridView.Rows[selectedIndex].Cells["userName"].Value.ToString();
            string description = (usersDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? string.Empty : usersDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            UserBOL _UserBOL = new UserBOL(userId, userName, null, null, description);
            new EditUserUI(_UserBOL).ShowDialog();
            fillDataGridView();
        }
        private void usersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (usersDataGridView.Rows.Count != 0)
                    ItemSelected(usersDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void ShowUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
            noticeLabel.Text = string.Empty;
        }
    }
}