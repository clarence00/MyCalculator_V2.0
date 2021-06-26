﻿using System;
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
        NumberButton numberbtn = new NumberButton();

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
                numberbtn.Display = display.Text;
                numberbtn.Preview = preview.Text;
                Button button = (Button)sender;

                if (numberbtn.Operation == "")
                {
                    numberbtn.Operators = button.Text;
                    numberbtn.add_operator();

                    display.Text = numberbtn.Display;
                    preview.Text = numberbtn.Preview;
                }
                else
                {
                    numberbtn.solving_process();

                    display.Text = numberbtn.Display;
                    preview.Text = numberbtn.Preview;
                    numberbtn.Num1 = double.Parse(display.Text);
                    numberbtn.Operation = button.Text;
                    preview.Text = numberbtn.Num1 + numberbtn.Operation;
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
                numberbtn.solving_process();

                display.Text = numberbtn.Display;
                preview.Text = numberbtn.Preview;
            }
            catch
            {
                display.Text = "Syntax Error";
            }
            preview.Text = "";
            numberbtn.Operation = "";
        }
    }
}
