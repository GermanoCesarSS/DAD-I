namespace Projeto_03
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mnu_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Arquivo,
            this.Mnu_Cadastro,
            this.Mnu_Sobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mnu_Arquivo
            // 
            this.Mnu_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Sair});
            this.Mnu_Arquivo.Name = "Mnu_Arquivo";
            this.Mnu_Arquivo.Size = new System.Drawing.Size(75, 24);
            this.Mnu_Arquivo.Text = "&Arquivo";
            // 
            // Mnu_Sair
            // 
            this.Mnu_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mnu_Sair.BackgroundImage")));
            this.Mnu_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mnu_Sair.Name = "Mnu_Sair";
            this.Mnu_Sair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.Mnu_Sair.Size = new System.Drawing.Size(163, 26);
            this.Mnu_Sair.Text = "&Sair";
            this.Mnu_Sair.Click += new System.EventHandler(this.Menu_Sair_Click);
            // 
            // Mnu_Cadastro
            // 
            this.Mnu_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Clientes,
            this.Mnu_Produtos,
            this.Mnu_Vendas});
            this.Mnu_Cadastro.Name = "Mnu_Cadastro";
            this.Mnu_Cadastro.Size = new System.Drawing.Size(88, 24);
            this.Mnu_Cadastro.Text = "&Cadastros";
            // 
            // Mnu_Clientes
            // 
            this.Mnu_Clientes.Name = "Mnu_Clientes";
            this.Mnu_Clientes.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.Mnu_Clientes.Size = new System.Drawing.Size(231, 26);
            this.Mnu_Clientes.Text = "&Clientes";
            // 
            // Mnu_Produtos
            // 
            this.Mnu_Produtos.Name = "Mnu_Produtos";
            this.Mnu_Produtos.Size = new System.Drawing.Size(231, 26);
            this.Mnu_Produtos.Text = "Produtos";
            // 
            // Mnu_Sobre
            // 
            this.Mnu_Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Empresa});
            this.Mnu_Sobre.Name = "Mnu_Sobre";
            this.Mnu_Sobre.Size = new System.Drawing.Size(62, 24);
            this.Mnu_Sobre.Text = "&Sobre";
            // 
            // Mnu_Empresa
            // 
            this.Mnu_Empresa.Name = "Mnu_Empresa";
            this.Mnu_Empresa.Size = new System.Drawing.Size(149, 26);
            this.Mnu_Empresa.Text = "Empresa";
            // 
            // Mnu_Vendas
            // 
            this.Mnu_Vendas.Name = "Mnu_Vendas";
            this.Mnu_Vendas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.Mnu_Vendas.Size = new System.Drawing.Size(231, 26);
            this.Mnu_Vendas.Text = "&Vendas";
            this.Mnu_Vendas.Click += new System.EventHandler(this.Mnu_Vendas_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 478);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo_14/02/2023";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Sair;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Clientes;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Produtos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Sobre;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Empresa;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Vendas;
    }
}

