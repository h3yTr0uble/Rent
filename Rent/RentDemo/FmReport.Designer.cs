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
            this.ctlRecieptsReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ctlToDate = new System.Windows.Forms.DateTimePicker();
            this.ctlFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ctlKindsReports = new System.Windows.Forms.ComboBox();
            this.ctlParkingsAttendanceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ctlRelevanceTransportsReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlReportPicture = new System.Windows.Forms.PictureBox();
            this.RelevanceTransportHoursCoefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelevanceTransportHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParkingAttendanceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecieptReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctlReportPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursCoefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingAttendanceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecieptReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlRecieptsReport
            // 
            this.ctlRecieptsReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ctlToDate.Size = new System.Drawing.Size(166, 22);
            this.ctlToDate.TabIndex = 6;
            // 
            // ctlFromDate
            // 
            this.ctlFromDate.Location = new System.Drawing.Point(72, 12);
            this.ctlFromDate.Name = "ctlFromDate";
            this.ctlFromDate.Size = new System.Drawing.Size(174, 22);
            this.ctlFromDate.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(534, 52);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(185, 24);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Сформировать отчет";
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
            this.ctlKindsReports.Location = new System.Drawing.Point(301, 52);
            this.ctlKindsReports.Name = "ctlKindsReports";
            this.ctlKindsReports.Size = new System.Drawing.Size(166, 24);
            this.ctlKindsReports.TabIndex = 7;
            // 
            // ctlParkingsAttendanceReport
            // 
            this.ctlParkingsAttendanceReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ctlRelevanceTransportsReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlRelevanceTransportsReport.LocalReport.ReportEmbeddedResource = "RentDemo.Reports.RelevanceTransportsReport.rdlc";
            this.ctlRelevanceTransportsReport.Location = new System.Drawing.Point(12, 95);
            this.ctlRelevanceTransportsReport.Name = "ctlRelevanceTransportsReport";
            this.ctlRelevanceTransportsReport.ServerReport.BearerToken = null;
            this.ctlRelevanceTransportsReport.Size = new System.Drawing.Size(776, 343);
            this.ctlRelevanceTransportsReport.TabIndex = 9;
            this.ctlRelevanceTransportsReport.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "до";
            // 
            // ctlReportPicture
            // 
            this.ctlReportPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlReportPicture.Location = new System.Drawing.Point(12, 95);
            this.ctlReportPicture.Name = "ctlReportPicture";
            this.ctlReportPicture.Size = new System.Drawing.Size(776, 343);
            this.ctlReportPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctlReportPicture.TabIndex = 12;
            this.ctlReportPicture.TabStop = false;
            // 
            // RelevanceTransportHoursCoefBindingSource
            // 
            this.RelevanceTransportHoursCoefBindingSource.DataSource = typeof(Entities.TransportReport);
            // 
            // RelevanceTransportHoursBindingSource
            // 
            this.RelevanceTransportHoursBindingSource.DataSource = typeof(Entities.TransportReport);
            // 
            // ParkingAttendanceReportBindingSource
            // 
            this.ParkingAttendanceReportBindingSource.DataSource = typeof(Entities.ParkingAttendancePerort);
            // 
            // RecieptReportBindingSource
            // 
            this.RecieptReportBindingSource.DataSource = typeof(Entities.RecieptReport);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тип отчета:";
            // 
            // FmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctlReportPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlRelevanceTransportsReport);
            this.Controls.Add(this.ctlParkingsAttendanceReport);
            this.Controls.Add(this.ctlKindsReports);
            this.Controls.Add(this.ctlToDate);
            this.Controls.Add(this.ctlFromDate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.ctlRecieptsReport);
            this.Name = "FmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование отчетов";
            this.Load += new System.EventHandler(this.FmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlReportPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursCoefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanceTransportHoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingAttendanceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecieptReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ctlReportPicture;
        private System.Windows.Forms.Label label3;
    }
}