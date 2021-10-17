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
    using System.Text.RegularExpressions;
    public partial class PersonalInfoReportUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        private void SetResourceManager()
        {

        }
        public PersonalInfoReportUI()
        {
            try
            {
                InitializeComponent();
                RadGridLocalizationProvider.CurrentProvider = new CustomGridViewLocalizationProvider();
                SetResourceManager();
                FillPersonalInfoGridView();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillPersonalInfoGridView()
        {
            reportGridView.Rows.Clear();
            try
            {
                reportGridView.Rows.Clear();
                reportGridView.GridElement.BeginUpdate();
                reportGridView.DataSource = new PersonalInfoBLL().SelectReport();
                if (reportGridView.DataSource == null)
                    return;
                reportGridView.Columns["Id داوطلب"].IsVisible = false;
                reportGridView.Columns["شماره شناسنامه"].IsVisible = false;
                reportGridView.Columns["سریال شناسنامه"].IsVisible = false;
                reportGridView.Columns["محل صدور"].IsVisible = false;
                reportGridView.Columns["محل تولد"].IsVisible = false;
                reportGridView.Columns["تاریخ تولد"].IsVisible = false;
                reportGridView.Columns["جنسیت"].IsVisible = false;
                reportGridView.Columns["تعداد عائله"].IsVisible = false;
                reportGridView.Columns["عکس داوطلب"].IsVisible = false;
                reportGridView.Columns["وضعیت تأهل"].IsVisible = false;
                reportGridView.Columns["تاریخ بازرسی"].IsVisible = false;
                reportGridView.Columns["شماره نامه"].IsVisible = false;
                reportGridView.Columns["تاریخ نامه"].IsVisible = false;
                foreach (GridViewDataColumn column in reportGridView.Columns)
                {
                    column.Width = Math.Max(100, column.HeaderText.Length * 8 + 10);
                    if (Regex.IsMatch(column.Name, "^[a-zA-Z0-9]*$") || column.HeaderText.Contains("شناسه"))
                        column.IsVisible = false;
                    column.AllowFiltering = true;
                }
                reportGridView.GridElement.EndUpdate();

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

                DataTable reportTable = new DataTable();
                foreach (GridViewDataColumn column in this.reportGridView.Columns)
                    reportTable.Columns.Add(column.UniqueName, column.DataType);
                foreach (GridViewDataRowInfo row in this.reportGridView.SelectedRows)
                {
                    DataRow dataRow = reportTable.NewRow();
                    foreach (DataColumn dataColumn in reportTable.Columns)
                        dataRow[dataColumn] = row.Cells[dataColumn.ColumnName].Value;
                    reportTable.Rows.Add(dataRow);
                }
                for (int i = 0; i < this.reportGridView.ColumnCount; i++)
                    reportTable.Columns[i].ColumnName = this.reportGridView.Columns[i].HeaderText;
                FastReport.Report report = new FastReport.Report();
                report.Load("etehadieh.frx");
                report.Dictionary.Connections[0].ConnectionString = ServerBLL.GetConnectionStrings();
                report.RegisterData(reportTable, "ReportPersonalInfo");
                //report.Design(this.MdiParent);
                report.Show();
            }
            catch (Exception exception)
            {
                ExceptionHandlerBOL _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                if (_ExceptionHandlerBOL != null)
                    new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
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

        private void reportGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
