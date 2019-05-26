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
            this.btnReport = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlEmployee
            // 
            this.ctlEmployee.AutoSize = true;
            this.ctlEmployee.Location = new System.Drawing.Point(14, 446);
            this.ctlEmployee.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ctlEmployee.Name = "ctlEmployee";
            this.ctlEmployee.Size = new System.Drawing.Size(134, 25);
            this.ctlEmployee.TabIndex = 0;
            this.ctlEmployee.Text = "ctlEmployee";
            // 
            // btnTransport
            // 
            this.btnTransport.Location = new System.Drawing.Point(106, 195);
            this.btnTransport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(270, 67);
            this.btnTransport.TabIndex = 1;
            this.btnTransport.Text = "Транспорт";
            this.btnTransport.UseVisualStyleBackColor = true;
            this.btnTransport.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(106, 272);
            this.btnClient.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(270, 70);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Клиенты";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnReciept
            // 
            this.btnReciept.Location = new System.Drawing.Point(106, 35);
            this.btnReciept.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReciept.Name = "btnReciept";
            this.btnReciept.Size = new System.Drawing.Size(270, 70);
            this.btnReciept.TabIndex = 3;
            this.btnReciept.Text = "Оформить квитанцию";
            this.btnReciept.UseVisualStyleBackColor = true;
            this.btnReciept.Click += new System.EventHandler(this.btnReciept_Click);
            // 
            // btnRecieptsList
            // 
            this.btnRecieptsList.Location = new System.Drawing.Point(106, 115);
            this.btnRecieptsList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRecieptsList.Name = "btnRecieptsList";
            this.btnRecieptsList.Size = new System.Drawing.Size(270, 70);
            this.btnRecieptsList.TabIndex = 4;
            this.btnRecieptsList.Text = "Квитанции";
            this.btnRecieptsList.UseVisualStyleBackColor = true;
            this.btnRecieptsList.Click += new System.EventHandler(this.btnRecieptsList_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(106, 352);
            this.btnReport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(270, 70);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Отчеты";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(473, 28);
            this.mainMenu.TabIndex = 6;
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
            // FmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 505);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRecieptsList);
            this.Controls.Add(this.btnReciept);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnTransport);
            this.Controls.Add(this.ctlEmployee);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmMainMenu_FormClosed);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctlEmployee;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnReciept;
        private System.Windows.Forms.Button btnRecieptsList;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlChangeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
    }
}