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
    public partial class FormStatistics : Form
    {
        Calc calc = new Calc();

        public FormStatistics()
        {
            InitializeComponent();
        }

        private void StandartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStandart();

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

        private void ProgrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormProgrammer();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var wnd = new FormSettings();
           var res = wnd.ShowDialog();
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

        private void BtnMemoryClean_Click(object sender, EventArgs e)
        {
            calc.Memory = 0;
            txtMemory.Text = "0";
        }

        private void BtnMemoryRecord_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtMemory.Text;
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

        private void BtnMemorySet_Click(object sender, EventArgs e)
        {
            calc.Memory = Double.Parse(txtShow.Text);
            txtMemory.Text = calc.Memory.ToString();
            txtShow.Text = "0";
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            txtMemory.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
        }

        private void BtnCAD_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            txtMemory.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
            calc.Numbers.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            calc.Numbers.Add(Double.Parse(txtShow.Text));
            txtShow.Text = null;
        }

        private void BtnSUMx_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            foreach (var item in calc.Numbers)
            {
                Sum += item;
            }
            txtShow.Text = Sum.ToString();
        }

        private void BtnSUMxPow2_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            foreach (var item in calc.Numbers)
            {
                Sum += item * item;
            }
            txtShow.Text = Sum.ToString();
        }

        private void BtnAVG_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            int iter = 0;
            foreach (var item in calc.Numbers)
            {
                Sum += item;
                iter++;
            }
            txtShow.Text = (Sum / iter).ToString();
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            txtShow.Text = Math.Exp(Int32.Parse(txtShow.Text)).ToString();
        }

    }
}
