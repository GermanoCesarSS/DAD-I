using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Txt_mascara.Mask = "00/00/0000";
            Txt_mascara.Text = null;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Txt_mascara.Mask = "(00) 9999-999";
            Txt_mascara.Text = null;

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Txt_mascara.Mask = "000.000.000-0";
            Txt_mascara.Text = null;

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { 
            textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_cidade.Lines. = Txt_cidades.Text.Split('\n');
        }
    }
}
