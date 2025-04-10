using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayUnimendicional
{
    public partial class frmVetor : Form
    {
        public frmVetor()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string[] pecasComputador = { "Mouse", "Teclado", "Monitor", "Gambinete", "Câmera" };

            foreach (string peca in pecasComputador)
                MessageBox.Show(peca);
        }
    }
}
