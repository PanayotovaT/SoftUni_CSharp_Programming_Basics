using System;
using System.Diagnostics.Tracing;

namespace Reading_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            int counter = 0;

            while(text != "Stop")
            {
                text = Console.ReadLine();
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
