using System;
using System.Drawing;
using System.Windows.Forms;

namespace LABA_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public double Sin(int x)
        {
            int nv2 = (int)numericUpDown2.Value;
            int mnoj = 1;
            int counter = 0;
            double ans = x;
            for (int i = 3; i < 3+2*nv2; i+=2)
            {
                mnoj *= -1;
                ans += mnoj * (((double)Math.Pow(x, i)) / Factor(i));
                counter += 1;
            }

            decimal standard = decimal.Round((decimal)ans, nv2, MidpointRounding.AwayFromZero);

            return (double)standard;
        }

        public double Cos(int x)
        {
            
            int nv2 = (int)numericUpDown2.Value;
            int mnoj = 1;
            double ans = 1;
            for (int i = 2; i < 2 + 2 * nv2; i += 2)
            {
                mnoj *= -1;
                ans += mnoj * (((double)Math.Pow(x, i)) / Factor(i));
            }

            decimal standard = decimal.Round((decimal)ans, nv2, MidpointRounding.AwayFromZero);

            return (double)standard;
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
            richTextBox1.Text = "\n\n\t" + "Sin(x) = x - (x^3) / 3! + (x^5) / 5! - (x^7) / 7! + ...";
            richTextBox2.Text = "\n\n\t" + "Sin(x)";

            int x = (int)numericUpDown1.Value;
            

            int nv2 = (int)numericUpDown2.Value;
            //decimal standard = decimal.Round((decimal)Math.Sin(x), nv2, MidpointRounding.AwayFromZero);
            decimal standard = (decimal)Math.Sin(x);
            string sin_m = Sin(x).ToString();
            string sin_a = standard.ToString();

            if (x > 9)
            {
                richTextBox1.Text = "\n\n" + "Ошибка, превышено максимальное значение X";

            }
            else if(nv2 > 14)
            {
                richTextBox1.Text = "\n\n" + "Ошибка, превышено максимальное значение погрешности ";
            }
            else
            {
                textBox1.Text = sin_m;
                textBox2.Text = sin_a;
            }

        }
        int counter_sin = 0;
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "\n\n\t" + "Cos(x) = 1 - (x^2) / 2! + (x^4) / 4! - (x^6) / 6! + ...";
            richTextBox2.Text = "\n\n\t" + "Cos(x)";
            int x = (int)numericUpDown1.Value;
            int nv2 = (int)numericUpDown2.Value;
            decimal standard = decimal.Round((decimal)Math.Cos(x), nv2, MidpointRounding.AwayFromZero);

            string cos_m = Cos(x).ToString();
            string cos_a = standard.ToString();

            if (x > 9)
            {
                richTextBox1.Text = "\n\n" + "Ошибка, превышено максимальное значение X";

            }
            else if (nv2 > 14)
            {
                richTextBox1.Text = "\n\n" + "Ошибка, превышено максимальное значение погрешности ";
            }
            else
            {
                textBox1.Text = cos_m;
                textBox2.Text = cos_a;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
