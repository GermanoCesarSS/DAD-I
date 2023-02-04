namespace WindowsFormsApp1
{
    partial class Frm_Principal
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
            this.Btn_Mensagem = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Mensagem = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Mensagem
            // 
            this.Btn_Mensagem.Location = new System.Drawing.Point(12, 383);
            this.Btn_Mensagem.Name = "Btn_Mensagem";
            this.Btn_Mensagem.Size = new System.Drawing.Size(136, 55);
            this.Btn_Mensagem.TabIndex = 0;
            this.Btn_Mensagem.Text = "&Mensagem";
            this.Btn_Mensagem.UseVisualStyleBackColor = true;
            this.Btn_Mensagem.Click += new System.EventHandler(this.Btn_Mensagem_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.ForeColor = System.Drawing.Color.Red;
            this.Btn_Sair.Location = new System.Drawing.Point(652, 383);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(136, 55);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Mensagem
            // 
            this.Lbl_Mensagem.AutoSize = true;
            this.Lbl_Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensagem.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Mensagem.Name = "Lbl_Mensagem";
            this.Lbl_Mensagem.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Mensagem.TabIndex = 2;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Enabled = false;
            this.Btn_Limpar.Location = new System.Drawing.Point(332, 383);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(136, 55);
            this.Btn_Limpar.TabIndex = 3;
            this.Btn_Limpar.Text = "&Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Azul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Vermelho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Lbl_Mensagem);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Mensagem);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula Inagural";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mensagem;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_Mensagem;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

