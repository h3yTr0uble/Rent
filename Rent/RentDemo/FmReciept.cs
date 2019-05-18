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
    public partial class FmReciept : Form
    {
        private Employee employee;
        private List<Tariff> tariffs;
        private Tariff actualTariff;
        private const double driverCoef = 1.3;

        public FmReciept(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void FmReciept_Load(object sender, EventArgs e)
        {
            lblEmployee.Text = employee.ToString();
            FillComboBox(ctlClient, GetClients());
            FillComboBox(ctlTransport, GetAvailableTransports());
            tariffs = new List<Tariff>(GetTariffs());
            RefreshDinamicItems();
        }

        private void FillComboBox(ComboBox comboBox, IEnumerable<BaseEntity> items)
        {
            comboBox.SelectedItem = null;
            comboBox.Items.Clear();
            comboBox.Items.AddRange(items.ToArray());
        }

        private IEnumerable<Client> GetClients()
        {
            return ClientDAO.GetClients();
        }

        private IEnumerable<Transport> GetAvailableTransports()
        {
            List<Transport> transports = new List<Transport>(TransportDAO.GetTransports());
            return transports.Select(t => t).Where(t => t.Parking != null);
        }

        private void ctlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClientPassport.Text = ((Client)ctlClient.SelectedItem).Passport;
        }

        private void ctlHours_ValueChanged(object sender, EventArgs e)
        {
            if (ctlHours.Value >= 24)
            {
                ctlDays.Value++;
                ctlHours.Value -= 24;
            }

            RefreshDinamicItems();
        }

        private IEnumerable<Tariff> GetTariffs()
        {
            return TariffsDAO.GetTariffs();
        }

        private Tariff ChooseTariff(IEnumerable<Tariff> tariffs)
        {
            int interval = (int)(ctlDays.Value * 24 + ctlHours.Value);
            IEnumerable<Tariff> tariffsDesc = tariffs.Select(t => t).OrderByDescending(t => t.Interval);

            foreach (Tariff tariff in tariffsDesc)
            {
                if (interval >= tariff.Interval)
                {
                    return tariff;
                }
            }

            return tariffsDesc.Last();
        }

        private void ctlDays_ValueChanged(object sender, EventArgs e)
        {
            RefreshDinamicItems();
        }

        private void RefreshDinamicItems()
        {
            actualTariff = ChooseTariff(tariffs);
            lblTariff.Text = actualTariff.ToString();
            lblReturnDate.Text = CalculateReturnDate().ToString();
            lblPrice.Text = CalculatePrice().ToString();
        }

        private DateTime CalculateReturnDate()
        {
            DateTime date = ctlCreationDate.Value;
            int interval = (int)(ctlDays.Value * 24 + ctlHours.Value);
            return date.AddHours(interval);
        }

        private void btnCreateReciept_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            Reciept reciept = CreateNewReciept();
            RecieptDAO.Add(reciept);
        }

        private Reciept CreateNewReciept()
        {
            Reciept reciept = new Reciept();
            reciept.Transport = (Transport)ctlTransport.SelectedItem;
            reciept.Client = (Client)ctlClient.SelectedItem;
            reciept.Tariff = actualTariff;
            reciept.Parking = ((Transport)ctlTransport.SelectedItem).Parking;
            reciept.Employee = employee;
            reciept.CreationDate = ctlCreationDate.Value;
            reciept.NecessaryReturnDate = CalculateReturnDate();
            reciept.Price = CalculatePrice();

            return reciept;
        }

        private double CalculatePrice()
        {
            if (ctlTransport.SelectedItem == null)
            {
                return 0;
            }

            Transport transport = ((Transport)ctlTransport.SelectedItem);
            int interval = (int)(ctlDays.Value * 24 + ctlHours.Value);
            double priece = actualTariff.Price * interval * transport.Coef * transport.CorrectCoef;
            if (checkDriver.Checked)
            {
                priece *= driverCoef;
            }

            return priece;
        }

        private void checkDriver_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = CalculatePrice().ToString();
        }

        private void ctlTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = CalculatePrice().ToString();
        }
    }
}
