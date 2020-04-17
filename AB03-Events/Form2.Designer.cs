using System.ComponentModel;

namespace AB03_Events
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(283, 288);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(139, 62);
            this.btnSchliessen.TabIndex = 0;
            this.btnSchliessen.Text = "schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.Location = new System.Drawing.Point(31, 153);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(371, 32);
            this.lblAusgabe.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 362);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.btnSchliessen);
            this.Name = "Form2";
            this.Text = "Informationen";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btnSchliessen;
    }
}