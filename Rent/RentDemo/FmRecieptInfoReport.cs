using Entities;
using Microsoft.Reporting.WinForms;
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
    public partial class FmRecieptInfoReport : Form
    {
        private Reciept reciept;

        public FmRecieptInfoReport(Reciept reciept)
        {
            this.reciept = reciept;
            InitializeComponent();
        }

        private void FmRecieptInfoReport_Load(object sender, EventArgs e)
        {
            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("idReciept", reciept.Id.ToString()));
            reportParameters.Add(new ReportParameter("creationDate", reciept.CreationDate.ToString()));
            reportParameters.Add(new ReportParameter("transportTitle", reciept.Transport.Title));
            reportParameters.Add(new ReportParameter("clientFullName", reciept.Client.FullName));
            reportParameters.Add(new ReportParameter("sourceParking", reciept.Parking.Title));
            reportParameters.Add(new ReportParameter("tariffTitle", reciept.Tariff.Title));
            reportParameters.Add(new ReportParameter("necessaryReturnDate", reciept.NecessaryReturnDate.ToString()));
            reportParameters.Add(new ReportParameter("employeeFullName", reciept.Employee.FullName));
            reportParameters.Add(new ReportParameter("price", reciept.Price.ToString()));
            if (reciept.DriverReciept != null)
            {
                reportParameters.Add(new ReportParameter("driverMessage", "Водитель:"));
                reportParameters.Add(new ReportParameter("driverFullName", reciept.DriverReciept.Driver.FullName));
            }

            if (reciept.RecieptForReturn != null)
            {
                reportParameters.Add(new ReportParameter("returnDateMessage", "Дата возврата"));
                reportParameters.Add(new ReportParameter("returnDate", reciept.RecieptForReturn.CreationDate.ToString()));
                reportParameters.Add(new ReportParameter("returnParkingMessage", "Возвращено на парковку:"));
                reportParameters.Add(new ReportParameter("returnParking", reciept.RecieptForReturn.Parking.Title));

                if (reciept.RecieptForReturn.FineReciept != null)
                {
                    reportParameters.Add(new ReportParameter("fineMessage", "Штраф:"));
                    reportParameters.Add(new ReportParameter("fine", reciept.RecieptForReturn.FineReciept.Fine.ToString()));
                }
            }

            ctlRecieptInfo.LocalReport.SetParameters(reportParameters);
            this.ctlRecieptInfo.RefreshReport();
        }
    }
}
