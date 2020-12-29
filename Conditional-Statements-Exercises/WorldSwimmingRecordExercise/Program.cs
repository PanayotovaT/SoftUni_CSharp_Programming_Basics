using System;

namespace WorldSwimmingRecordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time = distance * timePerMeter;
            double delayTime = Math.Floor(distance / 15) * 12.5;
            double totalTime = time + delayTime;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");

            }
            else
            {
                double missingSeconds = totalTime - record;
                    Console.WriteLine($"No, he failed! He was {missingSeconds:f2} seconds slower.");
            }
        }
    }
}
