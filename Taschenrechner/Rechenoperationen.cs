using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public class Rechenoperationen
    {
        public void Addition(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = zahl1 + zahl2;
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "+";
        }
        
        public void Subtraktion(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = zahl1 - zahl2;
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "-";
        }
        
        public void Multiplikation(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = zahl1 * zahl2;
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "*";
        }
        
        public void Division(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = zahl1 / zahl2;
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "/";
        }
        
        public void Potenz(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = Math.Pow(zahl1, zahl2);
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "^";
        }

        public void Pythagoras(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = Math.Sqrt(Math.Pow(zahl1, 2) + Math.Pow(zahl2, 2));
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "PYTH";
        }

        public void Max(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = Math.Max(zahl1, zahl2);
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "MAX";
        }
        
        public void Min(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = Math.Min(zahl1, zahl2);
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "MIN";
        }
        
        public void Mittelwert(TextBox operand1, TextBox operand2, Label resultat, Label methode)
        {
            double zahl1 = Convert.ToDouble(operand1.Text);
            double zahl2 = Convert.ToDouble(operand2.Text);
            double ergebnis = (zahl1 + zahl2) / 2;
            resultat.Text = Convert.ToString(ergebnis);
            methode.Text = "MW";
        }
    }
}