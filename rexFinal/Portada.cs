using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rexFinal
{
    public partial class Portada : Form
    {

        

        public Portada()
        {
            InitializeComponent();
            Program.musica.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nuevoJuego = new Form1();
            nuevoJuego.Show();
            Program.musica.Stop();
            this.Hide();
        }


    }
}
