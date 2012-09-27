using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieNeedsCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtHeight.Text) * 2.54;
            double weight = Convert.ToDouble(txtWeight.Text) / 2.2;
            int age = Convert.ToInt32(txtAge.Text);
            double malecal = ((10 * weight) + (6.25 * height) - (5 * age) + 5);
            double femalecal = ((10 * weight) + (6.25 * height) - (5 * age) - 161);

            if (cboxGender.Text == "Male" )
            {
                if (btnAct0.Checked)
                {
                    string malecal0 = (malecal * 1.3).ToString();
                    MessageBox.Show(malecal0);
                }
                else if (btnAct1.Checked)
                {
                    string malecal1 = (malecal * 1.4).ToString();
                    MessageBox.Show(malecal1);
                }
                else if (btnAct2.Checked)
                {
                    string malecal2 = (malecal * 1.5).ToString();
                    MessageBox.Show(malecal2);
                }
                else if (btnAct3.Checked)
                {
                    string malecal3 = (malecal * 1.6).ToString();
                    MessageBox.Show(malecal3);
                }
                else if (btnAct4.Checked)
                {
                    string malecal4 = (malecal * 1.8).ToString();
                    MessageBox.Show(malecal4);
                }
                else
                {
                    MessageBox.Show("Please Select Activity Level");
                }
            }
            
            if (cboxGender.Text == "Female")
            {
                if (btnAct0.Checked)
                {
                    string femalecal0 = (femalecal * 1.3).ToString();
                    MessageBox.Show(femalecal0);
                }
                else if (btnAct1.Checked)
                {
                    string femalecal1 = (femalecal * 1.4).ToString();
                    MessageBox.Show(femalecal1);
                }
                else if (btnAct2.Checked)
                {
                    string femalecal2 = (femalecal * 1.5).ToString();
                    MessageBox.Show(femalecal2);
                }
                else if (btnAct3.Checked)
                {
                    string femalecal3 = (femalecal * 1.6).ToString();
                    MessageBox.Show(femalecal3);
                }
                else if (btnAct4.Checked)
                {
                    string femalecal4 = (femalecal * 1.8).ToString();
                    MessageBox.Show(femalecal4);
                }
                else
                {
                    MessageBox.Show("Please Select Activity Level");
                }
            }         
        }
    }
}
