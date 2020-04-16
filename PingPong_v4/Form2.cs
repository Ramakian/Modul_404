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

namespace PingPong_v4
{
    public partial class frmGameOver : Form
    {
        static string filename = "scoreboard_pingpong_v4.txt"; // scoreboard-file
        static string path = Application.StartupPath + filename;
        public frmGameOver()
        {
            InitializeComponent();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            
            // restart-infomessage
            string restartInfo = "Du kannst das spiel mit dem Button restart neu starten.";
            string caption = "Viel Glück beim nächsten mal!";
            MessageBoxButtons buttonOk = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(restartInfo, caption, buttonOk);

            btnEnter.Visible = true;
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string createText = String.Format("   {0}        {1}        {2}", lblPoints.Text, name, DateTime.Today.ToString("dd.MM.yyyy")) + Environment.NewLine;
            File.AppendAllText(path, createText);
            lblScores.Text = File.ReadAllText(Application.StartupPath + filename);
            btnEnter.Visible = false;
        }
        
        public void SetPoints(int points)
        {
            lblPoints.Text = Convert.ToString(points);
        }


        private void frmGameOver_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
            lblScores.Text = File.ReadAllText(Application.StartupPath + filename);
        }
    }
}
