using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuadacomloop
{
    public partial class frmTabuadaComLoop : Form
    {
        public frmTabuadaComLoop()
        {
            InitializeComponent();
            this.AcceptButton = btnExecutar;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int numeroInserido = Convert.ToInt32(txtNumero.Text);
            lstTabuada.Items.Clear();

            for (int i = 1; i < 11; i++)
            {
                int resultado = numeroInserido * i;
                lstTabuada.Items.Add($"{numeroInserido} x {i}  = {resultado}");
            }


        }
    }
}
