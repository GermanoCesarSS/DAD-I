namespace LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txt_valor1 = new System.Windows.Forms.TextBox();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_dividir = new System.Windows.Forms.RadioButton();
            this.rdb_multiplicar = new System.Windows.Forms.RadioButton();
            this.rdb_subtrair = new System.Windows.Forms.RadioButton();
            this.rdb_somar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_valor1
            // 
            this.txt_valor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valor1.Location = new System.Drawing.Point(85, 146);
            this.txt_valor1.Multiline = true;
            this.txt_valor1.Name = "txt_valor1";
            this.txt_valor1.Size = new System.Drawing.Size(185, 22);
            this.txt_valor1.TabIndex = 0;
            this.txt_valor1.Text = "0";
            this.txt_valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor1_KeyPress);
            // 
            // txt_valor2
            // 
            this.txt_valor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valor2.Location = new System.Drawing.Point(85, 191);
            this.txt_valor2.Multiline = true;
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(185, 22);
            this.txt_valor2.TabIndex = 1;
            this.txt_valor2.Text = "0";
            this.txt_valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor2_KeyPress);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultado.Location = new System.Drawing.Point(85, 335);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(185, 38);
            this.txt_resultado.TabIndex = 2;
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 96);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdb_dividir);
            this.groupBox1.Controls.Add(this.rdb_multiplicar);
            this.groupBox1.Controls.Add(this.rdb_subtrair);
            this.groupBox1.Controls.Add(this.rdb_somar);
            this.groupBox1.Location = new System.Drawing.Point(35, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERADORES";
            // 
            // rdb_dividir
            // 
            this.rdb_dividir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_dividir.AutoSize = true;
            this.rdb_dividir.Location = new System.Drawing.Point(158, 57);
            this.rdb_dividir.Name = "rdb_dividir";
            this.rdb_dividir.Size = new System.Drawing.Size(76, 20);
            this.rdb_dividir.TabIndex = 3;
            this.rdb_dividir.Text = "DIVIDIR";
            this.rdb_dividir.UseVisualStyleBackColor = true;
            this.rdb_dividir.Click += new System.EventHandler(this.rdb_dividir_Click);
            // 
            // rdb_multiplicar
            // 
            this.rdb_multiplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_multiplicar.AutoSize = true;
            this.rdb_multiplicar.Location = new System.Drawing.Point(158, 31);
            this.rdb_multiplicar.Name = "rdb_multiplicar";
            this.rdb_multiplicar.Size = new System.Drawing.Size(118, 20);
            this.rdb_multiplicar.TabIndex = 2;
            this.rdb_multiplicar.Text = "MULTIPLICAR ";
            this.rdb_multiplicar.UseVisualStyleBackColor = true;
            this.rdb_multiplicar.Click += new System.EventHandler(this.rdb_multiplicar_Click);
            // 
            // rdb_subtrair
            // 
            this.rdb_subtrair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_subtrair.AutoSize = true;
            this.rdb_subtrair.Location = new System.Drawing.Point(50, 57);
            this.rdb_subtrair.Name = "rdb_subtrair";
            this.rdb_subtrair.Size = new System.Drawing.Size(97, 20);
            this.rdb_subtrair.TabIndex = 1;
            this.rdb_subtrair.Text = "SUBTRAIR";
            this.rdb_subtrair.UseVisualStyleBackColor = true;
            this.rdb_subtrair.Click += new System.EventHandler(this.rdb_subtrair_Click);
            // 
            // rdb_somar
            // 
            this.rdb_somar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_somar.AutoSize = true;
            this.rdb_somar.Checked = true;
            this.rdb_somar.Location = new System.Drawing.Point(50, 31);
            this.rdb_somar.Name = "rdb_somar";
            this.rdb_somar.Size = new System.Drawing.Size(77, 20);
            this.rdb_somar.TabIndex = 0;
            this.rdb_somar.TabStop = true;
            this.rdb_somar.Text = "SOMAR";
            this.rdb_somar.UseVisualStyleBackColor = true;
            this.rdb_somar.Click += new System.EventHandler(this.rdb_somar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.txt_valor1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor1;
        private System.Windows.Forms.TextBox txt_valor2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_somar;
        private System.Windows.Forms.RadioButton rdb_subtrair;
        private System.Windows.Forms.RadioButton rdb_multiplicar;
        private System.Windows.Forms.RadioButton rdb_dividir;
    }
}

