namespace RentDemo
{
    partial class FmAdminMenu
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
            this.btnOpenBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenBackup
            // 
            this.btnOpenBackup.Location = new System.Drawing.Point(44, 91);
            this.btnOpenBackup.Name = "btnOpenBackup";
            this.btnOpenBackup.Size = new System.Drawing.Size(278, 42);
            this.btnOpenBackup.TabIndex = 2;
            this.btnOpenBackup.Text = "btnOpenBackup";
            this.btnOpenBackup.UseVisualStyleBackColor = true;
            this.btnOpenBackup.Click += new System.EventHandler(this.btnOpenBackup_Click);
            // 
            // FmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 573);
            this.Controls.Add(this.btnOpenBackup);
            this.Name = "FmAdminMenu";
            this.Text = "FmAdminMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenBackup;
    }
}