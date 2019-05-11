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

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            BackupDAO.CreateBackup(@"D:\backup");//TODO: Добавить класс логики и реализовать выбор пути
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            BackupDAO.RestoreDatabase("Rent", @"D:\backup\Rent.Bak");//TODO: Реализовать выбор пути
        }
    }
}
