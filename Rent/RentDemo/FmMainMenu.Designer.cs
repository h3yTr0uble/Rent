namespace RentDemo
{
    partial class FmMainMenu
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
            this.ctlEmployee = new System.Windows.Forms.Label();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnReciept = new System.Windows.Forms.Button();
            this.btnRecieptsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlEmployee
            // 
            this.ctlEmployee.AutoSize = true;
            this.ctlEmployee.Location = new System.Drawing.Point(165, 549);
            this.ctlEmployee.Name = "ctlEmployee";
            this.ctlEmployee.Size = new System.Drawing.Size(84, 17);
            this.ctlEmployee.TabIndex = 0;
            this.ctlEmployee.Text = "ctlEmployee";
            // 
            // btnTransport
            // 
            this.btnTransport.Location = new System.Drawing.Point(144, 52);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(137, 45);
            this.btnTransport.TabIndex = 1;
            this.btnTransport.Text = "btnTransport";
            this.btnTransport.UseVisualStyleBackColor = true;
            this.btnTransport.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(144, 112);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(137, 45);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "btnClient";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnReciept
            // 
            this.btnReciept.Location = new System.Drawing.Point(144, 176);
            this.btnReciept.Name = "btnReciept";
            this.btnReciept.Size = new System.Drawing.Size(137, 45);
            this.btnReciept.TabIndex = 3;
            this.btnReciept.Text = "btnReciept";
            this.btnReciept.UseVisualStyleBackColor = true;
            this.btnReciept.Click += new System.EventHandler(this.btnReciept_Click);
            // 
            // btnRecieptsList
            // 
            this.btnRecieptsList.Location = new System.Drawing.Point(144, 248);
            this.btnRecieptsList.Name = "btnRecieptsList";
            this.btnRecieptsList.Size = new System.Drawing.Size(137, 45);
            this.btnRecieptsList.TabIndex = 4;
            this.btnRecieptsList.Text = "btnRecieptsList";
            this.btnRecieptsList.UseVisualStyleBackColor = true;
            this.btnRecieptsList.Click += new System.EventHandler(this.btnRecieptsList_Click);
            // 
            // FmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 575);
            this.Controls.Add(this.btnRecieptsList);
            this.Controls.Add(this.btnReciept);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnTransport);
            this.Controls.Add(this.ctlEmployee);
            this.Name = "FmMainMenu";
            this.Text = "FmMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctlEmployee;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnReciept;
        private System.Windows.Forms.Button btnRecieptsList;
    }
}