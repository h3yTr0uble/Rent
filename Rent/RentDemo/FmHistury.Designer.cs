namespace RentDemo
{
    partial class FmHistury
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
            this.ctlReciepts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ctlReciepts)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlReciepts
            // 
            this.ctlReciepts.AllowUserToAddRows = false;
            this.ctlReciepts.AllowUserToDeleteRows = false;
            this.ctlReciepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlReciepts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Transport,
            this.Client,
            this.CreationDate});
            this.ctlReciepts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlReciepts.Location = new System.Drawing.Point(14, 14);
            this.ctlReciepts.Margin = new System.Windows.Forms.Padding(5);
            this.ctlReciepts.MultiSelect = false;
            this.ctlReciepts.Name = "ctlReciepts";
            this.ctlReciepts.ReadOnly = true;
            this.ctlReciepts.RowHeadersVisible = false;
            this.ctlReciepts.RowTemplate.Height = 24;
            this.ctlReciepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlReciepts.Size = new System.Drawing.Size(1000, 226);
            this.ctlReciepts.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Номер квитанции";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Transport
            // 
            this.Transport.DataPropertyName = "transport";
            this.Transport.HeaderText = "Транспорт";
            this.Transport.Name = "Transport";
            this.Transport.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "client";
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "creationDate";
            this.CreationDate.HeaderText = "Дата оформления";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // FmHistury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 528);
            this.Controls.Add(this.ctlReciepts);
            this.Name = "FmHistury";
            this.Load += new System.EventHandler(this.FmHistury_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlReciepts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ctlReciepts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
    }
}