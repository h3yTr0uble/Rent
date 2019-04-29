using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BLL;

namespace RentDemo
{
    public partial class FmConnection : Form
    {
        public string ConnectionString { get; }

        public FmConnection()
        {
            InitializeComponent();
            ctlIntegratedSecurity.Items.Add("False");
            ctlIntegratedSecurity.Items.Add("True");

            string connectionString = ActualConnectionString.Get();
            WriteInTextBoxes(connectionString);
        }

        private void WriteInTextBoxes(string connectionString)
        {
            ConnectionStringInfo conString = new ConnectionStringInfo(connectionString);

            txtDataSource.Text = conString.DataSource;
            txtInitialCatalog.Text = conString.InitialCatalog;
            if (conString.IntegratedSecurity)
            {
                ctlIntegratedSecurity.SelectedIndex = 1;
                txtUserID.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                ctlIntegratedSecurity.SelectedIndex = 0;
                txtUserID.Text = conString.UserID;
                txtPassword.Text = conString.Password;
            }
        }

        private string CombineConStringFromTextBoxes()
        {
            StringBuilder connectionString = new StringBuilder();
            connectionString.Append($"Data Source={txtDataSource.Text.ToString()};");
            connectionString.Append($"Initial Catalog={txtInitialCatalog.Text.ToString()};");

            if (ctlIntegratedSecurity.Text == "True")
            {
                connectionString.Append($"Integrated Security={ctlIntegratedSecurity.Text};");
                
            }
            else
            {
                connectionString.Append($"User ID={txtUserID.Text};Password={txtPassword.Text};");
            }

            return connectionString.ToString();
        }

        private bool TestConnection(string connectionString, out string connectionInfo)//TODO: решить вопрос с абстракцией
        {
            StringBuilder conInfo = new StringBuilder();
            bool succesfulConnections;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                conInfo.AppendLine("Успешное соединение с сервером.");
                succesfulConnections = true;
            }
            catch (SqlException ex)
            {
                conInfo.AppendLine("Ошибка соединения с сервером.");
                foreach (SqlError error in ex.Errors)
                {
                    conInfo.AppendLine();
                    conInfo.AppendLine("Код ошибки:" + error.Number);
                    conInfo.AppendLine(error.Message);
                }
                succesfulConnections = false;
            }
            finally
            {
                connection.Close();
            }

            connectionInfo = conInfo.ToString();

            return succesfulConnections;
        }

        private void ctlIntegratedSecurity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctlIntegratedSecurity.Text == "True")
            {
                txtUserID.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUserID.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }

            string connectionString = CombineConStringFromTextBoxes();
            if (TestConnection(connectionString, out string connectionInfo))
            {
                MessageBox.Show(connectionInfo, "Информация о подключении", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(connectionInfo, "Информация о подключении", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }

            string connectionString = CombineConStringFromTextBoxes();
            if (TestConnection(connectionString, out _))
            {
                ActualConnectionString.Set(connectionString);
                this.Close();
            }
            else
            {
                string dialogMessage = string.Format($"Отсутствует подключение к серверу.\r\nПрименить настройки по умолчанию?");//какое сообщение?

                var dialogResult = MessageBox.Show(dialogMessage, 
                                                  "Информация о подключении", 
                                                   MessageBoxButtons.OKCancel, 
                                                   MessageBoxIcon.Warning);
                if (DialogResult == 0)
                {
                    ActualConnectionString.SetDefault();
                    this.Close();
                }
            }
        }

        private void String_Validating(TextBox txt, object sender, CancelEventArgs e)
        {
            string input = txt.Text.Trim();

            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(txt, "Поле не должно быть пустым!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txt, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDataSource_Validating(object sender, CancelEventArgs e)
        {
            String_Validating(txtDataSource, sender, e);
        }

        private void txtInitialCatalog_Validating(object sender, CancelEventArgs e)
        {
            String_Validating(txtInitialCatalog, sender, e);
        }
    }
}
