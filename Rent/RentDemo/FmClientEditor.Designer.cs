namespace RentDemo
{
    partial class FmClientEditor
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
            this.txtPassport = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlDrivingCategories = new System.Windows.Forms.ListBox();
            this.lblAwards = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(182, 50);
            this.txtPassport.Mask = "0000000000";
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(494, 22);
            this.txtPassport.TabIndex = 15;
            this.txtPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(182, 145);
            this.txtPhone.Mask = "8(999)-000-00-00";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(494, 22);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(182, 95);
            this.txtFullName.MaxLength = 255;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(494, 22);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Паспорт";
            // 
            // ctlDrivingCategories
            // 
            this.ctlDrivingCategories.FormattingEnabled = true;
            this.ctlDrivingCategories.ItemHeight = 16;
            this.ctlDrivingCategories.Location = new System.Drawing.Point(237, 192);
            this.ctlDrivingCategories.Name = "ctlDrivingCategories";
            this.ctlDrivingCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ctlDrivingCategories.Size = new System.Drawing.Size(200, 84);
            this.ctlDrivingCategories.TabIndex = 19;
            // 
            // lblAwards
            // 
            this.lblAwards.AutoSize = true;
            this.lblAwards.Location = new System.Drawing.Point(49, 192);
            this.lblAwards.Name = "lblAwards";
            this.lblAwards.Size = new System.Drawing.Size(157, 17);
            this.lblAwards.TabIndex = 18;
            this.lblAwards.Text = "Категориии вождения:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(479, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(572, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FmClientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 311);
            this.Controls.Add(this.ctlDrivingCategories);
            this.Controls.Add(this.lblAwards);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FmClientEditor";
            this.Text = "FmClientEditor";
            this.Load += new System.EventHandler(this.FmClientEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPassport;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ctlDrivingCategories;
        private System.Windows.Forms.Label lblAwards;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}