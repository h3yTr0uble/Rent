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

            string conString = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
            ConnectionStringInfo connectionString = new ConnectionStringInfo(conString);
            WriteInTextBoxes(connectionString);
        }

        private void WriteInTextBoxes(ConnectionStringInfo conString)
        {
            txtDataSource.Text = conString.DataSource;
            txtInitialCatalog.Text = conString.InitialCatalog;
            txtConnectionTimeout.Text = conString.ConnectionTimeout.ToString();
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
            connectionString.Append($"Initial Catalog ={txtInitialCatalog.Text.ToString()};");
            if (txtConnectionTimeout.Text != "0")
            {
                connectionString.Append($"Connection Timeout={txtConnectionTimeout.Text};");
            }
                                             
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

        private string TestConnection(string connectionString)//TODO: решить вопрос с абстракцией
        {
            StringBuilder connectionInfo = new StringBuilder();

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                connectionInfo.AppendLine("Успешное соединение с сервером.");
            }
            catch (SqlException ex)
            {
                connectionInfo.AppendLine("Ошибка соединения с сервером.");
                foreach (SqlError error in ex.Errors)
                {
                    connectionInfo.AppendLine();
                    connectionInfo.AppendLine("Код ошибки:" + error.Number);
                    connectionInfo.AppendLine(error.Message);
                }
            }
            finally
            {
                connection.Close();
            }

            return connectionInfo.ToString();
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
            string connectionString = CombineConStringFromTextBoxes();
            string connectionInfo = TestConnection(connectionString);
            MessageBox.Show(connectionInfo, "Информация о подключении", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtConnectionTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (number == 8 && txtConnectionTimeout.Text.Length == 1)
            {
                txtConnectionTimeout.Text = "0";
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                return;
            }

            if (Char.IsDigit(number) && txtConnectionTimeout.Text == "0")
            {
                txtConnectionTimeout.Text = "";
            }
        }
    }
}
