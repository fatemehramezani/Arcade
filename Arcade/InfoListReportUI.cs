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
    public partial class InfoListReportUI : Telerik.WinControls.UI.RadForm
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        PersonalInfoBLL _PersonalInfoBLL = new PersonalInfoBLL();
        PersonalInfoBOL _PersonalInfoBOL = new PersonalInfoBOL();
        private void SetResourceManager()
        {

        }
        public InfoListReportUI()
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
            personalInfoGridView.Rows.Clear();
            try
            {
                personalInfoGridView.Rows.Clear();
                personalInfoGridView.GridElement.BeginUpdate();
                personalInfoGridView.DataSource = _PersonalInfoBLL.SelectReport();
                if (personalInfoGridView.DataSource == null)
                    return;
                personalInfoGridView.Columns["Id داوطلب"].IsVisible = false;
                personalInfoGridView.Columns["شماره شناسنامه"].IsVisible = false;
                personalInfoGridView.Columns["سریال شناسنامه"].IsVisible = false;
                personalInfoGridView.Columns["محل صدور"].IsVisible = false;
                personalInfoGridView.Columns["محل تولد"].IsVisible = false;
                personalInfoGridView.Columns["تاریخ تولد"].IsVisible = false;
                personalInfoGridView.Columns["جنسیت"].IsVisible = false;
                personalInfoGridView.Columns["تعداد عائله"].IsVisible = false;
                personalInfoGridView.Columns["عکس داوطلب"].IsVisible = false;
                personalInfoGridView.Columns["وضعیت تأهل"].IsVisible = false;
                personalInfoGridView.Columns["تاریخ بازرسی"].IsVisible = false;
                personalInfoGridView.Columns["شماره نامه"].IsVisible = false;
                personalInfoGridView.Columns["تاریخ نامه"].IsVisible = false;
                foreach (GridViewDataColumn column in personalInfoGridView.Columns)
                {
                    column.Width = Math.Max(100, column.HeaderText.Length * 8 + 10);
                    if (Regex.IsMatch(column.Name, "^[a-zA-Z0-9]*$") || column.HeaderText.Contains("شناسه"))
                        column.IsVisible = false;
                    column.AllowFiltering = true;
                }
                personalInfoGridView.GridElement.EndUpdate();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void personalInfoGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                    if (personalInfoGridView.CurrentRow != null)
                        if (personalInfoGridView.CurrentRow.Index > -1)
                            if (personalInfoGridView.CurrentRow.Group == null)
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
                _PersonalInfoBOL = new PersonalInfoBOL();
                _PersonalInfoBOL.Id = DataConvertor.ConvertToInt(personalInfoGridView.CurrentRow.Cells["Id"].Value);
                _PersonalInfoBOL.FirstName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["FirstName"].Value);
                _PersonalInfoBOL.LastName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["LastName"].Value);
                _PersonalInfoBOL.FatherName = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["FatherName"].Value);
                _PersonalInfoBOL.NationalCode = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["NationalCode"].Value);
                _PersonalInfoBOL.Certificate = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Certificate"].Value);
                _PersonalInfoBOL.SerialNumber = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["SerialNumber"].Value);
                _PersonalInfoBOL.IssuancePlace = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["IssuancePlace"].Value);
                _PersonalInfoBOL.BirthPlace = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["BirthPlace"].Value);
                _PersonalInfoBOL.Birthday = DataConvertor.ConvertToDateTime(personalInfoGridView.CurrentRow.Cells["Birthday"].Value);
                _PersonalInfoBOL.IsMale = DataConvertor.ConvertToBoolean(personalInfoGridView.CurrentRow.Cells["IsMale"].Value);
                _PersonalInfoBOL.MaritalStatusId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["MaritalStatusId"].Value);
                _PersonalInfoBOL.MaritalStatusTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["MaritalStatusTitle"].Value);            
                _PersonalInfoBOL.ChildrenCount = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["ChildrenCount"].Value);
                _PersonalInfoBOL.Phone = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Phone"].Value);
                _PersonalInfoBOL.Mobile = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["Mobile"].Value);
                _PersonalInfoBOL.DegreeId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["DegreeId"].Value);
                _PersonalInfoBOL.DegreeTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["DegreeTitle"].Value);
                _PersonalInfoBOL.MilitaryStatusId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["MilitaryStatusId"].Value);
                _PersonalInfoBOL.MilitaryStatusTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["MilitaryStatusTitle"].Value);
                _PersonalInfoBOL.SkillDate = DataConvertor.ConvertToDateTime(personalInfoGridView.CurrentRow.Cells["SkillDate"].Value);
                _PersonalInfoBOL.IsSupported = DataConvertor.ConvertToBoolean(personalInfoGridView.CurrentRow.Cells["IsSupported"].Value);
                _PersonalInfoBOL.InsuranceNumber = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["InsuranceNumber"].Value);
                _PersonalInfoBOL.InsuranceStatusId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["InsuranceStatusId"].Value);
                _PersonalInfoBOL.InsuranceStatusTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["InsuranceStatusTitle"].Value);
                _PersonalInfoBOL.ConfirmationId = DataConvertor.ConvertToByte(personalInfoGridView.CurrentRow.Cells["ConfirmationId"].Value);
                _PersonalInfoBOL.ConfirmationTitle = DataConvertor.ConvertToString(personalInfoGridView.CurrentRow.Cells["ConfirmationTitle"].Value);
                if (personalInfoGridView.CurrentRow.Cells["Image"].Value != null)
                {
                    byte[] image = ImageToByte((Bitmap)personalInfoGridView.CurrentRow.Cells["Image"].Value);
                    _PersonalInfoBOL.Image = image;
                }
                else
                    _PersonalInfoBOL.Image = null;
                new EditPersonalInfoUI(_PersonalInfoBOL).ShowDialog();
                FillPersonalInfoGridView();
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

                DataTable reportTable = new DataTable();
                foreach (GridViewDataColumn column in this.personalInfoGridView.Columns)
                    reportTable.Columns.Add(column.UniqueName, column.DataType);
                foreach (GridViewDataRowInfo row in this.personalInfoGridView.SelectedRows)
                {
                    DataRow dataRow = reportTable.NewRow();
                    foreach (DataColumn dataColumn in reportTable.Columns)
                        dataRow[dataColumn] = row.Cells[dataColumn.ColumnName].Value;
                    reportTable.Rows.Add(dataRow);
                }
                for (int i = 0; i < this.personalInfoGridView.ColumnCount; i++)
                    reportTable.Columns[i].ColumnName = this.personalInfoGridView.Columns[i].HeaderText;
                FastReport.Report report = new FastReport.Report();
                report.Load("etehadieh - List.frx");
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

        private void personalInfoGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
