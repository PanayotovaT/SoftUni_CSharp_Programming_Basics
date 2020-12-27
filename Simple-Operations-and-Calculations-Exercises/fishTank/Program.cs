using System;

namespace _05.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Дължина в см – цяло число в интервала[10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент  – реално число в интервала[0.000 … 100.000]

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLitres = volume / 1000;
            double percentInNumber = percent / 100;

            double waterNeed = volumeInLitres * (1 - percentInNumber);
            Console.WriteLine($"{waterNeed:f3}");

        }
    }
}
