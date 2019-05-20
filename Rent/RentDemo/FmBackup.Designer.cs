namespace RentDemo
{
    partial class FmBackup
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
            this.gbCreationBackup = new System.Windows.Forms.GroupBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnChangeBackupPath = new System.Windows.Forms.Button();
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.gbRestoreDatabase = new System.Windows.Forms.GroupBox();
            this.txtRestoreFilePath = new System.Windows.Forms.TextBox();
            this.openFileRestoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseRestoreFile = new System.Windows.Forms.Button();
            this.btnRestoreDatabase = new System.Windows.Forms.Button();
            this.gbCreationBackup.SuspendLayout();
            this.gbRestoreDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreationBackup
            // 
            this.gbCreationBackup.Controls.Add(this.btnCreateBackup);
            this.gbCreationBackup.Controls.Add(this.btnChangeBackupPath);
            this.gbCreationBackup.Controls.Add(this.txtBackupPath);
            this.gbCreationBackup.Location = new System.Drawing.Point(12, 12);
            this.gbCreationBackup.Name = "gbCreationBackup";
            this.gbCreationBackup.Size = new System.Drawing.Size(622, 225);
            this.gbCreationBackup.TabIndex = 0;
            this.gbCreationBackup.TabStop = false;
            this.gbCreationBackup.Text = "Создание резервной копии";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(98, 41);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(252, 22);
            this.txtBackupPath.TabIndex = 0;
            // 
            // btnChangeBackupPath
            // 
            this.btnChangeBackupPath.Location = new System.Drawing.Point(356, 40);
            this.btnChangeBackupPath.Name = "btnChangeBackupPath";
            this.btnChangeBackupPath.Size = new System.Drawing.Size(196, 23);
            this.btnChangeBackupPath.TabIndex = 1;
            this.btnChangeBackupPath.Text = "btnChangeBackupPath";
            this.btnChangeBackupPath.UseVisualStyleBackColor = true;
            this.btnChangeBackupPath.Click += new System.EventHandler(this.btnChangeBackupPath_Click);
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.Location = new System.Drawing.Point(338, 167);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(278, 42);
            this.btnCreateBackup.TabIndex = 2;
            this.btnCreateBackup.Text = "btnCreateBackup";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // gbRestoreDatabase
            // 
            this.gbRestoreDatabase.Controls.Add(this.btnRestoreDatabase);
            this.gbRestoreDatabase.Controls.Add(this.btnChooseRestoreFile);
            this.gbRestoreDatabase.Controls.Add(this.txtRestoreFilePath);
            this.gbRestoreDatabase.Location = new System.Drawing.Point(12, 253);
            this.gbRestoreDatabase.Name = "gbRestoreDatabase";
            this.gbRestoreDatabase.Size = new System.Drawing.Size(622, 236);
            this.gbRestoreDatabase.TabIndex = 1;
            this.gbRestoreDatabase.TabStop = false;
            this.gbRestoreDatabase.Text = "Восстановление базы данных";
            // 
            // txtRestoreFilePath
            // 
            this.txtRestoreFilePath.Location = new System.Drawing.Point(28, 45);
            this.txtRestoreFilePath.Name = "txtRestoreFilePath";
            this.txtRestoreFilePath.Size = new System.Drawing.Size(322, 22);
            this.txtRestoreFilePath.TabIndex = 0;
            // 
            // openFileRestoreDialog
            // 
            this.openFileRestoreDialog.DefaultExt = "Bak";
            this.openFileRestoreDialog.Filter = "Резервные копии(*.Bak)|*.Bak";
            this.openFileRestoreDialog.RestoreDirectory = true;
            // 
            // btnChooseRestoreFile
            // 
            this.btnChooseRestoreFile.Location = new System.Drawing.Point(356, 44);
            this.btnChooseRestoreFile.Name = "btnChooseRestoreFile";
            this.btnChooseRestoreFile.Size = new System.Drawing.Size(196, 23);
            this.btnChooseRestoreFile.TabIndex = 2;
            this.btnChooseRestoreFile.Text = "btnChooseRestoreFile";
            this.btnChooseRestoreFile.UseVisualStyleBackColor = true;
            this.btnChooseRestoreFile.Click += new System.EventHandler(this.btnChooseRestoreFile_Click);
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Location = new System.Drawing.Point(338, 174);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(278, 39);
            this.btnRestoreDatabase.TabIndex = 3;
            this.btnRestoreDatabase.Text = "btnRestoreDatabase";
            this.btnRestoreDatabase.UseVisualStyleBackColor = true;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // FmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 501);
            this.Controls.Add(this.gbRestoreDatabase);
            this.Controls.Add(this.gbCreationBackup);
            this.Name = "FmBackup";
            this.Text = "FmBackup";
            this.gbCreationBackup.ResumeLayout(false);
            this.gbCreationBackup.PerformLayout();
            this.gbRestoreDatabase.ResumeLayout(false);
            this.gbRestoreDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreationBackup;
        private System.Windows.Forms.Button btnChangeBackupPath;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnCreateBackup;
        private System.Windows.Forms.GroupBox gbRestoreDatabase;
        private System.Windows.Forms.Button btnChooseRestoreFile;
        private System.Windows.Forms.TextBox txtRestoreFilePath;
        private System.Windows.Forms.OpenFileDialog openFileRestoreDialog;
        private System.Windows.Forms.Button btnRestoreDatabase;
    }
}