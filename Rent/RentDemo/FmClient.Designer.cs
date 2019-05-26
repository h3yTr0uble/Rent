namespace RentDemo
{
    partial class FmClient
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
            this.txtClientsDrivingCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlClients = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlAddClientContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditClientContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlCreateRecieptClientContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEnterClientContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlHistoryClientContext = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlEnterClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlCreateRecieptClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlHistoryClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlToMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSearch = new System.Windows.Forms.GroupBox();
            this.tbPasportPoisk = new System.Windows.Forms.MaskedTextBox();
            this.tbFioPoisk = new System.Windows.Forms.TextBox();
            this.tbTelPoisk = new System.Windows.Forms.MaskedTextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnResetSearchResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClients)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.ctlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientsDrivingCategory
            // 
            this.txtClientsDrivingCategory.Location = new System.Drawing.Point(725, 96);
            this.txtClientsDrivingCategory.Multiline = true;
            this.txtClientsDrivingCategory.Name = "txtClientsDrivingCategory";
            this.txtClientsDrivingCategory.Size = new System.Drawing.Size(235, 169);
            this.txtClientsDrivingCategory.TabIndex = 7;
            this.txtClientsDrivingCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(722, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Категории вождения, которыми владеет выбранный клиент:";
            // 
            // ctlClients
            // 
            this.ctlClients.AllowUserToAddRows = false;
            this.ctlClients.AllowUserToDeleteRows = false;
            this.ctlClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3});
            this.ctlClients.ContextMenuStrip = this.contextMenu;
            this.ctlClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlClients.Location = new System.Drawing.Point(3, 39);
            this.ctlClients.Margin = new System.Windows.Forms.Padding(5);
            this.ctlClients.MultiSelect = false;
            this.ctlClients.Name = "ctlClients";
            this.ctlClients.ReadOnly = true;
            this.ctlClients.RowHeadersVisible = false;
            this.ctlClients.RowHeadersWidth = 51;
            this.ctlClients.RowTemplate.Height = 24;
            this.ctlClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlClients.Size = new System.Drawing.Size(714, 226);
            this.ctlClients.TabIndex = 5;
            this.ctlClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlClients_CellClick);
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
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddClientContext,
            this.ctlEditClientContext,
            this.toolStripMenuItem2,
            this.ctlCreateRecieptClientContext,
            this.ctlEnterClientContext,
            this.toolStripMenuItem4,
            this.ctlHistoryClientContext});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(240, 136);
            // 
            // ctlAddClientContext
            // 
            this.ctlAddClientContext.Name = "ctlAddClientContext";
            this.ctlAddClientContext.Size = new System.Drawing.Size(239, 24);
            this.ctlAddClientContext.Text = "Добавить клиента";
            this.ctlAddClientContext.Click += new System.EventHandler(this.ctlAddClientContext_Click);
            // 
            // ctlEditClientContext
            // 
            this.ctlEditClientContext.Name = "ctlEditClientContext";
            this.ctlEditClientContext.Size = new System.Drawing.Size(239, 24);
            this.ctlEditClientContext.Text = "Редактировать клиента";
            this.ctlEditClientContext.Click += new System.EventHandler(this.ctlEditClientContext_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 6);
            // 
            // ctlCreateRecieptClientContext
            // 
            this.ctlCreateRecieptClientContext.Name = "ctlCreateRecieptClientContext";
            this.ctlCreateRecieptClientContext.Size = new System.Drawing.Size(239, 24);
            this.ctlCreateRecieptClientContext.Text = "Оформить квитанцию";
            this.ctlCreateRecieptClientContext.Click += new System.EventHandler(this.ctlCreateRecieptClientContext_Click);
            // 
            // ctlEnterClientContext
            // 
            this.ctlEnterClientContext.Name = "ctlEnterClientContext";
            this.ctlEnterClientContext.Size = new System.Drawing.Size(239, 24);
            this.ctlEnterClientContext.Text = "Выбрать";
            this.ctlEnterClientContext.Visible = false;
            this.ctlEnterClientContext.Click += new System.EventHandler(this.ctlEnterClientContext_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(236, 6);
            // 
            // ctlHistoryClientContext
            // 
            this.ctlHistoryClientContext.Name = "ctlHistoryClientContext";
            this.ctlHistoryClientContext.Size = new System.Drawing.Size(239, 24);
            this.ctlHistoryClientContext.Text = "История активности";
            this.ctlHistoryClientContext.Click += new System.EventHandler(this.ctlHistoryClientContext_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(961, 28);
            this.mainMenu.TabIndex = 9;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddClient,
            this.ctlEditClient,
            this.toolStripMenuItem3,
            this.ctlEnterClient,
            this.ctlCreateRecieptClient,
            this.toolStripMenuItem1,
            this.ctlHistoryClient,
            this.toolStripMenuItem5,
            this.ctlToMainForm});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(59, 24);
            this.ctlFile.Text = "Файл";
            // 
            // ctlAddClient
            // 
            this.ctlAddClient.Name = "ctlAddClient";
            this.ctlAddClient.Size = new System.Drawing.Size(253, 26);
            this.ctlAddClient.Text = "Добавить клиента";
            this.ctlAddClient.Click += new System.EventHandler(this.ctlAddClient_Click);
            // 
            // ctlEditClient
            // 
            this.ctlEditClient.Name = "ctlEditClient";
            this.ctlEditClient.Size = new System.Drawing.Size(253, 26);
            this.ctlEditClient.Text = "Редактировать клиента";
            this.ctlEditClient.Click += new System.EventHandler(this.ctlEditClient_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(250, 6);
            // 
            // ctlEnterClient
            // 
            this.ctlEnterClient.Name = "ctlEnterClient";
            this.ctlEnterClient.Size = new System.Drawing.Size(253, 26);
            this.ctlEnterClient.Text = "Выбрать";
            this.ctlEnterClient.Click += new System.EventHandler(this.ctlEnterClient_Click);
            // 
            // ctlCreateRecieptClient
            // 
            this.ctlCreateRecieptClient.Name = "ctlCreateRecieptClient";
            this.ctlCreateRecieptClient.Size = new System.Drawing.Size(253, 26);
            this.ctlCreateRecieptClient.Text = "Оформить квитанцию";
            this.ctlCreateRecieptClient.Click += new System.EventHandler(this.ctlCreateRecieptClient_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // ctlHistoryClient
            // 
            this.ctlHistoryClient.Name = "ctlHistoryClient";
            this.ctlHistoryClient.Size = new System.Drawing.Size(253, 26);
            this.ctlHistoryClient.Text = "История активности";
            this.ctlHistoryClient.Click += new System.EventHandler(this.ctlHistoryClient_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(250, 6);
            // 
            // ctlToMainForm
            // 
            this.ctlToMainForm.Name = "ctlToMainForm";
            this.ctlToMainForm.Size = new System.Drawing.Size(253, 26);
            this.ctlToMainForm.Text = "В главное меню";
            this.ctlToMainForm.Click += new System.EventHandler(this.CtlToMainForm_Click);
            // 
            // ctlSearch
            // 
            this.ctlSearch.Controls.Add(this.btnResetSearchResult);
            this.ctlSearch.Controls.Add(this.btnSearchClient);
            this.ctlSearch.Controls.Add(this.tbPasportPoisk);
            this.ctlSearch.Controls.Add(this.tbFioPoisk);
            this.ctlSearch.Controls.Add(this.tbTelPoisk);
            this.ctlSearch.Controls.Add(this.rb1);
            this.ctlSearch.Controls.Add(this.rb3);
            this.ctlSearch.Controls.Add(this.rb2);
            this.ctlSearch.Location = new System.Drawing.Point(12, 273);
            this.ctlSearch.Name = "ctlSearch";
            this.ctlSearch.Size = new System.Drawing.Size(948, 147);
            this.ctlSearch.TabIndex = 10;
            this.ctlSearch.TabStop = false;
            this.ctlSearch.Text = "Поиск по клиентам";
            // 
            // tbPasportPoisk
            // 
            this.tbPasportPoisk.Enabled = false;
            this.tbPasportPoisk.Location = new System.Drawing.Point(261, 70);
            this.tbPasportPoisk.Mask = "0000000000";
            this.tbPasportPoisk.Name = "tbPasportPoisk";
            this.tbPasportPoisk.Size = new System.Drawing.Size(464, 22);
            this.tbPasportPoisk.TabIndex = 25;
            this.tbPasportPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFioPoisk
            // 
            this.tbFioPoisk.Enabled = false;
            this.tbFioPoisk.Location = new System.Drawing.Point(261, 29);
            this.tbFioPoisk.MaxLength = 255;
            this.tbFioPoisk.Name = "tbFioPoisk";
            this.tbFioPoisk.Size = new System.Drawing.Size(464, 22);
            this.tbFioPoisk.TabIndex = 24;
            this.tbFioPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTelPoisk
            // 
            this.tbTelPoisk.Enabled = false;
            this.tbTelPoisk.Location = new System.Drawing.Point(261, 108);
            this.tbTelPoisk.Mask = "8(999)-000-00-00";
            this.tbTelPoisk.Name = "tbTelPoisk";
            this.tbTelPoisk.Size = new System.Drawing.Size(464, 22);
            this.tbTelPoisk.TabIndex = 22;
            this.tbTelPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(27, 30);
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
            this.rb3.Location = new System.Drawing.Point(24, 109);
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
            this.rb2.Location = new System.Drawing.Point(27, 71);
            this.rb2.Margin = new System.Windows.Forms.Padding(20);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(154, 21);
            this.rb2.TabIndex = 19;
            this.rb2.TabStop = true;
            this.rb2.Text = "Поиск по паспорту";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(796, 30);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(103, 22);
            this.btnSearchClient.TabIndex = 26;
            this.btnSearchClient.Text = "Найти";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // btnResetSearchResult
            // 
            this.btnResetSearchResult.Location = new System.Drawing.Point(796, 71);
            this.btnResetSearchResult.Name = "btnResetSearchResult";
            this.btnResetSearchResult.Size = new System.Drawing.Size(103, 23);
            this.btnResetSearchResult.TabIndex = 27;
            this.btnResetSearchResult.Text = "Сбросить";
            this.btnResetSearchResult.UseVisualStyleBackColor = true;
            // 
            // FmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 423);
            this.Controls.Add(this.ctlSearch);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.txtClientsDrivingCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlClients);
            this.Name = "FmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.FmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlClients)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ctlSearch.ResumeLayout(false);
            this.ctlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientsDrivingCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ctlClients;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlAddClientContext;
        private System.Windows.Forms.ToolStripMenuItem ctlEditClientContext;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlAddClient;
        private System.Windows.Forms.ToolStripMenuItem ctlEditClient;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlToMainForm;
        private System.Windows.Forms.GroupBox ctlSearch;
        private System.Windows.Forms.MaskedTextBox tbPasportPoisk;
        private System.Windows.Forms.TextBox tbFioPoisk;
        private System.Windows.Forms.MaskedTextBox tbTelPoisk;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctlCreateRecieptClientContext;
        private System.Windows.Forms.ToolStripMenuItem ctlEnterClientContext;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ctlEnterClient;
        private System.Windows.Forms.ToolStripMenuItem ctlCreateRecieptClient;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ctlHistoryClientContext;
        private System.Windows.Forms.ToolStripMenuItem ctlHistoryClient;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Button btnResetSearchResult;
        private System.Windows.Forms.Button btnSearchClient;
    }
}