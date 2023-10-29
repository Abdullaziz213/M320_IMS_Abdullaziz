using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    internal public class Square : Rectangle
    {
        public Square(float x = 100.0f, float y = 100.0f, float sideLength = 10.0f)
            : base(x, y, sideLength, sideLength)
        {
        }
    }
}
