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
            AddNewTransport();
        }

        private void AddNewTransport()
        {
            FmTransportEditor fmTransportEditor = new FmTransportEditor();
            if (fmTransportEditor.ShowDialog() == DialogResult.OK)
            {
                List<Transport> transports = new List<Transport>(GetTransports());
                FillCtlTransports(transports);
            }
        }

        private void EditSelectedTransport()
        {
            if (ctlTransports.SelectedCells.Count > 0)
            {
                Transport transport = (Transport)ctlTransports.SelectedCells[0].OwningRow.DataBoundItem;

                FmTransportEditor fmTransportEditor = new FmTransportEditor(transport);
                if (fmTransportEditor.ShowDialog() == DialogResult.OK)
                {
                    List<Transport> transports = new List<Transport>(GetTransports());
                    FillCtlTransports(transports);
                }
            }
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

        private void ctlEditTransport_Click(object sender, EventArgs e)
        {
            EditSelectedTransport();
        }

        private void ctlAddTransportContext_Click(object sender, EventArgs e)
        {
            AddNewTransport();
        }

        private void ctlEditTransportContext_Click(object sender, EventArgs e)
        {
            EditSelectedTransport();
        }
    }
}
