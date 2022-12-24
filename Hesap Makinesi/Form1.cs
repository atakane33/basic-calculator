using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);
            
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;

            label4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 - sayi2;

            label4.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 * sayi2;

            label4.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = (float)sayi1 / sayi2;

            label4.Text = toplam.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = Math.Log(sayi1, sayi2);

            label4.Text = toplam.ToString();

            label5.Text = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam1,toplam2;

            sayi1 = Convert.ToDouble(textBox1.Text);
            
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam1 = Math.Sqrt(sayi1);

            toplam2 = Math.Sqrt(sayi2);

            label4.Text = toplam1.ToString();

            label5.Text = toplam2.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = Math.Pow(sayi1, sayi2);

            label4.Text = toplam.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi1 == sayi2)
            {
                label4.Text = textBox1.Text;
            }

            else if (sayi1 != sayi2)
            {
                label4.Text = "Geçersiz";
                
                label5.Text = "Limit Yok !";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();

            a.Show();

            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sabit1, sabit2, g = 9.81, periyot1, periyot2;

            sayi1 = Convert.ToDouble(textBox1.Text);

            sabit1 = Math.Sqrt(sayi1 / (float)g);

            sayi2 = Convert.ToDouble(textBox2.Text);

            sabit2 = Math.Sqrt(sayi2 / (float)g);

            periyot1 = (2 * 3.14) * sabit1;

            periyot2 = (2 * 3.14) * sabit2;

            label4.Text = periyot1.ToString();
            
            label5.Text = periyot2.ToString();

            // 2 * pi sqrt(L / g) = Periyot
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double yol, süre,hız;

            yol = Convert.ToDouble(textBox1.Text);

            süre = Convert.ToDouble(textBox2.Text);

            hız = yol / süre;

            label4.Text = hız.ToString();
        }
    }
}
