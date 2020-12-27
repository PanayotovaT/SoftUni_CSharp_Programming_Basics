using System;

namespace _03.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1.Цена на уискито в лева – реално число в интервала[0.00 … 10000.00]
                2.Количество на бирата в литри – реално число в интервала[0.00 … 1 0000.00]
                3.Количество на виното в литри – реално число в интервала[0.00 … 10000.00]
                4.Количество на ракията в литри – реално число в интервала[0.00 … 10000.00]
                5.Количество на уискито в литри – реално число в интервала[0.00 … 10000.00] */

            double whiskyPrice = Double.Parse(Console.ReadLine());
            double beerQuantity = Double.Parse(Console.ReadLine());
            double wineQuantity = Double.Parse(Console.ReadLine());
            double rakiaQuantity = Double.Parse(Console.ReadLine());
            double whiskyQuantity = Double.Parse(Console.ReadLine());

            /*  •	цената на ракията е на половина по-ниска от тази на уискито;
                •	цената на виното е с 40% по-ниска от цената на ракията;
                •	цената на бирата е с 80% по-ниска от цената на ракията. */

            double rakiaPrice = whiskyPrice / 2;
            double rakiaSum = rakiaQuantity * rakiaPrice;

            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double wineSum = wineQuantity * winePrice;

            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;
            double beerSum = beerQuantity * beerPrice;

            double whiskySum = whiskyQuantity * whiskyPrice;

            double sum = whiskySum + rakiaSum + wineSum + beerSum;
            Console.WriteLine($"{sum:f2}");



        }
    }
}
