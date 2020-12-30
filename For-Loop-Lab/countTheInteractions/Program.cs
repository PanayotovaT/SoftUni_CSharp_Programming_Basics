using System;

namespace countTheInteractions
{
    class Program
    {
        static void Main(string[] args)
        {
            int itarationCounter = 1;
            for (int i = 1; i <= 15; i += 2)
            {
                Console.WriteLine($"{itarationCounter} - {i}");
                
                itarationCounter++;
            }
            Console.WriteLine(itarationCounter - 1);
        }
    }
}
