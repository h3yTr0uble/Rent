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
    public partial class FmClient : Form
    {
        public Client SelectedClient { get; private set; }
        public Employee Employee { get; private set; }

        public FmClient(Employee employee)
        {
            this.Employee = employee;
            InitializeComponent();
            ctlEnterClientContext.Visible = false;
            ctlEnterClient.Visible = false;
            ctlCreateRecieptClientContext.Visible = true;
            ctlCreateRecieptClient.Visible = true;
        }

        public FmClient(FmReciept fmReciept)
        {
            InitializeComponent();
            ctlEnterClientContext.Visible = true;
            ctlEnterClient.Visible = true;
            ctlCreateRecieptClientContext.Visible = false;
            ctlCreateRecieptClient.Visible = false;
        }

        private void FillCtlClients(IEnumerable<Client> clients)
        {
            ctlClients.DataSource = null;
            ctlClients.DataSource = clients;
        }

        private void FillctlClientsDrivingCategory(Client client)
        {
            txtClientsDrivingCategory.Clear();
            foreach (DrivingCategory drivingCategory in client.DrivingCategories)
            {
                txtClientsDrivingCategory.Text += drivingCategory.ToString() + Environment.NewLine;
            }
        }

        private void FmClient_Load(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>(GetClients());
            ctlClients.AutoGenerateColumns = false;
            FillCtlClients(clients);
        }

        private IEnumerable<Client> GetClients()
        {
            return ClientDAO.GetClients();
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
        }

        private void ctlClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = (Client)ctlClients.SelectedCells[0].OwningRow.DataBoundItem;
            FillctlClientsDrivingCategory(client);
        }

        private void AddNewClient()
        {
            FmClientEditor fmClientEditor = new FmClientEditor();
            if (fmClientEditor.ShowDialog() == DialogResult.OK)
            {
                List<Client> clients = new List<Client>(GetClients());
                FillCtlClients(clients);
            }
        }

        private void EditSelectedClient()
        {
            if (ctlClients.SelectedCells.Count > 0)
            {
                Client client = (Client)ctlClients.SelectedCells[0].OwningRow.DataBoundItem;

                FmClientEditor fmClientEditor = new FmClientEditor(client);
                if (fmClientEditor.ShowDialog() == DialogResult.OK)
                {
                    List<Client> clients = new List<Client>(GetClients());
                    FillCtlClients(clients);
                }
            }
        }

        private void ctlAddClient_Click(object sender, EventArgs e)
        {
            AddNewClient();
        }

        private void ctlEditClient_Click(object sender, EventArgs e)
        {
            EditSelectedClient();
        }

        private void ctlAddClientContext_Click(object sender, EventArgs e)
        {
            AddNewClient();
        }

        private void ctlEditClientContext_Click(object sender, EventArgs e)
        {
            EditSelectedClient();
        }

        private void ctlCreateRecieptClientContext_Click(object sender, EventArgs e)
        {
            OpenCreationReciept();
        }

        private void OpenHistorySelectedClient()
        {
            if (ctlClients.SelectedCells.Count > 0)
            {
                Client client = (Client)ctlClients.SelectedCells[0].OwningRow.DataBoundItem;

                FmHistury fmHistory = new FmHistury(client);
                fmHistory.ShowDialog();
            }
        }

        private void ctlEnterClientContext_Click(object sender, EventArgs e)
        {
            EnterSelectedClient();
        }

        private void EnterSelectedClient()
        {
            if (ctlClients.SelectedCells.Count > 0)
            {
                SelectedClient = (Client)ctlClients.SelectedCells[0].OwningRow.DataBoundItem;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ctlEnterClient_Click(object sender, EventArgs e)
        {
            EnterSelectedClient();
        }

        private void OpenCreationReciept()
        {
            SelectedClient = (Client)ctlClients.SelectedCells[0].OwningRow.DataBoundItem;
            FmReciept fmReciept = new FmReciept(this);
            fmReciept.Show();
            this.Close();
        }

        private void ctlCreateRecieptClient_Click(object sender, EventArgs e)
        {
            OpenCreationReciept();
        }

        private void ctlHistoryClientContext_Click(object sender, EventArgs e)
        {
            OpenSelectedClientHistory();
        }

        private void OpenSelectedClientHistory()
        {
            SelectedClient = (Client)ctlClients.SelectedCells[0].OwningRow.DataBoundItem;
            FmHistury fmHistory = new FmHistury(SelectedClient);
            fmHistory.ShowDialog();
        }

        private void ctlHistoryClient_Click(object sender, EventArgs e)
        {
            OpenSelectedClientHistory();
        }
    }
}
