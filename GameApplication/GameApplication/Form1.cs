using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApplication
{
    public partial class Form1 : Form
    {
        bool goRight;
        bool goLeft;
        bool shoot;
        bool gameOver;
        bool ordinaryManHit;
        int score;
        int level;
        int scoreForLevelMsg;
        int speedOfPoliceman;
        int speedOfBurglar;
        int bulletSpeed;
        Random random;

        public Form1()
        {
            this.random = new Random();
            this.speedOfPoliceman = 15;
            this.level = 1;
            this.scoreForLevelMsg = 0;
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If left key is pressed, the policeman moves to the left.
            // If right key is pressed, the policeman moves to the right.
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                e.SuppressKeyPress = true;

            }
            e.SuppressKeyPress = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // When left key is released, policeman should stop moving to the left. 
            // Similarly, when right key is released. policeman should stop moving to the right.
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shoot == false)
            {
                shoot = true;
                bullet.Top = policeOfficer.Top - 32;
                bullet.Left = policeOfficer.Left + (policeOfficer.Width / 2);
            }
            if (e.KeyCode == Keys.Enter && gameOver)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            speedOfBurglar = 3;

            burglar1.Left = random.Next(0, 300);
            burglar2.Left = random.Next(0, 300);
            ordinaryMan.Left = random.Next(0, 300);

            burglar1.Top = random.Next(0, 200) * -1;
            burglar2.Top = random.Next(0, 500) * -1;
            ordinaryMan.Top = random.Next(0, 900) * -1;

            score = 0;
            level = 1;
            bulletSpeed = 0;
            bullet.Left = -300; // moving the bullet out of the form, it only needs to be seen when we press space button.
            gameMessage.Visible = false;
            ordinaryManHit = false;
            shoot = false;
            updateScore();
            updateLevel();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            burglar1.Top += speedOfBurglar;
            burglar2.Top += speedOfBurglar;
            ordinaryMan.Top += speedOfBurglar;

            if (burglar1.Top > 559 || burglar2.Top > 559)
            {
                gameFinished();
            }

            if (ordinaryMan.Top > 620)
            {
                ordinaryMan.Top -= 900;
                ordinaryMan.Left = random.Next(0, 300);
            }

            // With policeOfficer.Left we make sure the policeOfficer stays in the form.
            if (goLeft && policeOfficer.Left > 0)
            {
                policeOfficer.Left -= speedOfPoliceman;
            }
            if (goRight && policeOfficer.Left < 297)
            {
                policeOfficer.Left += speedOfPoliceman;
            }

            // Making the bullet shoot a burglar.
            if (shoot)
            {
                bulletSpeed = 15;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -32)
            {
                shoot = false;
            }

            if (bullet.Bounds.IntersectsWith(burglar1.Bounds))
            {
                score += 1;
                burglar1.Top = -500;
                burglar1.Left = random.Next(0, 300);
                shoot = false;
                updateScore();
            }

            if (bullet.Bounds.IntersectsWith(burglar2.Bounds))
            {
                score += 1;
                burglar2.Top = -700;
                burglar2.Left = random.Next(0, 300);
                shoot = false;
                updateScore();
            }

            if (bullet.Bounds.IntersectsWith(ordinaryMan.Bounds))
            {
                ordinaryManHit = true;
                gameFinished();
            }

            if (burglar1.Bounds.IntersectsWith(gameMessage.Bounds) && gameMessage.Text=="Level up" || 
                burglar2.Bounds.IntersectsWith(gameMessage.Bounds) && gameMessage.Text == "Level up" || 
                ordinaryMan.Bounds.IntersectsWith(gameMessage.Bounds) && gameMessage.Text == "Level up")
            {
                gameMessage.Visible = false;
            }


            if (burglar1.Bounds.IntersectsWith(burglar2.Bounds) ||
                    burglar1.Bounds.IntersectsWith(ordinaryMan.Bounds))
            {
                burglar1.Top -= 100;
            }

            if (burglar2.Bounds.IntersectsWith(ordinaryMan.Bounds))
            {
                burglar2.Top -= 220;
            }
        }


        private void updateScore()
        {
            lblScore.Text = string.Format("Points: {0}", score.ToString());
            if(score == scoreForLevelMsg + 5)
            {
                gameMessage.Text = "Level up";
                gameMessage.Visible = true;
                gameMessage.BringToFront();
                level += 1;
                speedOfBurglar += 1;
                scoreForLevelMsg += 5;
                updateLevel();
            }
        }

        public void updateLevel()
        {
            lblLevel.Text = string.Format("Level: {0}", level);
        }

        private void gameFinished()
        {
            gameOver = true;
            gameTimer.Stop();
            if (ordinaryManHit)
            {
                gameMessage.Text = "GAME OVER" + Environment.NewLine + "You killed a civilian!" + Environment.NewLine + "Press Enter to try again.";
            }
            else
            {
                gameMessage.Text = "GAME OVER" + Environment.NewLine + "Press Enter to try again.";
            }
            gameMessage.BringToFront();
            gameMessage.Visible = true;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            pictureBoxCar.Visible = false;
            btnPlayGame.Visible = false;
            lblTitle.Visible = false;
            btnPlayGame.Enabled = false;
            resetGame();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ordinaryMan_Click(object sender, EventArgs e)
        {

        }
    }
}
