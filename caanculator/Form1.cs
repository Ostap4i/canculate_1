using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caanculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = button7.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str;

            }
            else
            {
                textBox2.Text = str;
            }
         


        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str1 = button8.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str1;

            }
            else
            {
                textBox2.Text = str1;
            }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str2 = button9.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str2;

            }
            else
            {
                textBox2.Text = str2;
            }
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str3 = button3.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str3;
                
            }
           else
            {
                textBox2.Text = str3;
            }
         

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str4 = button5.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str4;

            }
            else
            {
                textBox2.Text = str4;
            }
        
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string str5 = button6.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str5;

            }
            else
            {
                textBox2.Text = str5;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str6 = button1.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str6;

            }
            else
            {
                textBox2.Text = str6;
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str7 = button2.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str7;

            }
            else
            {
                textBox2.Text = str7;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str8 = button4.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str8;

            }
            else
            {

                textBox2.Text = str8;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string str9 = button10.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = str9;

            }
            else
            {
                textBox2.Text = str9;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string str10 = button11.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox3.Text = str10;

            }
            else
            {
                textBox3.Text = str10;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string str11 = button12.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox3.Text = str11;

            }
            else
            {
                textBox3.Text = str11;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string str12 = button11.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox3.Text = str12;

            }
            else
            {
                textBox3.Text = str12;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string str13 = button14.Text;
            if (textBox1.Text.Length == 0)
            {
                textBox3.Text = str13;

            }
            else
            {
                textBox3.Text = str13;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            if (textBox3.Text == "+")
            {
                textBox4.Text = $"{num1 + num2}";
            }

            if (textBox3.Text == "-")
            {
                textBox4.Text = $"{num1 - num2}";
            }
          
            if (textBox3.Text == "*")
            {
                textBox4.Text = $"{num1 * num2}";
            }
           
            if (textBox3.Text == "/")
            {
                textBox4.Text = $"{num1 / num2}";
            }
        }
    }
}

