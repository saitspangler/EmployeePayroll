namespace EmployeePayrollGUI
{
    partial class frmEmployees
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
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlPermanent = new System.Windows.Forms.Panel();
            this.txtRrsp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoPermanent = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtPayroll = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnlPermanent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 29;
            this.lstEmployees.Location = new System.Drawing.Point(506, 37);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(673, 468);
            this.lstEmployees.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlPermanent);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoPermanent);
            this.groupBox1.Controls.Add(this.rdoRegular);
            this.groupBox1.Location = new System.Drawing.Point(32, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Employee";
            // 
            // pnlPermanent
            // 
            this.pnlPermanent.Controls.Add(this.txtRrsp);
            this.pnlPermanent.Controls.Add(this.label4);
            this.pnlPermanent.Location = new System.Drawing.Point(40, 248);
            this.pnlPermanent.Name = "pnlPermanent";
            this.pnlPermanent.Size = new System.Drawing.Size(347, 56);
            this.pnlPermanent.TabIndex = 9;
            // 
            // txtRrsp
            // 
            this.txtRrsp.Location = new System.Drawing.Point(112, 10);
            this.txtRrsp.Name = "txtRrsp";
            this.txtRrsp.Size = new System.Drawing.Size(100, 35);
            this.txtRrsp.TabIndex = 8;
            this.txtRrsp.Tag = "RRSP %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "RRSP%:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(152, 191);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 35);
            this.txtRate.TabIndex = 7;
            this.txtRate.Tag = "Rate";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(152, 150);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 35);
            this.txtHours.TabIndex = 6;
            this.txtHours.Tag = "Hours";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 35);
            this.txtName.TabIndex = 5;
            this.txtName.Tag = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // rdoPermanent
            // 
            this.rdoPermanent.AutoSize = true;
            this.rdoPermanent.Location = new System.Drawing.Point(219, 46);
            this.rdoPermanent.Name = "rdoPermanent";
            this.rdoPermanent.Size = new System.Drawing.Size(155, 33);
            this.rdoPermanent.TabIndex = 1;
            this.rdoPermanent.TabStop = true;
            this.rdoPermanent.Text = "Permanent";
            this.rdoPermanent.UseVisualStyleBackColor = true;
            this.rdoPermanent.CheckedChanged += new System.EventHandler(this.rdoPermanent_CheckedChanged);
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(42, 46);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(123, 33);
            this.rdoRegular.TabIndex = 0;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            this.rdoRegular.CheckedChanged += new System.EventHandler(this.rdoRegular_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "# Employees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Payroll:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(301, 400);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 35);
            this.txtCount.TabIndex = 4;
            // 
            // txtPayroll
            // 
            this.txtPayroll.Location = new System.Drawing.Point(301, 451);
            this.txtPayroll.Name = "txtPayroll";
            this.txtPayroll.ReadOnly = true;
            this.txtPayroll.Size = new System.Drawing.Size(153, 35);
            this.txtPayroll.TabIndex = 5;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 532);
            this.Controls.Add(this.txtPayroll);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmEmployees";
            this.Text = "Employee Payroll";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPermanent.ResumeLayout(false);
            this.pnlPermanent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPermanent;
        private System.Windows.Forms.TextBox txtRrsp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoPermanent;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtPayroll;
    }
}

