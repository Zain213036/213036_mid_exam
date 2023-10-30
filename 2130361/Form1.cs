using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2130361
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                // Initialize ComboBox with employee grade levels
                comboBox1.Items.AddRange(new string[] { "Director", "Manager", "Project Manager", "Programmer" });


                // Initialize RadioButton basic salary options
                Salary3=( string { "30,000" });
                Salary4= ( string { "40,000" });
                Salary10=( string { "10,000" });
                Salary5=string { "50,000" };

                // Initialize CheckedListBox for bonuses
                Bounces.Items.AddRange(new string[] { "Project Completion Bonus (20,000)", "Year End Bonus (30,000)", "Performance Bonus (25,000)", "Customer Appreciation Bonus (15,000)" });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double a = 100000;
            double b = 50000;
            double c = 40000;
            double d = 30000;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double c1 = 20000;
            double c2 = 30000;
            double c3 = 25000;
            double c4 = 15000;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Other_Benefits_1(object sender, EventArgs e)
        {

            double a1 = 1000;
        }

        private void Other_Benefits_2(object sender, EventArgs e)
        {
            double a2 = 10000;

        }

        private void Convence(object sender, EventArgs e)
        {
            double a3 = 5000;

        }

        private void Housing(object sender, EventArgs e)
        {
            double a4 = 2000;
        }

        private void c(object sender, EventArgs e)
        {
            // Initialize variables
            double basicSalary = 0;
            double benefitsTotal = 0;
            double bonusesTotal = 0;
            double deductions = 0;

            // Get selected employee grade level
            string selectedGradeLevel = comboBox1.Text;

            // Calculate basic salary based on grade level
            switch (selectedGradeLevel)
            {
                case "Director":
                    basicSalary = 100000;
                    break;
                case "Manager":
                    basicSalary = 50000;
                    break;
                case "Project Manager":
                    basicSalary = 40000;
                    break;
                case "Programmer":
                    basicSalary = 30000;
                    break;
            }
            // Calculate benefits total
            if (Housing_Allowance.Checked)
                benefitsTotal += 20000;
            if (Convence_allowance.Checked)
                benefitsTotal += 15000;
            if (Other_Benefit_1.Checked)
                benefitsTotal += 10000;
            if (Other_Benefits2.Checked)
                benefitsTotal += 10000;

        }
        


    private void label5_Click(object sender, EventArgs e)
        {

        }

        private void E(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
