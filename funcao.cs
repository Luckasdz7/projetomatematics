using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetomatematics
{
    public partial class funcao : Form
    {
        public funcao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* decimal A = Convert.ToInt32(valora.Text);
            decimal B = Convert.ToInt32(valorb.Text);
            decimal Y = Convert.ToInt32(valory.Text);

            decimal yb = Y - B;
           decimal resultado = Convert.ToDecimal(yb/A);
            result.Text = resultado.ToString(); JÁ FOI TESTADO E FUNCIONA MAS TEM MELHORES
            */

            if (label4.Text == "+")
            {
                if (decimal.TryParse(valora.Text, out decimal A) & decimal.TryParse(valorb.Text, out decimal B) & decimal.TryParse(valory.Text, out decimal Y))
                {
                    decimal yb = Y - B;
                    decimal resultado = Convert.ToDecimal(yb / A);
                    result.Text = "o valor de x é " + resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (label4.Text == "-")
            {
                if (decimal.TryParse(valora.Text, out decimal A) & decimal.TryParse(valorb.Text, out decimal B) & decimal.TryParse(valory.Text, out decimal Y))
                {
                    decimal yb = Y + B;
                    decimal resultado = Convert.ToDecimal(yb / A);
                    result.Text = "o valor de x é " + resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                label4.Text = "+";
            }
            else
            {
                label4.Text = "-";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          valora.Clear();
            valorb.Clear();
            valory.Clear();
            result.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label4.Text = "deu certo e naõ sei como";   
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {







            if (decimal.TryParse(txtA.Text, out decimal Ax) & decimal.TryParse(txtB.Text, out decimal Bx) & decimal.TryParse(txtC.Text, out decimal Cx))
            {
                if (lblprimeiro.Text == "-" )
                {
                    Bx = -Bx;
                }
                if(lblsegundo.Text == "-")
                {
                    Cx = -Cx;
                }

                decimal baskara = (Bx * Bx) - 4 * Ax * Cx;

                double raiz = Math.Sqrt(Convert.ToDouble(baskara));
                decimal raizconvertida = Convert.ToDecimal(raiz);
                decimal x1 = (-Bx + raizconvertida) / (2 * Ax);
                decimal x2 = (-Bx - raizconvertida) / (2 * Ax);
                txtresultadoquad.Text = $"x1 = {x1:F2} e x2 = {x2:F2}";


            }
        }

        private void lblprimeiro_Click(object sender, EventArgs e)
        {
            lblprimeiro.Text = "-";
        }

        private void lblprimeiro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lblprimeiro.Text = "+";
            }
            else
            {
                lblprimeiro.Text = "-";
            }
        }

        private void lblsegundo_Click(object sender, EventArgs e)
        {
            lblsegundo.Text = "-";

        }

        private void lblsegundo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lblsegundo.Text = "+";
            }
            else
            {
                lblsegundo.Text = "-";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcao novafuncao = new funcao();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
