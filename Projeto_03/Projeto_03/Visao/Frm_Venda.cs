using Projeto_03.Controle;
using Projeto_03.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03.Visao
{
    public partial class Frm_Venda : Form
    {
        public Frm_Venda()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            Venda v = new Venda(); // Erição de objeto



            v.Nome = TxtBox_Nome.Text;
            v.Quantidade = Double.Parse(TxtBox_Quantidade.Text);
            v.Valor = Double.Parse(TxtBox_Valor.Text);

            C_Venda cv = new C_Venda();

            v = cv.calculaVenda(v);

            Lbl_Venda.Text = v.Total.ToString();

        }
    }
}
