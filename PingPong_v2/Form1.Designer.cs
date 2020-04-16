namespace PingPong_v2
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
            this.btnSpiel = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.vsbRacketRight = new System.Windows.Forms.VScrollBar();
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
            this.pnlSpiel.Location = new System.Drawing.Point(24, 65);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(350, 300);
            this.pnlSpiel.TabIndex = 0;
            // 
            // picRacketRight
            // 
            this.picRacketRight.BackColor = System.Drawing.Color.Black;
            this.picRacketRight.Location = new System.Drawing.Point(332, 162);
            this.picRacketRight.Name = "picRacketRight";
            this.picRacketRight.Size = new System.Drawing.Size(7, 40);
            this.picRacketRight.TabIndex = 1;
            this.picRacketRight.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(216, 120);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(24, 25);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnSpiel
            // 
            this.btnSpiel.Location = new System.Drawing.Point(14, 372);
            this.btnSpiel.Name = "btnSpiel";
            this.btnSpiel.Size = new System.Drawing.Size(121, 54);
            this.btnSpiel.TabIndex = 1;
            this.btnSpiel.Text = "Spiel starten";
            this.btnSpiel.UseVisualStyleBackColor = true;
            this.btnSpiel.Click += new System.EventHandler(this.btnSpiel_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 60;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(141, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punkte:";
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtPoints.Location = new System.Drawing.Point(241, 372);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(84, 29);
            this.txtPoints.TabIndex = 3;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsbRacketRight
            // 
            this.vsbRacketRight.Location = new System.Drawing.Point(377, 74);
            this.vsbRacketRight.Name = "vsbRacketRight";
            this.vsbRacketRight.Size = new System.Drawing.Size(34, 291);
            this.vsbRacketRight.TabIndex = 4;
            this.vsbRacketRight.Value = 50;
            this.vsbRacketRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbRacketRight_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 432);
            this.Controls.Add(this.vsbRacketRight);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpiel);
            this.Controls.Add(this.pnlSpiel);
            this.Name = "Form1";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.frmPingPong_Load);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picRacketRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Button btnSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.VScrollBar vsbRacketRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.PictureBox picRacketRight;
    }
}