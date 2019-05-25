﻿using Entities;
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
            fmTransport.Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FmClient fmClient = new FmClient(employee);
            fmClient.Show();
            this.Hide();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            FmReciept fmReciept = new FmReciept(employee);
            fmReciept.Show();
            this.Hide();
        }

        private void btnRecieptsList_Click(object sender, EventArgs e)
        {
            FmHistory fmHistory = new FmHistory();
            fmHistory.Show();
            this.Hide();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FmReport fmReport = new FmReport();
            fmReport.Show();
            this.Hide();
        }
    }
}
