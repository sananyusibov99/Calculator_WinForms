using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForms
{
    class Calc
    {

        public Calc()
        {
            Numbers = new List<double>();
        }

        public List<double> Numbers { get; set; }
        public double Memory { get; set; }

        public double FirstInt { get; set; }
        public double SecondInt { get; set; }
        public char? Sign { get; set; }

        public char[] HEX { get; set; }
    }
}
