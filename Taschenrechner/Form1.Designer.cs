namespace Taschenrechner
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
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMultiplikation = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperand1
            // 
            this.txtOperand1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOperand1.Location = new System.Drawing.Point(29, 30);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(140, 29);
            this.txtOperand1.TabIndex = 0;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOperand2.Location = new System.Drawing.Point(281, 30);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(140, 29);
            this.txtOperand2.TabIndex = 1;
            // 
            // btnAddition
            // 
            this.btnAddition.AutoSize = true;
            this.btnAddition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddition.Location = new System.Drawing.Point(29, 171);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(124, 59);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.Control;
            this.lblOperator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOperator.Location = new System.Drawing.Point(190, 33);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(70, 23);
            this.lblOperator.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ergebnis: ";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.Color.White;
            this.lblErgebnis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblErgebnis.Location = new System.Drawing.Point(145, 95);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(169, 28);
            this.lblErgebnis.TabIndex = 5;
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.AutoSize = true;
            this.btnSubtraktion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubtraktion.Location = new System.Drawing.Point(190, 171);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(124, 59);
            this.btnSubtraktion.TabIndex = 6;
            this.btnSubtraktion.Text = "Subtraktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMultiplikation
            // 
            this.btnMultiplikation.AutoSize = true;
            this.btnMultiplikation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMultiplikation.Location = new System.Drawing.Point(349, 171);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(135, 59);
            this.btnMultiplikation.TabIndex = 7;
            this.btnMultiplikation.Text = "Multiplikation";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.btnMultiplikation_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDivision.Location = new System.Drawing.Point(29, 261);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(124, 59);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.AutoSize = true;
            this.btnPotenz.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPotenz.Location = new System.Drawing.Point(190, 261);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(124, 59);
            this.btnPotenz.TabIndex = 9;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            // 
            // btnMax
            // 
            this.btnMax.AutoSize = true;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMax.Location = new System.Drawing.Point(29, 350);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(124, 59);
            this.btnMax.TabIndex = 10;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMin.Location = new System.Drawing.Point(349, 350);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(124, 59);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "Minimum";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.AutoSize = true;
            this.btnMittelwert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMittelwert.Location = new System.Drawing.Point(349, 261);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(124, 59);
            this.btnMittelwert.TabIndex = 13;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 441);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplikation);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplikation;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnMittelwert;
    }
}