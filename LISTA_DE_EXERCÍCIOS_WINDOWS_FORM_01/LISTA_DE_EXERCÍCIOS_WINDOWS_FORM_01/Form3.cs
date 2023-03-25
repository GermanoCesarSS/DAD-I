using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01
{
    public partial class Form3 : Form
    {
        int valor = 0;
        public Form3()
        {
            InitializeComponent();
            valor++;
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {

             
            System.Drawing.Image im1 = System.Drawing.Image.FromFile
                                    ("C:\\Users\\manoa\\Área de Trabalho\\imagem_Csharp\\butterfly.png");
            System.Drawing.Image im2 = System.Drawing.Image.FromFile
                                    ("C:\\Users\\manoa\\Área de Trabalho\\imagem_Csharp\\butterfly_2.png");

            // Set the size of the label to accommodate the bitmap size.

            if (valor % 2 == 0)
            {
                imag_butterfly.Image = im1;
            }
            else
            {
                imag_butterfly.Image = im2;
            }
            valor++;


            if (e.KeyCode == Keys.Up)
            {
                imag_butterfly.Location = new Point(imag_butterfly.Location.X,
                                                  imag_butterfly.Location.Y - 10);
            }
            if (e.KeyCode == Keys.Down)
            {
                imag_butterfly.Location = new Point(imag_butterfly.Location.X,
                                                  imag_butterfly.Location.Y + 10);
            }
            if (e.KeyCode == Keys.Left)
            {
                imag_butterfly.Location = new Point(imag_butterfly.Location.X - 10,
                                                  imag_butterfly.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                imag_butterfly.Location = new Point(imag_butterfly.Location.X + 10,
                                                  imag_butterfly.Location.Y);
            }
        }
    }
}
