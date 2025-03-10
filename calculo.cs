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
    public partial class calculo : Form
    {
        public calculo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtvalor1.Text, out int v1) & int.TryParse(txtvalor2.Text, out int v2))
            {
                int resultado = v1 + v2;
                txtvresult.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtvalor1.Text, out int v1MENOS) & int.TryParse(txtvalor2.Text, out int v2MENOS))
            {
                int resultadoMENOS = v1MENOS - v2MENOS;
                txtvresult.Text = resultadoMENOS.ToString();
            }
            else
            {
                MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtvalor1.Text, out int v1X) & int.TryParse(txtvalor2.Text, out int v2X))
            {
                int resultadoX = v1X * v2X;
                txtvresult.Text = resultadoX.ToString();
            }
            else
            {
                MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtvalor1.Text, out float v1div) & float.TryParse(txtvalor2.Text, out float v2div))
            {
                float resultado = v1div / v2div;
                txtvresult.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtvresult.Clear();
            txtvalor2.Clear();
            txtvalor1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculo novocalculo = new calculo();
            this.Close();
        }

        private void calculo_Load(object sender, EventArgs e)
        {
            

        }
    }
}
