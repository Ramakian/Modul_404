using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_v3
{
    public partial class Form1 : Form
    {
        private int _directionX = 5;
        private int _directionY = 2;
        private int _points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // start des spiels
        private void btnSpiel_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //ball bewegung
            picBall.Location = new Point(picBall.Location.X + _directionX, picBall.Location.Y + _directionY);

            //ball berührt rechte wand
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width
                && picBall.Location.Y + picBall.Height >= picRacketRight.Location.Y
                && picBall.Location.Y <= picRacketRight.Location.Y + picRacketRight.Height)
            {
                _directionX = -_directionX;
                _points += 10; //füge 10 Punkte hinzu
            }

            //Game Over
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width
                && (picBall.Location.Y + picBall.Height <= picRacketRight.Location.Y
                    || picBall.Location.Y >= picRacketRight.Location.Y + picRacketRight.Height))
            {
                tmrSpiel.Stop();
                string looser = "GAME OVER! Try again?";
                string caption = "GAME OVER";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(looser, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    picBall.Location = new Point(379, 69);
                    _points = 0;
                }

                if (result == DialogResult.No)
                {
                    Close();
                }
            }

            //ball berührt linke wand
            if (picBall.Location.X <= 0)
            {
                _directionX = -_directionX;
            }

            //ball berührt oberen rand
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                _directionY = -_directionY;
            }

            //ball berührt unteren rand
            if (picBall.Location.Y < 0)
            {
                _directionY = -_directionY;
            }

            //zeige Punktestand
            txtPoints.Text = Convert.ToString(_points);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Position des schlägers bei spielbeginn nach rechts setzen
            picRacketRight.Location = new Point(pnlSpiel.Width - picRacketRight.Width - picRacketRight.Width,
                pnlSpiel.Height / 2);

            //scrollbar rechts ans Panel anfügen, balken auf höhe des schläger anordnen.
            vsbRacketRight.Height = pnlSpiel.Height;
            vsbRacketRight.Location = new Point(pnlSpiel.Location.X + pnlSpiel.Width, pnlSpiel.Location.Y);
            vsbRacketRight.Minimum = 0;
            vsbRacketRight.Maximum = pnlSpiel.Height - picRacketRight.Height + vsbRacketRight.LargeChange;
            vsbRacketRight.Value = picRacketRight.Location.Y;
        }

        // Bewegung des schlägers der Scrollbar anpassen.
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
                    tmrSpiel.Stop();
                    break;

                case Keys.S:
                    tmrSpiel.Start();
                    break;
            }
        }

        // Braucht masn damit die pfeiltasten nicht von element zu element springen
        // Kontrolliere den ball mit den pfeiltasten
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
                return true; //Das man nicht über die einzelnen Elemente tippt mit den Pfeiltasten
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y);
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