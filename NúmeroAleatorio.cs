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
    public partial class NúmeroAleatorio : Form
    {
        int aleatorio = 0;
        Random rand = new Random();

        public NúmeroAleatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumMax.Text, out int numMax))
            {
                if (numMax > 0)
                {
                    aleatorio = rand.Next(1, numMax);
                    MessageBox.Show($"Número aleatorio : {aleatorio}");
                }
                else
                {
                    MessageBox.Show("Ingrese un número positivo");
                }

            }
            else
            {
                MessageBox.Show("Ungrese un número valido");
            }
        }
    }
}
