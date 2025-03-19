using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodeidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anonascimento, anoatual, idade;
            anonascimento = int.Parse(txtAnoNascimento.Text);
            anoatual = int.Parse(txtAnoAtual.Text);
            idade = anoatual - anonascimento;

            lblIdade.Text = idade.ToString();
        }
    }
}
