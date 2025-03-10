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
    public partial class conometro : Form
    {
        public conometro()
        {
            InitializeComponent();

            
        }
        int contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            button1.Text = "Continuar";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            lblconometro.Text = Convert.ToString(contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            contador = 0;
            lblconometro.Text = "0";
            button1.Text = "Iniciar";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            conometro novoconometro = new conometro();
            this.Close();
        }
    }
}
