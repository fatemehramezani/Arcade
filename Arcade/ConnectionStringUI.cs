using System;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessObjectLayer;
using Telerik.WinControls.UI;

namespace UserInterface
{
    public partial class ConnectionStringUI : RadForm
    {
        private readonly string _ConnectionName;
        private string _ConnnectionString = string.Empty;
        private ExceptionHandlerBOL _ExceptionHandlerBOL;

        public ConnectionStringUI(string connectionName)
        {
            InitializeComponent();
            _ConnectionName = connectionName;
        }

        private void DatabaseSetting_Load(object sender, EventArgs e)
        {
            FillServerComboBox();
        }

        private void FillServerComboBox()
        {
            try
            {
                var ServersTable = new DataTable();
                SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
                ServersTable = servers.GetDataSources();

                var obj = new object[ServersTable.Rows.Count];
                for (int i = 0; i < ServersTable.Rows.Count; i++)
                    obj[i] = string.Format("{0}\\{1}", ServersTable.Rows[i]["ServerName"].ToString(),
                        ServersTable.Rows[i]["InstanceName"].ToString());
                serversComboBox.DataSource = obj;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void FillDataBaseComboBox()
        {
            try
            {
                SetConnectionString(string.Empty);
                DataTable databases = ServerBLL.Select(_ConnnectionString);
                foreach (DataRow row in databases.Rows)
                    databaseComboBox.Items.Add(new RadListDataItem(row.ItemArray[0].ToString()));
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataBaseComboBox();
                if (noticeLabel.Text == string.Empty)
                {
                    securityGroupBox.Enabled = false;
                    databaseComboBox.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void SetConnectionString(string database)
        {
            try
            {
                if (passwordTextBox.Text != string.Empty && userNameTextBox.Text != string.Empty)
                    _ConnnectionString =
                        string.Format("Data Source={0};{1};Persist Security Info=True;User ID={2};Password={3};",
                            serversComboBox.Text,
                            database == string.Empty ? database : string.Format("Initial Catalog={0}", database),
                            userNameTextBox.Text, passwordTextBox.Text);
                else
                    _ConnnectionString = string.Format("Data Source={0};{1};Integrated Security=True",
                        serversComboBox.Text,
                        database == string.Empty
                            ? database
                            : string.Format("Initial Catalog={0}", database));
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                SetConnectionString();
                CloseForm();
            }
        }

        private void SetConnectionString()
        {
            try
            {
                SetConnectionString(databaseComboBox.SelectedItem.ToString());
                ServerBLL.SetConnectionString(_ConnectionName, _ConnnectionString);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            //SettingBOL _SettingBOL = new SettingBOL(key, value, null);
            //new SettingBLL().WriteKey(_SettingBOL);
        }

        private bool ValidateItem()
        {
            return databaseComboBox.SelectedIndex >= 0;
        }

        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
            noticeLabel.Text = string.Empty;
        }

        private void DatabaseSettingUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }

        private void closeForm()
        {
            Close();
        }
    }
}