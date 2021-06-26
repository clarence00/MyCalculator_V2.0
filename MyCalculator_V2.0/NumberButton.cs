using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator_V2._0
{
    public class NumberButton
    {
        private double num1;
        private double num2;
        private string operation = "";
        private string display;
        private string preview;
        private string operators;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }
        public string Operation { get => operation; set => operation = value; }
        public string Display { get => display; set => display = value; }
        public string Preview { get => preview; set => preview = value; }
        public string Operators { get => operators; set => operators = value; }

        public void operate()
        {
            Num1 = Double.Parse(Display);
            Operation = Operators;
            Display = "";
            Preview = Num1 + Operation;
        }

        public void process()
        {
            
        }
    }
}
