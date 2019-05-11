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
    public partial class FmTransport : Form
    {
        public FmTransport()
        {
            InitializeComponent();
        }

        private void ctlAddTransport_Click(object sender, EventArgs e)
        {
            FmTransportEditor fmTransportEditor = new FmTransportEditor();
            fmTransportEditor.ShowDialog();

        }

        private IEnumerable<Transport> GetTransports()
        {
            return TransportDAO.GetTransports();
        }

        private void FmTransport_Load(object sender, EventArgs e)
        {
            List<Transport> transports = new List<Transport>(GetTransports());
            FillCtlTransports(transports);
            ctlTransports.AutoGenerateColumns = false;
        }

        private void FillCtlTransports(IEnumerable<Transport> transports)
        {
            ctlTransports.DataSource = null;
            ctlTransports.DataSource = transports;
        }

    }
}
