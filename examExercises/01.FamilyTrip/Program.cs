using System;

namespace _01.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            //•	Брой нощувки – цяло число в интервала[0 … 1000]
            //•	Цена за нощувка – реално число в интервала[1.00 … 500.00]
            //•	Процент за допълнителни разходи – цяло число в интервала[0 … 100]

            double budget = double.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percentOtherExpenses = int.Parse(Console.ReadLine());

            if(numberOfNights > 7)
            {
                pricePerNight = pricePerNight - 0.05 * pricePerNight;
                
            }

            double otherExpenses = percentOtherExpenses * budget / 100;
            double hotelExpenses = numberOfNights * pricePerNight;
            double allExpenses = otherExpenses + hotelExpenses;

            if(budget >= allExpenses)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget - allExpenses):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(allExpenses - budget):f2} leva needed.");
            }



        }
    }
}
