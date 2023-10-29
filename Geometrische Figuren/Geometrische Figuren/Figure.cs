using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    internal public class Figure
    {
        protected float X { get; set; }
        protected float Y { get; set; }

        public Figure(float x = 100.0f, float y = 100.0f)
        {
            X = x;
            Y = y;
        }

        public virtual void PrintPosition()
        {
            Console.WriteLine($"Position: [{X}, {Y}]");
        }

        public virtual void PrintArea()
        {
            Console.WriteLine("Area: N/A");
        }
    }
}
