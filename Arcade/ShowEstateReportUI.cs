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

    public partial class ShowEstateReportUI : RadForm
    {
        EstateReportBLL _EstateReportBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowEstateReportUI(AccessMode accessMode)
        {
            InitializeComponent();
            Telerik.WinControls.UI.Localization.RadGridResLocalizationProvider.CurrentProvider = new Localization.CustomGridViewLocalizationProvider();
            newEstateReportButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _EstateReportBLL = new EstateReportBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            EstateReportBOL _EstateReportBOL = new EstateReportBOL();
            try
            {
                DataTable EstateReportRecords = _EstateReportBLL.Select(_EstateReportBOL);
                estateReportDataGridView.Rows.Clear();
                if (EstateReportRecords != null)
                    //for (int index = 0; index < EstateReportRecords.Length; index++)
                    estateReportDataGridView.DataSource = EstateReportRecords;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EstateReportDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                if (e.RowIndex != -1 && _AccessMode == AccessMode.Complete)
                    //ItemSelected(e.RowIndex);
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
                decimal? Price= DataConvertor.DataConvertor.ConvertToDecimal(estateReportDataGridView.Rows[selectedIndex].Cells["Price"].Value);
                string Title = DataConvertor.DataConvertor.ConvertToString(estateReportDataGridView.Rows[selectedIndex].Cells["Title"].Value);
                string Description = DataConvertor.DataConvertor.ConvertToString(estateReportDataGridView.Rows[selectedIndex].Cells["Descrtiption"].Value);
                string FirsName = DataConvertor.DataConvertor.ConvertToString(estateReportDataGridView.Rows[selectedIndex].Cells["FirstName"].Value);
                string LastNAme = DataConvertor.DataConvertor.ConvertToString(estateReportDataGridView.Rows[selectedIndex].Cells["LastName"].Value);
                string Name = DataConvertor.DataConvertor.ConvertToString(estateReportDataGridView.Rows[selectedIndex].Cells["Name"].Value);
                DateTime? Date= DataConvertor.DataConvertor.ConvertToDateTime(estateReportDataGridView.Rows[selectedIndex].Cells["Date"].Value);
                EstateReportBOL _EstateReportBOL = new EstateReportBOL(Price, Title, Date, FirsName, LastNAme, Name, Description);
                //new EditEstateReportUI(_EstateReportBOL).ShowDialog();
                fillDataGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EstateReportdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (estateReportDataGridView.Rows.Count != 0)
                    ItemSelected(estateReportDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newEstateReportButton_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable reportTable = new DataTable();
                
                foreach (GridViewDataColumn column in this.estateReportDataGridView.Columns)
                    reportTable.Columns.Add(column.UniqueName, column.DataType);
                foreach (GridViewDataRowInfo row in this.estateReportDataGridView.SelectedRows)
                {
                    DataRow dataRow = reportTable.NewRow();
                    foreach (DataColumn dataColumn in reportTable.Columns)
                        dataRow[dataColumn] = row.Cells[dataColumn.ColumnName].Value;
                    reportTable.Rows.Add(dataRow);
                }
                for (int i = 0; i < this.estateReportDataGridView.ColumnCount; i++)
                    reportTable.Columns[i].ColumnName = this.estateReportDataGridView.Columns[i].HeaderText;
                FastReport.Report report = new FastReport.Report();
                report.Load("ReportState.frx");
                report.Dictionary.Connections[0].ConnectionString = ServerBLL.ConnectionStrings();
                report.RegisterData(reportTable, "arcadeAdmin_reportEstate");
              //  report.Design(this.MdiParent);
                report.Show();
            }
            catch (Exception exception)
            {
                ExceptionHandlerBOL _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                if (_ExceptionHandlerBOL != null)
                    new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            }
            //new EditEstateReportUI().ShowDialog();
            //fillDataGridView();
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
        private void ShowEstateReportUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
    }
}
