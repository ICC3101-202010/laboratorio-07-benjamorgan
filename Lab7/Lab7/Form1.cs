using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        double primero = 0;
        double segundo =0;
        double resp = 0;
        string operador = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                operador = "+";
                double.TryParse(Pantalla.Text, out primero);
                Pantalla.Clear();
            }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                operador = "-";
                double.TryParse(Pantalla.Text, out primero);
                Pantalla.Clear();
            }
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                operador = "*";
                double.TryParse(Pantalla.Text, out primero);
                Pantalla.Clear();
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                operador = "/";
                double.TryParse(Pantalla.Text,out primero);
                Pantalla.Clear();
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                double.TryParse(Pantalla.Text, out segundo);
                //segundo = double.Parse(Pantalla.Text);
                switch (operador)
                {
                    case "+":
                        {
                            resp = primero + segundo;
                            Pantalla.Text = resp.ToString();
                            break;
                        }
                    case "-":
                        {
                            resp = primero - segundo;
                            Pantalla.Text = resp.ToString();

                            break;
                        }
                    case "*":
                        {
                            resp = primero * segundo;
                            Pantalla.Text = resp.ToString();

                            break;
                        }
                    case "/":
                        {
                            resp = primero / segundo;
                            if (resp == double.PositiveInfinity || resp == double.NegativeInfinity)
                                Pantalla.Text = "Sintax Error";
                            else
                                 Pantalla.Text = resp.ToString();

                            break;
                        }

                    default:
                        break;
                }
            }
            else
                Pantalla.Text = Pantalla.Text;
            
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1);
            else
                Pantalla.Text = Pantalla.Text;
        }

        private void btnans_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + resp.ToString();
        }
    }
}
