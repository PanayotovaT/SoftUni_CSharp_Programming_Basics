using System;

namespace _02.Shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Видеокарта – 250 лв./ бр.
            //•	Процесор – 35 % от цената на закупените видеокарти/ бр.
            //•	Рам памет – 10 % от цената на закупените видеокарти/ бр.

           
            double budget = double.Parse(Console.ReadLine());
            int videocardsNumber = int.Parse(Console.ReadLine());
            int processorsNumber = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            double videocardExpenses = videocardsNumber * 250;
            double processorsExpenses = 0.35 * videocardExpenses * processorsNumber;
            double ramMemoryExpenses = 0.10 * videocardExpenses * ramMemory;

            double allExpenses = videocardExpenses + processorsExpenses + ramMemoryExpenses;
            if(videocardsNumber > processorsNumber)
            {
                allExpenses = allExpenses - 0.15 * allExpenses;
            }

            if(budget >= allExpenses)
            {
                Console.WriteLine($"You have {(budget - allExpenses):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(allExpenses - budget):f2} leva more!");
            }
        }
    }
}
