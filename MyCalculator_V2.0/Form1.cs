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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
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
            if (display.Text == "0")
            {
                display.Text = "9";
            }
            else
            {
                display.Text += 9;
            }
        }
    }
}
