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
        NumberButton numberbtn = new NumberButton();

        public Form1()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            numberbtn.Display = display.Text;
            Button number = (Button)sender;
            numberbtn.Numclick = number.Text;

            numberbtn.read_display();
            display.Text = numberbtn.Display;
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
                numberbtn.Display = display.Text;
                numberbtn.Preview = preview.Text;
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
