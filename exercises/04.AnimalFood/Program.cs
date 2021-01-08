using System;

namespace _04.AnimalFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int allDays = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());
            double biscuits = 0;
            int allDogFood = 0;
            int allCatFood = 0;
            

            for (int day = 1; day <= allDays; day++)

            {
                 int dogFood = int.Parse(Console.ReadLine());
                 int catFood = int.Parse(Console.ReadLine());
                             
                if(day % 3 == 0)
                {
                    biscuits += 0.10 * dogFood + 0.10 * catFood;
                }
                allDogFood += dogFood;
                allCatFood += catFood;
            }
            biscuits = Math.Round(biscuits);

            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");
            int eatenFood = allDogFood + allCatFood;
            double percentEatenFood = eatenFood * 1.0 / allFood * 100;
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");

            double percentDogFood = allDogFood * 1.0 / eatenFood * 100;
            double percentCatFood = allCatFood * 1.0 / eatenFood * 100;
            Console.WriteLine($"{percentDogFood:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCatFood:f2}% eaten from the cat.");
        }
    }
}
