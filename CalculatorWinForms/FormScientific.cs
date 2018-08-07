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
    public partial class FormScientific : Form
    {
        Calc calc = new Calc();
        int count;
        public FormScientific()
        {
            InitializeComponent();
            txtShow.Text = "0";
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

        private void btnPlusSign_Click(object sender, EventArgs e)
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

        private void btnMinusSign_Click(object sender, EventArgs e)
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

        private void btnMultSign_Click(object sender, EventArgs e)
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

        private void btnDivSign_Click(object sender, EventArgs e)
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

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void calculate()
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

        private void btnReverseSign_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = 1 / calc.FirstInt;
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnRootSign_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = Math.Sqrt(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnXpow2_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Convert.ToDouble(txtShow.Text);
            calc.SecondInt = Math.Pow(calc.FirstInt, 2);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnXpow3_Click(object sender, EventArgs e)
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

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(txtShow.Text);
            calc.FirstInt = Factorial(n);
            txtShow.Text = calc.FirstInt.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Sin(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Cos(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Tan(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }


        private void btnCE_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            label1.Text = null;
            calc.FirstInt = 0;
            calc.SecondInt = 0;
            calc.Sign = null;
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

        private void btnMemorySet_Click(object sender, EventArgs e)
        {
            calc.Memory = Double.Parse(txtShow.Text);
            txtMemory.Text = calc.Memory.ToString();
            txtShow.Text = "0";
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

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtShow.Text = Math.PI.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Log10(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Log(calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void btnTenPowX_Click(object sender, EventArgs e)
        {
            calc.FirstInt = Double.Parse(txtShow.Text);
            calc.SecondInt = Math.Pow(10, calc.FirstInt);
            txtShow.Text = calc.SecondInt.ToString();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStandart();

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statisticslaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormStatistics();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }
    }
}
