
namespace JogodeNumeros
{
    partial class FrmJogodeNumeros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumeroTentativas = new System.Windows.Forms.Label();
            this.lblAbaixoBotao = new System.Windows.Forms.Label();
            this.btnTentativas = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(125, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(553, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Boas vindas para o meu jogo de números";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSubtitulo.Location = new System.Drawing.Point(201, 51);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(412, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "10 tentativas! Insira um número de 1 até 100";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.lblNumeroTentativas);
            this.panel2.Controls.Add(this.lblAbaixoBotao);
            this.panel2.Controls.Add(this.btnTentativas);
            this.panel2.Controls.Add(this.txtResultado);
            this.panel2.Controls.Add(this.lblSubtitulo);
            this.panel2.Controls.Add(this.txtNumeroInserido);
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 343);
            this.panel2.TabIndex = 2;
            // 
            // lblNumeroTentativas
            // 
            this.lblNumeroTentativas.AutoSize = true;
            this.lblNumeroTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTentativas.ForeColor = System.Drawing.Color.White;
            this.lblNumeroTentativas.Location = new System.Drawing.Point(541, 224);
            this.lblNumeroTentativas.Name = "lblNumeroTentativas";
            this.lblNumeroTentativas.Size = new System.Drawing.Size(30, 24);
            this.lblNumeroTentativas.TabIndex = 5;
            this.lblNumeroTentativas.Text = "10";
            // 
            // lblAbaixoBotao
            // 
            this.lblAbaixoBotao.AutoSize = true;
            this.lblAbaixoBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaixoBotao.ForeColor = System.Drawing.Color.White;
            this.lblAbaixoBotao.Location = new System.Drawing.Point(227, 224);
            this.lblAbaixoBotao.Name = "lblAbaixoBotao";
            this.lblAbaixoBotao.Size = new System.Drawing.Size(308, 24);
            this.lblAbaixoBotao.TabIndex = 4;
            this.lblAbaixoBotao.Text = "Veja quantas tentativas que te resta:";
            // 
            // btnTentativas
            // 
            this.btnTentativas.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativas.Location = new System.Drawing.Point(343, 164);
            this.btnTentativas.Name = "btnTentativas";
            this.btnTentativas.Size = new System.Drawing.Size(116, 32);
            this.btnTentativas.TabIndex = 3;
            this.btnTentativas.Text = "Tentativas";
            this.btnTentativas.UseVisualStyleBackColor = false;
            this.btnTentativas.Click += new System.EventHandler(this.btnTentativas_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(205, 262);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(397, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Location = new System.Drawing.Point(296, 116);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(209, 20);
            this.txtNumeroInserido.TabIndex = 0;
            this.txtNumeroInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmJogodeNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmJogodeNumeros";
            this.Text = "Jogo de números";
            this.Load += new System.EventHandler(this.FrmJogodeNumeros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumeroTentativas;
        private System.Windows.Forms.Label lblAbaixoBotao;
        private System.Windows.Forms.Button btnTentativas;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumeroInserido;
    }
}

