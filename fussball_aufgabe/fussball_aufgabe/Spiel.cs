using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_aufgabe
{
    internal class Spiel
    {
        public Fussballmannschaft HeimMannschaft { get; private set; }
        public Fussballmannschaft GastMannschaft { get; private set; }

        public Spiel(Fussballmannschaft heimMannschaft, Fussballmannschaft gastMannschaft)
        {
            HeimMannschaft = heimMannschaft;
            GastMannschaft = gastMannschaft;
        }

        public string Spielen()
        {
            int heimTore = HeimMannschaft.ZufälligerSpielzug();
            int gastTore = GastMannschaft.ZufälligerSpielzug();

            if (heimTore > gastTore)
            {
                return $"Real Madrid gewinnt {heimTore} - {gastTore}";
            }
            else if (gastTore > heimTore)
            {
                return $"Barcalona gewinnt {gastTore} - {heimTore}";
            }
            else
            {
                return $"Unentschieden {heimTore} - {gastTore}";
            }
        }
    }
}
