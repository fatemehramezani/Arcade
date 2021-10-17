using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    using System.Net;
    using System.IO;
    using BusinessLogicLibrary;

    public partial class ShowSettingUI : Telerik.WinControls.UI.RadForm
    {
        SettingBLL _SettingBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowSettingUI(AccessMode accessMode)
        {
            InitializeComponent();
            _AccessMode = accessMode;
            _SettingBLL = new SettingBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {            
                SettingBOL[] SettingRecords = _SettingBLL.Select();
                SettingDataGridView.Rows.Clear();
                if (SettingRecords != null)
                    for (int index = 0; index < SettingRecords.Length; index++)
                    {
                        SettingDataGridView.Rows.Add(SettingRecords[index].Key, SettingRecords[index].Value);
                        switch (SettingRecords[index].Key)
                        {
                            case "DefaultExceptionTitle":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "عنوان خطای ناشناخته";
                                break;
                            case "DefaultExceptionDescription":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "توضیحات خطای ناشناخته";
                                break;
                            case "DefaultExceptionHelpNote":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "راهنمای خطای ناشناخته";
                                break;
                            case "OfflineExceptionTitle":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "عنوان خطای عدم دسترسی";
                                break;
                            case "OfflineExceptionDescription":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "توضیحات خطای عدم دسترسی";
                                break;
                            case "OfflineExceptionHelpNote":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "راهنمای خطای عدم دسترسی";
                                break;
                            case "ImagePath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس تصاویر";
                                break;
                            case "DatabasePath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس بانک داده";
                                break;
                            case "ServerPath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس سرور";
                                break;
                            case "SentencePath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس فایل جمله روز";
                                break;
                            case "PaperPath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس مقالات";
                                break;
                            case "GalleryPath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس گالری تصاویر";
                                break;
                            case "TempPath":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس موقتی";
                                break;
                            case "Domain":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس دامنه";
                                break;
                            case "UserName":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "نام کاربری";
                                break;
                            case "Password":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "رمز عبور";
                                break;
                            case "ConnectionString":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "رشته اتصال بانک داده";
                                break;
                            case "Email":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "آدرس الکترونیکی";
                                break;
                            case "EmailPassword":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "رمز عبور آدرس الکترونیکی";
                                break;
                            case "SmtpServer":
                                SettingDataGridView.Rows[index].Cells["description"].Value = "سرور آدرس الکترونیکی";
                                break;
                            default:
                                SettingDataGridView.Rows[index].Cells["description"].Value = "ناشناخته";
                                break;
                           
                        }
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void SettingDataGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
        private void ItemSelected(int selectedIndex)
        {
            string key = (SettingDataGridView.Rows[selectedIndex].Cells["key"].Value == null ? null : SettingDataGridView.Rows[selectedIndex].Cells["key"].Value.ToString());
            string value = (SettingDataGridView.Rows[selectedIndex].Cells["value"].Value == null ? null : SettingDataGridView.Rows[selectedIndex].Cells["value"].Value.ToString());
            string description = (SettingDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : SettingDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            SettingBOL _SettingBOL = new SettingBOL(key, value, description);
            new EditSettingUI(_SettingBOL).ShowDialog();
            fillDataGridView();
        }
        private void SettingdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (SettingDataGridView.Rows.Count != 0)
                    ItemSelected(SettingDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void ShowSetting_KeyDown(object sender, KeyEventArgs e)
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