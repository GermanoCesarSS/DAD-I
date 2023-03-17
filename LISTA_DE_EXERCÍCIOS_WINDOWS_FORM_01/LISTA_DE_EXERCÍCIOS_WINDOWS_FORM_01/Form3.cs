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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                imag_butterfly.Location = new Point(imag_butterfly.Location.X,
                                                    imag_butterfly.Location.Y - 10); 
            } 
            if(e.KeyCode == Keys.Down)
            {
                imag_butterfly.Location = new Point(imag_butterfly.Location.X + 10,
                                                  imag_butterfly.Location.Y);
            }
        }
    }
}
