using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodeNumeros
{
    public partial class FrmJogodeNumeros : Form
    {
        int randomnumber;
        int numerodetentativas = 10;
        int palpitedojogador;
        bool jogoganho = false;
        string dica;

        public FrmJogodeNumeros()
        {
            InitializeComponent();
        }

        private void FrmJogodeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomnumber = random.Next(1, 101); //numero randomico gerará 1 entre 1 a 100
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            if (numerodetentativas == 0)
            {
                txtResultado.Text = "O número de tentativas acabaram, então o jogo acabou";
                return;
            }
            numerodetentativas--;
            lblNumeroTentativas.Text = numerodetentativas.ToString();

            if (!int.TryParse(txtNumeroInserido.Text, out palpitedojogador) || palpitedojogador < 1 || palpitedojogador > 100)
            {
                txtResultado.Text = "Por favor, insira um número entre 1 e 100.";
                return;
            }
            if (palpitedojogador == randomnumber)
            {

                jogoganho = true;
                dica = "Parabens você ganhou";

            }
            else if (palpitedojogador < randomnumber)
            {
                dica = "número randomico é maior";
            }
            else
            {
                dica = "número randomico é menor";
            }
            txtResultado.Text = dica;
        }
    }
}
