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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo NOVOcalculo = new calculo();
            NOVOcalculo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcao novafuncao = new funcao();
            novafuncao.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conometro novoconometro = new conometro();
            novoconometro.Show();
        }
    }
}
