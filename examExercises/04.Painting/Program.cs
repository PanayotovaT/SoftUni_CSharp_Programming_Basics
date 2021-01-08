using System;

namespace _04.Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Височина на стената -цяло число[0… 100]
            //2.Ширина на стената -цяло число[0… 100]
            //3.Процент от общата площ на стените, който няма да бъде боядисан - цяло число[5… 95]
            //На следващите редове до получаване на командата "Tired!" или докато не бъдат боядисани всички стени, се чете по едно число:
            //•	Литри боя – цяло число[0…100]:

            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percentNotToPaint = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
  
            double paintedWall = 0;
            int paintInLitres = 0;
            double allSpace = 4 * height * width;
            double wallsToPaint = allSpace - percentNotToPaint * allSpace / 100;

            while(command != "Tired!")
            {
                paintInLitres = int.Parse(command);
                
                paintedWall = paintInLitres * 1.0;
                wallsToPaint -= paintedWall;

                if(paintedWall > wallsToPaint)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Round((paintedWall - wallsToPaint), MidpointRounding.AwayFromZero)} l paint left!");
                    break;
                }
                else if(paintedWall == wallsToPaint)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }

                command = Console.ReadLine();
            }
            
            if (command == "Tired!")
            {
                Console.WriteLine($"{wallsToPaint} quadratic m left.");
            }


        }
    }
}
