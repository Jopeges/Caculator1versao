using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        decimal Valor1 = 0, Valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(lbValorDigitado.Text, CultureInfo.InvariantCulture);
            lbValorDigitado.Text = "";
            operacao = "VEZES";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(lbValorDigitado.Text, CultureInfo.InvariantCulture);
            lbValorDigitado.Text = "";
            operacao = "DIV";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(lbValorDigitado.Text, CultureInfo.InvariantCulture);
            lbValorDigitado.Text = "";
            operacao = "SUB";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Valor2 = decimal.Parse(lbValorDigitado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                lbValorDigitado.Text = Convert.ToString(Valor1 + Valor2);
            }
            else if (operacao == "SUB")
            {
                lbValorDigitado.Text = Convert.ToString(Valor1 - Valor2);
            }
            else if (operacao == "VEZES")
            {
                lbValorDigitado.Text = Convert.ToString(Valor1 * Valor2);
            }
            else
            {
                lbValorDigitado.Text = Convert.ToString(Valor1 / Valor2);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "2";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "5";
        }

        private void lbValorDigitado_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            lbValorDigitado.Text += "6";
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonmais_Click(object sender, EventArgs e)
        {
            Valor1 = decimal.Parse(lbValorDigitado.Text, CultureInfo.InvariantCulture);
            lbValorDigitado.Text = "";
            operacao = "SOMA";

        }
    }
}
