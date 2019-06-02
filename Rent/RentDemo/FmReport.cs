using DAL;
using Microsoft.Reporting.WinForms;
using RentDemo.Properties;
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
    public partial class FmReport : Form
    {
        private const int RecieptsReportIndex = 0;
        private const int ParkingsAttendanceIndex = 1;
        private const int RelevanceTransportIndex = 2;
        public FmReport()
        {
            InitializeComponent();
            ctlReportPicture.Image = Resources.Report;
        }

        private void FmReport_Load(object sender, EventArgs e)
        {
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ctlRecieptsReport.Visible = false;
            ctlParkingsAttendanceReport.Visible = false;
            ctlRelevanceTransportsReport.Visible = false;
            ctlReportPicture.Visible = false;

            DateTime fromDate = ctlFromDate.Value;
            DateTime toDate = ctlToDate.Value;
            if (ctlKindsReports.SelectedIndex == RecieptsReportIndex)
            {
                GenerateRecieptsReport(fromDate, toDate);
                return;
            }

            if (ctlKindsReports.SelectedIndex == ParkingsAttendanceIndex)
            {
                GenerateParkingsAttendanceReport(fromDate, toDate);
                return;
            }

            if (ctlKindsReports.SelectedIndex == RelevanceTransportIndex)
            {
                GenerateRelevanceTransportsReport(fromDate, toDate);
                return;
            }
        }

        private void GenerateRecieptsReport(DateTime fromDate, DateTime toDate)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource.Name = "Reciepts";
            reportDataSource.Value = this.RecieptReportBindingSource;
            this.ctlRecieptsReport.LocalReport.DataSources.Add(reportDataSource);
            ctlRecieptsReport.Visible = true;
            RecieptReportBindingSource.DataSource = RecieptReportDAO.GetRecieptsReport(fromDate, toDate).ToList();

            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("fromDate", fromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("toDate", toDate.ToShortDateString()));
            ctlRecieptsReport.LocalReport.SetParameters(reportParameters);

            ctlRecieptsReport.RefreshReport();
        }

        private void GenerateParkingsAttendanceReport(DateTime fromDate, DateTime toDate)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource.Name = "ParkingsAttendance";
            reportDataSource.Value = this.ParkingAttendanceReportBindingSource;
            this.ctlParkingsAttendanceReport.LocalReport.DataSources.Add(reportDataSource);
            ctlParkingsAttendanceReport.Visible = true;
            ParkingAttendanceReportBindingSource.DataSource = ParkingAttendanceReportDAO.GetParkingsAttendance(fromDate, toDate).ToList();

            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("fromDate", fromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("toDate", toDate.ToShortDateString()));
            ctlParkingsAttendanceReport.LocalReport.SetParameters(reportParameters);

            ctlParkingsAttendanceReport.RefreshReport();
        }

        private void GenerateRelevanceTransportsReport(DateTime fromDate, DateTime toDate)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "RelevanceTransportHoursCoef";
            reportDataSource1.Value = this.RelevanceTransportHoursCoefBindingSource;
            reportDataSource2.Name = "RelevanceTransportHours";
            reportDataSource2.Value = this.RelevanceTransportHoursBindingSource;
            this.ctlRelevanceTransportsReport.LocalReport.DataSources.Add(reportDataSource1);
            this.ctlRelevanceTransportsReport.LocalReport.DataSources.Add(reportDataSource2);
            ctlRelevanceTransportsReport.Visible = true;
            RelevanceTransportHoursBindingSource.DataSource = TransportReportDAO.GetTransportHours(fromDate, toDate).ToList();
            RelevanceTransportHoursCoefBindingSource.DataSource = TransportReportDAO.GetTransportHoursCoef(fromDate, toDate).ToList();

            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("fromDate", fromDate.ToShortDateString()));
            reportParameters.Add(new ReportParameter("toDate", toDate.ToShortDateString()));
            ctlRelevanceTransportsReport.LocalReport.SetParameters(reportParameters);

            ctlRelevanceTransportsReport.RefreshReport();
        }
    }
}
