using BLL;
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
    public partial class FmEmployeeEditor : Form
    {
        private bool createNew = true;
        private Employee employee;

        public FmEmployeeEditor()
        {
            InitializeComponent();
        }

        public FmEmployeeEditor(Employee employee)
        {
            createNew = false;
            this.employee = employee;
            InitializeComponent();
        }

        private void FmEmployeeEditor_Load(object sender, EventArgs e)
        {
            FillCtlPosition();

            if (createNew == true)
            {
                this.Text = "Добавление нового работника";
                btnOK.Text = "Создать";
                employee = new Employee();
            }
            else
            {
                this.Text = "Редактирование записи о работнике";
                btnOK.Text = "Обновить";

                txtPassport.Text = employee.Passport;
                txtFullName.Text = employee.FullName;
                txtPhone.Text = employee.Phone;
                ctlPosition.SelectedItem = employee.Position;
                if (employee.Account != null)
                {
                    txtLogin.Text = employee.Account.Login;
                }
            }

            FillCtlDrivingCategories();
        }

        private void FillCtlDrivingCategories()
        {
            List<DrivingCategory> drivingCategoryes = new List<DrivingCategory>(GetDrivingCategories());

            foreach (DrivingCategory drivingCategory in drivingCategoryes)
            {
                ctlDrivingCategories.Items.Add(drivingCategory);

                DrivingCategory eployeesDrivingCategory = employee.DrivingCategories.Select(c => c).Where(c => c.Id == drivingCategory.Id).SingleOrDefault();

                if (eployeesDrivingCategory != null)
                {
                    ctlDrivingCategories.SelectedIndex = ctlDrivingCategories.Items.Count - 1;
                }
            }
        }

        private void FillCtlPosition()
        {
            List<Position> positions = new List<Position>(GetPositions());

            foreach (Position position in positions)
            {
                ctlPosition.Items.Add(position);
            }
        }

        private IEnumerable<Position> GetPositions()
        {
            return PositionDAO.GetPositions();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }

            UpdateEmployee(employee);

            if (createNew)
            {
                EmployeeDAO.Add(employee);
            }
            else
            {
                EmployeeDAO.Edit(employee);
            }
        }

        private void UpdateEmployee(Employee employee)
        {
            employee.Passport = txtPassport.Text;
            employee.FullName = txtFullName.Text;
            employee.Phone = txtPhone.Text;
            employee.Position = (Position)ctlPosition.SelectedItem;
            employee.DrivingCategories = new List<DrivingCategory>();
            for (int i = 0; i < ctlDrivingCategories.Items.Count; i++)
            {
                if (ctlDrivingCategories.GetSelected(i))
                {
                    employee.DrivingCategories.Add((DrivingCategory)ctlDrivingCategories.Items[i]);
                }
            }

            if (!string.IsNullOrEmpty(txtLogin.Text))
            {
                if (employee.Account == null)
                {
                    employee.Account = new Account();
                }

                employee.Account.Login = txtLogin.Text;

                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    employee.Account.Password = MD5Hasher.GetHash(txtPassword.Text);
                }
            }
        }

        private IEnumerable<DrivingCategory> GetDrivingCategories()
        {
            return DrivingCategoryDAO.GetDrivingCategories();
        }
    }
}
