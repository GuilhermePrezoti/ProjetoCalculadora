
namespace ProjetoCalculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.soma = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.AccessibleDescription = "Botão utilizado para soma";
            this.soma.AccessibleName = "soma";
            this.soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soma.BackgroundImage")));
            this.soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soma.Location = new System.Drawing.Point(237, 127);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(120, 97);
            this.soma.TabIndex = 0;
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // Subtracao
            // 
            this.Subtracao.AccessibleDescription = "Botão para Subtrair";
            this.Subtracao.AccessibleName = "Subtrair";
            this.Subtracao.BackColor = System.Drawing.SystemColors.Control;
            this.Subtracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Subtracao.BackgroundImage")));
            this.Subtracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Subtracao.Location = new System.Drawing.Point(363, 127);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(108, 95);
            this.Subtracao.TabIndex = 1;
            this.Subtracao.UseVisualStyleBackColor = false;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.AccessibleDescription = "Botão para Multiplicar";
            this.Multiplicacao.AccessibleName = "Multiplicar";
            this.Multiplicacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Multiplicacao.BackgroundImage")));
            this.Multiplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Multiplicacao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Multiplicacao.Location = new System.Drawing.Point(477, 127);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(105, 95);
            this.Multiplicacao.TabIndex = 2;
            this.Multiplicacao.UseVisualStyleBackColor = false;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.AccessibleDescription = "Botão para dividir";
            this.divisao.AccessibleName = "Dividir";
            this.divisao.BackColor = System.Drawing.SystemColors.Control;
            this.divisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divisao.BackgroundImage")));
            this.divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.divisao.Location = new System.Drawing.Point(237, 228);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(120, 83);
            this.divisao.TabIndex = 3;
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // Potencia
            // 
            this.Potencia.AccessibleDescription = "Botão para Potencia";
            this.Potencia.AccessibleName = "Potencia";
            this.Potencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Potencia.BackgroundImage")));
            this.Potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Potencia.Location = new System.Drawing.Point(363, 228);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(108, 83);
            this.Potencia.TabIndex = 4;
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Raiz
            // 
            this.Raiz.AccessibleDescription = "Botão para  Raiz";
            this.Raiz.AccessibleName = "Raiz";
            this.Raiz.BackColor = System.Drawing.SystemColors.Control;
            this.Raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Raiz.BackgroundImage")));
            this.Raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raiz.Location = new System.Drawing.Point(477, 228);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(105, 83);
            this.Raiz.TabIndex = 5;
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Segundo Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Primeiro Número";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.soma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

