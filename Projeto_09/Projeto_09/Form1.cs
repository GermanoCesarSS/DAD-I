using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_09
{
    public partial class Form1 : Form
    {

        int contaForm2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();

            TabPage tabPage1 = new TabPage();
            tabPage1.Name = "Form2";
            tabPage1.Text = $"Formulário 2 {contaForm2}";
            tabPage1.Controls.Add(userControl1);

            tbc_janelas.TabPages.Add(tabPage1);
            contaForm2++;
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbc_janelas.TabPages.Remove(tbc_janelas.SelectedTab);
        }
    }
}
