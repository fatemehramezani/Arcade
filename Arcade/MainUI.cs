using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BusinessObjectLayer;
using BusinessLogicLayer;
using System.Resources;
using System.Reflection;
using JntMsgBox;
using Telerik.WinControls.UI;
using System.Web.UI.WebControls;

namespace UserInterface
{
    public partial class MainUI : RadForm
    {
       
        bool closingFlag = false;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ChangePasswordUI _ChangePasswordUI;
        ShowUserUI _ShowUserUI;
        ShowSettingUI _ShowSettingUI;
        About about;
        BackupUI _BackupUI;
        RestoreBackupUI _RestoreBackupUI;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        ShowPersonalInfoUI _ShowPersonalInfoUI;
        ShowMaritalStatusUI _ShowMaritalStatusUI;
        ShowMilitaryStatusUI _ShowMilitaryStatusUI;
        ShowCheckUI _ShowCheckUI;
        ShowEstateTypeUI _ShowEstateTypeUI;
        ShowEstateUI _ShowEstateUI;
        ShowCoordinatingCouncilUI _ShowCoordinatingCouncilUI;
        ShowPersonalRoleUI _ShowPersonalRoleUI;
        ShowLandLordUI _ShowLandLordUI;
        ShowPurchaseLetterUI _ShowPurchaseLetterUI;
        ShowLeaseUI _ShowLeaseUI;
        ShowBasisUI _ShowBasisUI;
        ShowEstateReportUI _ShowEstateReportUI;
      //  PersonalInfoReportUI _PersonalInfoReportUI;
      //  InfoListReportUI _InfoListReportUI;
        ShowInputUI _ShowInputUI;
        ShowOutPutUI _ShowOutPutUI;
        ShowEventUI _ShowEventUI;
        ShowRoleTypeUI _ShowroltypeUI;
        ShowJobUI _showJobUI;
        string ExitText;
        string ChangeText;
        string BackupText;
        string ExitConfirmation;
        string ChangeConfirmation;
        string BackupConfirmation;
        private AccessMode accessMode = AccessMode.NoAccess;

