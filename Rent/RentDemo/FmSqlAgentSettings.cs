using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;

namespace RentDemo
{
    public partial class FmSqlAgentSettings : Form
    {
        private Server server;
        private Job backup;
        private Job recalculateCoef;
        private Job reduseCoef;

        private const string jobBackupName = "CreateBackupRent";
        private const string jobRecalculateCoefName = "RecalculateCorrectCoefRent";
        private const string jobreduseCoefName = "ReduseCoefRent";

        private const int pathIndex = 1;

        private readonly Dictionary<string, int> daysOfWeek = new Dictionary<string, int>()
        {
            ["Воскресенье"] = 1,
            ["Понедельник"] = 2,
            ["Вторник"] = 4,
            ["Среда"] = 8,
            ["Четверг"] = 16,
            ["Пятница"] = 32,
            ["Суббота"] = 64
        };



        public FmSqlAgentSettings()
        {
            InitializeComponent();
        }

        private void FmSqlAgentSettings_Load(object sender, EventArgs e)
        {
            server = new Server();
            foreach (Job job in server.JobServer.Jobs)
            {
                switch (job.Name)
                {
                    case jobBackupName:
                        backup = job;
                        break;
                    case jobRecalculateCoefName:
                        recalculateCoef = job;
                        break;
                    case jobreduseCoefName:
                        reduseCoef = job;
                        break;
                }
            }

            FillJobBackupInfo();
        }

        private void FillJobBackupInfo()
        {
            FillCtlDaysBackup();
            JobScheduleCollection schedules = backup.JobSchedules;
            ctlDaysBackup.SelectedText = daysOfWeek.FirstOrDefault(x => x.Value == schedules[0].FrequencyInterval).Key;
            ctlTimeBackup.Text = schedules[0].ActiveStartTimeOfDay.ToString();
            JobStepCollection steps = backup.JobSteps;
            txtBackupPath.Text = steps[0].Command.Substring(19, steps[0].Command.Length - 20);
            ctlIsEnabledBackup.Checked = backup.IsEnabled;
        }

        private void FillCtlDaysBackup()
        {
            ctlDaysBackup.Items.Clear();
            foreach (var day in daysOfWeek)
            {
                ctlDaysBackup.Items.Add(day.Key);
            }
        }

        private void BtnChangeBackupPath_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    txtBackupPath.Text = path.ToString();
                }
            }
        }

        private void SaveJobBackupSettings()
        {
            JobScheduleCollection schedules = backup.JobSchedules;
            schedules[0].FrequencyInterval = daysOfWeek.FirstOrDefault(x => x.Key == ctlDaysBackup.SelectedItem.ToString()).Value;
            schedules[0].ActiveStartTimeOfDay = ctlTimeBackup.Value.TimeOfDay;
            schedules[0].Alter();
            JobStepCollection steps = backup.JobSteps;
            steps[0].Command = $"exec CreateBackup '{txtBackupPath.Text}'";
            steps[0].Alter();
            backup.IsEnabled = ctlIsEnabledBackup.Checked;
            backup.Alter();
        }

        private void BtnSaveBackup_Click(object sender, EventArgs e)
        {
            SaveJobBackupSettings();
        }
    }
}
