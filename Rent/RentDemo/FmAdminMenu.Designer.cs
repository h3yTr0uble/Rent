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
            this.btnBackupCreation = new System.Windows.Forms.Button();
            this.btnRestoreDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackupCreation
            // 
            this.btnBackupCreation.Location = new System.Drawing.Point(156, 55);
            this.btnBackupCreation.Name = "btnBackupCreation";
            this.btnBackupCreation.Size = new System.Drawing.Size(278, 42);
            this.btnBackupCreation.TabIndex = 0;
            this.btnBackupCreation.Text = "btnBackupCreation";
            this.btnBackupCreation.UseVisualStyleBackColor = true;
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Location = new System.Drawing.Point(156, 122);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(278, 39);
            this.btnRestoreDatabase.TabIndex = 1;
            this.btnRestoreDatabase.Text = "btnRestoreDatabase";
            this.btnRestoreDatabase.UseVisualStyleBackColor = true;
            // 
            // FmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 573);
            this.Controls.Add(this.btnRestoreDatabase);
            this.Controls.Add(this.btnBackupCreation);
            this.Name = "FmAdminMenu";
            this.Text = "FmAdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackupCreation;
        private System.Windows.Forms.Button btnRestoreDatabase;
    }
}