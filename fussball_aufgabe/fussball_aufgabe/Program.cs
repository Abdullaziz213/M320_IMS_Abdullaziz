using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_aufgabe
{
    

    class Program
    {
        static void Main()
        {
            // Erstellen der Spieler
            Torwart torwart1 = new Torwart("Ter Stegen");
            List<Feldspieler> feldspielerList1 = new List<Feldspieler>
        {
            new Feldspieler("Carvajal"),
            new Feldspieler("Nacho"),
            new Feldspieler("Ramos"),
            new Feldspieler("Marcelo"),
            new Feldspieler("Modric"),
            new Feldspieler("Casemiro"),
            new Feldspieler("Kroos"),
            new Feldspieler("Bale"),
            new Feldspieler("Benzema"),
            new Feldspieler("Rondalo"),
        };

            Torwart torwart2 = new Torwart("Navas");
            List<Feldspieler> feldspielerList2 = new List<Feldspieler>
        {
            new Feldspieler("Alba"),
            new Feldspieler("Umtiti"),
            new Feldspieler("Piqué"),
            new Feldspieler("Roberto"),
            new Feldspieler("Iniesta"),
            new Feldspieler("Busquets"),
            new Feldspieler("Rakitic"),
            new Feldspieler("Alcacer"),
            new Feldspieler("Suarez"),
            new Feldspieler("Messi"),
        };

            Fussballmannschaft heimMannschaft = new Fussballmannschaft(torwart1, feldspielerList1);
            Fussballmannschaft gastMannschaft = new Fussballmannschaft(torwart2, feldspielerList2);

            Spiel spiel = new Spiel(heimMannschaft, gastMannschaft);
            string ergebnis = spiel.Spielen();

            Console.WriteLine("Spiel Ergebnis: " + ergebnis);
        }
    }
}
