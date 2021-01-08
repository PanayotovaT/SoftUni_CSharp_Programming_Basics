using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Закупеното количество храна за кученцето в килограми – цяло число в интервала[1 …100]
            //•	На всеки следващ ред до получаване на команда Adopted ще получавате колко грама изяжда кученцето на всяко хранене -цяло число в интервала[10 …1000]

            int allFood = int.Parse(Console.ReadLine());
            string consumedFood = Console.ReadLine();
            int allFoodInGrams = allFood * 1000;
            int consumedFoodInGrams = 0;
            while (consumedFood != "Adopted")
            {

                consumedFoodInGrams += int.Parse(consumedFood);
                
                consumedFood = Console.ReadLine();
            }

            if(consumedFoodInGrams <= allFoodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {allFoodInGrams - consumedFoodInGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {consumedFoodInGrams - allFoodInGrams} grams more.");
            }
        }
    }
}
