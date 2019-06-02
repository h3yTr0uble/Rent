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
    public partial class FmEmployee : Form
    {
        public FmEmployee()
        {
            InitializeComponent();
        }

        private void FillCtlEmployees(IEnumerable<Employee> employees)
        {
            ctlEmployees.DataSource = null;
            ctlEmployees.DataSource = employees;
        }

        private void FmEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>(GetEmployees());
            ctlEmployees.AutoGenerateColumns = false;
            FillCtlEmployees(employees);
        }

        private IEnumerable<Employee> GetEmployees()
        {
            return EmployeeDAO.GetEmployees();
        }

        private void CtlAddEmployeeContext_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }

        private void AddNewEmployee()
        {
            FmEmployeeEditor fmEmployeeEditor = new FmEmployeeEditor();
            if (fmEmployeeEditor.ShowDialog() == DialogResult.OK)
            {
                List<Employee> employees = new List<Employee>(GetEmployees());
                FillCtlEmployees(employees);
            }
        }

        private void CtlAddEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }
    }
}
