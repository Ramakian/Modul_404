using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_v4
{
    public partial class Form1 : Form
    {
        frmGameOver frmGameOver = new frmGameOver();
        private int _directionX = 5;
        private int _directionY = 2;
        int Points = 0;
        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // beginn des spiels
        private void btnGame_Click(object sender, EventArgs e)
        {
            tmrGame.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(288, 66);
            Points = 0;
            txtPoints.Text = Convert.ToString(Points); // zurücksetzen des Punktestandes
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            // ball bewegung
            picBall.Location = new Point(picBall.Location.X + _directionX, picBall.Location.Y + _directionY);

            // ball berührt rechte wand
            if (picBall.Location.X >= pnlGame.Width - picBall.Width
                && picBall.Location.Y + picBall.Height >= picRacketRight.Location.Y
                && picBall.Location.Y <= picRacketRight.Location.Y + picRacketRight.Height)
            {
                _directionX = -_directionX;
                Points += 10; // füge 10 punkte hinzu

                if (rdbBall.Checked)
                {
                    picRacketRight.Location = new Point(pnlGame.Width - picRacketRight.Width,
                        random.Next(pnlGame.Height - picRacketRight.Height));
                }
            }

            // ball berührt linke wand
            if (picBall.Location.X <= 0)
            {
                _directionX = -_directionX;
            }

            // ball berührt oberen rand
            if (picBall.Location.Y >= pnlGame.Height - picBall.Height)
            {
                _directionY = -_directionY;
            }

            // ball berührt unteren rand
            if (picBall.Location.Y < 0)
            {
                _directionY = -_directionY;
            }

            // anzeige Punkte
            txtPoints.Text = Convert.ToString(Points);


            // game over
            if (picBall.Location.X >= pnlGame.Width - picBall.Width
                && (picBall.Location.Y + picBall.Height <= picRacketRight.Location.Y
                    || picBall.Location.Y >= picRacketRight.Location.Y + picRacketRight.Height))
            {
                tmrGame.Stop();
                frmGameOver.SetPoints(Points);

                // bestenliste anzeigen
                frmGameOver.Show();

                // zeige ein nachrichtenfenster das anzeigt das man verloren hat
                string enterName = "Please enter your name to the scoreboard.";
                string caption = "GAME OVER !!!";
                MessageBoxButtons buttonOk = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(enterName, caption, buttonOk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonVisible(false);

            // schläger an die rechte wand setzen
            picRacketRight.Location = new Point(pnlGame.Width - picRacketRight.Width - picRacketRight.Width,
                pnlGame.Height / 2);

            // scrollbar rechts ans Panel anfügen, balken auf höhe des schläger anordnen
            vsbRacketRight.Height = pnlGame.Height;
            vsbRacketRight.Location = new Point(pnlGame.Location.X + pnlGame.Width, pnlGame.Location.Y);
            vsbRacketRight.Minimum = 0;
            vsbRacketRight.Maximum = pnlGame.Height - picRacketRight.Height + vsbRacketRight.LargeChange;
            vsbRacketRight.Value = picRacketRight.Location.Y;

            // Pfeiltasten einer Liste hinzufügen
            List<Button> _dirButtons = new List<Button>();
            _dirButtons.Add(btnDown);
            _dirButtons.Add(btnLeft);
            _dirButtons.Add(btnRight);
            _dirButtons.Add(btnUp);
        }

        // bewege schläger wie die scrollbar
        private void vsbRacketRight_Scroll(object sender, ScrollEventArgs e)
        {
            picRacketRight.Location = new Point(picRacketRight.Location.X, vsbRacketRight.Value);
            vsbRacketRight.Value = picRacketRight.Location.Y;
        }

        // Kontrollier ob folgende tasten gedrückt worden sind(h,v,p,s) --> Anleitung zum spielen im Designer nachschauen
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
            }
        }

        // Braucht masn damit die pfeiltasten nicht von element zu element springen
        // Kontrolliere den ball mit den pfeiltasten
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
                return true; // Das man nicht über die einzelnen Elemente tippt mit den Pfeiltasten
            }
            
            if (keyData == Keys.Down)
            {
                picBall.Location = new Point(picBall.Location.X, picBall.Location.Y + 25);
                return true;
            }
            
            if (keyData == Keys.Left)
            {
                picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y);
                return true;
            }
            
            if (keyData == Keys.Right)
            {
                picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y);
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        // sichtbarkeit der Buttons einstellen
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

        private void btnLeft_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X, picBall.Location.Y + 25);
        }
    }
}