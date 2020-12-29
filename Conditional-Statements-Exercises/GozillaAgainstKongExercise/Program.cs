using System;

namespace GozillaAgainstKongExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //ред 1.бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //ред 2.брой на статистите – цяло число в интервала[1 … 500]
            //ред 3.цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decor = 0.10 * budget;
            double expensePerStatist = pricePerStatist * statists;

            if (statists > 150)
            {
                expensePerStatist = expensePerStatist - 0.10 * expensePerStatist;
            }

            double expenses = decor + expensePerStatist;
            double leftMoney = budget - expenses;

            if (budget >= expenses)
            {
                //o	"Action!" 
                //  "Wingard starts filming with {останалите пари} leva left."
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");

            }
            else
            {
                //o	"Not enough money!"
                //o   "Wingard needs {парите недостигащи за филма} leva more."
                Console.WriteLine("Not enough money!");
                double neededMoney = expenses - budget;
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");


            }
        }
    }
}
