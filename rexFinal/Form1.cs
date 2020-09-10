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
    public partial class Form1 : Form
    {

        bool jumping = false;
        int jumpSpeed = 10;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rnd = new Random();
        int position;
        bool isGameOver = false;


        public Form1()
        {
            InitializeComponent();
            gameReset();
        }

        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            lblpuntos.Text = "Puntos: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }

            else
            {
                jumpSpeed = 12;
            }

            if (trex.Top > 366 && jumping == false)
            {
                force = 12;
                trex.Top = 367;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        SystemSounds.Asterisk.Play();
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        lblpuntos.Text += " Pulsa R para reiniciar el juego";
                        isGameOver = true;
                    }
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                gameReset();
            }

            if(e.KeyCode == Keys.Q && isGameOver == true)
            {
                Program.portada.Show();
                Program.musica.Play();
                this.Hide();
                gameTimer.Stop();
            }
        }

        private void gameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            lblpuntos.Text = "Puntos: " + score;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 421;
            suelo.Top = 405;
            obs1.Top = 359;
            obs2.Top = 371;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rnd.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();

        }

        private void EventoCerrar(object sender, FormClosingEventArgs e)
        {
            const string message = "¿Quieres salir del juego?";
            const string caption = "Cerrando Juego";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result != DialogResult.No)
            {
                Program.portada.Show();
                Program.musica.Play();
                this.Hide();
            }

            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
