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
    public partial class FmHistury : Form
    {
        public Reciept SelectedReciept { get; private set; }
        private List<Reciept> reciepts = new List<Reciept>();
        private readonly int formMode = 0;
        private Transport transport;
        private Client client;

        public FmHistury()
        {
            formMode = 0;
            InitializeComponent();
        }

        public FmHistury(Transport transport)
        {
            formMode = 1;
            this.transport = transport;
            InitializeComponent();
        }

        public FmHistury(Client client)
        {
            formMode = 2;
            this.client = client;
            InitializeComponent();
        }

        private IEnumerable<Reciept> GetReciepts()
        {
            switch (formMode)
            {
                case 0:
                    return RecieptDAO.GetReciepts();
                case 1:
                    return RecieptDAO.GetRecieptsByTransport(transport);
                case 2:
                    return RecieptDAO.GetRecieptsByClient(client);
                default:
                    return null;
            }
        }

        private void FillCtlReciepts(IEnumerable<Reciept> reciepts)
        {
            ctlReciepts.DataSource = null;
            ctlReciepts.DataSource = reciepts;

            for (int i = 0; i < ctlReciepts.RowCount; i++)
            {
                Reciept reciept = (Reciept)ctlReciepts.Rows[i].DataBoundItem;
                if (reciept.RecieptForReturn == null)
                {
                    ctlReciepts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
                    ctlReciepts.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void FmHistury_Load(object sender, EventArgs e)
        {
            reciepts = GetReciepts().ToList();
            ctlReciepts.AutoGenerateColumns = false;
            FillCtlReciepts(reciepts);
        }

        private void ctlReciepts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Reciept reciept = (Reciept)ctlReciepts.SelectedCells[0].OwningRow.DataBoundItem;
            if (reciept.RecieptForReturn == null)
            {
                ctlCreationRecieptForReturn.Enabled = true;
                ctlCreationRecieptForReturnContext.Enabled = true;
            }
            else
            {
                ctlCreationRecieptForReturn.Enabled = false;
                ctlCreationRecieptForReturnContext.Enabled = false;
            }
        }

        private void OpenCreationRecieptForReturn()
        {
            SelectedReciept = (Reciept)ctlReciepts.SelectedCells[0].OwningRow.DataBoundItem;
            FmRecieptForReturn fmRecieptForReturn = new FmRecieptForReturn(SelectedReciept);
            if(fmRecieptForReturn.ShowDialog() == DialogResult.OK)
            {
                reciepts = GetReciepts().ToList();
                FillCtlReciepts(reciepts);
            }
        }

        private void ctlCreationRecieptForReturn_Click(object sender, EventArgs e)
        {
            OpenCreationRecieptForReturn();
        }

        private void ctlCreationRecieptForReturnContext_Click(object sender, EventArgs e)
        {
            OpenCreationRecieptForReturn();
        }
    }
}
