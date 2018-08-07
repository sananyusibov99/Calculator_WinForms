using Newtonsoft.Json.Linq;
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
        }

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

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wnd = new FormSettings();
            var res = wnd.ShowDialog();
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={newToolStripMenuItem.Text}&lang={Options.Language}");
                var data = JObject.Parse(result);
                MessageBox.Show((string)data["text"][0]);
                newToolStripMenuItem.Text = (string)data["text"][0];
            }
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
