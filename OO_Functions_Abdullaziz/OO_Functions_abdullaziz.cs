namespace OO_Functions
{
    class MyMath
    {
        public static double CalculateArithmeticMean(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Das Array ist leer.");
            }

            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }

        public static int FindSmallestValue(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Das Array ist leer.");
            }

            int smallest = numbers[0];
            foreach (int number in numbers)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            return smallest;
        }

        public static int FindLargestValue(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Das Array ist leer.");
            }

            int largest = numbers[0];
            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            return largest;
        }

        public static int[] ReadNumbers(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = ReadInt($"Bitte geben Sie die Zahl {i + 1} ein: ");
            }
            return numbers;
        }


        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Calc_ggT_r(b, a % b);
        }

        public static int Calc_kgV(int a, int b)
        {
            int ggT = Calc_ggT(a, b);
            return (a * b) / ggT;
        }

        public static int ReadInt(string prompt)
        {
            int result;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out result) || result <= 0);

            return result;
        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void ReverseArray<T>(T[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                Swap(ref array[left], ref array[right]);
                left++;
                right--;
            }
        }


        public static void ShowResult(string operation, int a, int b, int result)
        {
            Console.WriteLine($"{operation} von {a} und {b} ist {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculations = true;

            while (continueCalculations)
            {
                int count = MyMath.ReadInt("Bitte geben Sie die Anzahl der Zahlen ein: ");
                int[] numbers = MyMath.ReadNumbers(count);

                MyMath.ReverseArray(numbers);

                int ggT = MyMath.Calc_ggT(numbers[0], numbers[1]);
                int ggT_r = MyMath.Calc_ggT_r(numbers[0], numbers[1]);
                int kgV = MyMath.Calc_kgV(numbers[0], numbers[1]);

                MyMath.ShowResult("ggT (iterativ)", numbers[0], numbers[1], ggT);
                MyMath.ShowResult("ggT (rekursiv)", numbers[0], numbers[1], ggT_r);
                MyMath.ShowResult("kgV", numbers[0], numbers[1], kgV);

                double mean = MyMath.CalculateArithmeticMean(numbers);
                int smallest = MyMath.FindSmallestValue(numbers);
                int largest = MyMath.FindLargestValue(numbers);

                Console.WriteLine($"Arithmetischer Mittelwert: {mean}");
                Console.WriteLine($"Kleinster Wert: {smallest}");
                Console.WriteLine($"Größter Wert: {largest}");

                Console.WriteLine("Möchten Sie weitere Berechnungen durchführen? (j/n)");
                string input = Console.ReadLine();
                continueCalculations = (input.ToLower() == "j");
            }
        }
    }
}