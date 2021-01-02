using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int minNumber = int.MaxValue;

            while (i <= n)
            {
                int number = int.Parse(Console.ReadLine());
                i++;
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
