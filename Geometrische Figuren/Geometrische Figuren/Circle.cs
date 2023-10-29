using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    internal public class Circle : Figure
    {
        protected float Radius { get; set; }

        public Circle(float x = 100.0f, float y = 100.0f, float radius = 5.0f)
            : base(x, y)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
        }

        public override void PrintPosition()
        {
            Console.WriteLine($"Position (center): [{X}, {Y}]");
        }

        public override void PrintArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Area: {area}");
        }
    }
}
