using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_v5
{
    public partial class Form1 : Form
    {
        frmGameOver frmGameOver = new frmGameOver();
        private int _directionX = 5;
        private int _directionY = 2;
        int Points = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // start the game
        private void btnGame_Click(object sender, EventArgs e)
        {
            tmrGame.Start();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            // ball movement
            picBall.Location = new Point(picBall.Location.X + _directionX, picBall.Location.Y + _directionY);

            // ball hits right wall
            if (picBall.Location.X >= pnlGame.Width - picBall.Width
                && picBall.Location.Y + picBall.Height >= picRacketRight.Location.Y
                && picBall.Location.Y <= picRacketRight.Location.Y + picRacketRight.Height)
            {
                _directionX = -_directionX;
                Points += 10; // add 10 points
            }

            // ball hits left wall
            if (picBall.Location.X <= 0)
            {
                _directionX = -_directionX;
            }

            // ball hits top wall
            if (picBall.Location.Y >= pnlGame.Height - picBall.Height)
            {
                _directionY = -_directionY;
            }

            // ball hits bottom wall
            if (picBall.Location.Y < 0)
            {
                _directionY = -_directionY;
            }

            // show score
            txtPoints.Text = Convert.ToString(Points);

            // game over
            if (picBall.Location.X >= pnlGame.Width - picBall.Width
                && (picBall.Location.Y + picBall.Height <= picRacketRight.Location.Y
                    || picBall.Location.Y >= picRacketRight.Location.Y + picRacketRight.Height))
            {
                tmrGame.Stop();
                frmGameOver.SetPoints(Points);

                // show the scoreboard
                frmGameOver.ShowScoreboard();
                frmGameOver.Show();

                // show short messagebox to let the user know they lost
                string enterName = "Please enter your name to the scoreboard.";
                string caption = "GAME OVER !!!";
                MessageBoxButtons buttonOk = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(enterName, caption, buttonOk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonVisible(false);
            
            // set racket to right wall
            picRacketRight.Location = new Point(pnlGame.Width - picRacketRight.Width - picRacketRight.Width, pnlGame.Height / 2);
            
            // set scrollbar next to panel, config max & min & current value
            vsbRacketRight.Height = pnlGame.Height;
            vsbRacketRight.Location = new Point(pnlGame.Location.X + pnlGame.Width, pnlGame.Location.Y);
            vsbRacketRight.Minimum = 0;
            vsbRacketRight.Maximum = pnlGame.Height - picRacketRight.Height + vsbRacketRight.LargeChange;
            vsbRacketRight.Value = picRacketRight.Location.Y;
        }

        // move racket according to scrollbar
        private void vsbRacketRight_Scroll(object sender, ScrollEventArgs e)
        {
            picRacketRight.Location = new Point(picRacketRight.Location.X, vsbRacketRight.Value);
            vsbRacketRight.Value = picRacketRight.Location.Y;
        }

        // check if any of the keys (h, v, p, s) were pressed --> see game instructions in designer
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.H:
                    _directionY = -_directionY;
                    break;
                
                case Keys.V:
                    _directionX = -_directionX;
                    break;
                
                case Keys.P:
                    tmrGame.Stop();
                    break;
                
                case Keys.S:
                    tmrGame.Start();
                    break;
            }
        }

        private void rdbBall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBall.Checked)
            {
                vsbRacketRight.Visible = false;
                ButtonVisible(true);
            }
        }

        private void rdbRacket_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRacket.Checked)
            {
                vsbRacketRight.Visible = true;
                ButtonVisible(false);
                
                // add direction buttons to generic list
                /*
                List<Button> _dirButtons = new List<Button>();
                _dirButtons.Add(btnDown);
                _dirButtons.Add(btnLeft);
                _dirButtons.Add(btnRight);
                _dirButtons.Add(btnUp);
                */
            }
        }
        
        // is needed, so the arrow-keys don't jump from element to element
        // control the ball with the arrow-keys
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
                return true; // prevents the focus from being passed on
            }
            else if (keyData == Keys.Down)
            {
                picBall.Location = new Point(picBall.Location.X, picBall.Location.Y + 25);
                return true;
            }
            else if (keyData == Keys.Left)
            {
                picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y);
                return true;
            }
            else if (keyData == Keys.Right)
            {
                picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        
        // set visibility of direction buttons
        private void ButtonVisible(bool visible) 
        {
            if (visible)
            {
                btnDown.Visible = true;
                btnLeft.Visible = true;
                btnUp.Visible = true;
                btnRight.Visible = true;
            }
            else
            {
                btnDown.Visible = false;
                btnLeft.Visible = false;
                btnUp.Visible = false;
                btnRight.Visible = false;
            }
        }
    }
}