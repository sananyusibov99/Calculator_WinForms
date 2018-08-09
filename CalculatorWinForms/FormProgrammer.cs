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
    public partial class FormProgrammer : Form
    {
        Calc calc = new Calc();

        public FormProgrammer()
        {
            InitializeComponent();
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

        private void StatisticslaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStatistics();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormScientific();

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
                if (txtDEC.Text == "0" && txtDEC.Text != null)
                {
                    Button selected = (Button)sender;
                    String NumVal = selected.Text;
                    txtDEC.Text = NumVal;
                }
                else
                {
                    Button selected = (Button)sender;
                    String NumVal = selected.Text;
                    txtDEC.Text += NumVal;
                }

            }
            catch { MessageBox.Show("Not a valid entry"); }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtBIN.Clear();
            txtHEX.Clear();
            txtOCT.Clear();

            // Конвертация DEC в HEX
            int i = 1, j, temp = 0;
            char[] hexNumber = new char[100];
            int Decimal = Int32.Parse(txtDEC.Text);

            while (Decimal != 0)
            {
                temp = Decimal % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                char temp1 = Convert.ToChar(temp);
                hexNumber[i++] = temp1;
                Decimal = Decimal / 16;
            }

            for (j = i - 1; j > 0; j--)
                txtHEX.Text += (hexNumber[j]);

            //Конвертация в OCT
            i = 1;
            int[] octNumber = new int[100];
            Decimal = Int32.Parse(txtDEC.Text);
            
            while (Decimal != 0)
            {
                octNumber[i++] = Decimal % 8;
                Decimal = Decimal / 8;
            }

            for (j = i - 1; j > 0; j--)
                txtOCT.Text += (octNumber[j]);


            //Конвертация в BIN
            int remainder;
            string result = string.Empty;
            Decimal = Int32.Parse(txtDEC.Text);

            while (Decimal > 0)
            {
                remainder = Decimal % 2;
                Decimal /= 2;
                result = remainder.ToString() + result;
            }
            txtBIN.Text = result;


            txtDEC.Clear();
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            int lenght = txtDEC.Text.Length - 1;
            string text = txtDEC.Text;
            txtDEC.Clear();
            for (int i = 0; i < lenght; i++)
            {
                txtDEC.Text = txtDEC.Text + text[i];
            }
        }

    }
}
