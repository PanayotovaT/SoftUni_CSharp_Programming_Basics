using System;

namespace _1ExerciseUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double bgn = dollars * 1.763468;
            Console.WriteLine($"{bgn:f2}");

        }
    }
}
