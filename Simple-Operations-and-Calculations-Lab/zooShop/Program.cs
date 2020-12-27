using System;

namespace Project_Creation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            double dogsExpense = dogs * 2.50;
            double otherAnimalsExpense = otherAnimals * 4;
            double expense = dogsExpense + otherAnimalsExpense;
            Console.WriteLine($"{Math.Round(expense, 3)} lv.");

        }
    }
}
