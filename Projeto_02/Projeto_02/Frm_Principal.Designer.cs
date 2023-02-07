namespace Projeto_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sair.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sair.Image")));
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(660, 374);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(109, 46);
            this.Btn_Sair.TabIndex = 0;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Sair);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair;
    }
}

