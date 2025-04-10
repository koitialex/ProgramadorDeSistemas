using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace formularioSimples
{
    public partial class frmFomularioSimples : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=datahost;username=root;password=;database=  "; ///  
        public frmFomularioSimples()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //validade de campos obigatórios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastro.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor,escreva um nome.");
                return;
            }

            dataNascimento = dateTimePicker1.Value.Date;

            if(dataNascimento >= DateTime.Now.Date)
            {
                MessageBox.Show("Verifique novamente a sua data de nascimento.");
                return;
            }
            if(cbCidade.SelectedItem == null)
            {
                 MessageBox.Show("Por favor, selecione a cidade. ");
                 return;
            }
            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
            {
                 MessageBox.Show("Por favor, selecione o gênero ");
                 return;
            }
            //no momento em que todos os campos foram preenchidos
            numeroCadastro = Convert.ToInt32(txtNumeroCadastro.Text);
            nomeUsuario = txtNomeCompleto.Text;
            cidade = cbCidade.Text;
            generoF = rbFeminino.Checked; //verifica se de fato genero recebeu nessas variaveis
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //formatar a data para formato brasileiro
            string dataFormatada = dataNascimento.ToString("dd/mm/yyyy");


            //Determinar o genero selecionado
            string generoSelecionado = "Não informado";
            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else if (generoNB)
                generoSelecionado = "Não binário";

            //Exibir as informações em MessageBox
            MessageBox.Show($"O número cadastro: {numeroCadastro}");
            MessageBox.Show($"O nome: {nomeUsuario}");
            MessageBox.Show($"Data de nascimento: {dataFormatada}");
            MessageBox.Show($"Cidade: {cidade}");
            MessageBox.Show($"Gênero: {generoSelecionado}");

            Conexao cmd = new MySqlCommand(data_source);
            Conexao.Open();

            MessageBox.Show("Conexão feita com sucesso",
                           "Sucesso",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = Conexao
            };
            cmd.Prepare();

            cmd.CommandText = "insert into dadosdecliente(nomecompleto,nomesocial,email,cpf)"


        }


        private void txtNumeroCadastro_Click(object sender, EventArgs e)
        {
            if(txtNumeroCadastro.Text =="Número Cadastro")
            {
            txtNumeroCadastro = null;
            }
        }

        private void txtNomeComleto_Click(object sender, EventArgs e)
        {
            if(txtNomeCompleto.Text == "Insira o seu nome completo")
            { 
                txtNomeCompleto.Text = "";
            
            }
            
        }
    }
}
