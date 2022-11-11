using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System;

namespace Gravity_Impact
{
    public partial class Form1 : Form
    {
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;
        bool gameStart = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (player.Top == 303 || player.Top > 180)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                    player.Image = Properties.Resources.catto;
                }
                else if (player.Top == 39 || player.Top < 180)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                    player.Image = Properties.Resources.Dead;
                }
            }

            if (e.KeyCode == Keys.Enter && gameStart == false)
            {
                RestartGame();
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            lblhighScore.Text = "High Score: " + highScore;
            player.Top += gravity;
            score += 1;
            // when the player land on the platforms. 
            if (player.Top > 303)
            {
                gravity = 0;
                player.Top = 303;
                
            }
            else if (player.Top < 39)
            {
                gravity = 0;
                player.Top = 39;
                
            }
            // move the obstacles
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag as string == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameTimer.Stop();
                        lblScore.Text += " Game Over!! Press Enter to Restart.";
                        gameStart = false;
                        // set the high score 
                        if (score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }
            if (score > 1000)
            {
                obstacleSpeed = 15;
                gravityValue = 9;
            }
        }
        private void RestartGame()
        {
            lblScore.Parent = pictureBox1;
            lblhighScore.Parent = pictureBox2;
            lblhighScore.Top = 0;
            player.Location = new Point(98, 203);
            player.Image = Properties.Resources.catto;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag as string == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }

            gameTimer.Start();

        }
    }
}