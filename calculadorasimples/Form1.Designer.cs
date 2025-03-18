
namespace calculadorasimples
{
    partial class frmCalculadoraSimples
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txtPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblProdutoCalculo = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDivisao);
            this.groupBox1.Controls.Add(this.btnMultiplicar);
            this.groupBox1.Controls.Add(this.btnSubtrair);
            this.groupBox1.Controls.Add(this.lblProdutoCalculo);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.txtSegundoNumero);
            this.groupBox1.Controls.Add(this.lblSegundoNumero);
            this.groupBox1.Controls.Add(this.txtPrimeiroNumero);
            this.groupBox1.Controls.Add(this.lblPrimeiroNumero);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(31, 30);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(124, 20);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Primeiro numero";
            // 
            // txtPrimeiroNumero
            // 
            this.txtPrimeiroNumero.Location = new System.Drawing.Point(35, 65);
            this.txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            this.txtPrimeiroNumero.Size = new System.Drawing.Size(120, 33);
            this.txtPrimeiroNumero.TabIndex = 1;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNumero.Location = new System.Drawing.Point(32, 106);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(132, 20);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Segundo numero";
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(35, 146);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(120, 33);
            this.txtSegundoNumero.TabIndex = 3;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSomar.ForeColor = System.Drawing.Color.White;
            this.btnSomar.Location = new System.Drawing.Point(261, 64);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(119, 34);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(31, 220);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(98, 25);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblProdutoCalculo
            // 
            this.lblProdutoCalculo.AutoSize = true;
            this.lblProdutoCalculo.Location = new System.Drawing.Point(127, 220);
            this.lblProdutoCalculo.Name = "lblProdutoCalculo";
            this.lblProdutoCalculo.Size = new System.Drawing.Size(23, 25);
            this.lblProdutoCalculo.TabIndex = 6;
            this.lblProdutoCalculo.Text = "0";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(261, 133);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(119, 33);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultiplicar.Location = new System.Drawing.Point(398, 65);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(133, 33);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.Purple;
            this.btnDivisao.ForeColor = System.Drawing.Color.White;
            this.btnDivisao.Location = new System.Drawing.Point(398, 133);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(133, 33);
            this.btnDivisao.TabIndex = 9;
            this.btnDivisao.Text = "Dividir";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // frmCalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraSimples";
            this.Text = "calculadora Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txtPrimeiroNumero;
        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.Label lblProdutoCalculo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
    }
}

