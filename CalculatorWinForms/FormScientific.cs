﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CalculatorWinForms
{
    public partial class FormScientific : Form
    {
        int count = 0;
        Calc calc = new Calc();

        public FormScientific()
        {
            InitializeComponent();
            txtShow.Text = "0";
            try
            {
                WebClient();
                TextChange(texts);
            }
            catch { }
        }

        static List<string> texts = new List<string>();


        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStandart();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void ProgrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormProgrammer();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void StatisticslaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStatistics();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        public void TextChange(List<string> texts)
        {
            viewToolStripMenuItem.Text = texts[0];
            exitToolStripMenuItem.Text = texts[1];
            settingsToolStripMenuItem.Text = texts[2];
            exitToolStripMenuItem.Text = texts[3];
            scientificToolStripMenuItem.Text = texts[4];
            programmerToolStripMenuItem.Text = texts[5];
            statisticsToolStripMenuItem.Text = texts[6];
            standartToolStripMenuItem.Text = texts[7];
            //ActiveForm.Text = texts[8];

        }


        public void WebClient()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;

                texts = new List<string>
                {
                    viewToolStripMenuItem.Text,
                    exitToolStripMenuItem.Text,
                    settingsToolStripMenuItem.Text,
                    exitToolStripMenuItem.Text,
                    scientificToolStripMenuItem.Text,
                    programmerToolStripMenuItem.Text,
                    statisticsToolStripMenuItem.Text,
                    standartToolStripMenuItem.Text,

                };

                for (int item = 0; item < 8; item++)
                {
                    var result = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={texts[item]}&lang={Options.Language}");
                    var data = JObject.Parse(result);
                    texts[item] = (string)data["text"][0];
                }

                TextChange(texts);
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wnd = new FormSettings();
            var res = wnd.ShowDialog();

            WebClient();

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtShow.Text == "0" && txtShow.Text != null)
                {
                    Button selected = (Button)sender;
                    String NumVal = selected.Text;
                    txtShow.Text = NumVal;
                }
                else
                {
                    Button selected = (Button)sender;
                    String NumVal = selected.Text;
                    txtShow.Text += NumVal;
                }
                
            }
            catch { MessageBox.Show("Not a valid entry"); }
            }

        private void BtnPlusSign_Click(object sender, EventArgs e)
        {
            try
            {
                calc.FirstInt = double.Parse(txtShow.Text);
                txtShow.Clear();
                count = 1;
                label1.Text = calc.FirstInt.ToString() + '+';
                calc.Sign = '+';
            }
            catch { }
        }

        private void BtnMinusSign_Click(object sender, EventArgs e)
        {
            try
            {
                calc.FirstInt = double.Parse(txtShow.Text);
                txtShow.Clear();
                count = 1;
                label1.Text = calc.FirstInt.ToString() + '-';
                calc.Sign = '-';
            }
            catch { }
        }

        private void BtnMultSign_Click(object sender, EventArgs e)
        {
            try
            {
                calc.FirstInt = double.Parse(txtShow.Text);
                txtShow.Clear();
                count = 1;
                label1.Text = calc.FirstInt.ToString() + '*';
                calc.Sign = '*';
            }
            catch { }
        }

        private void BtnDivSign_Click(object sender, EventArgs e)
        {
            try
            {
                calc.FirstInt = double.Parse(txtShow.Text);
                txtShow.Clear();
                count = 1;
                label1.Text = calc.FirstInt.ToString() + '/';
                calc.Sign = '/';
            }
            catch { }
        }

        private void BtnEqualSign_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }

        private void Calculate()
        {
            switch (calc.Sign)
            {
                case '+':
                    calc.SecondInt = calc.FirstInt + double.Parse(txtShow.Text);
                    txtShow.Text = calc.SecondInt.ToString();
                    break;
                case '-':
                    calc.SecondInt = calc.FirstInt - double.Parse(txtShow.Text);
                    txtShow.Text = calc.SecondInt.ToString();
                    break;
                case '*':
                    calc.SecondInt = calc.FirstInt * double.Parse(txtShow.Text);
                    txtShow.Text = calc.SecondInt.ToString();
                    break;
                case '/':
                    calc.SecondInt = calc.FirstInt / double.Parse(txtShow.Text);
                    txtShow.Text = calc.SecondInt.ToString();
                    break;

                default:
                    break;
            }
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            int lenght = txtShow.Text.Length - 1;
            string text = txtShow.Text;
            txtShow.Clear();
            for (int i = 0; i < lenght; i++)
            {
                txtShow.Text = txtShow.Text + text[i];
            }
        }

        private void BtnReverseSign_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = 1 / calc.FirstInt;
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnRootSign_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = Math.Sqrt(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnXpow2_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = Math.Pow(calc.FirstInt, 2);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnXpow3_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = Math.Pow(calc.FirstInt, 3);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private double Factorial(double n)
        {
            int res = 1;
            for (int j = 1; j <= n; j++)
            {
                res *= j;
            }
            return res;
        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(txtShow.Text);
            calc.FirstInt = Factorial(n);
            txtShow.Text = calc.FirstInt.ToString();
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Sin(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Cos(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Tan(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            label1.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
        }

        private void BtnMemoryClean_Click(object sender, EventArgs e)
        {
            calc.Memory = 0;
            txtMemory.Text = "0";
        }

        private void BtnMemoryRecord_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtMemory.Text;
        }

        private void BtnMemorySet_Click(object sender, EventArgs e)
        {
            calc.Memory = Double.Parse(txtShow.Text);
            txtMemory.Text = calc.Memory.ToString();
            txtShow.Text = "0";
        }

        private void BtnMemoryAdd_Click(object sender, EventArgs e)
        {
            double Num2, Num3;
            Num2 = Double.Parse(txtShow.Text);
            Num3 = calc.Memory + Num2;
            txtMemory.Text = Num3.ToString();
        }

        private void BtnMemorySub_Click(object sender, EventArgs e)
        {
            double Num2, Num3;
            Num2 = Double.Parse(txtShow.Text);
            Num3 = calc.Memory - Num2;
            txtMemory.Text = Num3.ToString();
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            txtShow.Text = Math.PI.ToString();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Log10(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnLn_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Log(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void BtnTenPowX_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Pow(10, calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

    }
}
