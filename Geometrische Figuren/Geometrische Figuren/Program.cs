using System.Drawing;

namespace Geometrische_Figuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
        new Rectangle(50.0f, 60.0f, 20.0f, 10.0f),
        new Circle(200.0f, 150.0f, 8.0f),
        new Square(300.0f, 250.0f, 15.0f)
            };

            foreach (var figure in figures)
            {
                figure.PrintPosition();
                figure.PrintArea();

                if (figure is IRotatable)
                {
                    
                    ((IRotatable)figure).Rotate();
                }
            }
        }
    }
}