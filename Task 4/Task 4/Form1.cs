using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private Random random= new Random();
        
        public Form1()
        {
            InitializeComponent();
            label4.Visible= false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            int a = Int32.Parse(str);

            string pass = "";

            string alfavit = "AaBbCcDdEeFfGgHhIiJjKkOoPpQqRrSsTtUuVvWwXxYyZz";

            string str1 = textBox2.Text;

            int a1 = Int32.Parse(str1);

            if (a1 == 1)
            {
                for (int i = 0; i < a; i++)
                {
                    pass += randomForNum();
                }
            }
            else if (a1 == 2)
            {
                for (int i = 0; i < a; i++)
                {
                    pass += alfavit[randomForWord()];
                }
            }
            else if (a1 == 3)
            {
                for (int i = 0; i < a; i++)
                {
                    if (randomForNum() > 5)
                    {
                        pass += randomForNum();
                    }
                    else
                    {
                        pass += alfavit[randomForWord()];
                    }
                }
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    if (randomForNum() > 5)
                    {
                        pass += randomForNum();
                    }
                    else
                    {
                        pass += alfavit[randomForWord()];
                    }
                }
            }

            label4.Text = "Result: " + pass;



            label4.Visible = true;
        }
        private int randomForNum()
        {

            return random.Next(1, 10);
        }

        private int randomForWord()
        {

            return random.Next(1, 47);
        }
    }
}
