﻿using DAL;
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
            fmBackup.Show();
            this.Hide();
        }
    }
}
