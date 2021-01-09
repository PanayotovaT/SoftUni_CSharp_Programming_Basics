using System;

namespace _03.HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	На първи ред получавате тип цвете: string["Sunflower", "Daisy", "Lavender", "Mint"].
            //•	На втори ред получавате брой цветя: цяло число[1 - 1000].
            //•	На трети ред получавате сезон: string["Spring", "Summer", "Autumn"]."].

            string flowerType = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double producedHoney = 0;

            //Season     Sunflower    Daisy     Lavender     Mint
            //Spring     10           12        12           10
            //Summer     8            8         8            12
            //Autumn     12           6         6            6

            switch (flowerType)
            {
                case "Sunflower":
                    switch (season)
                    {
                        case "Spring":
                            producedHoney = numOfFlowers * 10;
                            break;
                        case "Summer":
                            producedHoney = numOfFlowers * 8;
                            break;
                        case "Autumn":
                            producedHoney = numOfFlowers * 12;
                            break;
                    }
                    break;
                case "Daisy":
                    switch (season)
                    {
                        case "Spring":
                            producedHoney = numOfFlowers * 12;
                            break;
                        case "Summer":
                            producedHoney = numOfFlowers * 8;
                            break;
                        case "Autumn":
                            producedHoney = numOfFlowers * 6;
                            break;
                    }
                    break;
                case "Lavender":
                    switch (season)
                    {
                        case "Spring":
                            producedHoney = numOfFlowers * 12;
                            break;
                        case "Summer":
                            producedHoney = numOfFlowers * 8;
                            break;
                        case "Autumn":
                            producedHoney = numOfFlowers * 6;
                            break;
                    }
                    break;
                case "Mint":
                    switch (season)
                    {
                        case "Spring":
                            producedHoney = numOfFlowers * 10;
                            break;
                        case "Summer":
                            producedHoney = numOfFlowers * 12;
                            break;
                        case "Autumn":
                            producedHoney = numOfFlowers * 6;
                            break;
                    }
                    break;
            }

            if (season == "Summer")
            {
                producedHoney += 0.10 * producedHoney;
            }
            else if (season == "Autumn")
            {
                producedHoney -= 0.05 * producedHoney;
            }
            else if (season == "Spring")
            {
                if(flowerType == "Daisy" || flowerType == "Mint")
                {
                    producedHoney += 0.10 * producedHoney;
                }
            }

            Console.WriteLine($"Total honey harvested: {producedHoney:f2}");
        }
    }
}
