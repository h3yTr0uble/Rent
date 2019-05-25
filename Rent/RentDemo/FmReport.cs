﻿using DAL;
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
        }

        private void FmReport_Load(object sender, EventArgs e)
        {
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ctlRecieptsReport.Visible = false;
            ctlParkingsAttendanceReport.Visible = false;
            ctlRecieptsReport.Visible = false;

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
                GenerateRecieptsReport(fromDate, toDate);
                return;
            }
        }

        private void GenerateRecieptsReport(DateTime fromDate, DateTime toDate)
        {
            ctlRecieptsReport.Visible = true;
            RecieptReportBindingSource.DataSource = RecieptReportDAO.GetRecieptsReport(fromDate, toDate).ToList();
            ctlRecieptsReport.RefreshReport();
        }

        private void GenerateParkingsAttendanceReport(DateTime fromDate, DateTime toDate)
        {
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            //reportDataSource.Name = "ParkingsAttendance";
            //reportDataSource.Value = ParkingAttendanceReportBindingSource;
            //ctlParkingsAttendanceReport.LocalReport.DataSources.Add(reportDataSource);
            ctlParkingsAttendanceReport.Visible = true;
            ParkingAttendanceReportBindingSource.DataSource = ParkingAttendanceReportDAO.GetParkingsAttendance(fromDate, toDate).ToList();
            ctlParkingsAttendanceReport.RefreshReport();
        }
    }
}