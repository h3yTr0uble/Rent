namespace RentDemo
{
    partial class FmRecieptInfoReport
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
            this.ctlRecieptInfo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ctlRecieptInfo
            // 
            this.ctlRecieptInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRecieptInfo.LocalReport.ReportEmbeddedResource = "RentDemo.Reports.RecieptInfoReport.rdlc";
            this.ctlRecieptInfo.Location = new System.Drawing.Point(0, 0);
            this.ctlRecieptInfo.Name = "ctlRecieptInfo";
            this.ctlRecieptInfo.ServerReport.BearerToken = null;
            this.ctlRecieptInfo.Size = new System.Drawing.Size(800, 550);
            this.ctlRecieptInfo.TabIndex = 0;
            // 
            // FmRecieptInfoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.ctlRecieptInfo);
            this.Name = "FmRecieptInfoReport";
            this.Text = "Квитанция №";
            this.Load += new System.EventHandler(this.FmRecieptInfoReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ctlRecieptInfo;
    }
}