using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox
{
    public partial class FrmPictureBox : Form
    {
        private string imagemLocalizada;
        public FrmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbPaulista.Image = Image.FromFile(@"C:\Users\Alex.kishikawa\Downloads\masp-sp.PNG");
            pbPaulista.SizeMode = PictureBoxSizeMode.StretchImage; 

        }

        private void btnAnexarImagem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
            //caixa de diálogo para abrir arquivo
            OpenFileDialog abrirarquivo = new OpenFileDialog();
            abrirarquivo.Filter = "jpg files (*.jpg) |*.jpg | png files (*.png) | *.png | All files (*.*) | *.*";

                if(abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemLocalizada;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
