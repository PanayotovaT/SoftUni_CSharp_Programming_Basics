using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2;
            int value2 = 3;

            for (int i = 0; i < 33; i++)
            {
                Console.WriteLine($"{value}^{i} = {Math.Pow(value,i)}            {value2}^{i} = {Math.Pow(value2, i)}");

                

            }
        }
    }
}
