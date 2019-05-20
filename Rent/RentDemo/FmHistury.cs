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
        private List<Reciept> reciepts;

        public FmHistury()
        {
            reciepts = new List<Reciept>(RecieptDAO.GetReciepts());
            InitializeComponent();
        }

        public FmHistury(Transport transport)
        {
            reciepts = new List<Reciept>(RecieptDAO.GetRecieptsByTransport(transport));
            InitializeComponent();
        }

        public FmHistury(Client client)
        {
            reciepts = new List<Reciept>(RecieptDAO.GetRecieptsByClient(client));
            InitializeComponent();
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
            fmRecieptForReturn.ShowDialog();
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
