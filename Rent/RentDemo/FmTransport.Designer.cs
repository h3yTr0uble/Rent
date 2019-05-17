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
            this.CorrectCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlAddTransportContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditTransportContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSearch = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.btnSbros = new System.Windows.Forms.Button();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.cbParkPoisk = new System.Windows.Forms.ComboBox();
            this.cbKategorPoisk = new System.Windows.Forms.ComboBox();
            this.cbCvetPoisk = new System.Windows.Forms.ComboBox();
            this.cbModelPoisk = new System.Windows.Forms.ComboBox();
            this.cbMarkaPoisk = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbKoefPoisk2 = new System.Windows.Forms.TextBox();
            this.tbKoefPoisk1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbGodPoisk2 = new System.Windows.Forms.TextBox();
            this.tbGodPoisk1 = new System.Windows.Forms.TextBox();
            this.tbNomerPoisk = new System.Windows.Forms.TextBox();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTransports)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.ctlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1069, 28);
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
            this.ctlEditTransport.Click += new System.EventHandler(this.ctlEditTransport_Click);
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
            this.Coef,
            this.CorrectCoef});
            this.ctlTransports.ContextMenuStrip = this.contextMenu;
            this.ctlTransports.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlTransports.Location = new System.Drawing.Point(0, 31);
            this.ctlTransports.MultiSelect = false;
            this.ctlTransports.Name = "ctlTransports";
            this.ctlTransports.RowHeadersVisible = false;
            this.ctlTransports.RowTemplate.Height = 24;
            this.ctlTransports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlTransports.Size = new System.Drawing.Size(1057, 222);
            this.ctlTransports.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "ГосНомер";
            this.Title.Name = "Title";
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Марка";
            this.Brand.Name = "Brand";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Год выпуска";
            this.Year.Name = "Year";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            // 
            // DrivingCategory
            // 
            this.DrivingCategory.DataPropertyName = "DrivingCategory";
            this.DrivingCategory.HeaderText = "Категория вождения";
            this.DrivingCategory.Name = "DrivingCategory";
            // 
            // Parking
            // 
            this.Parking.DataPropertyName = "Parking";
            this.Parking.HeaderText = "Парковка";
            this.Parking.Name = "Parking";
            // 
            // Coef
            // 
            this.Coef.DataPropertyName = "Coef";
            this.Coef.HeaderText = "Коэффициент стоимости";
            this.Coef.Name = "Coef";
            // 
            // CorrectCoef
            // 
            this.CorrectCoef.DataPropertyName = "CorrectCoef";
            this.CorrectCoef.HeaderText = "Поправочный коэффициент";
            this.CorrectCoef.Name = "CorrectCoef";
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
            this.ctlAddTransportContext.Click += new System.EventHandler(this.ctlAddTransportContext_Click);
            // 
            // ctlEditTransportContext
            // 
            this.ctlEditTransportContext.Name = "ctlEditTransportContext";
            this.ctlEditTransportContext.Size = new System.Drawing.Size(256, 24);
            this.ctlEditTransportContext.Text = "Редактировать транспорт";
            this.ctlEditTransportContext.Click += new System.EventHandler(this.ctlEditTransportContext_Click);
            // 
            // ctlSearch
            // 
            this.ctlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlSearch.Controls.Add(this.rb5);
            this.ctlSearch.Controls.Add(this.btnSbros);
            this.ctlSearch.Controls.Add(this.btnPoisk);
            this.ctlSearch.Controls.Add(this.cbParkPoisk);
            this.ctlSearch.Controls.Add(this.cbKategorPoisk);
            this.ctlSearch.Controls.Add(this.cbCvetPoisk);
            this.ctlSearch.Controls.Add(this.cbModelPoisk);
            this.ctlSearch.Controls.Add(this.cbMarkaPoisk);
            this.ctlSearch.Controls.Add(this.label18);
            this.ctlSearch.Controls.Add(this.tbKoefPoisk2);
            this.ctlSearch.Controls.Add(this.tbKoefPoisk1);
            this.ctlSearch.Controls.Add(this.label17);
            this.ctlSearch.Controls.Add(this.tbGodPoisk2);
            this.ctlSearch.Controls.Add(this.tbGodPoisk1);
            this.ctlSearch.Controls.Add(this.tbNomerPoisk);
            this.ctlSearch.Controls.Add(this.rb7);
            this.ctlSearch.Controls.Add(this.rb8);
            this.ctlSearch.Controls.Add(this.rb6);
            this.ctlSearch.Controls.Add(this.rb4);
            this.ctlSearch.Controls.Add(this.rb3);
            this.ctlSearch.Controls.Add(this.rb2);
            this.ctlSearch.Controls.Add(this.rb1);
            this.ctlSearch.Location = new System.Drawing.Point(12, 259);
            this.ctlSearch.Name = "ctlSearch";
            this.ctlSearch.Size = new System.Drawing.Size(1045, 312);
            this.ctlSearch.TabIndex = 2;
            this.ctlSearch.TabStop = false;
            this.ctlSearch.Text = "Поиск по транспорту";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 160);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(130, 21);
            this.rb5.TabIndex = 43;
            this.rb5.TabStop = true;
            this.rb5.Text = "Поиск по цвету";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // btnSbros
            // 
            this.btnSbros.Location = new System.Drawing.Point(844, 20);
            this.btnSbros.Name = "btnSbros";
            this.btnSbros.Size = new System.Drawing.Size(180, 30);
            this.btnSbros.TabIndex = 42;
            this.btnSbros.Text = "Сброс";
            this.btnSbros.UseVisualStyleBackColor = true;
            // 
            // btnPoisk
            // 
            this.btnPoisk.Enabled = false;
            this.btnPoisk.Location = new System.Drawing.Point(844, 231);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(180, 62);
            this.btnPoisk.TabIndex = 41;
            this.btnPoisk.Text = "Найти";
            this.btnPoisk.UseVisualStyleBackColor = true;
            // 
            // cbParkPoisk
            // 
            this.cbParkPoisk.Enabled = false;
            this.cbParkPoisk.FormattingEnabled = true;
            this.cbParkPoisk.Location = new System.Drawing.Point(416, 230);
            this.cbParkPoisk.Name = "cbParkPoisk";
            this.cbParkPoisk.Size = new System.Drawing.Size(397, 24);
            this.cbParkPoisk.TabIndex = 40;
            // 
            // cbKategorPoisk
            // 
            this.cbKategorPoisk.Enabled = false;
            this.cbKategorPoisk.FormattingEnabled = true;
            this.cbKategorPoisk.Location = new System.Drawing.Point(416, 195);
            this.cbKategorPoisk.Name = "cbKategorPoisk";
            this.cbKategorPoisk.Size = new System.Drawing.Size(397, 24);
            this.cbKategorPoisk.TabIndex = 39;
            // 
            // cbCvetPoisk
            // 
            this.cbCvetPoisk.Enabled = false;
            this.cbCvetPoisk.FormattingEnabled = true;
            this.cbCvetPoisk.Location = new System.Drawing.Point(416, 160);
            this.cbCvetPoisk.Name = "cbCvetPoisk";
            this.cbCvetPoisk.Size = new System.Drawing.Size(397, 24);
            this.cbCvetPoisk.TabIndex = 38;
            // 
            // cbModelPoisk
            // 
            this.cbModelPoisk.Enabled = false;
            this.cbModelPoisk.FormattingEnabled = true;
            this.cbModelPoisk.Location = new System.Drawing.Point(416, 90);
            this.cbModelPoisk.Name = "cbModelPoisk";
            this.cbModelPoisk.Size = new System.Drawing.Size(397, 24);
            this.cbModelPoisk.TabIndex = 37;
            // 
            // cbMarkaPoisk
            // 
            this.cbMarkaPoisk.Enabled = false;
            this.cbMarkaPoisk.FormattingEnabled = true;
            this.cbMarkaPoisk.Location = new System.Drawing.Point(416, 55);
            this.cbMarkaPoisk.Name = "cbMarkaPoisk";
            this.cbMarkaPoisk.Size = new System.Drawing.Size(397, 24);
            this.cbMarkaPoisk.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(607, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "-";
            // 
            // tbKoefPoisk2
            // 
            this.tbKoefPoisk2.Enabled = false;
            this.tbKoefPoisk2.Location = new System.Drawing.Point(628, 265);
            this.tbKoefPoisk2.MaxLength = 10;
            this.tbKoefPoisk2.Name = "tbKoefPoisk2";
            this.tbKoefPoisk2.Size = new System.Drawing.Size(185, 22);
            this.tbKoefPoisk2.TabIndex = 34;
            // 
            // tbKoefPoisk1
            // 
            this.tbKoefPoisk1.Enabled = false;
            this.tbKoefPoisk1.Location = new System.Drawing.Point(416, 265);
            this.tbKoefPoisk1.MaxLength = 10;
            this.tbKoefPoisk1.Name = "tbKoefPoisk1";
            this.tbKoefPoisk1.Size = new System.Drawing.Size(185, 22);
            this.tbKoefPoisk1.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(607, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "-";
            // 
            // tbGodPoisk2
            // 
            this.tbGodPoisk2.Enabled = false;
            this.tbGodPoisk2.Location = new System.Drawing.Point(628, 125);
            this.tbGodPoisk2.MaxLength = 4;
            this.tbGodPoisk2.Name = "tbGodPoisk2";
            this.tbGodPoisk2.Size = new System.Drawing.Size(185, 22);
            this.tbGodPoisk2.TabIndex = 31;
            // 
            // tbGodPoisk1
            // 
            this.tbGodPoisk1.Enabled = false;
            this.tbGodPoisk1.Location = new System.Drawing.Point(416, 125);
            this.tbGodPoisk1.MaxLength = 4;
            this.tbGodPoisk1.Name = "tbGodPoisk1";
            this.tbGodPoisk1.Size = new System.Drawing.Size(185, 22);
            this.tbGodPoisk1.TabIndex = 30;
            // 
            // tbNomerPoisk
            // 
            this.tbNomerPoisk.Enabled = false;
            this.tbNomerPoisk.Location = new System.Drawing.Point(416, 20);
            this.tbNomerPoisk.MaxLength = 10;
            this.tbNomerPoisk.Name = "tbNomerPoisk";
            this.tbNomerPoisk.Size = new System.Drawing.Size(397, 22);
            this.tbNomerPoisk.TabIndex = 29;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(6, 231);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(204, 21);
            this.rb7.TabIndex = 28;
            this.rb7.TabStop = true;
            this.rb7.Text = "Поиск по адресу парковки";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(6, 266);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(277, 21);
            this.rb8.TabIndex = 27;
            this.rb8.TabStop = true;
            this.rb8.Text = "Поиск по диапазону коэф. стоимости";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(6, 196);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(228, 21);
            this.rb6.TabIndex = 26;
            this.rb6.TabStop = true;
            this.rb6.Text = "Поиск по категории вождения";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 126);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(261, 21);
            this.rb4.TabIndex = 25;
            this.rb4.TabStop = true;
            this.rb4.Text = "Поиск по диапазону годов выпуска";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 91);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(142, 21);
            this.rb3.TabIndex = 24;
            this.rb3.TabStop = true;
            this.rb3.Text = "Поиск по модели";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 56);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(133, 21);
            this.rb2.TabIndex = 23;
            this.rb2.TabStop = true;
            this.rb2.Text = "Поиск по марке";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 21);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(230, 21);
            this.rb1.TabIndex = 22;
            this.rb1.TabStop = true;
            this.rb1.Text = "Поиск по нормепу транспорта";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // FmTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 583);
            this.Controls.Add(this.ctlSearch);
            this.Controls.Add(this.ctlTransports);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FmTransport";
            this.Text = "FmTransport";
            this.Load += new System.EventHandler(this.FmTransport_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTransports)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ctlSearch.ResumeLayout(false);
            this.ctlSearch.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlAddTransportContext;
        private System.Windows.Forms.ToolStripMenuItem ctlEditTransportContext;
        private System.Windows.Forms.GroupBox ctlSearch;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Button btnSbros;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.ComboBox cbParkPoisk;
        private System.Windows.Forms.ComboBox cbKategorPoisk;
        private System.Windows.Forms.ComboBox cbCvetPoisk;
        private System.Windows.Forms.ComboBox cbModelPoisk;
        private System.Windows.Forms.ComboBox cbMarkaPoisk;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbKoefPoisk2;
        private System.Windows.Forms.TextBox tbKoefPoisk1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbGodPoisk2;
        private System.Windows.Forms.TextBox tbGodPoisk1;
        private System.Windows.Forms.TextBox tbNomerPoisk;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectCoef;
    }
}