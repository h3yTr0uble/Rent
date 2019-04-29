using BLL;
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
            string login = txtLogin.Text.Trim();//Надо шифровать логин?
            string password = MD5Hasher.GetHash(txtPassword.Text.Trim());

            if (login == adminLogin && password == adminPassword)
            {
                FmAdminMenu adminMenu = new FmAdminMenu();
                adminMenu.Show();
                this.Hide();

                return;
            }
        }
    }
}
