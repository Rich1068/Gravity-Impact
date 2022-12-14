using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace Gravity_Impact
{
    public partial class Form1 : Form
    {
        //variables
        int gravity;
        int gravityValue = 0;
        int obstacleSpeed = 0;
        int score = 0;
        public static int score3;
        int highScore = 0;
        bool gameStart = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //Movement
            if (e.KeyCode == Keys.Space)
            {
                //floor
                if (player.Top == 473 || player.Top > 218)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                    player.Image = Properties.Resources.Character2;
                }
                //ceiling
                else if (player.Top == 50 || player.Top < 218)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                    player.Image = Properties.Resources.Character2R;
                }
            }
            //Start or Restart
            if (e.KeyCode == Keys.Enter && gameStart == false)
            {
                pictureBox6.Hide();
                gameStart= true;
                RestartGame();
            }
        }

        public void GameTimerEvent(object sender, EventArgs e)
        {
            //variable updates
            lblScore.Text = "Score: " + score;
            lblhighScore.Text = "High Score:";
            lblscore_value.Text = Properties.Settings.Default.h_score;
            player.Top += gravity;
            score += 1;
            // when the player land on the platforms. 
            if (player.Top > 473)
            {
                gravity = 0;
                player.Top = 473;
                player.Image = Properties.Resources.Character2;
            }
            else if (player.Top < 50)
            {
                gravity = 0;
                player.Top = 50;
                player.Image = Properties.Resources.Character2R;
            }
            //obstacles movement
            foreach (Control x in this.Controls)
            {
                //Obstacle
                if (x is PictureBox && x.Tag as string == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        
                    }
                    //collision with obstacle
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        score3 = score-1;
                        gameTimer.Stop();
                        gameStart = false;
                        Form3 f3 = new Form3();
                        f3.Show();
                        //set the high score 
                        int a = Int32.Parse(lblscore_value.Text);
                        if (score>a)
                        {
                            highScore = score;
                            lblscore_value.Text = highScore.ToString();
                            Properties.Settings.Default.h_score = lblscore_value.Text;
                            Properties.Settings.Default.Save();
                        }
                        pictureBox6.Show();
                    }
                }
                //Coin
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
            //Movement speed
            if (score > 500)
            {
                obstacleSpeed = 15;
                gravityValue = 12;
            }
            if (score > 1000)
            {
                obstacleSpeed = 16;
                gravityValue = 13;
            }
            if (score > 1500)
            {
                obstacleSpeed = 18;
                gravityValue = 14;
            }
            if (score > 2500)
            {
                obstacleSpeed = 20;
                gravityValue = 16;
            }
            if (score > 4000)
            {
                obstacleSpeed = 23;
                gravityValue = 17;
            }
        }
        private void RestartGame()
        {
            //starting points
            gameStart= true;
            lblScore.Parent = pictureBox1;
            lblscore_value.Parent = pictureBox2;
            lblhighScore.Parent = pictureBox2;
            lblhighScore.Top = 0;
            lblscore_value.Top = 0;
            player.Location = new Point(88, 203);
            player.Image = Properties.Resources.Character2;
            score = 0;
            gravityValue = 11;
            gravity = gravityValue;
            obstacleSpeed = 13;
            foreach (Control x in this.Controls)
            {
                //obstacle rng spawn
                if (x is PictureBox && x.Tag as string == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
                //coin rng spawn
                if (x is PictureBox && x.Tag as string == "coin")
                {
                    x.Left = random.Next(2000, 3000);
                }
            }

            gameTimer.Start();

        }
    }
}