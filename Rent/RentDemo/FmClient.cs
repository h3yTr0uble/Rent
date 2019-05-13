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
        public FmClient()
        {
            InitializeComponent();
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
            FillCtlClients(clients);
            ctlClients.AutoGenerateColumns = false;
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
    }
}
