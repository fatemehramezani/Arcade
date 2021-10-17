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
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    using Telerik.WinControls.UI;
    
    public partial class ShowBasisUI : RadForm
    {

       // BasisBLL _BasisBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowBasisUI(AccessMode accessMode)
        {
            InitializeComponent();
            
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newBasisButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
           // _BasisBLL = new BasisBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            
            try
            {
                ////ArcadeEntities _ArcadeEntities = new ArcadeEntities();
                //BasisDataGridView.Rows.Clear();

                //_ArcadeEntities.Bases.Load(); 
                //BasisDataGridView.DataSource = _ArcadeEntities.Bases.Local.ToBindingList();
                ////for (int i = 0; i < _ArcadeEntities.Bases.ToList().Count; i++)
                ////   BasisDataGridView.Rows.Add(_ArcadeEntities.Bases.Local[0].Id, _ArcadeEntities.Bases.Local[0].Price);
                    
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void BasisDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                if (e.RowIndex != -1 && _AccessMode == AccessMode.Complete)
                    ItemSelected(e.RowIndex);
                if (_AccessMode != AccessMode.Complete)
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
        private void ItemSelected(int selectedIndex)
        {
            try
            {
                byte? Id = DataConvertor.DataConvertor.ConvertToByte(BasisDataGridView.Rows[selectedIndex].Cells["Id"].Value);
                string Title = DataConvertor.DataConvertor.ConvertToString(BasisDataGridView.Rows[selectedIndex].Cells["Title"].Value );

                //BasisBOL _BasisBOL = new BasisBOL(Id, Title);
            //    new EditBasisUI(_BasisBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void BasisdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (BasisDataGridView.Rows.Count != 0)
                    ItemSelected(BasisDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newBasisButton_Click(object sender, EventArgs e)
        {
            //new EditBasisUI().ShowDialog();
            fillDataGridView();
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

        private void ShowBasisUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
