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
        public Transport SelectedTransport { get; private set; }
        public Employee Employee { get; private set; }

        public FmTransport(Employee employee)
        {
            this.Employee = employee;
            InitializeComponent();
            ctlEnterTransportContext.Visible = false;
            ctlEnterTransport.Visible = false;
            ctlCreateRecieptTransportContext.Visible = true;
            ctlCreateRecieptTransport.Visible = true;
        }

        public FmTransport(FmReciept fmReciept)
        {
            InitializeComponent();
            ctlEnterTransportContext.Visible = true;
            ctlEnterTransport.Visible = true;
            ctlCreateRecieptTransportContext.Visible = false;
            ctlCreateRecieptTransport.Visible = false;
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
            ctlTransports.AutoGenerateColumns = false;
            FillCtlTransports(transports);
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

        private void EnterSelectedTransport()
        {
            if (ctlTransports.SelectedCells.Count > 0)
            {
                SelectedTransport = (Transport)ctlTransports.SelectedCells[0].OwningRow.DataBoundItem;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ctlEnterTransportContext_Click(object sender, EventArgs e)
        {
            EnterSelectedTransport();
        }

        private void ctlEnterTransport_Click(object sender, EventArgs e)
        {
            EnterSelectedTransport();
        }

        private void ctlCreateRecieptTransport_Click(object sender, EventArgs e)
        {
            OpenCreationReciept();
        }

        private void OpenCreationReciept()
        {
            SelectedTransport = (Transport)ctlTransports.SelectedCells[0].OwningRow.DataBoundItem;
            FmReciept fmReciept = new FmReciept(this);
            fmReciept.Show();
            this.Close();
        }

        private void ctlCreateRecieptTransportContext_Click(object sender, EventArgs e)
        {
            OpenCreationReciept();
        }

        private void OpenSelectedTransportHistory()
        {
            SelectedTransport = (Transport)ctlTransports.SelectedCells[0].OwningRow.DataBoundItem;
            FmHistury fmHistory = new FmHistury(SelectedTransport);
            fmHistory.ShowDialog();
        }

        private void ctlHistoryTransport_Click(object sender, EventArgs e)
        {
            OpenSelectedTransportHistory();
        }

        private void ctlHistoryTransportContext_Click(object sender, EventArgs e)
        {
            OpenSelectedTransportHistory();
        }
    }
}
