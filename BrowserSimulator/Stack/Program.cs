using Browsersimulator;

namespace Browsersimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack stack = new StringStack(5);

            stack.Push("Value1");
            stack.Push("Value2");
            stack.Push("Value3");

            string topValue = stack.Peek();
            Console.WriteLine($"Top value on the stack: {topValue}");

            string poppedValue = stack.Pop();
            Console.WriteLine($"Popped value from the stack: {poppedValue}");

            stack.Swap();

            Console.WriteLine("Remaining values in the stack:");
            while (!stack.IsEmpty)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}