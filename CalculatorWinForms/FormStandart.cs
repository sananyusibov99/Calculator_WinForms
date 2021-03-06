﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class FormStandart : Form
    {
        Calc calc = new Calc();
        int count = 0;

        public FormStandart()
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

        private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormScientific();

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.NumPad1 || keyData == Keys.D1)
            {
                btnNumber1.PerformClick();
                btnNumber1.Focus();
            }
            else if (keyData == Keys.NumPad2 || keyData == Keys.D2)
            {
                btnNumber2.PerformClick();
                btnNumber2.Focus();
            }
            else if (keyData == Keys.NumPad3 || keyData == Keys.D3)
            {
                btnNumber3.PerformClick();
                btnNumber3.Focus();
            }
            else if (keyData == Keys.NumPad4 || keyData == Keys.D4)
            {
                btnNumber4.PerformClick();
                btnNumber4.Focus();
            }
            else if (keyData == Keys.NumPad5 || keyData == Keys.D5)
            {
                btnNumber5.PerformClick();
                btnNumber5.Focus();
            }
            else if (keyData == Keys.NumPad6 || keyData == Keys.D6)
            {
                btnNumber6.PerformClick();
                btnNumber6.Focus();
            }
            else if (keyData == Keys.NumPad7 || keyData == Keys.D7)
            {
                btnNumber7.PerformClick();
                btnNumber7.Focus();
            }
            else if (keyData == Keys.NumPad8 || keyData == Keys.D8)
            {
                btnNumber8.PerformClick();
                btnNumber8.Focus();
            }
            else if (keyData == Keys.NumPad9 || keyData == Keys.D9)
            {
                btnNumber9.PerformClick();
                btnNumber9.Focus();
            }
            else if (keyData == Keys.NumPad0 || keyData == Keys.D0)
            {
                btnNumber0.PerformClick();
                btnNumber0.Focus();
            }
            else if (keyData == Keys.Add || keyData == (Keys.Shift |Keys.Oemplus))
            {
                btnPlusSign.PerformClick();
                btnPlusSign.Focus();
            }
            else if (keyData == Keys.Subtract || keyData == Keys.OemMinus)
            {
                btnMinusSign.PerformClick();
                btnMinusSign.Focus();
            }
            else if (keyData == Keys.Divide)
            {
                btnDivSign.PerformClick();
                btnDivSign.Focus();
            }
            else if (keyData == Keys.Multiply || keyData == (Keys.Shift | Keys.D8))
            {
                btnMultSign.PerformClick();
                btnMultSign.Focus();
            }
            else if (keyData == Keys.Enter || keyData == Keys.Oemplus)
            {
                btnEqualSign.PerformClick();
                btnEqualSign.Focus();
            }
            else if (keyData == Keys.Back)
            {
                btnBackspace.PerformClick();
                btnBackspace.Focus();
            }

            return true;
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

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            label1.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
        }

    }
}
