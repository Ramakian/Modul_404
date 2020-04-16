namespace PingPong_v4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.picRacketRight = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.vsbRacketRight = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.rdbRacket = new System.Windows.Forms.RadioButton();
            this.rdbBall = new System.Windows.Forms.RadioButton();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picRacketRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            this.grpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGame.Controls.Add(this.picRacketRight);
            this.pnlGame.Controls.Add(this.picBall);
            this.pnlGame.Location = new System.Drawing.Point(12, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(607, 329);
            this.pnlGame.TabIndex = 2;
            // 
            // picRacketRight
            // 
            this.picRacketRight.BackColor = System.Drawing.Color.Black;
            this.picRacketRight.Location = new System.Drawing.Point(596, 38);
            this.picRacketRight.Name = "picRacketRight";
            this.picRacketRight.Size = new System.Drawing.Size(10, 40);
            this.picRacketRight.TabIndex = 1;
            this.picRacketRight.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(288, 66);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(24, 25);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // vsbRacketRight
            // 
            this.vsbRacketRight.Location = new System.Drawing.Point(622, 12);
            this.vsbRacketRight.Name = "vsbRacketRight";
            this.vsbRacketRight.Size = new System.Drawing.Size(34, 330);
            this.vsbRacketRight.TabIndex = 6;
            this.vsbRacketRight.Value = 50;
            this.vsbRacketRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbRacketRight_Scroll);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(203, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 123);
            this.label2.TabIndex = 17;
            this.label2.Text =
                "Keyboard controls:\r\nKey\r\nH Change horizontal direction of the ball\r\nV Change vert" +
                "ical direction of the ball\r\nP Pause the game\r\nS Continue the Game";
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtPoints.Location = new System.Drawing.Point(131, 372);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(107, 29);
            this.txtPoints.TabIndex = 16;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Points: ";
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(12, 437);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(121, 54);
            this.btnGame.TabIndex = 14;
            this.btnGame.Text = "Start Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.BackgroundImage = global::PingPong_v4.Properties.Resources.pyr_left_512;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.Location = new System.Drawing.Point(702, 179);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(26, 27);
            this.btnLeft.TabIndex = 21;
            this.btnLeft.Tag = "le";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.BackgroundImage = global::PingPong_v4.Properties.Resources.pyr_right_512;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.Location = new System.Drawing.Point(756, 179);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(26, 27);
            this.btnRight.TabIndex = 20;
            this.btnRight.Tag = "ri";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.BackgroundImage = global::PingPong_v4.Properties.Resources.pyr_down_512;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Location = new System.Drawing.Point(728, 207);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 27);
            this.btnDown.TabIndex = 19;
            this.btnDown.Tag = "do";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.BackgroundImage = global::PingPong_v4.Properties.Resources.pyr_up_512;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Location = new System.Drawing.Point(728, 152);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 27);
            this.btnUp.TabIndex = 18;
            this.btnUp.Tag = "up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 30;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.rdbRacket);
            this.grpControl.Controls.Add(this.rdbBall);
            this.grpControl.Location = new System.Drawing.Point(595, 477);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(212, 84);
            this.grpControl.TabIndex = 22;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Select the Control";
            // 
            // rdbRacket
            // 
            this.rdbRacket.AutoSize = true;
            this.rdbRacket.Checked = true;
            this.rdbRacket.Location = new System.Drawing.Point(16, 51);
            this.rdbRacket.Name = "rdbRacket";
            this.rdbRacket.Size = new System.Drawing.Size(105, 19);
            this.rdbRacket.TabIndex = 1;
            this.rdbRacket.TabStop = true;
            this.rdbRacket.Text = "Racket-Control";
            this.rdbRacket.UseVisualStyleBackColor = true;
            this.rdbRacket.CheckedChanged += new System.EventHandler(this.rdbRacket_CheckedChanged);
            // 
            // rdbBall
            // 
            this.rdbBall.AutoSize = true;
            this.rdbBall.Location = new System.Drawing.Point(16, 24);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(89, 19);
            this.rdbBall.TabIndex = 0;
            this.rdbBall.Text = "Ball-Control";
            this.rdbBall.UseVisualStyleBackColor = true;
            this.rdbBall.CheckedChanged += new System.EventHandler(this.rdbBall_CheckedChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 507);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 54);
            this.btnRestart.TabIndex = 23;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 572);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.vsbRacketRight);
            this.Controls.Add(this.pnlGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ping-Pong Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picRacketRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picRacketRight;
        private System.Windows.Forms.VScrollBar vsbRacketRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.RadioButton rdbBall;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.RadioButton rdbRacket;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer tmrGame;
    }
}