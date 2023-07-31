namespace CalculadoraForms
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.maskedTextBox1.Location = new System.Drawing.Point(28, 193);
            this.maskedTextBox1.Mask = "00000000000000000000000000";
            this.maskedTextBox1.MaximumSize = new System.Drawing.Size(360, 26);
            this.maskedTextBox1.MinimumSize = new System.Drawing.Size(360, 26);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(360, 26);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Onyx", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 140);
            this.label1.MaximumSize = new System.Drawing.Size(160, 30);
            this.label1.MinimumSize = new System.Drawing.Size(160, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "insira um valor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.Color.Teal;
            this.soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.soma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soma.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(28, 257);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 47);
            this.soma.TabIndex = 2;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.Color.Teal;
            this.subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtracao.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(109, 257);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(75, 47);
            this.subtracao.TabIndex = 2;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.Color.Teal;
            this.multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicacao.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(28, 310);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(75, 47);
            this.multiplicacao.TabIndex = 2;
            this.multiplicacao.Text = "*";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.Teal;
            this.divisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisao.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(109, 310);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(75, 47);
            this.divisao.TabIndex = 2;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxResultado.Location = new System.Drawing.Point(199, 295);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(189, 26);
            this.textBoxResultado.TabIndex = 4;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelResultado.Font = new System.Drawing.Font("Onyx", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(217, 257);
            this.labelResultado.MaximumSize = new System.Drawing.Size(160, 30);
            this.labelResultado.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(160, 30);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "resultado";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 544);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximumSize = new System.Drawing.Size(416, 583);
            this.MinimumSize = new System.Drawing.Size(416, 583);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelResultado;
    }
}

