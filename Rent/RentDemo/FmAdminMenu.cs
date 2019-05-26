using DAL;
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
    public partial class FmAdminMenu : Form
    {
        public FmAdminMenu()
        {
            InitializeComponent();
        }

        private void btnOpenBackup_Click(object sender, EventArgs e)
        {
            FmBackup fmBackup = new FmBackup();
            fmBackup.ShowDialog();
        }

        private void CtlChangeUser_Click(object sender, EventArgs e)
        {
            FmLogin fmLogin = new FmLogin();
            fmLogin.Show();
            this.Hide();
        }

        private void CtlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FmAdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Информационное сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void FmAdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
