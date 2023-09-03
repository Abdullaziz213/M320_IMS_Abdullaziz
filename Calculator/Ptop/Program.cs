namespace Calculator
{
    class Calculator
    {
        private static int lastResult = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wähle eine Operation: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Beenden");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Das Programm wird beendet.");
                    break;
                }

                Console.Write("Gib den ersten Wert ein: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Gib den zweiten Wert ein: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(num1, num2);
                        break;
                    case 2:
                        result = Subtract(num1, num2);
                        break;
                    case 3:
                        result = Multiply(num1, num2);
                        break;
                    case 4:
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        break;
                }

                lastResult = result;
                Console.WriteLine("Ergebnis: " + result);
            }
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
                return 0;
            }
            return a / b;
        }
    }
}