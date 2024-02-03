using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            int num = Int32.Parse(str);

           label2.Text = $"Result: {(num - 32) * 5 / 9}";
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            int num = Int32.Parse(str);

            label2.Text = $"Result: {(num * 9 / 5) + 32}";
            label2.Visible = true;
        }
    }
}
