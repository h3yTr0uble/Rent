using BLL;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentDemo
{
    public partial class FmLogin : Form
    {
        private const string adminLogin = "txtLogin";//= "RodkinMaxim-admin";
        private const string adminPassword = "2cee41f80635b463eaae8a0613adb6ef";// = "9079720d11b0596602e8c287d6232355";

        public FmLogin()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            FmConnection fmConnection = new FmConnection();
            fmConnection.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Login = txtLogin.Text.Trim();//Надо шифровать логин?
            account.Password = MD5Hasher.GetHash(txtPassword.Text.Trim());

            if (account.Login == adminLogin && account.Password == adminPassword)
            {
                FmAdminMenu adminMenu = new FmAdminMenu();
                adminMenu.Show();
                this.Hide();

                return;
            }

            AccountDAO.SearchEmployee(account);

            if (account.Employee != null)
            {
                FmMainMenu mainMenu = new FmMainMenu(account.Employee);
                mainMenu.Show();
                this.Hide();

                return;
            }

            string loginErrorMessage = $"Ошибка входа в систему./r/nНеверные имя пользователя или пароль.";
            MessageBox.Show(loginErrorMessage, "Ошибка входа.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
