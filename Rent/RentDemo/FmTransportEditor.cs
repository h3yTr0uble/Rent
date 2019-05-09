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
    public partial class FmTransportEditor : Form
    {
        private bool createNew = true;
        public Transport transport { get; }

        public FmTransportEditor()
        {
            InitializeComponent();
        }

        public FmTransportEditor(Transport transport)
        {
            createNew = false;
        }

        private void FmTransportEditor_Load(object sender, EventArgs e)
        {
            if (createNew == true)
            {
                this.Text = "Добавление нового транспорта";
                btnOK.Text = "Создать";
            }
            else
            {
                this.Text = "Редактирование записи о транспорте";
                btnOK.Text = "Обновить";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
