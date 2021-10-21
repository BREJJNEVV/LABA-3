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

        int x;

        public int Sin(int x)
        {


            return x - (x^3 / 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // синус
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
                x = (int)numericUpDown1.Value;

                double asd = Sin(x);


                decimal sin = (decimal)Math.Sin(x); 
                Convert.ToDecimal(x);

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
                decimal nmV1 = numericUpDown1.Value;
                int sss = 1;
            }
        }
    }
}
