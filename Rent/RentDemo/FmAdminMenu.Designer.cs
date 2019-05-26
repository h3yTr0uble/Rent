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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSqlAgentSettings = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenBackup
            // 
            this.btnOpenBackup.Location = new System.Drawing.Point(29, 31);
            this.btnOpenBackup.Name = "btnOpenBackup";
            this.btnOpenBackup.Size = new System.Drawing.Size(278, 42);
            this.btnOpenBackup.TabIndex = 2;
            this.btnOpenBackup.Text = "Резервное копирование";
            this.btnOpenBackup.UseVisualStyleBackColor = true;
            this.btnOpenBackup.Click += new System.EventHandler(this.btnOpenBackup_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(29, 79);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(278, 42);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Работники";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSqlAgentSettings
            // 
            this.btnSqlAgentSettings.Location = new System.Drawing.Point(29, 127);
            this.btnSqlAgentSettings.Name = "btnSqlAgentSettings";
            this.btnSqlAgentSettings.Size = new System.Drawing.Size(278, 42);
            this.btnSqlAgentSettings.TabIndex = 4;
            this.btnSqlAgentSettings.Text = "Настройка SQL Agent";
            this.btnSqlAgentSettings.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(334, 28);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlChangeUser,
            this.toolStripMenuItem1,
            this.ctlExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(59, 24);
            this.ctlFile.Text = "Файл";
            // 
            // ctlChangeUser
            // 
            this.ctlChangeUser.Name = "ctlChangeUser";
            this.ctlChangeUser.Size = new System.Drawing.Size(252, 26);
            this.ctlChangeUser.Text = "Сменить пользователя";
            this.ctlChangeUser.Click += new System.EventHandler(this.CtlChangeUser_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // ctlExit
            // 
            this.ctlExit.Name = "ctlExit";
            this.ctlExit.Size = new System.Drawing.Size(252, 26);
            this.ctlExit.Text = "Выход";
            this.ctlExit.Click += new System.EventHandler(this.CtlExit_Click);
            // 
            // FmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 181);
            this.Controls.Add(this.btnSqlAgentSettings);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnOpenBackup);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmAdminMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmAdminMenu_FormClosed);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenBackup;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSqlAgentSettings;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlChangeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
    }
}