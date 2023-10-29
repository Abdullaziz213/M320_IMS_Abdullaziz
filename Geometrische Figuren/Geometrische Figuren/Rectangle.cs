using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    internal public class Rectangle : Figure
    {
        protected float Width { get; set; }
        protected float Height { get; set; }

        public Rectangle(float x = 100.0f, float y = 100.0f, float width = 10.0f, float height = 10.0f)
            : base(x, y)
        {
            if (width > 0 && height > 0)
            {
                Width = width;
                Height = height;
            }
        }

        public override void PrintPosition()
        {
            Console.WriteLine($"Position: [{X}, {Y}]");
        }

        public override void PrintArea()
        {
            float area = Width * Height;
            Console.WriteLine($"Area: {area}");
        }
    }
}
