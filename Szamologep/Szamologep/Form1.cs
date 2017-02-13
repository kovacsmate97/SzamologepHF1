using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x;
        double y;
        char operation;

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            y = Convert.ToDouble(textBox1.Text);
        }

        private void elojel(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Substring(1);
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
                textBox1.Text = "-" + textBox1.Text;
        }
        private void CE(object sender, EventArgs e)
        {
            textBox1.Clear();
            Calculator.CE(y);
        }
        private void C(object sender, EventArgs e)
        {
            textBox1.Clear();
            Calculator.C(x, y);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '+';
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '-';
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '*';
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '/';
                textBox1.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (double.TryParse(textBox1.Text, out y))

                    switch (operation)
                    {
                        case '+':

                            textBox1.Text = (Calculator.Osszead(x, y)).ToString();
                            break;

                        case '-':

                            textBox1.Text = (Calculator.Kivon(x, y)).ToString();
                            break;

                        case '*':

                            textBox1.Text = (Calculator.Szorzas(x, y)).ToString();
                            break;

                        case '/':
                            if (y == 0)
                            {

                                textBox1.Text = "0-val nem lehet osztani";
                                return;
                            }

                            textBox1.Text = (Calculator.Osztas(x, y)).ToString();
                            break;
                    }

            }
        }


    }
}