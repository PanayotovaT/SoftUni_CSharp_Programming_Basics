using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                
                double budget = double.Parse(Console.ReadLine());

                double savedMoney = double.Parse(Console.ReadLine());
                double totalMoneySaved = savedMoney;

                while (totalMoneySaved < budget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    totalMoneySaved += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}

