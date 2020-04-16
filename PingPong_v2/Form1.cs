using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_v2
{
    public partial class Form1 : Form
    {
        private int _directionX = 8;
        private int _directionY = 4;
        private int _points = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpiel_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //ball bewegung
            picBall.Location = new Point(picBall.Location.X + _directionX, picBall.Location.Y + _directionY);

            //ball trifft rechten spielrand
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width
                && picBall.Location.Y + picBall.Height >= picRacketRight.Location.Y
                && picBall.Location.Y <= picRacketRight.Location.Y + picRacketRight.Height)
            {
                _directionX = -_directionX;
                _points += 10; //10 punkte dazu
            }

            //game over
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)

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
            
            //ball trifft linken rand
            if (picBall.Location.X <= 0)
            {
                _directionX = -_directionX;
            }
                        
            //ball trifft oberen rand
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                _directionY = -_directionY;
            }
            
            //ball trifft unteren rand
            if (picBall.Location.Y < 0)
            {
                _directionY = -_directionY;
            }
            
            //zeige Punktestand
            txtPoints.Text = Convert.ToString(_points);
        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {
            //Position des schlägers bei spielbeginn nach rechts setzen
            picRacketRight.Location = new Point(pnlSpiel.Width - picRacketRight.Width, pnlSpiel.Height / 2);
            
            //scrollbar rechts ans Panel anfügen, balken auf höhe des schläger anordnen.
            vsbRacketRight.Height = pnlSpiel.Height;
            vsbRacketRight.Location = new Point(pnlSpiel.Location.X + pnlSpiel.Width, pnlSpiel.Location.Y);
            vsbRacketRight.Minimum = 0;
            vsbRacketRight.Maximum = pnlSpiel.Height - picRacketRight.Height + vsbRacketRight.LargeChange;
            vsbRacketRight.Value = picRacketRight.Location.Y;
        }
        
        private void vsbRacketRight_Scroll(object sender, ScrollEventArgs e)
        {
            picRacketRight.Location = new Point(picRacketRight.Location.X, vsbRacketRight.Value);
            vsbRacketRight.Value = picRacketRight.Location.Y;
        }
    }
}