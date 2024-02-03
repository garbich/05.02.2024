using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible= false;
        }

        private Dictionary<string, string> dictionary= new Dictionary<string, string>
        {
            {"apple", "яблуко" },
            { "book", "книга"},
            {"car", "автомобіль" },

    };

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToLower();

            if (dictionary.ContainsKey(str))
            {
                label2.Text = $"Translate: {dictionary[str]}";
                label2.Visible = true;
            }
            else
            {
                label2.Text = "Word not found";
                label2.Visible = true ;
            }
        }
    }
}
