﻿using System;

namespace _02.CatWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int walkMinutes = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            //5 cl per minute

            int burnedCalories = numberOfWalks * walkMinutes * 5;
            double halfOfTheCalories = calories * 1.0 / 2;

            if (burnedCalories >= halfOfTheCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
