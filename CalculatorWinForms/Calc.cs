using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForms
{
    class Calc
    {
        private double firstInt;
        public double FirstInt
        {
            get { return firstInt; }
            set { firstInt = value; }
        }

        private double secondInt;
        public double SecondInt
        {
            get { return secondInt; }
            set { secondInt = value; }
        }

        private char? sign;
        public char? Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        private double memory;
        public double Memory
        {
            get { return memory; }
            set { memory = value; }
        }

        private char[] hex;
        public char[] HEX
        {
            get { return hex; }
            set { hex = value; }
        }
    }
}
