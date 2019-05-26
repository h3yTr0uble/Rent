namespace RentDemo
{
    partial class FmRecieptForReturn
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
            this.label14 = new System.Windows.Forms.Label();
            this.ctlParkings = new System.Windows.Forms.ComboBox();
            this.ctlCreationDate = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbFine = new System.Windows.Forms.GroupBox();
            this.btnEnterFine = new System.Windows.Forms.Button();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFine.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(353, 26);
            this.label14.TabIndex = 4;
            this.label14.Text = "Парковка, на которую возвращен транспорт";
            // 
            // ctlParkings
            // 
            this.ctlParkings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlParkings.FormattingEnabled = true;
            this.ctlParkings.Location = new System.Drawing.Point(370, 14);
            this.ctlParkings.Name = "ctlParkings";
            this.ctlParkings.Size = new System.Drawing.Size(309, 26);
            this.ctlParkings.TabIndex = 5;
            // 
            // ctlCreationDate
            // 
            this.ctlCreationDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.ctlCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctlCreationDate.Location = new System.Drawing.Point(177, 56);
            this.ctlCreationDate.Name = "ctlCreationDate";
            this.ctlCreationDate.Size = new System.Drawing.Size(170, 24);
            this.ctlCreationDate.TabIndex = 46;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(496, 56);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(183, 36);
            this.btnEnter.TabIndex = 45;
            this.btnEnter.Text = "Оформить";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gbFine
            // 
            this.gbFine.Controls.Add(this.btnEnterFine);
            this.gbFine.Controls.Add(this.txtFine);
            this.gbFine.Controls.Add(this.label18);
            this.gbFine.Controls.Add(this.label17);
            this.gbFine.Controls.Add(this.txtInterval);
            this.gbFine.Controls.Add(this.label16);
            this.gbFine.Location = new System.Drawing.Point(14, 99);
            this.gbFine.Name = "gbFine";
            this.gbFine.Size = new System.Drawing.Size(678, 165);
            this.gbFine.TabIndex = 44;
            this.gbFine.TabStop = false;
            this.gbFine.Text = "Штраф за несвоевременный возврат транспорта";
            this.gbFine.Visible = false;
            // 
            // btnEnterFine
            // 
            this.btnEnterFine.Location = new System.Drawing.Point(405, 97);
            this.btnEnterFine.Name = "btnEnterFine";
            this.btnEnterFine.Size = new System.Drawing.Size(261, 54);
            this.btnEnterFine.TabIndex = 19;
            this.btnEnterFine.Text = "Подтвердить офомление квитанции";
            this.btnEnterFine.UseVisualStyleBackColor = true;
            this.btnEnterFine.Click += new System.EventHandler(this.btnEnterFine_Click);
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(296, 65);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(151, 24);
            this.txtFine.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(169, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 18);
            this.label18.TabIndex = 3;
            this.label18.Text = "Сумма штрафа";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(454, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 18);
            this.label17.TabIndex = 2;
            this.label17.Text = "часов";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(296, 30);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.ReadOnly = true;
            this.txtInterval.Size = new System.Drawing.Size(151, 24);
            this.txtInterval.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(247, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Возврат транспорта просрочен на";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-251, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 18);
            this.label15.TabIndex = 43;
            this.label15.Text = "Дата оформления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Дата возврата:";
            // 
            // FmRecieptForReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlCreationDate);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbFine);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ctlParkings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FmRecieptForReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление квитанции на возврат";
            this.gbFine.ResumeLayout(false);
            this.gbFine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ctlParkings;
        private System.Windows.Forms.DateTimePicker ctlCreationDate;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox gbFine;
        private System.Windows.Forms.Button btnEnterFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}