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


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double v1, v2, rs;

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }

        private void rdb_multiplicar_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txt_valor1.Text);
            v2 = double.Parse(txt_valor2.Text);
            rs = v1 * v2;

            txt_resultado.Text = rs + "";
        }

        private void rdb_dividir_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txt_valor1.Text);
            v2 = double.Parse(txt_valor2.Text);
            rs = v1 / v2;

            if (v2 == 0)
            {
               txt_resultado.Text = "ERRO";
            }
            else
            {
                txt_resultado.Text = rs+"";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdb_somar_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txt_valor1.Text);
            v2 = double.Parse(txt_valor2.Text);
            rs = v1 + v2;

            txt_resultado.Text = rs+""; 

        }

        private void rdb_subtrair_Click(object sender, EventArgs e)
        {
            v1 =double.Parse(txt_valor1.Text);
            v2 = double.Parse(txt_valor2.Text);
            rs = v1 - v2;

            txt_resultado.Text = rs + "";
        }
    }
}
