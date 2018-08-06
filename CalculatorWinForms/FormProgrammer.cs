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
    public partial class FormProgrammer : Form
    {
        Calc calc = new Calc();
        public FormProgrammer()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
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

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnCalculate_Click(object sender, EventArgs e)
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

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int lenght = txtDEC.Text.Length - 1;
            string text = txtDEC.Text;
            txtDEC.Clear();
            for (int i = 0; i < lenght; i++)
            {
                txtDEC.Text = txtDEC.Text + text[i];
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
