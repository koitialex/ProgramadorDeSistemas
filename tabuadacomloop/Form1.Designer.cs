
namespace tabuadacomloop
{
    partial class frmTabuadaComLoop
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.pnlFundo.SuspendLayout();
            this.pnlEsquerda.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.Cyan;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlDireita);
            this.pnlFundo.Controls.Add(this.pnlEsquerda);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(800, 450);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.Pink;
            this.pnlEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEsquerda.Controls.Add(this.lstTabuada);
            this.pnlEsquerda.Location = new System.Drawing.Point(27, 25);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(353, 397);
            this.pnlEsquerda.TabIndex = 0;
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.Pink;
            this.pnlDireita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDireita.Controls.Add(this.btnExecutar);
            this.pnlDireita.Controls.Add(this.txtNumero);
            this.pnlDireita.Controls.Add(this.lblTitulo);
            this.pnlDireita.Location = new System.Drawing.Point(406, 25);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(367, 397);
            this.pnlDireita.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(65, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira um número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(72, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(236, 62);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.Cyan;
            this.btnExecutar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(128, 320);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(128, 47);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 28;
            this.lstTabuada.Location = new System.Drawing.Point(22, 27);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(305, 340);
            this.lstTabuada.TabIndex = 3;
            // 
            // frmTabuadaComLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmTabuadaComLoop";
            this.Text = "Tabuada com loop";
            this.pnlFundo.ResumeLayout(false);
            this.pnlEsquerda.ResumeLayout(false);
            this.pnlDireita.ResumeLayout(false);
            this.pnlDireita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}

