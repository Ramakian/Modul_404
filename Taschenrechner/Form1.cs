using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        Rechenoperationen _rechenoperationen = new Rechenoperationen();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Addition(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Subtraktion(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Multiplikation(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Division(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnPotenz_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Potenz(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnPyth_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Pythagoras(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Max(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Min(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            _rechenoperationen.Mittelwert(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }
    }
}