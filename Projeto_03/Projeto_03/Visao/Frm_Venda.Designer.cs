namespace Projeto_03.Visao
{
    partial class Frm_Venda
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Nome = new System.Windows.Forms.TextBox();
            this.TxtBox_Quantidade = new System.Windows.Forms.TextBox();
            this.TxtBox_Valor = new System.Windows.Forms.TextBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Venda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(32, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(448, 42);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "VENDA DE PRODUTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // TxtBox_Nome
            // 
            this.TxtBox_Nome.Location = new System.Drawing.Point(98, 93);
            this.TxtBox_Nome.Name = "TxtBox_Nome";
            this.TxtBox_Nome.Size = new System.Drawing.Size(286, 22);
            this.TxtBox_Nome.TabIndex = 2;
            // 
            // TxtBox_Quantidade
            // 
            this.TxtBox_Quantidade.Location = new System.Drawing.Point(51, 175);
            this.TxtBox_Quantidade.Name = "TxtBox_Quantidade";
            this.TxtBox_Quantidade.Size = new System.Drawing.Size(113, 22);
            this.TxtBox_Quantidade.TabIndex = 3;
            // 
            // TxtBox_Valor
            // 
            this.TxtBox_Valor.Location = new System.Drawing.Point(282, 175);
            this.TxtBox_Valor.Name = "TxtBox_Valor";
            this.TxtBox_Valor.Size = new System.Drawing.Size(113, 22);
            this.TxtBox_Valor.TabIndex = 4;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(434, 174);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calcular.TabIndex = 5;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor R$: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbl_Venda
            // 
            this.Lbl_Venda.AutoSize = true;
            this.Lbl_Venda.Location = new System.Drawing.Point(198, 232);
            this.Lbl_Venda.Name = "Lbl_Venda";
            this.Lbl_Venda.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Venda.TabIndex = 10;
            this.Lbl_Venda.Text = "label5";
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.Lbl_Venda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.TxtBox_Valor);
            this.Controls.Add(this.TxtBox_Quantidade);
            this.Controls.Add(this.TxtBox_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "Frm_Venda";
            this.Text = "Frm_Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Nome;
        private System.Windows.Forms.TextBox TxtBox_Quantidade;
        private System.Windows.Forms.TextBox TxtBox_Valor;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Venda;
    }
}