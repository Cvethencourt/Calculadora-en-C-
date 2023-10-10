using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double x;
        double y;
        double result;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "9";
        }

        private void BtnPuntoDecimal_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + ".";
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            x = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            x = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            x = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            x = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            y = double.Parse(Resultado.Text);

            switch (operacion) {
                case "+":
                    result = x + y;
                    Resultado.Text = result.ToString();
                    break;
                case "-":
                    result = x - y;
                    Resultado.Text = result.ToString();
                    break;
                case "*":
                    result = x * y;
                    Resultado.Text = result.ToString();
                    break;
                case "/":
                    result = x / y;
                    Resultado.Text = result.ToString();
                    break;
            }
        }

        private void BtnAC_Click(object sender, EventArgs e)
        {
            Resultado.Clear();
        }
    }
}