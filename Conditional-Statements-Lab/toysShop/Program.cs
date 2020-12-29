using System;

namespace Exercise3Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //Calculate the profit from the toys.
            //Check if the number of the toys is >= 50
            //if yes -> -25%
            //-10% from the money is enough profit for rent
            //check if the money is enough for the holiday

            double totalprofit = puzzles * 2.60 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            int numberOfToys = puzzles + dolls + teddyBears + minions + trucks;

            if (numberOfToys >= 50)
            {
                totalprofit = totalprofit - 0.25 * totalprofit;
                //totalprofit = totalprofit*0.75;
                //totalprofit -= totalprofit*0.25;

            }

            totalprofit = totalprofit - 0.10 * totalprofit;

            double diff = Math.Abs(totalprofit - holidayPrice); 
            //Math.Abs vadi chisla v polovjitelna stoinost

            if (totalprofit >= holidayPrice)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed");
            }
        }
    }
}