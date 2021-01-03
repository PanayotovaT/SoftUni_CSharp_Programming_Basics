using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeSize = cakeWidth * cakeLength;
            
            int takenPieces = 0;
            string command = "";

            while (cakeSize > 0)
            {
                command = Console.ReadLine();
                
                if (command == "STOP") 
                {
                    break;
                }
                else if (command != "STOP")
                {
                    takenPieces = int.Parse(command);
                    cakeSize -= takenPieces;
                }
                


            }
            if (command == "STOP")
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else if (cakeSize <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}
