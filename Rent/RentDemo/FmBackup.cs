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
    public partial class FmBackup : Form
    {
        public FmBackup()
        {
            InitializeComponent();
        }

        private void btnChangeBackupPath_Click(object sender, EventArgs e)
        {
            string path = null;
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    txtBackupPath.Text = path.ToString();
                }
            }
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            BackupDAO.CreateBackup(txtBackupPath.Text);
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            BackupDAO.RestoreDatabase("Rent", txtRestoreFilePath.Text);
        }

        private void btnChooseRestoreFile_Click(object sender, EventArgs e)
        {
            string path = null;

            if (openFileRestoreDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileRestoreDialog.FileName;
                txtRestoreFilePath.Text = path.ToString();
            }
        }
    }
}
