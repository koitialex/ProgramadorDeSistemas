
namespace calculadorasimples
{
    partial class frmCalculodeIdade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnNascimento = new System.Windows.Forms.Panel();
            this.lblAnoNasce = new System.Windows.Forms.Label();
            this.txtAnoNasce = new System.Windows.Forms.TextBox();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.pnNascimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNascimento
            // 
            this.pnNascimento.BackColor = System.Drawing.Color.DeepPink;
            this.pnNascimento.Controls.Add(this.lblIdade);
            this.pnNascimento.Controls.Add(this.btnCalcular);
            this.pnNascimento.Controls.Add(this.txtAnoAtual);
            this.pnNascimento.Controls.Add(this.lblAnoAtual);
            this.pnNascimento.Controls.Add(this.txtAnoNasce);
            this.pnNascimento.Controls.Add(this.lblAnoNasce);
            this.pnNascimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNascimento.Location = new System.Drawing.Point(0, 0);
            this.pnNascimento.Name = "pnNascimento";
            this.pnNascimento.Size = new System.Drawing.Size(800, 450);
            this.pnNascimento.TabIndex = 0;
            // 
            // lblAnoNasce
            // 
            this.lblAnoNasce.AutoSize = true;
            this.lblAnoNasce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoNasce.ForeColor = System.Drawing.Color.White;
            this.lblAnoNasce.Location = new System.Drawing.Point(318, 95);
            this.lblAnoNasce.Name = "lblAnoNasce";
            this.lblAnoNasce.Size = new System.Drawing.Size(174, 24);
            this.lblAnoNasce.TabIndex = 1;
            this.lblAnoNasce.Text = "Ano de nascimento";
            // 
            // txtAnoNasce
            // 
            this.txtAnoNasce.Location = new System.Drawing.Point(322, 138);
            this.txtAnoNasce.Name = "txtAnoNasce";
            this.txtAnoNasce.Size = new System.Drawing.Size(170, 20);
            this.txtAnoNasce.TabIndex = 2;
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoAtual.ForeColor = System.Drawing.Color.White;
            this.lblAnoAtual.Location = new System.Drawing.Point(318, 189);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(89, 24);
            this.lblAnoAtual.TabIndex = 3;
            this.lblAnoAtual.Text = "Ano atual";
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(322, 232);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(170, 20);
            this.txtAnoAtual.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(322, 316);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(170, 33);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(390, 275);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(26, 29);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "0";
            // 
            // frmCalculodeIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnNascimento);
            this.Name = "frmCalculodeIdade";
            this.Text = "Form2";
            this.pnNascimento.ResumeLayout(false);
            this.pnNascimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.TextBox txtAnoNasce;
        private System.Windows.Forms.Label lblAnoNasce;
    }
}