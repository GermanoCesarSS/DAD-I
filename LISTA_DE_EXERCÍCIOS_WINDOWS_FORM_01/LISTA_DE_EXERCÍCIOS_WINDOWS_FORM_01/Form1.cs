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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }

        private void rdb_somar_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txt_valor1.Text);
            double v2 = double.Parse(txt_valor2.Text);

            double rs = v1 + v2;

            txt_resultado.Text = rs+""; 

        }
    }
}
