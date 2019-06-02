namespace RentDemo
{
    partial class FmSqlAgentSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveBackup = new System.Windows.Forms.Button();
            this.ctlTimeBackup = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlDaysBackup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlIsEnabledBackup = new System.Windows.Forms.CheckBox();
            this.btnChangeBackupPath = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveRecalculateCoef = new System.Windows.Forms.Button();
            this.ctlDaysRecalculateCoef = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlTimeRecalculateCoef = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlNumberDaysRecalculateCoef = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlIsEnabledRecalculateCoef = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveReduce = new System.Windows.Forms.Button();
            this.ctlDayOfMontchReduce = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlTimeReduce = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlIsEnabledReduse = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDayOfMontchReduce)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 222);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveBackup);
            this.tabPage1.Controls.Add(this.ctlTimeBackup);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctlDaysBackup);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctlIsEnabledBackup);
            this.tabPage1.Controls.Add(this.btnChangeBackupPath);
            this.tabPage1.Controls.Add(this.txtBackupPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Резервоное копирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveBackup
            // 
            this.btnSaveBackup.Location = new System.Drawing.Point(462, 154);
            this.btnSaveBackup.Name = "btnSaveBackup";
            this.btnSaveBackup.Size = new System.Drawing.Size(94, 31);
            this.btnSaveBackup.TabIndex = 9;
            this.btnSaveBackup.Text = "Сохранить";
            this.btnSaveBackup.UseVisualStyleBackColor = true;
            this.btnSaveBackup.Click += new System.EventHandler(this.BtnSaveBackup_Click);
            // 
            // ctlTimeBackup
            // 
            this.ctlTimeBackup.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ctlTimeBackup.Location = new System.Drawing.Point(452, 111);
            this.ctlTimeBackup.Name = "ctlTimeBackup";
            this.ctlTimeBackup.ShowUpDown = true;
            this.ctlTimeBackup.Size = new System.Drawing.Size(94, 22);
            this.ctlTimeBackup.TabIndex = 8;
            this.ctlTimeBackup.Value = new System.DateTime(2019, 6, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "в";
            // 
            // ctlDaysBackup
            // 
            this.ctlDaysBackup.FormattingEnabled = true;
            this.ctlDaysBackup.Items.AddRange(new object[] {
            "Понедельник"});
            this.ctlDaysBackup.Location = new System.Drawing.Point(201, 111);
            this.ctlDaysBackup.Name = "ctlDaysBackup";
            this.ctlDaysBackup.Size = new System.Drawing.Size(198, 24);
            this.ctlDaysBackup.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Повторяется каждый:";
            // 
            // ctlIsEnabledBackup
            // 
            this.ctlIsEnabledBackup.AutoSize = true;
            this.ctlIsEnabledBackup.Location = new System.Drawing.Point(18, 24);
            this.ctlIsEnabledBackup.Name = "ctlIsEnabledBackup";
            this.ctlIsEnabledBackup.Size = new System.Drawing.Size(96, 21);
            this.ctlIsEnabledBackup.TabIndex = 4;
            this.ctlIsEnabledBackup.Text = "Включено";
            this.ctlIsEnabledBackup.UseVisualStyleBackColor = true;
            // 
            // btnChangeBackupPath
            // 
            this.btnChangeBackupPath.Location = new System.Drawing.Point(360, 63);
            this.btnChangeBackupPath.Name = "btnChangeBackupPath";
            this.btnChangeBackupPath.Size = new System.Drawing.Size(176, 29);
            this.btnChangeBackupPath.TabIndex = 3;
            this.btnChangeBackupPath.Text = "Выбрать путь";
            this.btnChangeBackupPath.UseVisualStyleBackColor = true;
            this.btnChangeBackupPath.Click += new System.EventHandler(this.BtnChangeBackupPath_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(18, 66);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(322, 22);
            this.txtBackupPath.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveRecalculateCoef);
            this.tabPage2.Controls.Add(this.ctlDaysRecalculateCoef);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ctlTimeRecalculateCoef);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ctlNumberDaysRecalculateCoef);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ctlIsEnabledRecalculateCoef);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Перерасчет коэффициентов стоимости";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveRecalculateCoef
            // 
            this.btnSaveRecalculateCoef.Location = new System.Drawing.Point(464, 154);
            this.btnSaveRecalculateCoef.Name = "btnSaveRecalculateCoef";
            this.btnSaveRecalculateCoef.Size = new System.Drawing.Size(94, 31);
            this.btnSaveRecalculateCoef.TabIndex = 17;
            this.btnSaveRecalculateCoef.Text = "Сохранить";
            this.btnSaveRecalculateCoef.UseVisualStyleBackColor = true;
            // 
            // ctlDaysRecalculateCoef
            // 
            this.ctlDaysRecalculateCoef.FormattingEnabled = true;
            this.ctlDaysRecalculateCoef.Items.AddRange(new object[] {
            "Понедельник"});
            this.ctlDaysRecalculateCoef.Location = new System.Drawing.Point(242, 99);
            this.ctlDaysRecalculateCoef.Name = "ctlDaysRecalculateCoef";
            this.ctlDaysRecalculateCoef.Size = new System.Drawing.Size(143, 24);
            this.ctlDaysRecalculateCoef.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Повторяется ежемесячно";
            // 
            // ctlTimeRecalculateCoef
            // 
            this.ctlTimeRecalculateCoef.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ctlTimeRecalculateCoef.Location = new System.Drawing.Point(412, 102);
            this.ctlTimeRecalculateCoef.Name = "ctlTimeRecalculateCoef";
            this.ctlTimeRecalculateCoef.ShowUpDown = true;
            this.ctlTimeRecalculateCoef.Size = new System.Drawing.Size(94, 22);
            this.ctlTimeRecalculateCoef.TabIndex = 13;
            this.ctlTimeRecalculateCoef.Value = new System.DateTime(2019, 6, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "в";
            // 
            // ctlNumberDaysRecalculateCoef
            // 
            this.ctlNumberDaysRecalculateCoef.FormattingEnabled = true;
            this.ctlNumberDaysRecalculateCoef.Items.AddRange(new object[] {
            "Первый"});
            this.ctlNumberDaysRecalculateCoef.Location = new System.Drawing.Point(93, 99);
            this.ctlNumberDaysRecalculateCoef.Name = "ctlNumberDaysRecalculateCoef";
            this.ctlNumberDaysRecalculateCoef.Size = new System.Drawing.Size(143, 24);
            this.ctlNumberDaysRecalculateCoef.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Каждый:";
            // 
            // ctlIsEnabledRecalculateCoef
            // 
            this.ctlIsEnabledRecalculateCoef.AutoSize = true;
            this.ctlIsEnabledRecalculateCoef.Location = new System.Drawing.Point(27, 23);
            this.ctlIsEnabledRecalculateCoef.Name = "ctlIsEnabledRecalculateCoef";
            this.ctlIsEnabledRecalculateCoef.Size = new System.Drawing.Size(96, 21);
            this.ctlIsEnabledRecalculateCoef.TabIndex = 5;
            this.ctlIsEnabledRecalculateCoef.Text = "Включено";
            this.ctlIsEnabledRecalculateCoef.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSaveReduce);
            this.tabPage3.Controls.Add(this.ctlDayOfMontchReduce);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.ctlTimeReduce);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.ctlIsEnabledReduse);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(564, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Амортизация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaveReduce
            // 
            this.btnSaveReduce.Location = new System.Drawing.Point(462, 154);
            this.btnSaveReduce.Name = "btnSaveReduce";
            this.btnSaveReduce.Size = new System.Drawing.Size(94, 31);
            this.btnSaveReduce.TabIndex = 25;
            this.btnSaveReduce.Text = "Сохранить";
            this.btnSaveReduce.UseVisualStyleBackColor = true;
            // 
            // ctlDayOfMontchReduce
            // 
            this.ctlDayOfMontchReduce.Location = new System.Drawing.Point(191, 75);
            this.ctlDayOfMontchReduce.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ctlDayOfMontchReduce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctlDayOfMontchReduce.Name = "ctlDayOfMontchReduce";
            this.ctlDayOfMontchReduce.ReadOnly = true;
            this.ctlDayOfMontchReduce.Size = new System.Drawing.Size(53, 22);
            this.ctlDayOfMontchReduce.TabIndex = 24;
            this.ctlDayOfMontchReduce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Повторяется ежегодно";
            // 
            // ctlTimeReduce
            // 
            this.ctlTimeReduce.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ctlTimeReduce.Location = new System.Drawing.Point(322, 75);
            this.ctlTimeReduce.Name = "ctlTimeReduce";
            this.ctlTimeReduce.ShowUpDown = true;
            this.ctlTimeReduce.Size = new System.Drawing.Size(94, 22);
            this.ctlTimeReduce.TabIndex = 21;
            this.ctlTimeReduce.Value = new System.DateTime(2019, 6, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "января в";
            // 
            // ctlIsEnabledReduse
            // 
            this.ctlIsEnabledReduse.AutoSize = true;
            this.ctlIsEnabledReduse.Location = new System.Drawing.Point(19, 26);
            this.ctlIsEnabledReduse.Name = "ctlIsEnabledReduse";
            this.ctlIsEnabledReduse.Size = new System.Drawing.Size(96, 21);
            this.ctlIsEnabledReduse.TabIndex = 17;
            this.ctlIsEnabledReduse.Text = "Включено";
            this.ctlIsEnabledReduse.UseVisualStyleBackColor = true;
            // 
            // FmSqlAgentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 222);
            this.Controls.Add(this.tabControl1);
            this.Name = "FmSqlAgentSettings";
            this.Text = "Настройка заданий SQL Agent";
            this.Load += new System.EventHandler(this.FmSqlAgentSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDayOfMontchReduce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveBackup;
        private System.Windows.Forms.DateTimePicker ctlTimeBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ctlDaysBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ctlIsEnabledBackup;
        private System.Windows.Forms.Button btnChangeBackupPath;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.CheckBox ctlIsEnabledRecalculateCoef;
        private System.Windows.Forms.ComboBox ctlDaysRecalculateCoef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ctlTimeRecalculateCoef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ctlNumberDaysRecalculateCoef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ctlDayOfMontchReduce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ctlTimeReduce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ctlIsEnabledReduse;
        private System.Windows.Forms.Button btnSaveRecalculateCoef;
        private System.Windows.Forms.Button btnSaveReduce;
    }
}