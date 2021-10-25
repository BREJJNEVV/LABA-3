using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public int Ssin(int x)
        {
            return x - (x ^ 3 / Factor(3)) + (x ^ 5 / Factor(5)) - (x ^ 7 / Factor(7));
        }

        public int Sin(int x)
        {
            int mnoj = 1;
            int ans = x;
            for (int i = 3; mnoj == 1; i+=2)
            {
                if (GetChislPoslZapytoy(ans) >= numericUpDown2.Value) // если сейчас у числа больше чисел после запятой чем их максимум, то 
                {
                    return ans;
                }
                mnoj *= -1;
                ans += mnoj * ((x ^ i) / Factor(i));

            }
            return ans;
        }

        public int GetChislPoslZapytoy(double number)
        {
            string str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
            return str.Contains(".") ? str.Remove(0, Math.Truncate(number).ToString().Length + 1).Length : 0;
        }



        public int Factor(int f)    
        {
            int Sum = 1;

            for (int i = 1; i < f + 1; i++)
            {
                Sum *= i;
            }
            return Sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // синус
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //MessageBox.Show("факториал 3 =" + Factor(3));
                int x = (int)numericUpDown1.Value;
                    
                string sin_m = Sin(x).ToString();

                //decimal sin_a = (decimal)Math.Sin(x); 
                //Convert.ToDecimal(x);

                string sin_a = Math.Sin(x).ToString();

                textBox1.Text = sin_m;
                textBox2.Text = sin_a;

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
                decimal nmV1 = numericUpDown1.Value;
            }
        }
    }
}
