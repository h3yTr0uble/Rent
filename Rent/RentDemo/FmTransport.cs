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
    }
}
