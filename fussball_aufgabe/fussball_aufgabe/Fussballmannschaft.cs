using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_aufgabe
{
    internal class Fussballmannschaft
    {
        public List<Feldspieler> FeldspielerList { get; private set; }
        public Torwart Torwart { get; private set; }

        public Fussballmannschaft(Torwart torwart, List<Feldspieler> feldspielerList)
        {
            Torwart = torwart;
            FeldspielerList = feldspielerList;
        }

        public int ZufälligerSpielzug()
        {
            Random random = new Random();
            int erzielteTore = 0;

            foreach (var spieler in FeldspielerList)
            {
                int zufallsAktion = random.Next(1, 4);

                if (zufallsAktion == 1)
                {
                    spieler.AufsTorSchiessen();
                    int torwartAktion = random.Next(1, 4);
                    if (torwartAktion == 1)
                        Torwart.SchussHalten();
                    else if (torwartAktion == 2)
                        Torwart.Abstoss();
                    else
                    {
                        erzielteTore++;
                        spieler.TorErzielt();
                    }

                }
                else if (zufallsAktion == 2)
                    spieler.Graetschen();
                else
                    spieler.Dribbeln();


            }
            return erzielteTore;
        }
    }
}
