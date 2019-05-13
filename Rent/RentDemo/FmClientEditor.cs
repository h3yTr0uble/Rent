using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entities;

namespace RentDemo
{
    public partial class FmClientEditor : Form
    {
        private bool createNew = true;
        private Client client;

        public FmClientEditor()
        {
            InitializeComponent();
        }

        public FmClientEditor(Client client)
        {
            createNew = false;
            this.client = client;
            InitializeComponent();
        }

        private void FmClientEditor_Load(object sender, EventArgs e)
        {
            if (createNew == true)
            {
                this.Text = "Добавление нового клиента";
                btnOK.Text = "Создать";
                client = new Client();
            }
            else
            {
                this.Text = "Редактирование записи о клиенте";
                btnOK.Text = "Обновить";

                txtPassport.Text = client.Passport;
                txtFullName.Text = client.FullName;
                txtPhone.Text = client.Phone;
            }

            FillCtlDrivingCategories();
        }

        private void FillCtlDrivingCategories()
        {
            List<DrivingCategory> drivingCategoryes = new List<DrivingCategory>(GetDrivingCategories());

            foreach (DrivingCategory drivingCategory in drivingCategoryes)
            {
                ctlDrivingCategories.Items.Add(drivingCategory);

                DrivingCategory clientsDrivingCategory = client.DrivingCategories.Select(c => c).Where(c => c.Id == drivingCategory.Id).SingleOrDefault();

                if (clientsDrivingCategory != null)
                {
                    ctlDrivingCategories.SelectedIndex = ctlDrivingCategories.Items.Count - 1;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }

            UpdateClient(client);

            if (createNew)
            {
                ClientDAO.Add(client);
            }
            else
            {
                ClientDAO.Edit(client);
            }
        }

        private void UpdateClient(Client client)
        {
            client.Passport = txtPassport.Text;
            client.FullName = txtFullName.Text;
            client.Phone = txtPhone.Text;
            client.DrivingCategories = new List<DrivingCategory>();
            for (int i = 0; i < ctlDrivingCategories.Items.Count; i++)
            {
                if (ctlDrivingCategories.GetSelected(i))
                {
                    client.DrivingCategories.Add((DrivingCategory)ctlDrivingCategories.Items[i]);
                }
            }
        }

        private IEnumerable<DrivingCategory> GetDrivingCategories()
        {
            return DrivingCategoryDAO.GetDrivingCategories();
        }
    }
}
