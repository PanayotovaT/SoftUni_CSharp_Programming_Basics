using System;

namespace Exam07._06._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int numOfBees = int.Parse(Console.ReadLine());
            int numofFlowers = int.Parse(Console.ReadLine());

            double producedHoney = Math.Round((numOfBees * numofFlowers * 0.21), 3);
            double honeyComb = Math.Floor(producedHoney / 100);
            double leftHoney = Math.Round((producedHoney % 100), 3);

            Console.WriteLine($"{honeyComb} honeycombs filled.");
            Console.WriteLine($"{leftHoney:f2} grams of honey left.");

        }
    }
}
