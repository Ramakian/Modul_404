using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PingPong_v5
{
    public partial class frmGameOver : Form
    {
        static string filename = "scoreboard_pingpong_v5.txt"; // scoreboard-file
        static string path = Application.StartupPath + filename;
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string createText = String.Format("   {0}        {1}        {2}", lblPoints.Text, name, DateTime.Today.ToString("dd.MM.yyyy")) + Environment.NewLine;
            File.AppendAllText(path, createText);
            lblScores.Text = File.ReadAllText(Application.StartupPath + filename);
            btnEnter.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            
            // restart-infomessage
            string restartInfo = "You can restart the game with the button in the bottom left corner.";
            string caption = "Better luck next time!";
            MessageBoxButtons buttonOk = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(restartInfo, caption, buttonOk);
        }
        
        public void SetPoints(int points)
        {
            lblPoints.Text = Convert.ToString(points);
        }

        public void ShowScoreboard()
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
            lblScores.Text = File.ReadAllText(Application.StartupPath + filename);
        }
    }
}