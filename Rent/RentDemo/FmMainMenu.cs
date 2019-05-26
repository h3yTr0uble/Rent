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
    public partial class FmMainMenu : Form
    {
        private Employee employee;

        public FmMainMenu(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            ctlEmployee.Text = employee.FullName;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            FmTransport fmTransport = new FmTransport(employee);
            fmTransport.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FmClient fmClient = new FmClient(employee);
            fmClient.ShowDialog();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            FmReciept fmReciept = new FmReciept(employee);
            fmReciept.ShowDialog();
        }

        private void btnRecieptsList_Click(object sender, EventArgs e)
        {
            FmHistory fmHistory = new FmHistory();
            fmHistory.ShowDialog();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FmReport fmReport = new FmReport();
            fmReport.ShowDialog();
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

        private void FmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Информационное сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void FmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
