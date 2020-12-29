using System;

namespace _02.Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double excursionPrice = double.Parse(Console.ReadLine());

            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int numberOfToys = puzzles + dolls + teddyBears + minions + trucks;
            double totalProfit = puzzles * 2.60 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;

            if(numberOfToys >= 50)
            {
                totalProfit = totalProfit - 0.25 * totalProfit;
            }

            totalProfit = totalProfit - 0.1 * totalProfit;

            double moneyleft = Math.Abs(totalProfit - excursionPrice);

            if (excursionPrice <= totalProfit)
            {
                
                Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyleft:f2} lv needed.");
            }
        }
    }
}
