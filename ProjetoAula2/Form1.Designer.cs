namespace ProjetoAula2
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
            this.labellogin = new System.Windows.Forms.Label();
            this.labelsenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.Black;
            this.labellogin.Location = new System.Drawing.Point(227, 102);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(49, 26);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "login";
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.BackColor = System.Drawing.Color.Transparent;
            this.labelsenha.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.ForeColor = System.Drawing.Color.Black;
            this.labelsenha.Location = new System.Drawing.Point(227, 178);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(65, 26);
            this.labelsenha.TabIndex = 1;
            this.labelsenha.Text = "Senha";
            this.labelsenha.Click += new System.EventHandler(this.labelsenha_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(408, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAula2.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(983, 622);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.labellogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aula1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

