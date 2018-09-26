using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int penambahan(int a, int b)
        {
            return a + b;
        }

        private int pengurangan(int a, int b)
        {
            return a - b;
        }

        private int pembagian(int a, int b)
        {
            return a / b;
        }

        private int perkalian(int a, int b)
        {
            return a * b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);

            if(comboBox1.Text == "penjumlahan" || comboBox1.Text == "penambahan")
            {
                textBox3.Text = Convert.ToString(penambahan(a, b));
            }
            if (comboBox1.Text == "pengurangan")
            {
                textBox3.Text = Convert.ToString(pengurangan(a, b));
            }
            if (comboBox1.Text == "pembagian")
            {
                textBox3.Text = Convert.ToString(pembagian(a, b));
            }
            if (comboBox1.Text == "perkalian")
            {
                textBox3.Text = Convert.ToString(perkalian(a, b));
            }
        }
    }
}
