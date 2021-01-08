using System;

namespace _05.SuitcaseLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Капацитетът на багажника – реално число в диапазона[100.0…6000.0]
            //След това до получаване на команда "End" или до запълване на багажника, се чете по един ред:
            //            o Обем на куфар – реално число в диапазона[100.0…6000.0]
            double luggageCapacity = double.Parse(Console.ReadLine());
            string suitcase = Console.ReadLine();
            double suitcasevolume = 0;
            int counter = 1;
           

            while (suitcase != "End")
            {
                suitcasevolume = double.Parse(suitcase);
                if(counter % 3 == 0)
                {
                    suitcasevolume += 0.10 * suitcasevolume;
                }

                luggageCapacity -= suitcasevolume;
                if( luggageCapacity < 0)
                {
                    Console.WriteLine("No more space!");
                   
                    break;
                }
                
                suitcase = Console.ReadLine();
                counter++;
            }

            if(suitcase == "End")
            {

                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter - 1} suitcases loaded.");

        }
    }
}
