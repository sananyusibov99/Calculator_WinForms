﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForms
{
    public static class Options
    {
        private static string language;
        public static string Language
        {
            get { return language; }
            set { language= value; }
        }

        private static List<string> texts;
        public static List<string> Texts
        {
            get { return texts; }
            set { texts = value; }
        }



    }
}
