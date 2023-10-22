using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_aufgabe
{
    internal class Feldspieler
    {
        public string Name { get; private set; }

        public Feldspieler(string name)
        {
            Name = name;
        }

        public void AufsTorSchiessen()
        {
            Console.WriteLine($"{Name} schießt aufs Tor!");
        }

        public void Graetschen()
        {
            Console.WriteLine($"{Name} macht eine Blutgrätsche!");
        }

        public void Dribbeln()
        {
            Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
        }

        public void TorErzielt()
        {
            Console.WriteLine($"{Name} erzielt ein Tor");
        }
    }
}
