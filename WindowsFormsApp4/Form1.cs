using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double nombre = 0;
        char operation;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text +"1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = double.Parse(textBox1.Text + "0").ToString();
        }

        private void buttonpourcentage_Click(object sender, EventArgs e)
        {
            nombre= double.Parse(textBox1.Text);
            nombre = nombre / 100;
            textBox1.Text = nombre.ToString();

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox1.Text="0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox1.Text = "0";
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

        }

        private void buttonRAC_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            nombre = Math.Sqrt(nombre);
            textBox1.Text = nombre.ToString();
        }

        private void buttonCARR_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            nombre = Math.Pow(nombre, 2);
            textBox1.Text = nombre.ToString();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            nombre = 1 / nombre;
            textBox1.Text = nombre.ToString();
        }

        private void buttonDEV_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation= '÷';

        }

        private void buttonPRO_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = 'X';
        }

        private void buttonSUPP_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = '-';
        }

        private void buttonAD_Click(object sender, EventArgs e)
        {
            nombre = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = '+';
        }

        private void buttonegal_Click(object sender, EventArgs e)
        {
            if (operation == '+')
            {
                textBox1.Text = ((nombre) + (double .Parse(textBox1.Text))).ToString();
            }
            if (operation == 'X')
            {
                textBox1.Text = ((nombre) * (double.Parse(textBox1.Text))).ToString();
            }
            if (operation == '-')
            {
                textBox1.Text = ((nombre) - (double.Parse(textBox1.Text))).ToString();
            }
            if (operation == '÷')
            {
                textBox1.Text = ((nombre) / (double.Parse(textBox1.Text))).ToString();
            }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            textBox1.Text = ",";
        }
    }
    }

