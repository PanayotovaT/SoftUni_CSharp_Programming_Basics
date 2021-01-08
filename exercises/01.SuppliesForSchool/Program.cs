using System;

namespace _01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Пакет химикали -5.80 лв
            //•	Пакет маркери -7.20 лв
            //•	Препарат - 1.20 лв(за литър)
            int numOfPens = int.Parse(Console.ReadLine());
            int numOfMarkers = int.Parse(Console.ReadLine());
            double cleanser = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double bill = (numOfPens * 5.80 + numOfMarkers * 7.20 + cleanser * 1.20);
            double billWithDiscount = bill - (bill * discount / 100);
            Console.WriteLine($"{billWithDiscount:f3}");



        }
    }
}
