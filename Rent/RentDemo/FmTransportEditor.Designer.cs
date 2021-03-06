﻿namespace RentDemo
{
    partial class FmTransportEditor
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.ctlBrand = new System.Windows.Forms.ComboBox();
            this.ctlParking = new System.Windows.Forms.ComboBox();
            this.ctlModel = new System.Windows.Forms.ComboBox();
            this.ctlColor = new System.Windows.Forms.ComboBox();
            this.ctlDrivingCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddParking = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorrectCoef = new System.Windows.Forms.TextBox();
            this.btnCalculateCoef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(216, 12);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(139, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "txtTitle";
            // 
            // txtCoef
            // 
            this.txtCoef.Location = new System.Drawing.Point(218, 291);
            this.txtCoef.Margin = new System.Windows.Forms.Padding(9);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(137, 22);
            this.txtCoef.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(218, 128);
            this.txtYear.Margin = new System.Windows.Forms.Padding(9);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(137, 22);
            this.txtYear.TabIndex = 2;
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // ctlBrand
            // 
            this.ctlBrand.FormattingEnabled = true;
            this.ctlBrand.Location = new System.Drawing.Point(216, 48);
            this.ctlBrand.Margin = new System.Windows.Forms.Padding(5);
            this.ctlBrand.Name = "ctlBrand";
            this.ctlBrand.Size = new System.Drawing.Size(139, 24);
            this.ctlBrand.TabIndex = 3;
            this.ctlBrand.SelectedIndexChanged += new System.EventHandler(this.ctlBrand_SelectedIndexChanged);
            // 
            // ctlParking
            // 
            this.ctlParking.FormattingEnabled = true;
            this.ctlParking.Location = new System.Drawing.Point(218, 249);
            this.ctlParking.Margin = new System.Windows.Forms.Padding(9);
            this.ctlParking.Name = "ctlParking";
            this.ctlParking.Size = new System.Drawing.Size(137, 24);
            this.ctlParking.TabIndex = 4;
            // 
            // ctlModel
            // 
            this.ctlModel.FormattingEnabled = true;
            this.ctlModel.Location = new System.Drawing.Point(216, 86);
            this.ctlModel.Margin = new System.Windows.Forms.Padding(9);
            this.ctlModel.Name = "ctlModel";
            this.ctlModel.Size = new System.Drawing.Size(139, 24);
            this.ctlModel.TabIndex = 5;
            this.ctlModel.SelectedIndexChanged += new System.EventHandler(this.ctlModel_SelectedIndexChanged);
            // 
            // ctlColor
            // 
            this.ctlColor.FormattingEnabled = true;
            this.ctlColor.Location = new System.Drawing.Point(218, 165);
            this.ctlColor.Margin = new System.Windows.Forms.Padding(9);
            this.ctlColor.Name = "ctlColor";
            this.ctlColor.Size = new System.Drawing.Size(137, 24);
            this.ctlColor.TabIndex = 6;
            // 
            // ctlDrivingCategory
            // 
            this.ctlDrivingCategory.FormattingEnabled = true;
            this.ctlDrivingCategory.Location = new System.Drawing.Point(218, 207);
            this.ctlDrivingCategory.Margin = new System.Windows.Forms.Padding(9);
            this.ctlDrivingCategory.Name = "ctlDrivingCategory";
            this.ctlDrivingCategory.Size = new System.Drawing.Size(137, 24);
            this.ctlDrivingCategory.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Коэффициент стоимости";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Адрес парковки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Категория вождения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Цвет";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Год выпуска";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Модель";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Марка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(72, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Номер транспорта";
            // 
            // btnAddParking
            // 
            this.btnAddParking.Location = new System.Drawing.Point(363, 246);
            this.btnAddParking.Name = "btnAddParking";
            this.btnAddParking.Size = new System.Drawing.Size(202, 29);
            this.btnAddParking.TabIndex = 46;
            this.btnAddParking.Text = "Добавить парковку";
            this.btnAddParking.UseVisualStyleBackColor = true;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(363, 162);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(202, 29);
            this.btnAddColor.TabIndex = 45;
            this.btnAddColor.Text = "Добавить цвет";
            this.btnAddColor.UseVisualStyleBackColor = true;
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(363, 83);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(202, 29);
            this.btnAddModel.TabIndex = 44;
            this.btnAddModel.Text = "Добавить модель";
            this.btnAddModel.UseVisualStyleBackColor = true;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(363, 45);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(202, 29);
            this.btnAddBrand.TabIndex = 43;
            this.btnAddBrand.Text = "Добавить марку";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(363, 366);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 30);
            this.btnOK.TabIndex = 47;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Поправочный коэффициент";
            // 
            // txtCorrectCoef
            // 
            this.txtCorrectCoef.Location = new System.Drawing.Point(218, 331);
            this.txtCorrectCoef.Margin = new System.Windows.Forms.Padding(9);
            this.txtCorrectCoef.Name = "txtCorrectCoef";
            this.txtCorrectCoef.Size = new System.Drawing.Size(137, 22);
            this.txtCorrectCoef.TabIndex = 49;
            // 
            // btnCalculateCoef
            // 
            this.btnCalculateCoef.Location = new System.Drawing.Point(363, 288);
            this.btnCalculateCoef.Name = "btnCalculateCoef";
            this.btnCalculateCoef.Size = new System.Drawing.Size(202, 29);
            this.btnCalculateCoef.TabIndex = 51;
            this.btnCalculateCoef.Text = "Рассчитать коэффициент";
            this.btnCalculateCoef.UseVisualStyleBackColor = true;
            this.btnCalculateCoef.Click += new System.EventHandler(this.btnCalculateCoef_Click);
            // 
            // FmTransportEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 402);
            this.Controls.Add(this.btnCalculateCoef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorrectCoef);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddParking);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ctlDrivingCategory);
            this.Controls.Add(this.ctlColor);
            this.Controls.Add(this.ctlModel);
            this.Controls.Add(this.ctlParking);
            this.Controls.Add(this.ctlBrand);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCoef);
            this.Controls.Add(this.txtTitle);
            this.Name = "FmTransportEditor";
            this.Load += new System.EventHandler(this.FmTransportEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCoef;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox ctlBrand;
        private System.Windows.Forms.ComboBox ctlParking;
        private System.Windows.Forms.ComboBox ctlModel;
        private System.Windows.Forms.ComboBox ctlColor;
        private System.Windows.Forms.ComboBox ctlDrivingCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddParking;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorrectCoef;
        private System.Windows.Forms.Button btnCalculateCoef;
    }
}