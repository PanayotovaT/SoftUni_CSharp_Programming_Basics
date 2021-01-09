using System;

namespace _04.BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	На първи ред получавате начална популация: цяло число[1 - 1000].
            //•	На втори ред получавате години: цяло число[1 - 100].

            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            //На всеки 10 пчели се излюпват нови 2 пчели в началото на всяка година. 
            //В края на всяка година 2 на всеки 20 от пчелите загиват.
            //В началото на всяка 5 - та година след излюпването на новите пчели, 5 на всеки 50 пчели напускат кошера, за да основат собствен такъв.
            int newBees = 0;
            int deadBees = 0;
            int leftBees = 0;
            
            for (int year = 1; year <= years; year++)
            {
                newBees = population / 10 * 2;
                population += newBees;
                if (year % 5 == 0)
                {
                    leftBees = population / 50 * 5;
                    population -= leftBees;
                }


                deadBees = population / 20 * 2;
                population -= deadBees;

            }
            Console.WriteLine($"Beehive population: {population}");



        }
    }
}
