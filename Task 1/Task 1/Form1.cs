using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible= false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2 = textBox2.Text;

            int num1 = Int32.Parse(str);
            int num2 = Int32.Parse(str2);

            label3.Text = $"Result = {num1 + num2}";
            label3 .Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2 = textBox2.Text;

            int num1 = Int32.Parse(str);
            int num2 = Int32.Parse(str2);

            label3.Text = $"Result = {num1 - num2}";
            label3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2 = textBox2.Text;

            int num1 = Int32.Parse(str);
            int num2 = Int32.Parse(str2);

            label3.Text = $"Result = {num1 * num2}";
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2 = textBox2.Text;

            int num1 = Int32.Parse(str);
            int num2 = Int32.Parse(str2);

            label3.Text = $"Result = {num1 / num2}";
            label3.Visible = true;
        }
    }
}
