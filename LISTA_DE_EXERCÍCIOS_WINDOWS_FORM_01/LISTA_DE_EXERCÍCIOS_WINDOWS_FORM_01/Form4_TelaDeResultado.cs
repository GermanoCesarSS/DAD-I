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
    public partial class Form4_TelaDeResultado : Form
    {
        public Form4_TelaDeResultado()
        {
            InitializeComponent();
        }

        private void Form4_TelaDeResultado_Activated(object sender, EventArgs e)
        {
            label4.Text = Form4.votoBolsonario.ToString();
            label5.Text = Form4.votoLula.ToString();
            label6.Text = Form4.votoMarcao.ToString();
        }
    }
}
