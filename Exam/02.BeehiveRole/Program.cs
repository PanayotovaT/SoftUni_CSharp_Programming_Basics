using System;

namespace _02.BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	На първи ред получавате интелект: цяло число[1 - 100].
            //•	На втори ред получавате сила: цяло число[1 - 100].
            //•	На трети ред получавате пол: string["female", "male"].

            int intelligence = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            //роля                интелект              сила                пол
            //Queen Bee            >= 80                >= 80               female           - done
            //Repairing Bee        >= 80                 Any                 Any
            //Cleaning Bee         >= 60                 Any                 Any
            //Drone Bee            Any                   >= 80               male
            //Guard Bee            Any                   >= 60               Any
            //Worker Bee           Any                   Any                  Any


            if( intelligence >= 80 && power >= 80 && gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if(intelligence >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if(intelligence >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if(power >= 80 && gender == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if(power >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }

        }
    }
}
