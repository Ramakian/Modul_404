namespace PingPong_v3
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
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picRacketRight = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.vsbRacketRight = new System.Windows.Forms.VScrollBar();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpiel = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picRacketRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picRacketRight);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(24, 24);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(607, 329);
            this.pnlSpiel.TabIndex = 1;
            // 
            // picRacketRight
            // 
            this.picRacketRight.BackColor = System.Drawing.Color.Black;
            this.picRacketRight.Location = new System.Drawing.Point(596, 38);
            this.picRacketRight.Name = "picRacketRight";
            this.picRacketRight.Size = new System.Drawing.Size(3, 40);
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
            this.vsbRacketRight.Location = new System.Drawing.Point(635, 24);
            this.vsbRacketRight.Name = "vsbRacketRight";
            this.vsbRacketRight.Size = new System.Drawing.Size(34, 330);
            this.vsbRacketRight.TabIndex = 5;
            this.vsbRacketRight.Value = 50;
            this.vsbRacketRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbRacketRight_Scroll);
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtPoints.Location = new System.Drawing.Point(143, 377);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(84, 29);
            this.txtPoints.TabIndex = 8;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Punkte:";
            // 
            // btnSpiel
            // 
            this.btnSpiel.Location = new System.Drawing.Point(24, 436);
            this.btnSpiel.Name = "btnSpiel";
            this.btnSpiel.Size = new System.Drawing.Size(121, 54);
            this.btnSpiel.TabIndex = 6;
            this.btnSpiel.Text = "Spiel starten";
            this.btnSpiel.UseVisualStyleBackColor = true;
            this.btnSpiel.Click += new System.EventHandler(this.btnSpiel_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 30;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.BackgroundImage = global::PingPong_v3.Properties.Resources.pyr_up_512;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Location = new System.Drawing.Point(738, 162);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 27);
            this.btnUp.TabIndex = 9;
            this.btnUp.Tag = "up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.BackgroundImage = global::PingPong_v3.Properties.Resources.pyr_down_512;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Location = new System.Drawing.Point(738, 216);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 27);
            this.btnDown.TabIndex = 10;
            this.btnDown.Tag = "do";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.BackgroundImage = global::PingPong_v3.Properties.Resources.pyr_right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.Location = new System.Drawing.Point(766, 189);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(26, 27);
            this.btnRight.TabIndex = 11;
            this.btnRight.Tag = "ri";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.BackgroundImage = global::PingPong_v3.Properties.Resources.pyr_left_512;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.Location = new System.Drawing.Point(712, 189);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(26, 27);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Tag = "le";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(169, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 123);
            this.label2.TabIndex = 13;
            this.label2.Text =
                "Tastatursteuerung:\r\nTaste\r\nH Horizontale Flugrichtung umkehren\r\nV Vertikale Flugr" +
                "ichtung umkehren\r\nP Spiel pausieren\r\nS Spiel weiterlaufen lassen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpiel);
            this.Controls.Add(this.vsbRacketRight);
            this.Controls.Add(this.pnlSpiel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picRacketRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picRacketRight;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.VScrollBar vsbRacketRight;
        private System.Windows.Forms.Button btnSpiel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}