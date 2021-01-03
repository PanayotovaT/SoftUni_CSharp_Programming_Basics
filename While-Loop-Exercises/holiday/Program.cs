using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int countSpendDays = 0;


            while (availableMoney < tripPrice)
            {
                string action = Console.ReadLine(); //spend, save
                countDays++;

                if (action == "save")
                {
                    double saveMoney = double.Parse(Console.ReadLine());
                    availableMoney += saveMoney;
                    countSpendDays = 0;
                }
                else if (action == "spend")
                {
                    double spendMoney = double.Parse(Console.ReadLine());
                    countSpendDays++;
                    if (spendMoney > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    else if (spendMoney <= availableMoney)
                    {
                        availableMoney -= spendMoney;
                    }
                    if (countSpendDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(countDays);
                        break;
                    }

                }
                if (availableMoney >= tripPrice)
                {
                    Console.WriteLine($"You saved the money for {countDays} days.");
                }
            }
        }
    }
}
