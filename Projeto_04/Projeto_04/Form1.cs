using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_04
{
    public partial class Form1 : Form
    {
        public double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rdb_Masculino_Click(object sender, EventArgs e)
        {
            Chb_Prostota.Enabled = true;

            Chb_Gravidez.Enabled = false;
            Chb_Mamografia.Enabled = false; 

            total = Chb_Gravidez.Checked ? (Double.Parse(Lbl_Total.Text) - 100): total;

            total = Chb_Mamografia.Checked ? (Double.Parse(Lbl_Total.Text) - 712): total;

            Chb_Gravidez.Checked = false;
            Chb_Mamografia.Checked = false;



            Lbl_Total.Text = total.ToString();
        }

        private void Rdb_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            Chb_Prostota.Enabled = false;

            Chb_Gravidez.Enabled = true;
            Chb_Mamografia.Enabled = true;

            Chb_Prostota.Checked = false;
        }

        private void Chb_Coracao_Click(object sender, EventArgs e)
        {
            if (Chb_Coracao.Checked)
            {
                total = Double.Parse(Lbl_Total.Text) + 500.50;
            }
            else 
            {
                total = Double.Parse(Lbl_Total.Text) - 500.50;
            }

            Lbl_Total.Text = total.ToString();
        }

        private void Chb_Gravidez_Click(object sender, EventArgs e)
        {
            if (Chb_Gravidez.Checked)
            {
                total = Double.Parse(Lbl_Total.Text) + 100;
            }
            else
            {
                total = Double.Parse(Lbl_Total.Text) - 100;
            }

            Lbl_Total.Text = total.ToString();
        }

       

        private void Chb_Prostota_Click(object sender, EventArgs e)
        {

        }

        private void Chb_Prostota_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_Prostota.Checked)
            {
                total = Double.Parse(Lbl_Total.Text) + 50;
            }
            else
            {
                total = Double.Parse(Lbl_Total.Text) - 50;
            }

            Lbl_Total.Text = total.ToString();
        }

        private void Chb_Mamografia_Click(object sender, EventArgs e)
        {
            if (Chb_Mamografia.Checked)
            {
                total = Double.Parse(Lbl_Total.Text) + 712;
            }
            else
            {
                total = Double.Parse(Lbl_Total.Text) - 712;
            }

            Lbl_Total.Text = total.ToString();
        }

        private void Chb_Ortopédico_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_Ortopédico.Checked)
            {
                total = Double.Parse(Lbl_Total.Text) + 35;
            }
            else
            {
                total = Double.Parse(Lbl_Total.Text) - 35;
            }

            Lbl_Total.Text = total.ToString();
        }

        private void Chb_Sangue_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_Coracao.Checked)
            {
                total = Double.Parse(Lbl_Total.Text) + 15;
            }
            else
            {
                total = Double.Parse(Lbl_Total.Text) - 15;
            }

            Lbl_Total.Text = total.ToString();
        }
    }
}
