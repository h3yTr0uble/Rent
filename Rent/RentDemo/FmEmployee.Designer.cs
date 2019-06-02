namespace RentDemo
{
    partial class FmEmployee
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
            this.components = new System.ComponentModel.Container();
            this.ctlSearch = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnResetSearchResult = new System.Windows.Forms.Button();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.tbPasportPoisk = new System.Windows.Forms.MaskedTextBox();
            this.tbFioPoisk = new System.Windows.Forms.TextBox();
            this.tbTelPoisk = new System.Windows.Forms.MaskedTextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.ctlEmployees = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlAddEmployeeContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditEmployeeContext = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlToMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlEmployees)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlSearch
            // 
            this.ctlSearch.Controls.Add(this.comboBox1);
            this.ctlSearch.Controls.Add(this.radioButton1);
            this.ctlSearch.Controls.Add(this.btnResetSearchResult);
            this.ctlSearch.Controls.Add(this.btnSearchClient);
            this.ctlSearch.Controls.Add(this.tbPasportPoisk);
            this.ctlSearch.Controls.Add(this.tbFioPoisk);
            this.ctlSearch.Controls.Add(this.tbTelPoisk);
            this.ctlSearch.Controls.Add(this.rb1);
            this.ctlSearch.Controls.Add(this.rb3);
            this.ctlSearch.Controls.Add(this.rb2);
            this.ctlSearch.Location = new System.Drawing.Point(5, 285);
            this.ctlSearch.Name = "ctlSearch";
            this.ctlSearch.Size = new System.Drawing.Size(818, 173);
            this.ctlSearch.TabIndex = 13;
            this.ctlSearch.TabStop = false;
            this.ctlSearch.Text = "Поиск по клиентам";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(397, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 146);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 21);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Поиск по должности";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnResetSearchResult
            // 
            this.btnResetSearchResult.Location = new System.Drawing.Point(680, 68);
            this.btnResetSearchResult.Name = "btnResetSearchResult";
            this.btnResetSearchResult.Size = new System.Drawing.Size(103, 23);
            this.btnResetSearchResult.TabIndex = 27;
            this.btnResetSearchResult.Text = "Сбросить";
            this.btnResetSearchResult.UseVisualStyleBackColor = true;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(680, 29);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(103, 22);
            this.btnSearchClient.TabIndex = 26;
            this.btnSearchClient.Text = "Найти";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // tbPasportPoisk
            // 
            this.tbPasportPoisk.Enabled = false;
            this.tbPasportPoisk.Location = new System.Drawing.Point(261, 70);
            this.tbPasportPoisk.Mask = "0000000000";
            this.tbPasportPoisk.Name = "tbPasportPoisk";
            this.tbPasportPoisk.Size = new System.Drawing.Size(397, 22);
            this.tbPasportPoisk.TabIndex = 25;
            this.tbPasportPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFioPoisk
            // 
            this.tbFioPoisk.Enabled = false;
            this.tbFioPoisk.Location = new System.Drawing.Point(261, 29);
            this.tbFioPoisk.MaxLength = 255;
            this.tbFioPoisk.Name = "tbFioPoisk";
            this.tbFioPoisk.Size = new System.Drawing.Size(397, 22);
            this.tbFioPoisk.TabIndex = 24;
            this.tbFioPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTelPoisk
            // 
            this.tbTelPoisk.Enabled = false;
            this.tbTelPoisk.Location = new System.Drawing.Point(261, 108);
            this.tbTelPoisk.Mask = "8(999)-000-00-00";
            this.tbTelPoisk.Name = "tbTelPoisk";
            this.tbTelPoisk.Size = new System.Drawing.Size(397, 22);
            this.tbTelPoisk.TabIndex = 22;
            this.tbTelPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(24, 30);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(127, 21);
            this.rb1.TabIndex = 21;
            this.rb1.TabStop = true;
            this.rb1.Text = "Поиск по ФИО";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(24, 108);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(211, 21);
            this.rb3.TabIndex = 20;
            this.rb3.TabStop = true;
            this.rb3.Text = "Поиск по номеру телефона";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(24, 70);
            this.rb2.Margin = new System.Windows.Forms.Padding(20);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(154, 21);
            this.rb2.TabIndex = 19;
            this.rb2.TabStop = true;
            this.rb2.Text = "Поиск по паспорту";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // ctlEmployees
            // 
            this.ctlEmployees.AllowUserToAddRows = false;
            this.ctlEmployees.AllowUserToDeleteRows = false;
            this.ctlEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Position});
            this.ctlEmployees.ContextMenuStrip = this.contextMenu;
            this.ctlEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlEmployees.Location = new System.Drawing.Point(5, 25);
            this.ctlEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmployees.MultiSelect = false;
            this.ctlEmployees.Name = "ctlEmployees";
            this.ctlEmployees.ReadOnly = true;
            this.ctlEmployees.RowHeadersVisible = false;
            this.ctlEmployees.RowHeadersWidth = 51;
            this.ctlEmployees.RowTemplate.Height = 24;
            this.ctlEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlEmployees.Size = new System.Drawing.Size(818, 252);
            this.ctlEmployees.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Passport";
            this.Column1.HeaderText = "Паспорт";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FullName";
            this.Column2.HeaderText = "ФИО";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "Телефон";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 155;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Должность";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 125;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddEmployeeContext,
            this.ctlEditEmployeeContext});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(259, 52);
            // 
            // ctlAddEmployeeContext
            // 
            this.ctlAddEmployeeContext.Name = "ctlAddEmployeeContext";
            this.ctlAddEmployeeContext.Size = new System.Drawing.Size(258, 24);
            this.ctlAddEmployeeContext.Text = "Добавить работника";
            this.ctlAddEmployeeContext.Click += new System.EventHandler(this.CtlAddEmployeeContext_Click);
            // 
            // ctlEditEmployeeContext
            // 
            this.ctlEditEmployeeContext.Name = "ctlEditEmployeeContext";
            this.ctlEditEmployeeContext.Size = new System.Drawing.Size(258, 24);
            this.ctlEditEmployeeContext.Text = "Редактировать работника";
            this.ctlEditEmployeeContext.Click += new System.EventHandler(this.CtlEditEmployeeContext_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(832, 28);
            this.mainMenu.TabIndex = 15;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddEmployee,
            this.ctlEditEmployee,
            this.toolStripMenuItem5,
            this.ctlToMainForm});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(59, 24);
            this.ctlFile.Text = "Файл";
            // 
            // ctlAddEmployee
            // 
            this.ctlAddEmployee.Name = "ctlAddEmployee";
            this.ctlAddEmployee.Size = new System.Drawing.Size(272, 26);
            this.ctlAddEmployee.Text = "Добавить работника";
            this.ctlAddEmployee.Click += new System.EventHandler(this.CtlAddEmployee_Click);
            // 
            // ctlEditEmployee
            // 
            this.ctlEditEmployee.Name = "ctlEditEmployee";
            this.ctlEditEmployee.Size = new System.Drawing.Size(272, 26);
            this.ctlEditEmployee.Text = "Редактировать работника";
            this.ctlEditEmployee.Click += new System.EventHandler(this.CtlEditEmployee_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(269, 6);
            // 
            // ctlToMainForm
            // 
            this.ctlToMainForm.Name = "ctlToMainForm";
            this.ctlToMainForm.Size = new System.Drawing.Size(272, 26);
            this.ctlToMainForm.Text = "В главное меню";
            this.ctlToMainForm.Click += new System.EventHandler(this.CtlToMainForm_Click);
            // 
            // FmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 462);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.ctlSearch);
            this.Controls.Add(this.ctlEmployees);
            this.Name = "FmEmployee";
            this.Text = "FmEmployee";
            this.Load += new System.EventHandler(this.FmEmployee_Load);
            this.ctlSearch.ResumeLayout(false);
            this.ctlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlEmployees)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ctlSearch;
        private System.Windows.Forms.Button btnResetSearchResult;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.MaskedTextBox tbPasportPoisk;
        private System.Windows.Forms.TextBox tbFioPoisk;
        private System.Windows.Forms.MaskedTextBox tbTelPoisk;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.DataGridView ctlEmployees;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlAddEmployeeContext;
        private System.Windows.Forms.ToolStripMenuItem ctlEditEmployeeContext;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem ctlEditEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem ctlToMainForm;
    }
}