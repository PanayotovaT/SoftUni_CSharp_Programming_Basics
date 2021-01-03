using System;

namespace _04.Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int steps = 0;
            

            while (steps < 10000)
            {
                string command = Console.ReadLine();
                if (command != "Going home")
                {
                    int stepsToHome = int.Parse(command);
                    steps += stepsToHome;
                }
                else if (command == "Going home")
                {
                    int walkedStepsHome = int.Parse(Console.ReadLine());
                    steps += walkedStepsHome;
                    break;
                }

            }
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else 
            {
                int finalsteps = 10000 - steps;
                Console.WriteLine($"{finalsteps} more steps to reach goal.");
            }
        }
    }
}
