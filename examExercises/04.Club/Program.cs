using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред – желаната печалба на клуба -реално число в интервала[1.00... 15000.00]
            //Поредица от два реда до получаване на командата "Party!" или до достигане на желаната печалба:
            //o Име на коктейла – текст
            //o   Брой на коктейлите за поръчката – цяло число в интервала[1… 50]

            double wishedProfit = double.Parse(Console.ReadLine());
            string cocktailName = Console.ReadLine(); ;
            double profit = 0;
            while(cocktailName != "Party!")
            {
                int numberOfCocktails = int.Parse(Console.ReadLine());
                int cocktailPrice = int.Parse($"{cocktailName.Length}");
                double bill = 0;
                bill = numberOfCocktails * cocktailPrice;
                if(bill % 2 != 0)
                {
                    bill -= 0.25 * bill; ; ;
                }
                profit += bill;

               
                if(profit >= wishedProfit)
                {
                    break;
                }

                cocktailName = Console.ReadLine();
            }

            if(cocktailName == "Party!")
            {
                Console.WriteLine($"We need {(wishedProfit - profit):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Target acquired.");
            }
            
                Console.WriteLine($"Club income - {profit:f2} leva.");
        }
    }
}
