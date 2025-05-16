using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2do_bloque_BF
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlumnoAleatorio repaso2 = new AlumnoAleatorio();
            repaso2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NúmeroAleatorio repaso1 = new NúmeroAleatorio();
            repaso1.Show();
              
        }
    }
}
