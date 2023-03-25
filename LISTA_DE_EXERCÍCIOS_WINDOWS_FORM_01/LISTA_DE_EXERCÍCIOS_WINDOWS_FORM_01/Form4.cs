using LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01.controle;
using LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01.modelo;
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
    public partial class Form4 : Form
    {
        System.Drawing.Image img_Brasao = System.Drawing.Image.FromFile
                                            ("C:\\Users\\manoa\\Área de Trabalho\\imagem_Csharp\\Brasao.jpg");

        System.Drawing.Image img_Lula = System.Drawing.Image.FromFile
                                            ("C:\\Users\\manoa\\Área de Trabalho\\imagem_Csharp\\Lula.jpg");

        System.Drawing.Image img_Bolsonario = System.Drawing.Image.FromFile
                                            ("C:\\Users\\manoa\\Área de Trabalho\\imagem_Csharp\\Bolsonario.jpg");
        System.Drawing.Image img_Marcao = System.Drawing.Image.FromFile
                                            ("C:\\Users\\manoa\\Área de Trabalho\\imagem_Csharp\\Marcao.png");

        public static int votoLula = 0,
            votoBolsonario = 0,
            votoMarcao = 0,
            votoNulo = 0;

        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "1";
            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

            if (label1.Text == "3" && label2.Text == "1")
            {
                pictureBox1.Image = img_Marcao;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "2";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

            if (label1.Text == "2" && label2.Text == "2")
            {
                pictureBox1.Image = img_Bolsonario;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "3";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

            if (label1.Text == "1" && label2.Text == "3")
            {
                pictureBox1.Image = img_Lula;
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "4";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "5";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "6";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "7";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "8";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "9";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string l1 = label1.Text;
            string l2 = label2.Text;
            string botao = "0";

            Voto voto = new Voto(botao, l1, l2);
            Voto_C vt = new Voto_C();

            voto = vt.Votar(voto);

            label1.Text = voto.label1;
            label2.Text = voto.label2;

        }
    

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;

            pictureBox1.Image = img_Brasao;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voto NULO confirmado", "VOTO NULO");
            votoNulo++;
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bolsonario: {votoBolsonario}\nLula: {votoLula}\nMarcão: {votoMarcao}\nNulo: {votoNulo}", "RESULTADOS");

            Form4_TelaDeResultado frm = new Form4_TelaDeResultado();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == img_Lula)
            {
                MessageBox.Show("Voto LULA confirmado", "VOTO");
                votoLula++;
            }else if(pictureBox1.Image == img_Bolsonario)
            {
                MessageBox.Show("Voto BOLSONARIO confirmado", "VOTO");
                votoBolsonario++;
            }else if(pictureBox1.Image == img_Marcao)
            {
                MessageBox.Show("Voto MARCÃO confirmado", "VOTO");
                votoMarcao++;
            }
            else
            {
                var res = DialogResult;
                res = MessageBox.Show("Votar NULO?", "VOTO NULO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    res = MessageBox.Show("Voto NULO confirmado", "VOTO NULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    votoNulo++;
                }
                else if(res == DialogResult.No)
                {
                    res = MessageBox.Show("Voto NULO cancelado", "VOTO NULO",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            label1.Text = null;
            label2.Text = null;
            pictureBox1.Image = img_Brasao;
        }

        private void começarAEleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os votos foram zerados!", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            votoLula = 0;
            votoMarcao= 0;
            votoBolsonario = 0;
            label1.Text = null;
            label2.Text = null;
            pictureBox1.Image = img_Brasao;
        }
    }
}
