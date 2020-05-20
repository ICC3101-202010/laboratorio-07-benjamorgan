using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab7
{
    public partial class Form1 : Form
    {
        double primero = 0;
        double segundo =0;
        double resp = 0;
        string operador = "+";
        List<string> hist = new List<string>();
        double primero2 = 0;
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
                double primero2 = 0;
                operador = "+";
                if (double.TryParse(Pantalla.Text, out primero2))
                {                    
                    primero += primero2;
                    Pantalla.Clear();
                }
                else
                {
                    Pantalla.Text = "Sintax Error";
                }


            }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                operador = "-";

                if (  primero2 ==0)
                {
                    if (double.TryParse(Pantalla.Text, out primero2))
                    {
                        primero += primero2;
                        Pantalla.Clear();
                    }
                }
                else if (primero2 !=0)
                {
                    if (double.TryParse(Pantalla.Text, out primero2))
                    {


                        primero -= primero2;
                        Pantalla.Clear();
                    }
                }
                else
                {
                    Pantalla.Text = "Sintax Error";
                }

            }
            else
                Pantalla.Text = "-";
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                operador = "*";
                if (primero2 != 0)
                {
                    if (double.TryParse(Pantalla.Text, out primero2))
                    {

                        primero = primero * double.Parse(Pantalla.Text);
                        Pantalla.Clear();
                    }
                }
                else if (primero2 == 0)
                {
                    if (double.TryParse(Pantalla.Text, out primero2))
                    {
                        primero += primero2;
                        double.TryParse(Pantalla.Text,out primero2);
                        Pantalla.Clear();
                    }
                }

                else
                {
                    Pantalla.Text = "Sintax Error";
                }

            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {

                operador = "/";
                if (primero2 != 0)
                {
                    if (double.TryParse(Pantalla.Text, out primero2))
                    {

                        primero = primero / double.Parse(Pantalla.Text);
                        Pantalla.Clear();
                    }
                }
                else if (primero2 == 0)
                {
                    if (double.TryParse(Pantalla.Text, out primero2))
                    {
                        primero += primero2;
                        double.TryParse(Pantalla.Text, out primero2);
                        Pantalla.Clear();
                    }
                }

                
                else
                {
                    Pantalla.Text = "Sintax Error";

                }
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                if (double.TryParse(Pantalla.Text, out segundo))
                {
                    double.TryParse(Pantalla.Text, out segundo);
                
                //segundo = double.Parse(Pantalla.Text);
                    switch (operador)
                    {
                        case "+":
                            {
                                resp = primero + segundo;
                                Pantalla.Text = resp.ToString();
                                hist.Add(primero.ToString() + " " + operador + " " + segundo.ToString() + " = " + resp);
                                break;
                            }
                        case "-":
                            {

                                 resp = primero - segundo;
                                 Pantalla.Text = resp.ToString();
                                 hist.Add(primero.ToString() + " " + operador + " " + segundo.ToString() + " = " + resp);


                                break;
                            }
                        case "*":
                            {
                                resp = primero * segundo;
                                Pantalla.Text = resp.ToString();
                                hist.Add(primero.ToString() + " " + operador + " " + segundo.ToString() + " = " + resp);

                                break;
                            }
                        case "/":
                            {
                                resp = primero / segundo;
                                if (resp == double.PositiveInfinity || resp == double.NegativeInfinity)
                                {
                                    Pantalla.Text = "Math Error";
                                }
                                else
                                {
                                    Pantalla.Text = resp.ToString();
                                    hist.Add(primero.ToString() + " "+operador+" " + segundo.ToString() + " = " + resp);
                                    primero = 0;
                                    segundo = 0;
                                }
                                break;
                            }

                        default:
                            break;
                    }
                }
                else
                    Pantalla.Text = "Sintax Error";
            }
            else
                Pantalla.Text = Pantalla.Text ;
            
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            primero = 0;
            primero2 = 0;
            segundo = 0;
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

        private void btnhist_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Textbox_Historial.Clear();
            for (int i = 0; i < hist.Count(); i++)
            {
                Textbox_Historial.Text += hist[i] + Environment.NewLine;
            }

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBorrarHist_Click(object sender, EventArgs e)
        {
            Textbox_Historial.Clear();
            hist.Clear();
            
        }
    }
}
