namespace Projeto_04
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
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Grb_Sexo = new System.Windows.Forms.GroupBox();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Grb_Exames = new System.Windows.Forms.GroupBox();
            this.Chb_Sangue = new System.Windows.Forms.CheckBox();
            this.Chb_Ortopédico = new System.Windows.Forms.CheckBox();
            this.Chb_Mamografia = new System.Windows.Forms.CheckBox();
            this.Chb_Prostota = new System.Windows.Forms.CheckBox();
            this.Chb_Gravidez = new System.Windows.Forms.CheckBox();
            this.Chb_Coracao = new System.Windows.Forms.CheckBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Grb_Sexo.SuspendLayout();
            this.Grb_Exames.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(39, 31);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            this.Lbl_Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grb_Sexo
            // 
            this.Grb_Sexo.Controls.Add(this.Rdb_Masculino);
            this.Grb_Sexo.Controls.Add(this.Rdb_Feminino);
            this.Grb_Sexo.Location = new System.Drawing.Point(34, 108);
            this.Grb_Sexo.Name = "Grb_Sexo";
            this.Grb_Sexo.Size = new System.Drawing.Size(161, 100);
            this.Grb_Sexo.TabIndex = 1;
            this.Grb_Sexo.TabStop = false;
            this.Grb_Sexo.Text = "Sexo";
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(23, 55);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(89, 20);
            this.Rdb_Masculino.TabIndex = 1;
            this.Rdb_Masculino.Text = "Masculino";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            this.Rdb_Masculino.Click += new System.EventHandler(this.Rdb_Masculino_Click);
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Checked = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(23, 29);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(83, 20);
            this.Rdb_Feminino.TabIndex = 0;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "Feminino";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            this.Rdb_Feminino.CheckedChanged += new System.EventHandler(this.Rdb_Feminino_CheckedChanged);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(42, 50);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(344, 22);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Grb_Exames
            // 
            this.Grb_Exames.Controls.Add(this.Chb_Sangue);
            this.Grb_Exames.Controls.Add(this.Chb_Ortopédico);
            this.Grb_Exames.Controls.Add(this.Chb_Mamografia);
            this.Grb_Exames.Controls.Add(this.Chb_Prostota);
            this.Grb_Exames.Controls.Add(this.Chb_Gravidez);
            this.Grb_Exames.Controls.Add(this.Chb_Coracao);
            this.Grb_Exames.Location = new System.Drawing.Point(217, 108);
            this.Grb_Exames.Name = "Grb_Exames";
            this.Grb_Exames.Size = new System.Drawing.Size(377, 100);
            this.Grb_Exames.TabIndex = 3;
            this.Grb_Exames.TabStop = false;
            this.Grb_Exames.Text = "Exames";
            // 
            // Chb_Sangue
            // 
            this.Chb_Sangue.AutoSize = true;
            this.Chb_Sangue.Location = new System.Drawing.Point(263, 56);
            this.Chb_Sangue.Name = "Chb_Sangue";
            this.Chb_Sangue.Size = new System.Drawing.Size(76, 20);
            this.Chb_Sangue.TabIndex = 5;
            this.Chb_Sangue.Text = "Sangue";
            this.Chb_Sangue.UseVisualStyleBackColor = true;
            this.Chb_Sangue.CheckedChanged += new System.EventHandler(this.Chb_Sangue_CheckedChanged);
            // 
            // Chb_Ortopédico
            // 
            this.Chb_Ortopédico.AutoSize = true;
            this.Chb_Ortopédico.Location = new System.Drawing.Point(263, 30);
            this.Chb_Ortopédico.Name = "Chb_Ortopédico";
            this.Chb_Ortopédico.Size = new System.Drawing.Size(96, 20);
            this.Chb_Ortopédico.TabIndex = 4;
            this.Chb_Ortopédico.Text = "Ortopédico";
            this.Chb_Ortopédico.UseVisualStyleBackColor = true;
            this.Chb_Ortopédico.CheckedChanged += new System.EventHandler(this.Chb_Ortopédico_CheckedChanged);
            // 
            // Chb_Mamografia
            // 
            this.Chb_Mamografia.AutoSize = true;
            this.Chb_Mamografia.Location = new System.Drawing.Point(145, 56);
            this.Chb_Mamografia.Name = "Chb_Mamografia";
            this.Chb_Mamografia.Size = new System.Drawing.Size(101, 20);
            this.Chb_Mamografia.TabIndex = 3;
            this.Chb_Mamografia.Text = "Mamografia";
            this.Chb_Mamografia.UseVisualStyleBackColor = true;
            this.Chb_Mamografia.Click += new System.EventHandler(this.Chb_Mamografia_Click);
            // 
            // Chb_Prostota
            // 
            this.Chb_Prostota.AutoSize = true;
            this.Chb_Prostota.Enabled = false;
            this.Chb_Prostota.Location = new System.Drawing.Point(145, 30);
            this.Chb_Prostota.Name = "Chb_Prostota";
            this.Chb_Prostota.Size = new System.Drawing.Size(79, 20);
            this.Chb_Prostota.TabIndex = 2;
            this.Chb_Prostota.Text = "Prostota";
            this.Chb_Prostota.UseVisualStyleBackColor = true;
            this.Chb_Prostota.CheckedChanged += new System.EventHandler(this.Chb_Prostota_CheckedChanged);
            this.Chb_Prostota.Click += new System.EventHandler(this.Chb_Prostota_Click);
            // 
            // Chb_Gravidez
            // 
            this.Chb_Gravidez.AutoSize = true;
            this.Chb_Gravidez.Location = new System.Drawing.Point(30, 56);
            this.Chb_Gravidez.Name = "Chb_Gravidez";
            this.Chb_Gravidez.Size = new System.Drawing.Size(83, 20);
            this.Chb_Gravidez.TabIndex = 1;
            this.Chb_Gravidez.Text = "Gravidez";
            this.Chb_Gravidez.UseVisualStyleBackColor = true;
            this.Chb_Gravidez.Click += new System.EventHandler(this.Chb_Gravidez_Click);
            // 
            // Chb_Coracao
            // 
            this.Chb_Coracao.AutoSize = true;
            this.Chb_Coracao.Location = new System.Drawing.Point(30, 29);
            this.Chb_Coracao.Name = "Chb_Coracao";
            this.Chb_Coracao.Size = new System.Drawing.Size(81, 20);
            this.Chb_Coracao.TabIndex = 0;
            this.Chb_Coracao.Text = "Coração";
            this.Chb_Coracao.UseVisualStyleBackColor = true;
            this.Chb_Coracao.Click += new System.EventHandler(this.Chb_Coracao_Click);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(484, 274);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(110, 51);
            this.Lbl_Total.TabIndex = 4;
            this.Lbl_Total.Text = "0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Grb_Exames);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Grb_Sexo);
            this.Controls.Add(this.Lbl_Nome);
            this.Name = "Form1";
            this.Text = "Fera";
            this.Grb_Sexo.ResumeLayout(false);
            this.Grb_Sexo.PerformLayout();
            this.Grb_Exames.ResumeLayout(false);
            this.Grb_Exames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.GroupBox Grb_Sexo;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.GroupBox Grb_Exames;
        private System.Windows.Forms.CheckBox Chb_Sangue;
        private System.Windows.Forms.CheckBox Chb_Ortopédico;
        private System.Windows.Forms.CheckBox Chb_Mamografia;
        private System.Windows.Forms.CheckBox Chb_Prostota;
        private System.Windows.Forms.CheckBox Chb_Gravidez;
        private System.Windows.Forms.CheckBox Chb_Coracao;
        private System.Windows.Forms.Label Lbl_Total;
    }
}

