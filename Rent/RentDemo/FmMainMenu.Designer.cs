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
            this.btnTransport.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // FmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 575);
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
    }
}