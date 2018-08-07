using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStandart();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormScientific();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormProgrammer();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }

        private void btnNumber_Click(object sender, EventArgs e)
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

        private void btnMemoryClean_Click(object sender, EventArgs e)
        {
                calc.Memory = 0;
                txtMemory.Text = "0";
        }

        private void btnMemoryRecord_Click(object sender, EventArgs e)
        {
                txtShow.Text = txtMemory.Text;
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            double Num2, Num3;
            Num2 = Double.Parse(txtShow.Text);
            Num3 = calc.Memory + Num2;
            txtMemory.Text = Num3.ToString();
        }

        private void btnMemorySub_Click(object sender, EventArgs e)
        {
            double Num2, Num3;
            Num2 = Double.Parse(txtShow.Text);
            Num3 = calc.Memory - Num2;
            txtMemory.Text = Num3.ToString();
        }

        private void btnMemorySet_Click(object sender, EventArgs e)
        {
            calc.Memory = Double.Parse(txtShow.Text);
            txtMemory.Text = calc.Memory.ToString();
            txtShow.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int lenght = txtShow.Text.Length - 1;
            string text = txtShow.Text;
            txtShow.Clear();
            for (int i = 0; i < lenght; i++)
            {
                txtShow.Text = txtShow.Text + text[i];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            txtMemory.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.Numbers.Add(Double.Parse(txtShow.Text));
            txtShow.Text = null;
        }

        private void btnSUMx_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            foreach (var item in calc.Numbers)
            {
                Sum += item;
            }
            txtShow.Text = Sum.ToString();
        }

        private void btnSUMxPow2_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            foreach (var item in calc.Numbers)
            {
                Sum += item*item;
            }
            txtShow.Text = Sum.ToString();
        }

        private void btnCAD_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            txtMemory.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
            calc.Numbers.Clear();
        }

        private void btnAVG_Click(object sender, EventArgs e)
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

        private void btnExp_Click(object sender, EventArgs e)
        {
            txtShow.Text = Math.Exp(Int32.Parse(txtShow.Text)).ToString();
        }
    }
}
