using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A TECLA DIGITADA NÃO FOR LETRA
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void LimparTextBoxes(Control.ControlCollection controrles)
        {
            foreach(Control control in controrles)
            {
                if(control is TextBox)
                {
                    ((TextBox)(control)).Text = String.Empty;
                   
                }if(control is MaskedTextBox)
                {
                    ((MaskedTextBox)(control)).Text = String.Empty;
                }
           
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtData.Text != "" && txtBairro.Text != "" && txtRua.Text != ""
                && txtTelefone.Text != "" && txtEscola.Text != "" && txtSerie.Text != ""){
                MessageBox.Show("CADASTRO SALVO COM SUCESSO", "SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBoxes(this.Controls);
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS OS CAMPOS","CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            var resp = DialogResult;
            resp = MessageBox.Show("DESEJA LIMPAR?", "LIMPAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if(resp == DialogResult.OK)
            LimparTextBoxes(this.Controls);
        }

        private void btnLimpar_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
