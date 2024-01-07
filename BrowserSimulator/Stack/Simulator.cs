using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsersimulator
{
    public class Simulator
    {

        private StringStack stack = new StringStack();

        private string currentUrl = "";
        public void Run()
        {
            while (true)
            {
            Console.Write("Geben Sie eine URL ein: ");
            string url = Console.ReadLine();
                switch (url)
                {
                    case "e":
                        break;
                    case "p":
                        stack.Pop();
                        break;
                    case "f":

                    default:
                        BrowseUrl(url);
                        break;
                }
        
            }
        }

        private void Undo()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine("Diese Funktion ist ");
            }
        }


        private void Redo()
        {
            if(fowardStack.Count > 0)
            {
                historyStack.Push(url);
                fowardStack.Clear();
            }
            currentUrl = url;
            Console.WriteLine($"Loading...... {url}");
        }
    }
}
