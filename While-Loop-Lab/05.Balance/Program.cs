using System;

namespace _05.Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int transactions = int.Parse(Console.ReadLine());
            double sum = 0;
            int i = 1;
            while (i <= transactions)
            {
                double money = double.Parse(Console.ReadLine());
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += money;

                Console.WriteLine($"Increase: {money:f2}");

                i++;

            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
