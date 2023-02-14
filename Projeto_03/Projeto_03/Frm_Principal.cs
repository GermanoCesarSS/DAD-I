using Projeto_03.Visao;
using System;
using System.Windows.Forms;
using Projeto_03.Visao;

namespace Projeto_03
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }


        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mnu_Vendas_Click(object sender, EventArgs e)
        {
            Frm_Venda frm_Venda = new Frm_Venda();
            frm_Venda.ShowDialog();
        }
    }
}
