using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator_V2._0
{
    public partial class Form1 : Form
    {
        Double num1;
        Double num2;
        String operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "1";
            }
            else
            {
                display.Text += 1;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "0";
            }
            else
            {
                display.Text += 0;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "2";
            }
            else
            {
                display.Text += 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "3";
            }
            else
            {
                display.Text += 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "4";
            }
            else
            {
                display.Text += 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "5";
            }
            else
            {
                display.Text += 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "6";
            }
            else
            {
                display.Text += 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "7";
            }
            else
            {
                display.Text += 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") ||
                (display.Text == "Syntax Error"))
            {
                display.Text = "8";
            }
            else
            {
                display.Text += 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (display.Text == "Undefined") || 
                (display.Text == "Syntax Error"))
            {
                display.Text = "9";
            }
            else
            {
                display.Text += 9;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int length = display.Text.Length;
            if (length > 0)
            {
                display.Text = display.Text.Remove(length -1, 1);
                if (display.Text == "")
                {
                    display.Text = "0";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
            preview.Text = "";
        }

        private void operation_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                if (operation == "")
                {
                    num1 = Double.Parse(display.Text);
                    operation = button.Text;
                    display.Text = "";
                    preview.Text = num1 + operation;
                }
                else
                {
                    num2 = Double.Parse(display.Text);
                    switch (operation)
                    {
                        case "+":
                            display.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            display.Text = (num1 - num2).ToString();
                            break;
                        case "x":
                            display.Text = (num1 * num2).ToString();
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                display.Text = "Undefined";
                            }
                            else
                            {
                                display.Text = (num1 / num2).ToString();
                            }
                            break;
                    }
                    num1 = double.Parse(display.Text);
                    operation = button.Text;
                    preview.Text = num1 + operation;
                    display.Text = "";
                }
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Double.Parse(display.Text);
                switch (operation)
                {
                    case "+":
                        display.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        display.Text = (num1 - num2).ToString();
                        break;
                    case "x":
                        display.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            display.Text = "Undefined";
                        }
                        else
                        {
                            display.Text = (num1 / num2).ToString();
                        }
                        break;
                }
            }
            catch
            {
                display.Text = "Syntax Error";
            }
            preview.Text = "";
        }
    }
}
