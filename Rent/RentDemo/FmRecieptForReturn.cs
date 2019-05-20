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
    public partial class FmRecieptForReturn : Form
    {
        private Reciept reciept;
        private const double fineCoef = 1.5;

        public FmRecieptForReturn(Reciept reciept)
        {
            this.reciept = reciept;
            InitializeComponent();
            FillCtlParkings(GetParkings());
        }

        private static IEnumerable<Parking> GetParkings()
        {
            return ParkingDAO.GetParkings();
        }

        private void FillCtlParkings(IEnumerable<Parking> parking)
        {
            ctlParkings.SelectedItem = null;
            ctlParkings.Items.Clear();
            ctlParkings.Items.AddRange(parking.ToArray());
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (ctlCreationDate.Value > reciept.NecessaryReturnDate)
            {
                gbFine.Visible = true;
                TimeSpan interval = ctlCreationDate.Value - reciept.NecessaryReturnDate;
                txtInterval.Text = Math.Round(interval.TotalHours).ToString();
                txtFine.Text = CalculateFine(interval, reciept).ToString();
            }
            else
            {
                RecieptForReturn recieptForReturn = CreateRecieptForReturn();
                RecieptForReturnDAO.Add(recieptForReturn, reciept);

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private double CalculateFine(TimeSpan interval, Reciept reciept)
        {
            double fine = reciept.Tariff.Price * interval.TotalHours * reciept.Transport.Coef * reciept.Transport.CorrectCoef * fineCoef;

            return Math.Round(fine);
        }

        private void btnEnterFine_Click(object sender, EventArgs e)
        {
            RecieptForReturn recieptForReturn = CreateRecieptForReturn();
            FineReciept fineReciept = CreateFineReciept();
            recieptForReturn.FineReciept = fineReciept;
            RecieptForReturnDAO.Add(recieptForReturn, reciept);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private FineReciept CreateFineReciept()
        {
            FineReciept fineReciept = new FineReciept(double.Parse(txtFine.Text));

            return fineReciept;
        }

        private RecieptForReturn CreateRecieptForReturn()
        {
            RecieptForReturn recieptForReturn = new RecieptForReturn();
            recieptForReturn.Parking = (Parking)ctlParkings.SelectedItem;
            recieptForReturn.CreationDate = ctlCreationDate.Value;

            return recieptForReturn;
        }
    }
}
