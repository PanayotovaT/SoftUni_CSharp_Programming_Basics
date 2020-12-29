using System;

namespace EvenOrOdd_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 ==1)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
