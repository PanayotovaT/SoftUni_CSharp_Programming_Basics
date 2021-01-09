using System;

namespace _06.HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първи ред получавате количесто мед за зимата: реално число[1.00 - 1000.00].
            //•	На следващите до получаване на "Winter has come"редове ще получавате:
            //            o Име на пчела: string
            //          o   На следващите 6 реда ще получавате добития от пчелата мед: реално число[-1000.00 - 1000.00]. 
            //o Ако накрая на 6 - те месеца пчелата е изяла повече мед, отколкото е събрала, принтирайте:
            //"{име на пчела} was banished for gluttony"
            double honeyQuantity = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double totalHoney = 0;
            while(name != "Winter has come")
            {
                double honeyYield = 0;
                double gatheredHoney = 0;
                for (int month = 1; month <= 6; month++)
                {
                    honeyYield = double.Parse(Console.ReadLine());
                    gatheredHoney += honeyYield;

                }
                totalHoney += gatheredHoney;
                if(gatheredHoney < 0)
                {
                    Console.WriteLine($"{name} was banished for gluttony");
                }
                else if(totalHoney >= honeyQuantity)
                {
                    Console.WriteLine($"Well done! Honey surplus {totalHoney - honeyQuantity:f2}.");
                    break;
                }
                name = Console.ReadLine();
            }
            if(name == "Winter has come")
            {
                Console.WriteLine($"Hard Winter! Honey needed {honeyQuantity - totalHoney:f2}.");
            }
        }
    }
}
