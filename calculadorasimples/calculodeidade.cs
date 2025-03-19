using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasimples
{
    public partial class frmCalculodeIdade : Form
    {
        public frmCalculodeIdade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int idade, anoatual, anonascimento;
            anonascimento = int.Parse(txtAnoNasce.Text);
            anoatual = int.Parse(txtAnoAtual.Text);
            idade = anoatual - anonascimento;

            lblIdade.Text = idade.ToString();
        }
    }
}
