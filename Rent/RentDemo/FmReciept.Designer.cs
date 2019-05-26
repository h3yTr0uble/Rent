namespace RentDemo
{
    partial class FmReciept
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
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.txtClientPassport = new System.Windows.Forms.TextBox();
            this.linkLblClientInfo = new System.Windows.Forms.LinkLabel();
            this.ctlClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblTransportInfo = new System.Windows.Forms.LinkLabel();
            this.gbTransport = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlTransport = new System.Windows.Forms.ComboBox();
            this.ctlRentInterval = new System.Windows.Forms.GroupBox();
            this.ctlHours = new System.Windows.Forms.NumericUpDown();
            this.ctlDays = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateReciept = new System.Windows.Forms.Button();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTariff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlCreationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlDriver = new System.Windows.Forms.ComboBox();
            this.checkDriver = new System.Windows.Forms.CheckBox();
            this.gbClient.SuspendLayout();
            this.gbTransport.SuspendLayout();
            this.ctlRentInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDays)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.txtClientPassport);
            this.gbClient.Controls.Add(this.linkLblClientInfo);
            this.gbClient.Controls.Add(this.ctlClient);
            this.gbClient.Controls.Add(this.label2);
            this.gbClient.Controls.Add(this.label1);
            this.gbClient.Location = new System.Drawing.Point(14, 14);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(846, 121);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Клиент";
            // 
            // txtClientPassport
            // 
            this.txtClientPassport.Location = new System.Drawing.Point(94, 79);
            this.txtClientPassport.Name = "txtClientPassport";
            this.txtClientPassport.ReadOnly = true;
            this.txtClientPassport.Size = new System.Drawing.Size(425, 24);
            this.txtClientPassport.TabIndex = 41;
            // 
            // linkLblClientInfo
            // 
            this.linkLblClientInfo.AutoSize = true;
            this.linkLblClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblClientInfo.LinkColor = System.Drawing.Color.Blue;
            this.linkLblClientInfo.Location = new System.Drawing.Point(532, 39);
            this.linkLblClientInfo.Name = "linkLblClientInfo";
            this.linkLblClientInfo.Size = new System.Drawing.Size(101, 20);
            this.linkLblClientInfo.TabIndex = 34;
            this.linkLblClientInfo.TabStop = true;
            this.linkLblClientInfo.Text = "подробнее";
            this.linkLblClientInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClientInfo_LinkClicked);
            // 
            // ctlClient
            // 
            this.ctlClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlClient.FormattingEnabled = true;
            this.ctlClient.Location = new System.Drawing.Point(94, 35);
            this.ctlClient.Name = "ctlClient";
            this.ctlClient.Size = new System.Drawing.Size(425, 26);
            this.ctlClient.TabIndex = 40;
            this.ctlClient.SelectedIndexChanged += new System.EventHandler(this.ctlClient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Паспорт:";
            // 
            // linkLblTransportInfo
            // 
            this.linkLblTransportInfo.AutoSize = true;
            this.linkLblTransportInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblTransportInfo.LinkColor = System.Drawing.Color.Blue;
            this.linkLblTransportInfo.Location = new System.Drawing.Point(320, 40);
            this.linkLblTransportInfo.Name = "linkLblTransportInfo";
            this.linkLblTransportInfo.Size = new System.Drawing.Size(101, 20);
            this.linkLblTransportInfo.TabIndex = 42;
            this.linkLblTransportInfo.TabStop = true;
            this.linkLblTransportInfo.Text = "подробнее";
            this.linkLblTransportInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblTransportInfo_LinkClicked);
            // 
            // gbTransport
            // 
            this.gbTransport.Controls.Add(this.linkLblTransportInfo);
            this.gbTransport.Controls.Add(this.label3);
            this.gbTransport.Controls.Add(this.ctlTransport);
            this.gbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTransport.Location = new System.Drawing.Point(14, 141);
            this.gbTransport.Name = "gbTransport";
            this.gbTransport.Size = new System.Drawing.Size(846, 85);
            this.gbTransport.TabIndex = 1;
            this.gbTransport.TabStop = false;
            this.gbTransport.Text = "Транспорт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Гос номер:";
            // 
            // ctlTransport
            // 
            this.ctlTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlTransport.FormattingEnabled = true;
            this.ctlTransport.Location = new System.Drawing.Point(120, 36);
            this.ctlTransport.Name = "ctlTransport";
            this.ctlTransport.Size = new System.Drawing.Size(192, 26);
            this.ctlTransport.TabIndex = 33;
            this.ctlTransport.SelectedIndexChanged += new System.EventHandler(this.ctlTransport_SelectedIndexChanged);
            // 
            // ctlRentInterval
            // 
            this.ctlRentInterval.Controls.Add(this.ctlHours);
            this.ctlRentInterval.Controls.Add(this.ctlDays);
            this.ctlRentInterval.Controls.Add(this.label11);
            this.ctlRentInterval.Controls.Add(this.label10);
            this.ctlRentInterval.Location = new System.Drawing.Point(14, 284);
            this.ctlRentInterval.Name = "ctlRentInterval";
            this.ctlRentInterval.Size = new System.Drawing.Size(846, 88);
            this.ctlRentInterval.TabIndex = 2;
            this.ctlRentInterval.TabStop = false;
            this.ctlRentInterval.Text = "Срок аренды";
            // 
            // ctlHours
            // 
            this.ctlHours.Location = new System.Drawing.Point(252, 34);
            this.ctlHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ctlHours.Name = "ctlHours";
            this.ctlHours.Size = new System.Drawing.Size(135, 24);
            this.ctlHours.TabIndex = 47;
            this.ctlHours.ValueChanged += new System.EventHandler(this.ctlHours_ValueChanged);
            // 
            // ctlDays
            // 
            this.ctlDays.Location = new System.Drawing.Point(39, 34);
            this.ctlDays.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ctlDays.Name = "ctlDays";
            this.ctlDays.Size = new System.Drawing.Size(135, 24);
            this.ctlDays.TabIndex = 46;
            this.ctlDays.ValueChanged += new System.EventHandler(this.ctlDays_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "часов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "суток";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblReturnDate);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(542, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 105);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стоимость:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата возврата:";
            // 
            // btnCreateReciept
            // 
            this.btnCreateReciept.Location = new System.Drawing.Point(699, 489);
            this.btnCreateReciept.Name = "btnCreateReciept";
            this.btnCreateReciept.Size = new System.Drawing.Size(161, 35);
            this.btnCreateReciept.TabIndex = 18;
            this.btnCreateReciept.Text = "Оформить";
            this.btnCreateReciept.UseVisualStyleBackColor = true;
            this.btnCreateReciept.Click += new System.EventHandler(this.btnCreateReciept_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(156, 22);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(0, 18);
            this.lblReturnDate.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(156, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 18);
            this.lblPrice.TabIndex = 22;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(130, 464);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(78, 18);
            this.lblEmployee.TabIndex = 41;
            this.lblEmployee.Text = "laRabotnik";
            // 
            // lblTariff
            // 
            this.lblTariff.AutoSize = true;
            this.lblTariff.Location = new System.Drawing.Point(130, 427);
            this.lblTariff.Name = "lblTariff";
            this.lblTariff.Size = new System.Drawing.Size(57, 18);
            this.lblTariff.TabIndex = 40;
            this.lblTariff.Text = "Малый";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Работник:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Тариф:";
            // 
            // ctlCreationDate
            // 
            this.ctlCreationDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.ctlCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctlCreationDate.Location = new System.Drawing.Point(175, 239);
            this.ctlCreationDate.Name = "ctlCreationDate";
            this.ctlCreationDate.Size = new System.Drawing.Size(173, 24);
            this.ctlCreationDate.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Дата оформления:";
            // 
            // ctlDriver
            // 
            this.ctlDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlDriver.Enabled = false;
            this.ctlDriver.FormattingEnabled = true;
            this.ctlDriver.Location = new System.Drawing.Point(134, 378);
            this.ctlDriver.Name = "ctlDriver";
            this.ctlDriver.Size = new System.Drawing.Size(399, 26);
            this.ctlDriver.TabIndex = 45;
            // 
            // checkDriver
            // 
            this.checkDriver.AutoSize = true;
            this.checkDriver.Location = new System.Drawing.Point(22, 378);
            this.checkDriver.Name = "checkDriver";
            this.checkDriver.Size = new System.Drawing.Size(98, 22);
            this.checkDriver.TabIndex = 44;
            this.checkDriver.Text = "Водитель";
            this.checkDriver.UseVisualStyleBackColor = true;
            this.checkDriver.CheckedChanged += new System.EventHandler(this.checkDriver_CheckedChanged);
            // 
            // FmReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 530);
            this.Controls.Add(this.ctlDriver);
            this.Controls.Add(this.checkDriver);
            this.Controls.Add(this.btnCreateReciept);
            this.Controls.Add(this.ctlCreationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblTariff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctlRentInterval);
            this.Controls.Add(this.gbTransport);
            this.Controls.Add(this.gbClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FmReciept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление квитанции";
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbTransport.ResumeLayout(false);
            this.gbTransport.PerformLayout();
            this.ctlRentInterval.ResumeLayout(false);
            this.ctlRentInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TextBox txtClientPassport;
        private System.Windows.Forms.ComboBox ctlClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTransport;
        private System.Windows.Forms.GroupBox ctlRentInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreateReciept;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTariff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLblTransportInfo;
        public System.Windows.Forms.ComboBox ctlTransport;
        private System.Windows.Forms.LinkLabel linkLblClientInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ctlHours;
        private System.Windows.Forms.NumericUpDown ctlDays;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ctlCreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctlDriver;
        private System.Windows.Forms.CheckBox checkDriver;
    }
}