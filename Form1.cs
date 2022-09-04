using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        
        string PrimaryValue = string.Empty;
        string SecondaryValue = string.Empty;
        string TypeOperation = String.Empty;
        decimal result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToString(result) != String.Empty)
            {
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                PrimaryValue = String.Empty;
                SecondaryValue = String.Empty;
                TypeOperation = String.Empty;
            }
            if(TypeOperation == String.Empty)
            {
                textBox1.Text = String.Empty;
                PrimaryValue = String.Empty;
            }
            else
            {
                textBox1.Text = String.Empty;
                SecondaryValue = String.Empty;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (TypeOperation == String.Empty)
            {
                PrimaryValue += 0;
                textBox1.Text += 0;
            }
            else
            {
                SecondaryValue += 0;
                textBox1.Text += 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (TypeOperation == String.Empty)
            {
                PrimaryValue += 2;
                textBox1.Text += 2;
            }
            else
            {
                SecondaryValue += 2;
                textBox1.Text += 2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TypeOperation == String.Empty)
            {
                PrimaryValue += 1;
                textBox1.Text += 1;
            }
            else
            {
                SecondaryValue += 1;
                textBox1.Text += 1;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 3;
                textBox1.Text += 3;
            }
            else
            {
                SecondaryValue += 3;
                textBox1.Text += 3;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 4;
                textBox1.Text += 4;
            }
            else
            {
                SecondaryValue += 4;
                textBox1.Text += 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 5;
                textBox1.Text += 5;
            }
            else
            {
                SecondaryValue += 5;
                textBox1.Text += 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 6;
                textBox1.Text += 6;
            }
            else
            {
                SecondaryValue += 6;
                textBox1.Text += 6;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 7;
                textBox1.Text += 7;
            }
            else
            {
                SecondaryValue += 7;
                textBox1.Text += 7;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 8;
                textBox1.Text += 8;
            }
            else
            {
                SecondaryValue += 8;
                textBox1.Text += 8;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += 9;
                textBox1.Text += 9;
            }
            else
            {
                SecondaryValue += 9;
                textBox1.Text += 9;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (TypeOperation == string.Empty)
            {
                PrimaryValue += ".";
                textBox1.Text += ".";
            }
            else
            {
                SecondaryValue += ".";
                textBox1.Text += ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text += PrimaryValue + "/";
            TypeOperation = "/";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text += PrimaryValue + "*";
            TypeOperation = "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text += PrimaryValue + "-";
            TypeOperation = "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text += PrimaryValue + "+";
            TypeOperation = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (PrimaryValue == String.Empty || SecondaryValue == String.Empty)
                return;
            decimal value1 = decimal.Parse(PrimaryValue, CultureInfo.InvariantCulture);
            decimal value2 = decimal.Parse(SecondaryValue, CultureInfo.InvariantCulture);
            
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;

            switch (TypeOperation)
            {
                case "+":
                    result = value1 + value2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = value1 - value2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "/":
                    if (value2 == 0)
                    {
                        textBox1.Text = "Indeterminação";
                        break;
                    }
                    result = value1 / value2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "*":
                    result = value1 * value2;
                    textBox1.Text = Convert.ToString(result);
                    break;
                default:
                    break;
            }

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            PrimaryValue = String.Empty;
            SecondaryValue = String.Empty;
            TypeOperation = String.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
