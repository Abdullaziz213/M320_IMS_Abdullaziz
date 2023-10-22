using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_aufgabe
{
    internal class Torwart
    {
        public string Name { get; private set; }

        public Torwart(string name)
        {
            Name = name;
        }

        public void SchussHalten()
        {
            Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
        }

        public void Abstoss()
        {
            Console.WriteLine($"{Name} macht einen Abstoß!");
        }
    }
}
