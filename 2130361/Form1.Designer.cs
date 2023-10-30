namespace _2130361
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary5 = new System.Windows.Forms.RadioButton();
            this.Salary3 = new System.Windows.Forms.RadioButton();
            this.Salary4 = new System.Windows.Forms.RadioButton();
            this.salary10 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Benefits = new System.Windows.Forms.GroupBox();
            this.Other_Benefits2 = new System.Windows.Forms.CheckBox();
            this.Other_Benefit_1 = new System.Windows.Forms.CheckBox();
            this.Convence_allowance = new System.Windows.Forms.CheckBox();
            this.Housing_Allowance = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bounces = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Provident_Deduction = new System.Windows.Forms.TextBox();
            this.Medical_deduction = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Benefits.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grade";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Project Manager",
            "Programmer"});
            this.comboBox1.Location = new System.Drawing.Point(67, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // salary5
            // 
            this.salary5.AutoSize = true;
            this.salary5.Location = new System.Drawing.Point(147, 166);
            this.salary5.Name = "salary5";
            this.salary5.Size = new System.Drawing.Size(58, 17);
            this.salary5.TabIndex = 6;
            this.salary5.TabStop = true;
            this.salary5.Text = "50,000";
            this.salary5.UseVisualStyleBackColor = true;
            // 
            // Salary3
            // 
            this.Salary3.AutoSize = true;
            this.Salary3.Location = new System.Drawing.Point(147, 189);
            this.Salary3.Name = "Salary3";
            this.Salary3.Size = new System.Drawing.Size(58, 17);
            this.Salary3.TabIndex = 8;
            this.Salary3.TabStop = true;
            this.Salary3.Text = "30,000";
            this.Salary3.UseVisualStyleBackColor = true;
            this.Salary3.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Salary4
            // 
            this.Salary4.AutoSize = true;
            this.Salary4.Location = new System.Drawing.Point(25, 189);
            this.Salary4.Name = "Salary4";
            this.Salary4.Size = new System.Drawing.Size(58, 17);
            this.Salary4.TabIndex = 7;
            this.Salary4.TabStop = true;
            this.Salary4.Text = "40,000";
            this.Salary4.UseVisualStyleBackColor = true;
            // 
            // salary10
            // 
            this.salary10.AutoSize = true;
            this.salary10.Location = new System.Drawing.Point(25, 166);
            this.salary10.Name = "salary10";
            this.salary10.Size = new System.Drawing.Size(64, 17);
            this.salary10.TabIndex = 5;
            this.salary10.TabStop = true;
            this.salary10.Text = "100,000";
            this.salary10.UseVisualStyleBackColor = true;
            // 
            // Benefits
            // 
            this.Benefits.Controls.Add(this.Other_Benefits2);
            this.Benefits.Controls.Add(this.Other_Benefit_1);
            this.Benefits.Controls.Add(this.Convence_allowance);
            this.Benefits.Controls.Add(this.Housing_Allowance);
            this.Benefits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Benefits.Location = new System.Drawing.Point(2, 212);
            this.Benefits.Name = "Benefits";
            this.Benefits.Size = new System.Drawing.Size(385, 113);
            this.Benefits.TabIndex = 9;
            this.Benefits.TabStop = false;
            this.Benefits.Text = "Benefits";
            // 
            // Other_Benefits2
            // 
            this.Other_Benefits2.AutoSize = true;
            this.Other_Benefits2.Location = new System.Drawing.Point(204, 85);
            this.Other_Benefits2.Name = "Other_Benefits2";
            this.Other_Benefits2.Size = new System.Drawing.Size(133, 22);
            this.Other_Benefits2.TabIndex = 3;
            this.Other_Benefits2.Text = "Other Benefits 2";
            this.Other_Benefits2.UseVisualStyleBackColor = true;
            this.Other_Benefits2.TextChanged += new System.EventHandler(this.Other_Benefits_2);
            // 
            // Other_Benefit_1
            // 
            this.Other_Benefit_1.AutoSize = true;
            this.Other_Benefit_1.Location = new System.Drawing.Point(7, 85);
            this.Other_Benefit_1.Name = "Other_Benefit_1";
            this.Other_Benefit_1.Size = new System.Drawing.Size(133, 22);
            this.Other_Benefit_1.TabIndex = 2;
            this.Other_Benefit_1.Text = "Other Benefits 1";
            this.Other_Benefit_1.UseVisualStyleBackColor = true;
            this.Other_Benefit_1.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.Other_Benefit_1.TextChanged += new System.EventHandler(this.Other_Benefits_1);
            // 
            // Convence_allowance
            // 
            this.Convence_allowance.AutoSize = true;
            this.Convence_allowance.Location = new System.Drawing.Point(204, 33);
            this.Convence_allowance.Name = "Convence_allowance";
            this.Convence_allowance.Size = new System.Drawing.Size(165, 22);
            this.Convence_allowance.TabIndex = 1;
            this.Convence_allowance.Text = "Convence Allowance";
            this.Convence_allowance.UseVisualStyleBackColor = true;
            this.Convence_allowance.TextChanged += new System.EventHandler(this.Convence);
            // 
            // Housing_Allowance
            // 
            this.Housing_Allowance.AutoSize = true;
            this.Housing_Allowance.Location = new System.Drawing.Point(7, 33);
            this.Housing_Allowance.Name = "Housing_Allowance";
            this.Housing_Allowance.Size = new System.Drawing.Size(153, 22);
            this.Housing_Allowance.TabIndex = 0;
            this.Housing_Allowance.Text = "Housing Allowance";
            this.Housing_Allowance.UseVisualStyleBackColor = true;
            this.Housing_Allowance.TextChanged += new System.EventHandler(this.Housing);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(6, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bnouses :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bounces
            // 
            this.Bounces.FormattingEnabled = true;
            this.Bounces.Items.AddRange(new object[] {
            "Project Completed Bonus",
            "Year End Bonus",
            "Performance Bonus",
            "Customer Appreciation Bonus"});
            this.Bounces.Location = new System.Drawing.Point(87, 331);
            this.Bounces.Name = "Bounces";
            this.Bounces.Size = new System.Drawing.Size(278, 94);
            this.Bounces.TabIndex = 11;
            this.Bounces.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Provident_Deduction);
            this.groupBox1.Controls.Add(this.Medical_deduction);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(87, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deduction";
            // 
            // Provident_Deduction
            // 
            this.Provident_Deduction.Location = new System.Drawing.Point(6, 64);
            this.Provident_Deduction.Name = "Provident_Deduction";
            this.Provident_Deduction.Size = new System.Drawing.Size(246, 24);
            this.Provident_Deduction.TabIndex = 1;
            // 
            // Medical_deduction
            // 
            this.Medical_deduction.Location = new System.Drawing.Point(6, 34);
            this.Medical_deduction.Name = "Medical_deduction";
            this.Medical_deduction.Size = new System.Drawing.Size(246, 24);
            this.Medical_deduction.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(2, 557);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.c);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(290, 553);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Ok";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.TextChanged += new System.EventHandler(this.E);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label5.Location = new System.Drawing.Point(28, -6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 46);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salary Calculation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(428, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bounces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Benefits);
            this.Controls.Add(this.Salary3);
            this.Controls.Add(this.Salary4);
            this.Controls.Add(this.salary5);
            this.Controls.Add(this.salary10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Benefits.ResumeLayout(false);
            this.Benefits.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton salary5;
        private System.Windows.Forms.RadioButton Salary3;
        private System.Windows.Forms.RadioButton Salary4;
        private System.Windows.Forms.RadioButton salary10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Benefits;
        private System.Windows.Forms.CheckBox Other_Benefits2;
        private System.Windows.Forms.CheckBox Other_Benefit_1;
        private System.Windows.Forms.CheckBox Convence_allowance;
        private System.Windows.Forms.CheckBox Housing_Allowance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox Bounces;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Provident_Deduction;
        private System.Windows.Forms.TextBox Medical_deduction;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label5;
    }
}

