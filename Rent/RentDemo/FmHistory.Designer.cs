namespace RentDemo
{
    partial class FmHistory
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlCreationRecieptForReturnContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlInfoContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTransportPoisk = new System.Windows.Forms.TextBox();
            this.tbKvPoisk = new System.Windows.Forms.TextBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.tbDatePoisk2 = new System.Windows.Forms.DateTimePicker();
            this.tbDatePoisk1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlCreationRecieptForReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlReciepts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NecessaryReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlReciepts)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlCreationRecieptForReturnContext,
            this.toolStripMenuItem1,
            this.ctlInfoContext});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(313, 58);
            // 
            // ctlCreationRecieptForReturnContext
            // 
            this.ctlCreationRecieptForReturnContext.Name = "ctlCreationRecieptForReturnContext";
            this.ctlCreationRecieptForReturnContext.Size = new System.Drawing.Size(312, 24);
            this.ctlCreationRecieptForReturnContext.Text = "Оформить квитанцию на возврат";
            this.ctlCreationRecieptForReturnContext.Click += new System.EventHandler(this.ctlCreationRecieptForReturnContext_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(309, 6);
            // 
            // ctlInfoContext
            // 
            this.ctlInfoContext.Name = "ctlInfoContext";
            this.ctlInfoContext.Size = new System.Drawing.Size(312, 24);
            this.ctlInfoContext.Text = "Подробная информация";
            this.ctlInfoContext.Click += new System.EventHandler(this.ctlInfoContext_Click);
            // 
            // tbTransportPoisk
            // 
            this.tbTransportPoisk.Enabled = false;
            this.tbTransportPoisk.Location = new System.Drawing.Point(465, 324);
            this.tbTransportPoisk.MaxLength = 10;
            this.tbTransportPoisk.Name = "tbTransportPoisk";
            this.tbTransportPoisk.Size = new System.Drawing.Size(418, 22);
            this.tbTransportPoisk.TabIndex = 10;
            this.tbTransportPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKvPoisk
            // 
            this.tbKvPoisk.Enabled = false;
            this.tbKvPoisk.Location = new System.Drawing.Point(465, 284);
            this.tbKvPoisk.MaxLength = 10;
            this.tbKvPoisk.Name = "tbKvPoisk";
            this.tbKvPoisk.Size = new System.Drawing.Size(418, 22);
            this.tbKvPoisk.TabIndex = 9;
            this.tbKvPoisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(37, 323);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(222, 21);
            this.rb2.TabIndex = 8;
            this.rb2.TabStop = true;
            this.rb2.Text = "Поиск по номеру транспорта";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(37, 284);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(214, 21);
            this.rb1.TabIndex = 7;
            this.rb1.TabStop = true;
            this.rb1.Text = "Поиск по номеру квитанции";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // tbDatePoisk2
            // 
            this.tbDatePoisk2.CustomFormat = "dd.MM.yyyy HH:mm";
            this.tbDatePoisk2.Enabled = false;
            this.tbDatePoisk2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDatePoisk2.Location = new System.Drawing.Point(690, 362);
            this.tbDatePoisk2.Name = "tbDatePoisk2";
            this.tbDatePoisk2.Size = new System.Drawing.Size(194, 22);
            this.tbDatePoisk2.TabIndex = 29;
            // 
            // tbDatePoisk1
            // 
            this.tbDatePoisk1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.tbDatePoisk1.Enabled = false;
            this.tbDatePoisk1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDatePoisk1.Location = new System.Drawing.Point(465, 362);
            this.tbDatePoisk1.Name = "tbDatePoisk1";
            this.tbDatePoisk1.Size = new System.Drawing.Size(194, 22);
            this.tbDatePoisk1.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(665, 366);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "-";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(895, 28);
            this.mainMenu.TabIndex = 31;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlCreationRecieptForReturn,
            this.toolStripMenuItem2,
            this.ctlInfo});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ctlCreationRecieptForReturn
            // 
            this.ctlCreationRecieptForReturn.Name = "ctlCreationRecieptForReturn";
            this.ctlCreationRecieptForReturn.Size = new System.Drawing.Size(326, 26);
            this.ctlCreationRecieptForReturn.Text = "Оформить квитанцию на возврат";
            this.ctlCreationRecieptForReturn.Click += new System.EventHandler(this.ctlCreationRecieptForReturn_Click);
            // 
            // ctlReciepts
            // 
            this.ctlReciepts.AllowUserToAddRows = false;
            this.ctlReciepts.AllowUserToDeleteRows = false;
            this.ctlReciepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlReciepts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClientFullName,
            this.TransportTitle,
            this.CreationDate,
            this.NecessaryReturnDate});
            this.ctlReciepts.ContextMenuStrip = this.contextMenu;
            this.ctlReciepts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlReciepts.Location = new System.Drawing.Point(14, 33);
            this.ctlReciepts.Margin = new System.Windows.Forms.Padding(5);
            this.ctlReciepts.MultiSelect = false;
            this.ctlReciepts.Name = "ctlReciepts";
            this.ctlReciepts.ReadOnly = true;
            this.ctlReciepts.RowHeadersVisible = false;
            this.ctlReciepts.RowHeadersWidth = 51;
            this.ctlReciepts.RowTemplate.Height = 24;
            this.ctlReciepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlReciepts.Size = new System.Drawing.Size(869, 226);
            this.ctlReciepts.TabIndex = 6;
            this.ctlReciepts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlReciepts_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Номер квитанции";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // ClientFullName
            // 
            this.ClientFullName.DataPropertyName = "Client";
            this.ClientFullName.HeaderText = "Клиент";
            this.ClientFullName.MinimumWidth = 6;
            this.ClientFullName.Name = "ClientFullName";
            this.ClientFullName.ReadOnly = true;
            this.ClientFullName.Width = 125;
            // 
            // TransportTitle
            // 
            this.TransportTitle.DataPropertyName = "Transport";
            this.TransportTitle.HeaderText = "Транспорт";
            this.TransportTitle.MinimumWidth = 6;
            this.TransportTitle.Name = "TransportTitle";
            this.TransportTitle.ReadOnly = true;
            this.TransportTitle.Width = 125;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "Дата оформления";
            this.CreationDate.MinimumWidth = 6;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.Width = 125;
            // 
            // NecessaryReturnDate
            // 
            this.NecessaryReturnDate.DataPropertyName = "NecessaryReturnDate";
            this.NecessaryReturnDate.HeaderText = "Необходимая дата возврата";
            this.NecessaryReturnDate.MinimumWidth = 6;
            this.NecessaryReturnDate.Name = "NecessaryReturnDate";
            this.NecessaryReturnDate.ReadOnly = true;
            this.NecessaryReturnDate.Width = 125;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 361);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(278, 21);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Поиск по диапазону дат оформления";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(791, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(323, 6);
            // 
            // ctlInfo
            // 
            this.ctlInfo.Name = "ctlInfo";
            this.ctlInfo.Size = new System.Drawing.Size(326, 26);
            this.ctlInfo.Text = "Подробная информация";
            this.ctlInfo.Click += new System.EventHandler(this.CtlInfo_Click);
            // 
            // FmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.tbDatePoisk2);
            this.Controls.Add(this.tbDatePoisk1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbTransportPoisk);
            this.Controls.Add(this.tbKvPoisk);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.ctlReciepts);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список квитанций";
            this.Load += new System.EventHandler(this.FmHistury_Load);
            this.contextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlReciepts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTransportPoisk;
        private System.Windows.Forms.TextBox tbKvPoisk;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.DateTimePicker tbDatePoisk2;
        private System.Windows.Forms.DateTimePicker tbDatePoisk1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlCreationRecieptForReturnContext;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlInfoContext;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctlCreationRecieptForReturn;
        private System.Windows.Forms.DataGridView ctlReciepts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NecessaryReturnDate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctlInfo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}