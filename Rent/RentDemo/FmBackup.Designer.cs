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
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.btnChangeBackupPath = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.gbRestoreDatabase = new System.Windows.Forms.GroupBox();
            this.btnRestoreDatabase = new System.Windows.Forms.Button();
            this.btnChooseRestoreFile = new System.Windows.Forms.Button();
            this.txtRestoreFilePath = new System.Windows.Forms.TextBox();
            this.openFileRestoreDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.gbCreationBackup.Size = new System.Drawing.Size(562, 111);
            this.gbCreationBackup.TabIndex = 0;
            this.gbCreationBackup.TabStop = false;
            this.gbCreationBackup.Text = "Создание резервной копии";
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.Location = new System.Drawing.Point(295, 76);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(261, 29);
            this.btnCreateBackup.TabIndex = 2;
            this.btnCreateBackup.Text = "Создать резервную копию";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // btnChangeBackupPath
            // 
            this.btnChangeBackupPath.Location = new System.Drawing.Point(380, 21);
            this.btnChangeBackupPath.Name = "btnChangeBackupPath";
            this.btnChangeBackupPath.Size = new System.Drawing.Size(176, 29);
            this.btnChangeBackupPath.TabIndex = 1;
            this.btnChangeBackupPath.Text = "Выбрать путь";
            this.btnChangeBackupPath.UseVisualStyleBackColor = true;
            this.btnChangeBackupPath.Click += new System.EventHandler(this.btnChangeBackupPath_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(28, 21);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(322, 22);
            this.txtBackupPath.TabIndex = 0;
            // 
            // gbRestoreDatabase
            // 
            this.gbRestoreDatabase.Controls.Add(this.btnRestoreDatabase);
            this.gbRestoreDatabase.Controls.Add(this.btnChooseRestoreFile);
            this.gbRestoreDatabase.Controls.Add(this.txtRestoreFilePath);
            this.gbRestoreDatabase.Location = new System.Drawing.Point(12, 129);
            this.gbRestoreDatabase.Name = "gbRestoreDatabase";
            this.gbRestoreDatabase.Size = new System.Drawing.Size(562, 125);
            this.gbRestoreDatabase.TabIndex = 1;
            this.gbRestoreDatabase.TabStop = false;
            this.gbRestoreDatabase.Text = "Восстановление базы данных";
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Location = new System.Drawing.Point(291, 83);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(261, 29);
            this.btnRestoreDatabase.TabIndex = 3;
            this.btnRestoreDatabase.Text = "Восстановить базу данных";
            this.btnRestoreDatabase.UseVisualStyleBackColor = true;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // btnChooseRestoreFile
            // 
            this.btnChooseRestoreFile.Location = new System.Drawing.Point(356, 21);
            this.btnChooseRestoreFile.Name = "btnChooseRestoreFile";
            this.btnChooseRestoreFile.Size = new System.Drawing.Size(196, 44);
            this.btnChooseRestoreFile.TabIndex = 2;
            this.btnChooseRestoreFile.Text = "Выбрать файл резервной копии";
            this.btnChooseRestoreFile.UseVisualStyleBackColor = true;
            this.btnChooseRestoreFile.Click += new System.EventHandler(this.btnChooseRestoreFile_Click);
            // 
            // txtRestoreFilePath
            // 
            this.txtRestoreFilePath.Location = new System.Drawing.Point(28, 21);
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
            // FmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 261);
            this.Controls.Add(this.gbRestoreDatabase);
            this.Controls.Add(this.gbCreationBackup);
            this.Name = "FmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Резервное копирование";
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