using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB03_Events
{
    public partial class Form1 : Form
    {
        Form2 information = new Form2();
        public Form1()
        {
            InitializeComponent();
            //Initialize Button-Eventhandler
            //information.btnSchliessen.Click += new EventHandler(this.btnSchliessen_Click);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            txtOutput.Text += "Click" + Environment.NewLine;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtOutput.Text += "Double-Click" + Environment.NewLine;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtOutput.Text += "Left Mousebutton down" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtOutput.Text += "Right Mousebutton down" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtOutput.Text += "Middle Mousebutton down" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtOutput.Text += "Left Mousebutton up" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtOutput.Text += "Right Mousebutton up" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtOutput.Text += "Middle Mousebutton up" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            txtOutput.Text += "Key down" + Environment.NewLine;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            txtOutput.Text += "Key up" + Environment.NewLine;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtOutput.Text += e.KeyChar + " - key pressed" + Environment.NewLine;
        }

        private void btnInfos_Click(object sender, EventArgs e)
        {
            information.Show();
            //information.lblAusgabe.Text = "Dies ist ein Informationsformular";
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            information.Hide();
        }
    }
}