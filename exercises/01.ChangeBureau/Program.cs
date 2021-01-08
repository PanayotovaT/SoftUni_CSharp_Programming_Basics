using System;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoinNum = int.Parse(Console.ReadLine());
            double cineseUan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            //•1 биткойн = 1168 лева.
            //•	1 китайски юан = 0.15 долара.
            //•	1 долар = 1.76 лева.
            //•	1 евро = 1.95 лева.

            double lv = bitCoinNum * 1168;  //pari ot bitkoin v lv
            double dollar = cineseUan * 0.15;
            double sumInLv = lv + dollar * 1.76;
            double euro = sumInLv / 1.95;
            double totalSum = euro - (euro * comission) / 100;

            Console.WriteLine($"{totalSum:f2}");



        }
    }
}
