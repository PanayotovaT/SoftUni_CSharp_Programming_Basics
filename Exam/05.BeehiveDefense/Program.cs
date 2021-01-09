using System;

namespace _05.BeehiveDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	На първи ред получавате брой пчели: цяло число[100 - 10000].
            //•	На втори ред получавате здраве: цяло число[1 - 10000].
            //•	На трети ред получавате атака: цяло число[1 - 10000].

            int numOfBees = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int attck = int.Parse(Console.ReadLine());

            while(numOfBees >= 0)
            {

                numOfBees -= attck;
                if(numOfBees < 0)
                {
                    Console.WriteLine("The bear stole the honey! Bees left 0.");
                }
                else if(numOfBees < 100)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {numOfBees}.");
                    break;
                }
                health -= numOfBees * 5;
                if(health <= 0)
                {
                    Console.WriteLine($"Beehive won! Bees left {numOfBees}.");
                    break;
                }


            }

        }
    }
}
