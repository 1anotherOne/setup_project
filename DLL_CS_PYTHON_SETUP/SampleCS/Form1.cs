using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculate;

namespace SampleCS
{
    public partial class Form1 : Form
    {
        Calculator calculator;
        public Form1()
        {
            calculator = new Calculator();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = calculator.Add(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = calculator.Substract(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = calculator.Multiply(Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label12.Text = calculator.Devide(Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox7.Text)).ToString();
        }
    }
}
