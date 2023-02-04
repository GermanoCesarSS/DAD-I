using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Mensagem_Click(object sender, EventArgs e)
        {
            Lbl_Mensagem.Text = "UNIFUNEC 2023";
            Lbl_Mensagem.Enabled = false;
            Btn_Limpar.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Lbl_Mensagem.Text = string.Empty;

            Btn_Limpar.Enabled = false;
            Btn_Mensagem.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Lbl_Mensagem.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lbl_Mensagem.ForeColor = Color.Red;
        }
    }
}
