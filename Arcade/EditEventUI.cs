using System;
using System.Drawing;
using System.Windows.Forms;
using ComplexDataType;
using System.Resources;
using BusinessObjectLayer;
using System.Reflection;
using BusinessLogicLayer;
using JntMsgBox;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Security.AccessControl;

namespace UserInterface
{
    using DataConvertor;
    using Telerik.WinControls.UI;
    using BusinessObjectLayer;
    public partial class EditEventUI : Telerik.WinControls.UI.RadForm
    {
        FormMode _FormMode = FormMode.Insert;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        string CancelText;
        string UpdateText;
        string InsertText;
        char[] spliter = { ';', ':' };
        string DeleteText;
        string AccessText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        string AccessConfirmation;
        string Successed;
        private AccessMode _AccessMode;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        EventBOL _EventBOL = new EventBOL();
        EventBLL _EventBLL = new EventBLL();
        public EditEventUI()
        {
            try
            {
                InitializeComponent();
                SetResourceManager();
                _FormMode = FormMode.Insert;
                SetEventUpdateVisibility(false);
                idTextBox.Text = DataConvertor.ConvertToString(_EventBLL.SelectMaxId());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private int CheckBoxListSelectedIndex(CheckedListBox _CheckedListBox, ListItem _ListItem)
        {
            for (int index = 0; index < _CheckedListBox.Items.Count; index++)
            {
                if (((ListItem)_CheckedListBox.Items[index]).Id == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        public EditEventUI(EventBOL eventBOL)
        {
            try
            {
                InitializeComponent();
                SetResourceManager();
                _EventBOL = eventBOL;
                SetEventUpdateVisibility(true);
                LoadEvent(_EventBOL);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadEvent(EventBOL _EventBOL)
        {
            try
            {
                _FormMode = FormMode.Update;
                SetEventUpdateVisibility(true);
                LoadEvent();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void SetResourceManager()
        {
            CancelText = _ResourceManager.GetString("Cancel");
            UpdateText = _ResourceManager.GetString("Update");
            InsertText = _ResourceManager.GetString("Insert");
            DeleteText = _ResourceManager.GetString("Delete");
            AccessText = _ResourceManager.GetString("Access");
            UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
            DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
            AccessConfirmation = _ResourceManager.GetString("AccessConfirmation");
            Successed = _ResourceManager.GetString("Successed");
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
        private void EditEventUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }
        #region Event
        private void LoadEvent()
        {
            try
            {

                idTextBox.Text = _EventBOL.Id.ToString();
                titleTextBox.Text = _EventBOL.Title;
                descriptionTextBox.Text = _EventBOL.Description;
              //  CheckBind();
                }

            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private int ComboBoxSelectedIndex(RadDropDownList _ComboBox, ListItem _ListItem)
        {
            for (int index = 0; index < _ComboBox.Items.Count; index++)
            {
                if (DataConvertor.ConvertToShort(((RadListDataItem)_ComboBox.Items[index]).Value) == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        private void SetEventUpdateVisibility(bool visibility)
        {
            try
            {
                deleteButton.Visible = visibility;
                editButton.Visible = visibility;

                if (visibility)
                {
                    insertCancelButton.Text = CancelText;
                    _FormMode = FormMode.Update;
                }
                else
                {
                    insertCancelButton.Text = InsertText;
                    _FormMode = FormMode.Insert;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void insertCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_FormMode == FormMode.Insert)
                {
                        InsertEvent();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertEvent()
        {
            try
            {
                _EventBOL.Id = new EventBLL().SelectMaxId();
                _EventBOL.Title = titleTextBox.Text;
                _EventBOL.Description = descriptionTextBox.Text;
                //for (int i=0; i<checkGridView.Rows.Count; i++)
                //{
                //    string Id = DataConvertor.ConvertToString(checkGridView.Rows[i].Cells["Id"].Value);
                //    _EventBOL.CheckNumbers += Id + ';';
                //}
                if(_JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel)==DialogResult.OK)
                {
                    _EventBLL.Insert(_EventBOL);
                    CloseForm();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
                DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
                if (_DialogResult == DialogResult.OK)
                    UpdateEvent();
        }
        private void UpdateEvent()
        {

            try
            {
                _EventBOL.Title = titleTextBox.Text;
                _EventBOL.Description = descriptionTextBox.Text;
                //_EventBOL.CheckNumbers = string.Empty;
                //if (checkGridView.Rows.Count > 0)
                //{
                //    for (int i = 0; i < checkGridView.Rows.Count; i++)
                //    {
                //        string Id = DataConvertor.ConvertToString(checkGridView.Rows[i].Cells["Id"].Value);
                //        _EventBOL.CheckNumbers += Id + ';';
                //    }
                //}
                    _EventBLL.Update(_EventBOL);
                _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeleteEvent();
        }
        private void DeleteEvent()
        {
            try
            {
                _EventBLL.Delete(_EventBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        #endregion
        //private void CheckBind()
        //{

        //    CheckBLL _CheckBLL=new CheckBLL();
        //    string CheckId = _EventBOL.CheckNumbers;
        //    if (CheckId != string.Empty && CheckId != null)
        //    {
        //        string[] sponsorSet = CheckId.Split(spliter[0]);
        //        if (sponsorSet.Length > 0)
        //        {

        //            foreach (string item in sponsorSet)
        //                if (item != string.Empty && item != null)
        //                {
        //                    CheckBOL _CheckBOL=new CheckBOL();
        //                    _CheckBOL.Id = DataConvertor.ConvertToInt(item);
        //                    CheckBOL[] _CheckBOLs = _CheckBLL.Select(_CheckBOL);
        //                    if(_CheckBOLs!=null)
        //                    {
        //                        for (int index = 0; index < _CheckBOLs.Length; index++)
        //                            checkGridView.Rows.Add(_CheckBOLs[index].Id, _CheckBOLs[index].Number, _CheckBOLs[index].AccountNumber, _CheckBOLs[index].Date, _CheckBOLs[index].AccountName, _CheckBOLs[index].BankName, _CheckBOLs[index].ForWhom, _CheckBOLs[index].Price);
        //                    }
        //                }

        //        }
        //    }

        }
      

       
        
    }
