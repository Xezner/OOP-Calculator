using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Calculator_Remake
{
    public partial class Form1 : Form
    {
        string[] operations = { "", "", "", "", "", "", "", "", "", "" };
        int number_Operations = 0;
        string current_Operation = "";
        float num1, num2 = 0;
        float result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_E_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {
            num1 = num2 = result = 0;
               
            textBox1.Text = "0";
            number_Operations = 0;
            current_Operation = null;

            for (int i = operations.Length; i <= 0; i++)
            {
                operations[i] = null;
            }
        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if(result!= 0)
            {

            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void period_Click(object sender, EventArgs e)
        {
            if((textBox1.Text).Contains("."))
            {
                //do nothing
            }
            else if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        //sign changing
        private void signChange_Click(object sender, EventArgs e)
        {
            textBox1.Text = (float.Parse(textBox1.Text) * -1).ToString();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            result = 1;
            while(num1>0)
            {
                result = result * num1;
                num1--;
            }
            textBox1.Text = result.ToString();
        }

        //addition operation
        private void add_Click(object sender, EventArgs e)
        {
            if(num1 == 0)
            {
                num1 = float.Parse(textBox1.Text);
            }
            else
            {
                result = num1 + float.Parse(textBox1.Text);
            }

            if(result != 0)
            {
                textBox1.Text = result.ToString();
            }
            else
            { 
                textBox1.Text = " ";
            }

            



        }

        private void equals_Click(object sender, EventArgs e)
        {

        }
    }
}
