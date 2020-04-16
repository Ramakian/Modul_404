using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB06_Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ZeichneSchachbrett(Convert.ToInt32(nudAnzahlZeilen.Value));
        }
        
        private void ZeichneSchachbrett(int anzahl)
        {
            int brettbreite = pnlSchachbrett.Width;
            int bretthoehe = pnlSchachbrett.Height;
            int zellenbreite = brettbreite / anzahl;
            int zellenhoehe = bretthoehe / anzahl;
            bool geradeZeile = true;
            
            pnlSchachbrett.Controls.Clear(); //Löschen des aktuellen Schachbretts
            for (int y = 0; y + zellenhoehe <= bretthoehe; y = y + zellenhoehe)
            {
                int startpunktX = geradeZeile ? zellenbreite : 0;
                geradeZeile = !geradeZeile; //Wechsel für nächste Zeile
                for (int x = startpunktX; x + zellenbreite <= brettbreite; x = x + (2 * zellenbreite))
                {
                    var zelle = new Label
                    {
                        BackColor = Color.Black,
                        Location = new Point(x, y),
                        Width = zellenbreite,
                        Height = zellenhoehe
                    };
                    pnlSchachbrett.Controls.Add(zelle);
                }
            }
        }
    }
}