        public MainUI()
        {
            try
            {
                InitializeComponent();
                SetResourceManager();
                ShowDate();
                this.LayoutMdi(MdiLayout.ArrangeIcons);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowDate()
        {
            dateLabel.Text = DataConvertor.DataConvertor.ConvertToPersianDate(DateTime.Now);
        }
        private void menuButtonCommand_Click(object sender, EventArgs e)
        {
            switch (((RadButtonElement)sender).Name)
            {
               
                case "changePasswordButtonCommand":
                    ChangePassword();
                    break;
                case "changeUserButtonCommand":
                    RestartApplication();
                    break;
                case "exitButtonCommand":
                    GetExitConfirmtion();
                    break;
                case "usersButtonCommand":
                    ShowUserUI();
                    break;
                case "cascadeButtonCommand":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "horizontalButtonCommand":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "verticalButtonCommand":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "restoreAllButtonCommand":
                    RestoreAll();
                    break;
                case "closeAllButtonCommand":
                    CloseAll();
                    break;
                case "minimizeAllButtonCommand":
                    MinimizeAll();
                    break;
                case "aboutButtonCommand":
                    ShowAbout();
                    break;
                case "backupButtonCommand":
                    ShowBackup();
                    break;
                case "restoreBackupButtonCommand":
                    ShowRestoreBackup();
                    break;
                case "settingButtonCommand":
                    ShowSettingUI();
                    break;
                case "personalInfoButtonCommand":
                    ShowPersonalInfoUI();
                    break;
                case "personalInfoReportButtonCommand":
               //     ShowPersonalInfoReportUI();
                    break;
                case "infoListReportButtonCommand":
                //    ShowInfoListReportUI();
                    break;
                case "maritalStatusButtonElement":
                    ShowMaritalStatusUI();                    
                    break;
                case "roleTypeButtonElement":
                    ShowRoleTypeUI();    
                    break;

                case "militaryStatusButtonElement":
                    ShowMilitaryStatusUI();
                    break;
                case "jobButtonElement":
                    ShowJobUI();
                    break;
                case "estateTypeButtonElement":
                    ShowEstateTypeUI();
                    break;
                case "RoleButtonElement":
                    break;

                case "CheckButtonElement":
                    ShowCheckUI();
                    break;
                case "estateCommandButton2":
                    ShowEstateUI();
                    break;
                case "coordinatingCouncilCommandButton":
                    ShowCoordinatingCouncilUI();
                    break;
                case "PersonalRoleButtonElement":
                    ShowPersonalRoleUI();
                    break;
                case "landLordCommandButton":
                    ShowLandLordUI();
                    break;
                case "purchaseLetterButtonCommand":
                    ShowPurchaseLetterUI();
                    break;
                case "LeaseButtonElement":
                    ShowLeaseUI();
                    break;
                case "BasisCommandButton":
                    ShowBasisUI();
                    break;
                case "inputCommandButtom":
                    ShowInputUI();
                    break;
                case "outputCommandButtom":
                    ShowOutputUI();
                    break;
                case "eventCommandButtom":
                    ShowEventUI();
                    break;
                case "ReportradButton":
                    ShowEstateReportUI();
                    break;
            }
        }


        private void ShowEstateReportUI()
        {
            try
            {
                if (_ShowEstateReportUI == null || !_ShowEstateReportUI.Visible)
                {
                    if (_ShowEstateReportUI != null)
                        _ShowEstateReportUI.Dispose();
                    _ShowEstateReportUI = new ShowEstateReportUI(AccessMode.Complete);
                    _ShowEstateReportUI.MdiParent = this;
                    _ShowEstateReportUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }


        private void ShowInputUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowInputUI.Visible)
                {
                    if (_ShowMaritalStatusUI != null)
                        _ShowInputUI.Dispose();
                    _ShowInputUI = new ShowInputUI();
                    _ShowInputUI.MdiParent = this;
                    _ShowInputUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowOutputUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowOutPutUI.Visible)
                {
                    if (_ShowMaritalStatusUI != null)
                        _ShowOutPutUI.Dispose();
                    _ShowOutPutUI = new ShowOutPutUI();
                    _ShowOutPutUI.MdiParent = this;
                    _ShowOutPutUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowEventUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowEventUI.Visible)
                {
                    if (_ShowMaritalStatusUI != null)
                        _ShowEventUI.Dispose();
                    _ShowEventUI = new ShowEventUI(AccessMode.Complete);
                    _ShowEventUI.MdiParent = this;
                    _ShowEventUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowBasisUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowBasisUI.Visible)
                {
                    if (_ShowMaritalStatusUI != null)
                        _ShowBasisUI.Dispose();
                    _ShowBasisUI = new ShowBasisUI(AccessMode.Complete);
                    _ShowBasisUI.MdiParent = this;
                    _ShowBasisUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }




        private void SetResourceManager()
        {
            ExitText = _ResourceManager.GetString("Exit");
            ChangeText = _ResourceManager.GetString("Change");
            BackupText = _ResourceManager.GetString("Backup");
            ExitConfirmation = _ResourceManager.GetString("ExitConfirmation");
            ChangeConfirmation = _ResourceManager.GetString("ChangeConfirmation");
            BackupConfirmation = _ResourceManager.GetString("BackupConfirmation");
        }
        //private void ShowInfoListReportUI()
        //{
        //    try
        //    {
        //        if (_InfoListReportUI == null || !_InfoListReportUI.Visible)
        //        {
        //            if (_InfoListReportUI != null)
        //                _InfoListReportUI.Dispose();
        //            _InfoListReportUI = new InfoListReportUI();
        //            _InfoListReportUI.MdiParent = this;
        //            _InfoListReportUI.Show();
        //        }
        //        else
        //        {
        //            _InfoListReportUI.Focus();
        //            _InfoListReportUI.WindowState = FormWindowState.Normal;
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
        //        errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
        //    }
        //}
        //private void ShowPersonalInfoReportUI()
        //{
        //    try
        //    {
        //        if (_PersonalInfoReportUI == null || !_PersonalInfoReportUI.Visible)
        //        {
        //            if (_PersonalInfoReportUI != null)
        //                _PersonalInfoReportUI.Dispose();
        //            _PersonalInfoReportUI = new PersonalInfoReportUI();
        //            _PersonalInfoReportUI.MdiParent = this;
        //            _PersonalInfoReportUI.Show();
        //        }
        //        else
        //        {
        //            _PersonalInfoReportUI.Focus();
        //            _PersonalInfoReportUI.WindowState = FormWindowState.Normal;
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
        //        errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
        //    }
        //}

      
        private void ShowmilitarySatusUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowMilitaryStatusUI.Visible)
                {
                    if (_ShowMaritalStatusUI != null)
                        _ShowMilitaryStatusUI.Dispose();
                    _ShowMilitaryStatusUI = new ShowMilitaryStatusUI(AccessMode.Complete);
                    _ShowMilitaryStatusUI.MdiParent = this;
                    _ShowMilitaryStatusUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowLandLordUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowLandLordUI.Visible)
                {
                    if (_ShowMaritalStatusUI != null)
                        _ShowLandLordUI.Dispose();
                    _ShowLandLordUI = new ShowLandLordUI();
                    _ShowLandLordUI.MdiParent = this;
                    _ShowLandLordUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void ShowCoordinatingCouncilUI()
        {
            try
            {
                if (_ShowCoordinatingCouncilUI == null || !_ShowCoordinatingCouncilUI.Visible)
                {
                    if (_ShowCoordinatingCouncilUI != null)
                        _ShowCoordinatingCouncilUI.Dispose();
                    _ShowCoordinatingCouncilUI = new ShowCoordinatingCouncilUI();
                    _ShowCoordinatingCouncilUI.MdiParent = this;
                    _ShowCoordinatingCouncilUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }


        private void ShowRoleTypeUI()
        {
            try
            {
                if (_ShowroltypeUI == null || !_ShowroltypeUI.Visible)
                {
                    if (_ShowroltypeUI != null)
                        _ShowroltypeUI.Dispose();
                    _ShowroltypeUI = new ShowRoleTypeUI(AccessMode.Complete);
                    _ShowroltypeUI.MdiParent = this;
                    _ShowroltypeUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void ShowEstateUI()
        {
            try
            {
                if (_ShowEstateUI == null || !_ShowEstateUI.Visible)
                {
                    if (_ShowEstateUI != null)
                        _ShowEstateUI.Dispose();
                    _ShowEstateUI = new ShowEstateUI();
                    _ShowEstateUI.MdiParent = this;
                    _ShowEstateUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void ShowPurchaseLetterUI()
        {
            try
            {
                if (_ShowPurchaseLetterUI == null || !_ShowPurchaseLetterUI.Visible)
                {
                    if (_ShowPurchaseLetterUI != null)
                        _ShowPurchaseLetterUI.Dispose();
                    _ShowPurchaseLetterUI = new ShowPurchaseLetterUI();
                    _ShowPurchaseLetterUI.MdiParent = this;
                    _ShowPurchaseLetterUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowPersonalRoleUI()
        {
            try
            {
                if (_ShowPersonalRoleUI == null || !_ShowPersonalRoleUI.Visible)
                {
                    if (_ShowPersonalRoleUI != null)
                        _ShowPersonalRoleUI.Dispose();
                    _ShowPersonalRoleUI = new ShowPersonalRoleUI(accessMode);
                    _ShowPersonalRoleUI.MdiParent = this;
                    _ShowPersonalRoleUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }



        private void ShowEstateTypeUI()
        {
            try
            {
                if (_ShowEstateTypeUI == null || !_ShowEstateTypeUI.Visible)
                {
                    if (_ShowEstateTypeUI != null)
                        _ShowroltypeUI.Dispose();
                    _ShowEstateTypeUI = new ShowEstateTypeUI(AccessMode.Complete);
                    _ShowEstateTypeUI.MdiParent = this;
                    _ShowEstateTypeUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }



        private void ShowRoleUI()
        {
            try
            {
                if (_ShowEstateTypeUI == null || !_ShowEstateTypeUI.Visible)
                {
                    if (_ShowEstateTypeUI != null)
                        _ShowroltypeUI.Dispose();
                    _ShowEstateTypeUI = new ShowEstateTypeUI(AccessMode.Complete);
                    _ShowEstateTypeUI.MdiParent = this;
                    _ShowEstateTypeUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }


        private void ShowMilitaryStatusUI()
        {
            try
            {
                if (_ShowMilitaryStatusUI == null || !_ShowMilitaryStatusUI.Visible)
                {
                    if (_ShowMilitaryStatusUI != null)
                        _ShowMilitaryStatusUI.Dispose();
                    _ShowMilitaryStatusUI = new ShowMilitaryStatusUI(AccessMode.Complete);
                    _ShowMilitaryStatusUI.MdiParent = this;
                    _ShowMilitaryStatusUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }


        private void ShowJobUI()
        {
            try
            {
                if (_showJobUI == null || !_showJobUI.Visible)
                {
                    if (_showJobUI!= null)
                        _showJobUI.Dispose();
                    _showJobUI = new ShowJobUI(AccessMode.Complete);
                    _showJobUI.MdiParent = this;
                    _showJobUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }



        private void ShowMaritalStatusUI()
        {
            try
            {
                if (_ShowMaritalStatusUI == null || !_ShowMaritalStatusUI.Visible)
                {
                    if (_ShowMaritalStatusUI!= null)
                        _ShowMaritalStatusUI.Dispose();
                    _ShowMaritalStatusUI = new ShowMaritalStatusUI(AccessMode.Complete);
                    _ShowMaritalStatusUI.MdiParent = this;
                    _ShowMaritalStatusUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }


        
        private void ShowCheckUI()
        {
            try
            {
                if (_ShowCheckUI== null || !_ShowCheckUI.Visible)
                {
                    if (_ShowCheckUI!= null)
                        _ShowCheckUI.Dispose();
                    _ShowCheckUI= new ShowCheckUI(AccessMode.Complete);
                    _ShowCheckUI.MdiParent = this;
                    _ShowCheckUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
      /*  private void ShowMilitaryStatusTypeUI1()
        {
            try
            {
                if (_ShowMilitaryStatusTypeUI == null || !_ShowMilitaryStatusTypeUI.Visible)
                {
                    if (_ShowMilitaryStatusTypeUI != null)
                        _ShowMilitaryStatusTypeUI.Dispose();
                    _ShowMilitaryStatusTypeUI = new ShowMilitaryStatusTypeUI(AccessMode.Complete);
                    _ShowMilitaryStatusTypeUI.MdiParent = this;
                    _ShowMilitaryStatusTypeUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        */

         

        private void ShowLeaseUI()
        {
            try
            {
                if (_ShowLeaseUI == null || !_ShowLeaseUI.Visible)
                {
                    if (_ShowLeaseUI != null)
                        _ShowLeaseUI.Dispose();
                    _ShowLeaseUI = new ShowLeaseUI();
                    _ShowLeaseUI.MdiParent = this;
                    _ShowLeaseUI.Show();
                }
                else 
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }




        private void ShowSettingUI()
        {
            try
            {
                if (_ShowSettingUI == null || !_ShowSettingUI.Visible)
                {
                    if (_ShowSettingUI != null)
                        _ShowSettingUI.Dispose();
                    _ShowSettingUI = new ShowSettingUI(AccessMode.Complete);
                    _ShowSettingUI.MdiParent = this;
                    _ShowSettingUI.Show();
                }
                else
                {
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowRestoreBackup()
        {
            try
            {
                if (_RestoreBackupUI == null || !_RestoreBackupUI.Visible)
                {
                    if (_RestoreBackupUI != null)
                        _RestoreBackupUI.Dispose();
                    _RestoreBackupUI = new RestoreBackupUI();
                    _RestoreBackupUI.MdiParent = this;
                    _RestoreBackupUI.Show();
                }
                else
                {
                    _RestoreBackupUI.Focus();
                    _RestoreBackupUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowBackup()
        {
            try
            {
                if (_BackupUI == null || !_BackupUI.Visible)
                {
                    if (_BackupUI != null)
                        _BackupUI.Dispose();
                    _BackupUI = new BackupUI();
                    _BackupUI.MdiParent = this;
                    _BackupUI.Show();
                }
                else
                {
                    _BackupUI.Focus();
                    _BackupUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowAbout()
        {
            try
            {
                if (about == null || !about.Visible)
                {
                    if (about != null)
                        about.Dispose();
                    about = new About();
                    about.MdiParent = this;
                    about.Show();
                }
                else
                {
                    about.Focus();
                    about.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void MinimizeAll()
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.WindowState = FormWindowState.Minimized;
            }
        }
        private void CloseAll()
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.Close();
            }
        }
        private void RestoreAll()
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.WindowState = FormWindowState.Normal;
            }
        }
        private void ShowPersonalInfoUI()
        {
            try
            {
                if (_ShowPersonalInfoUI == null || !_ShowPersonalInfoUI.Visible)
                {
                    if (_ShowPersonalInfoUI != null)
                        _ShowPersonalInfoUI.Dispose();
                    _ShowPersonalInfoUI = new ShowPersonalInfoUI();
                    _ShowPersonalInfoUI.MdiParent = this;
                    _ShowPersonalInfoUI.Show();
                }
                else
                {
                    _ShowPersonalInfoUI.Focus();
                    _ShowPersonalInfoUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowUserUI()
        {
            try
            {
                if (_ShowUserUI == null || !_ShowUserUI.Visible)
                {
                    if (_ShowUserUI != null)
                        _ShowUserUI.Dispose();
                    _ShowUserUI = new ShowUserUI();
                    _ShowUserUI.MdiParent = this;
                    _ShowUserUI.Show();
                }
                else
                {
                    _ShowUserUI.Focus();
                    _ShowUserUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void GetExitConfirmtion()
        {
            if (closingFlag == false)
            {
                JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                DialogResult result = _JntMsgBoxFarsi.Show(BackupConfirmation, BackupText, JntStyle.YesNo);
                if (result == DialogResult.Yes)
                    ShowBackup();
                else
                {
                    closingFlag = true;
                    result = _JntMsgBoxFarsi.Show(ExitConfirmation, ExitText, JntStyle.YesNo);
                    if (result == DialogResult.Yes)
                        CloseForm();
                    else
                        closingFlag = false;
                }
            }
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void CloseApplication()
        {
            Application.Exit();
        }
        private void RestartApplication()
        {
            closingFlag = true;
            GetChangeConfirmtion();
        }
        private void GetChangeConfirmtion()
        {
            JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
            DialogResult result = _JntMsgBoxFarsi.Show(ChangeConfirmation, ChangeText, JntStyle.YesNo);
            if (result == DialogResult.Yes)
                Application.Restart();
            closingFlag = false;
        }
        private void ChangePassword()
        {
            try
            {
                if (_ChangePasswordUI == null || !_ChangePasswordUI.Visible)
                {
                    if (_ChangePasswordUI != null)
                        _ChangePasswordUI.Dispose();
                    _ChangePasswordUI = new ChangePasswordUI();
                    _ChangePasswordUI.Show();
                }
                else
                {
                    _ChangePasswordUI.Focus();
                    _ChangePasswordUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetExitConfirmtion();
            if (!closingFlag)
                e.Cancel = true;
        }
        private void MainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseApplication();
        }
        private void errorLabelCommand_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
            errorLabelCommand.Text = string.Empty;
        }
    }
}