using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_v1
{
    public partial class Form1 : Form
    {
        private int _directionX = 5;
        private int _directionY = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //ball bewegung
            picBall.Location = new Point(picBall.Location.X + _directionX, picBall.Location.Y + _directionY);
            
            //ball berührt rechte wand
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                _directionX = -_directionX;
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
            
        }
    }
}