namespace RentDemo
{
    partial class FmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RecieptReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelevanceTransportHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelevanceTransportHoursCoefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParkingAttendanceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctlRecieptsReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ctlToDate = new System.Windows.Forms.DateTimePicker();
            this.ctlFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ctlKindsReports = new System.Windows.Forms.ComboBox();
            this.ctlParkingsAttendanceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ctlRelevanceTransportsReport = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RecieptReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursCoefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingAttendanceReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RecieptReportBindingSource
            // 
            this.RecieptReportBindingSource.DataSource = typeof(Entities.RecieptReport);
            // 
            // RelevanceTransportHoursBindingSource
            // 
            this.RelevanceTransportHoursBindingSource.DataSource = typeof(Entities.TransportReport);
            // 
            // RelevanceTransportHoursCoefBindingSource
            // 
            this.RelevanceTransportHoursCoefBindingSource.DataSource = typeof(Entities.TransportReport);
            // 
            // ParkingAttendanceReportBindingSource
            // 
            this.ParkingAttendanceReportBindingSource.DataSource = typeof(Entities.ParkingAttendancePerort);
            // 
            // ctlRecieptsReport
            // 
            this.ctlRecieptsReport.LocalReport.ReportEmbeddedResource = "RentDemo.Reports.RecieptsReport.rdlc";
            this.ctlRecieptsReport.Location = new System.Drawing.Point(12, 95);
            this.ctlRecieptsReport.Name = "ctlRecieptsReport";
            this.ctlRecieptsReport.ServerReport.BearerToken = null;
            this.ctlRecieptsReport.Size = new System.Drawing.Size(776, 334);
            this.ctlRecieptsReport.TabIndex = 0;
            this.ctlRecieptsReport.Visible = false;
            // 
            // ctlToDate
            // 
            this.ctlToDate.Location = new System.Drawing.Point(301, 12);
            this.ctlToDate.Name = "ctlToDate";
            this.ctlToDate.Size = new System.Drawing.Size(200, 22);
            this.ctlToDate.TabIndex = 6;
            // 
            // ctlFromDate
            // 
            this.ctlFromDate.Location = new System.Drawing.Point(72, 12);
            this.ctlFromDate.Name = "ctlFromDate";
            this.ctlFromDate.Size = new System.Drawing.Size(200, 22);
            this.ctlFromDate.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(570, 53);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(152, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // ctlKindsReports
            // 
            this.ctlKindsReports.FormattingEnabled = true;
            this.ctlKindsReports.Items.AddRange(new object[] {
            "Прибыль по квитанциям",
            "Популярность парковок",
            "Актуальность транспорта"});
            this.ctlKindsReports.Location = new System.Drawing.Point(396, 53);
            this.ctlKindsReports.Name = "ctlKindsReports";
            this.ctlKindsReports.Size = new System.Drawing.Size(121, 24);
            this.ctlKindsReports.TabIndex = 7;
            // 
            // ctlParkingsAttendanceReport
            // 
            reportDataSource1.Name = "ParkingsAttendance";
            reportDataSource1.Value = this.ParkingAttendanceReportBindingSource;
            this.ctlParkingsAttendanceReport.LocalReport.DataSources.Add(reportDataSource1);
            this.ctlParkingsAttendanceReport.LocalReport.ReportEmbeddedResource = "RentDemo.Reports.ParkingsAttendanceReport.rdlc";
            this.ctlParkingsAttendanceReport.Location = new System.Drawing.Point(12, 95);
            this.ctlParkingsAttendanceReport.Name = "ctlParkingsAttendanceReport";
            this.ctlParkingsAttendanceReport.ServerReport.BearerToken = null;
            this.ctlParkingsAttendanceReport.Size = new System.Drawing.Size(776, 334);
            this.ctlParkingsAttendanceReport.TabIndex = 8;
            this.ctlParkingsAttendanceReport.Visible = false;
            // 
            // ctlRelevanceTransportsReport
            // 
            reportDataSource2.Name = "RelevanceTransportHoursCoef";
            reportDataSource2.Value = this.RelevanceTransportHoursCoefBindingSource;
            reportDataSource3.Name = "RelevanceTransportHours";
            reportDataSource3.Value = this.RelevanceTransportHoursBindingSource;
            this.ctlRelevanceTransportsReport.LocalReport.DataSources.Add(reportDataSource2);
            this.ctlRelevanceTransportsReport.LocalReport.DataSources.Add(reportDataSource3);
            this.ctlRelevanceTransportsReport.LocalReport.ReportEmbeddedResource = "RentDemo.Reports.RelevanceTransportsReport.rdlc";
            this.ctlRelevanceTransportsReport.Location = new System.Drawing.Point(12, 95);
            this.ctlRelevanceTransportsReport.Name = "ctlRelevanceTransportsReport";
            this.ctlRelevanceTransportsReport.ServerReport.BearerToken = null;
            this.ctlRelevanceTransportsReport.Size = new System.Drawing.Size(776, 343);
            this.ctlRelevanceTransportsReport.TabIndex = 9;
            this.ctlRelevanceTransportsReport.Visible = false;
            // 
            // FmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlRelevanceTransportsReport);
            this.Controls.Add(this.ctlParkingsAttendanceReport);
            this.Controls.Add(this.ctlKindsReports);
            this.Controls.Add(this.ctlToDate);
            this.Controls.Add(this.ctlFromDate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.ctlRecieptsReport);
            this.Name = "FmReport";
            this.Text = "FmReport";
            this.Load += new System.EventHandler(this.FmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecieptReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursCoefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingAttendanceReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ctlRecieptsReport;
        private System.Windows.Forms.BindingSource RecieptReportBindingSource;
        private System.Windows.Forms.DateTimePicker ctlToDate;
        private System.Windows.Forms.DateTimePicker ctlFromDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox ctlKindsReports;
        private Microsoft.Reporting.WinForms.ReportViewer ctlParkingsAttendanceReport;
        private System.Windows.Forms.BindingSource ParkingAttendanceReportBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer ctlRelevanceTransportsReport;
        private System.Windows.Forms.BindingSource RelevanceTransportHoursBindingSource;
        private System.Windows.Forms.BindingSource RelevanceTransportHoursCoefBindingSource;
    }
}