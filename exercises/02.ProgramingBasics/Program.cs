using System;

namespace _02.ProgramingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            //наклона на терена го забавя на всеки 50 м. с 30 секунди

            double personalTime = timePerMeter * distance + (Math.Floor(distance / 50) * 30);

            if (personalTime < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {personalTime:f2} seconds.");
            }
            else
            {
                double neededSec = personalTime - recordInSec;
                Console.WriteLine($"No! He was {neededSec:f2} seconds slower.");
            }

        }
    }
}
