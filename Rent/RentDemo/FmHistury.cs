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
        }

        private void FmHistury_Load(object sender, EventArgs e)
        {
            FillCtlReciepts(reciepts);
            ctlReciepts.AutoGenerateColumns = false;
        }
    }
}
