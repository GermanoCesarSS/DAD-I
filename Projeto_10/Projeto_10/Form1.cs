using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if(e.KeyCode== Keys.Up)
            {
                label1.Location= new Point(label1.Location.X, label1.Location.Y - 10);
            }
            if(e.KeyCode == Keys.Down)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 10);
            }
            if(e.KeyCode == Keys.Right)
            {
                label1.Location = new Point(label1.Location.X + 10, label1.Location.Y);
            }
            if(e.KeyCode == Keys.Left)
            {
                label1.Location = new Point(label1.Location.X - 10, label1.Location.Y);
            }
            

        }
    }
}
