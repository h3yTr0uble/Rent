namespace RentDemo
{
    partial class FmTransport
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlToMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTransports = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlAddTransportContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditTransportContext = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTransports)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(971, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddTransport,
            this.ctlEditTransport,
            this.toolStripMenuItem1,
            this.ctlToMainForm});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(57, 24);
            this.ctlFile.Text = "Файл";
            // 
            // ctlAddTransport
            // 
            this.ctlAddTransport.Name = "ctlAddTransport";
            this.ctlAddTransport.Size = new System.Drawing.Size(262, 26);
            this.ctlAddTransport.Text = "Добавить транспорт";
            this.ctlAddTransport.Click += new System.EventHandler(this.ctlAddTransport_Click);
            // 
            // ctlEditTransport
            // 
            this.ctlEditTransport.Name = "ctlEditTransport";
            this.ctlEditTransport.Size = new System.Drawing.Size(262, 26);
            this.ctlEditTransport.Text = "Редактировать транспорт";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(259, 6);
            // 
            // ctlToMainForm
            // 
            this.ctlToMainForm.Name = "ctlToMainForm";
            this.ctlToMainForm.Size = new System.Drawing.Size(262, 26);
            this.ctlToMainForm.Text = "В главное меню";
            // 
            // ctlTransports
            // 
            this.ctlTransports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlTransports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Brand,
            this.Model,
            this.Year,
            this.Color,
            this.DrivingCategory,
            this.Parking,
            this.Coef});
            this.ctlTransports.ContextMenuStrip = this.contextMenu;
            this.ctlTransports.Location = new System.Drawing.Point(0, 31);
            this.ctlTransports.Name = "ctlTransports";
            this.ctlTransports.RowTemplate.Height = 24;
            this.ctlTransports.Size = new System.Drawing.Size(971, 222);
            this.ctlTransports.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "ГосНомер";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Марка";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год выпуска";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // DrivingCategory
            // 
            this.DrivingCategory.HeaderText = "Категория вождения";
            this.DrivingCategory.Name = "DrivingCategory";
            this.DrivingCategory.ReadOnly = true;
            // 
            // Parking
            // 
            this.Parking.HeaderText = "Парковка";
            this.Parking.Name = "Parking";
            this.Parking.ReadOnly = true;
            // 
            // Coef
            // 
            this.Coef.HeaderText = "Коэффициент стоимости";
            this.Coef.Name = "Coef";
            this.Coef.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddTransportContext,
            this.ctlEditTransportContext});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(257, 52);
            // 
            // ctlAddTransportContext
            // 
            this.ctlAddTransportContext.Name = "ctlAddTransportContext";
            this.ctlAddTransportContext.Size = new System.Drawing.Size(256, 24);
            this.ctlAddTransportContext.Text = "Добавить транспорт";
            // 
            // ctlEditTransportContext
            // 
            this.ctlEditTransportContext.Name = "ctlEditTransportContext";
            this.ctlEditTransportContext.Size = new System.Drawing.Size(256, 24);
            this.ctlEditTransportContext.Text = "Редактировать транспорт";
            // 
            // FmTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 536);
            this.Controls.Add(this.ctlTransports);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FmTransport";
            this.Text = "FmTransport";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTransports)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlAddTransport;
        private System.Windows.Forms.ToolStripMenuItem ctlEditTransport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlToMainForm;
        private System.Windows.Forms.DataGridView ctlTransports;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlAddTransportContext;
        private System.Windows.Forms.ToolStripMenuItem ctlEditTransportContext;
    }
}