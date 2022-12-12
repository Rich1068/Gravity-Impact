using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace Gravity_Impact
{
    public partial class Form1 : Form
    {
        int gravity;
        int gravityValue = 0;
        int obstacleSpeed = 0;
        int score = 0;
        int highScore = 0;
        bool gameStart = false;

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (player.Top == 293 || player.Top > 173)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                    player.Image = Properties.Resources.Character2;
                }
                else if (player.Top == 48 || player.Top < 173)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                    player.Image = Properties.Resources.Character2R;
                }
            }

            if (e.KeyCode == Keys.Enter && gameStart == false)
            {
                pictureBox6.Hide();
                RestartGame();
            }
           
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            lblhighScore.Text = "High Score:";
            lblscore_value.Text = Properties.Settings.Default.h_score;
            player.Top += gravity;
            score += 1;
            // when the player land on the platforms. 
            if (player.Top > 293)
            {
                gravity = 0;
                player.Top = 293;
                player.Image = Properties.Resources.Character2;
            }
            else if (player.Top < 48)
            {
                gravity = 0;
                player.Top = 48;
                player.Image = Properties.Resources.Character2R;
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
                        Form3 f3 = new Form3();
                        f3.Show();
                        // set the high score 
                        int a = Int32.Parse(lblscore_value.Text);
                        if (score>a)
                        {
                            highScore = score;
                            lblscore_value.Text = highScore.ToString();
                            Properties.Settings.Default.h_score = lblscore_value.Text;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                if (x is PictureBox && x.Tag as string == "coin")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = random.Next(2000, 3000);
                    }
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        x.Left = random.Next(2000, 3000);
                        score += 100;
                    }
                }
            }
            if (score > 500)
            {
                obstacleSpeed = 12;
                gravityValue = 9;
            }
            if (score > 1000)
            {
                obstacleSpeed = 15;
                gravityValue = 12;
            }
            if (score > 1500)
            {
                obstacleSpeed = 17;
                gravityValue = 13;
            }
            if (score > 2500)
            {
                obstacleSpeed = 20;
                gravityValue = 14;
            }
            if (score > 4000)
            {
                obstacleSpeed = 23;
                gravityValue = 15;
            }
        }
        private void RestartGame()
        {
            lblScore.Parent = pictureBox1;
            lblscore_value.Parent = pictureBox2;
            lblhighScore.Parent = pictureBox2;
            lblhighScore.Top = 0;
            lblscore_value.Top = 0;
            player.Location = new Point(98, 203);
            player.Image = Properties.Resources.Character2;
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
                if (x is PictureBox && x.Tag as string == "coin")
                {
                    x.Left = random.Next(2000, 3000);
                }
            }

            gameTimer.Start();

        }
    }
}