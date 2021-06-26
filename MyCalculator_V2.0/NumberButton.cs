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

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }
        public string Operation { get => operation; set => operation = value; }
    }
}
