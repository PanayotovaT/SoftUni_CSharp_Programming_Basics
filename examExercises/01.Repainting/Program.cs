using System;

namespace examJuly2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Предпазен найлон -1.50 лв.за кв.м.
            //•	Боя - 14.50 лв.за литър
            //•	Разредител за боя - 5.00 лв.за литър
            //, която се заплаща на майсторите за 1 час работа, е равна на 30% от сбора на всички разходи за материали.

            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double expenseNylon = 1.50 * nylon + 2 * 1.50;
            double expensePaint = 14.50 * paint + 0.10 * paint * 14.50;
            double expenseDiluent = 5 * diluent;
            double expenseBags = 0.40;
            double expenseMaterials = expenseNylon + expensePaint + expenseDiluent + expenseBags;
            double expenseWorkers = 0.30 * expenseMaterials * hours;
            double allExpenses = expenseMaterials + expenseWorkers;


            allExpenses = Math.Round(allExpenses, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Total expenses: {allExpenses} lv.");
            
            

            
        }
    }
}
