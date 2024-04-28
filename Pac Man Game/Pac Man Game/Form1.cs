using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man_Game
{
    public partial class Form1 : Form
    {
        bool godown, goup, goright, goleft, isGameOver;

        int score, playerSpeed, redGhostSpeed, pinkGhostX, pinkGhostY,orangeGhostSpeed;
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

      

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void resetGame()
        {
            score = 0;
            txtScore.Text = "Score: 0";
            redGhostSpeed = 5;
            orangeGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;

            pacman.Left = 52;
            pacman.Top = 59;

            redGhost.Left = 102;
            redGhost.Top = 414;

            orangeGhost.Left = 52;
            orangeGhost.Top = 270;

            pinkGhost.Left = 391;
            pinkGhost.Top = 111;

            foreach (Control X  in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Visible = true;
                }
            }

            playerSpeed = 8;
            isGameOver = false;

            gameTimer.Start();
        }

        private void gameOver(string message)
        {

        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            if (goleft == true)
            {
               pacman.Left -= playerSpeed;
               pacman.Image = Properties.Resources.Pac_Man_Left;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.Pac_Man_Right;
            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.Pac_Man_Down;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Pac_Man_Up;
            }



            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                       
                    }
                }
            }
        }





















































          private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redGhost_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }
    }
}
