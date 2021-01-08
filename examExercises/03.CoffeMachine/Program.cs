using System;

namespace _03.CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {


            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            //           Без захар              Нормално                Допълнително захар
            //Еспресо     0.90 лв./ бр.         1 лв. / бр.             1.20 лв. / бр.
            //Капучино    1.00 лв. / бр.        1.20 лв. / бр.          1.60 лв. / бр.
            //Чай         0.50 лв. / бр.        0.60 лв. / бр.          0.70 лв. / бр.

            double expense = 0;

            switch (drink)
            {
                case "Espresso":


                    if (sugar == "Without")
                    {
                        expense = 0.90 * numberOfDrinks;
                        expense -= 0.35 * expense;
                    }
                    else if(sugar == "Normal")
                    {
                        expense = 1.0 * numberOfDrinks;

                    }
                    else if (sugar == "Extra")
                    {
                        expense = 1.20 * numberOfDrinks;
                    }
                    if (numberOfDrinks >= 5)
                    {
                        expense -= 0.25 * expense;
                    }
                    break;
                case "Cappuccino":

                    if (sugar == "Without")
                    {
                        expense = 1.00 * numberOfDrinks;
                        expense -= 0.35 * expense;
                    }
                    else if(sugar == "Normal")
                    {
                        expense = 1.20 * numberOfDrinks;
                    }
                    else if(sugar == "Extra")
                    {
                        expense = 1.60 * numberOfDrinks;
                    }
                    break;
                case "Tea":
                    
                    if (sugar == "Without")
                    {
                        expense = 0.50 * numberOfDrinks;
                        expense -= 0.35 * expense;
                    }
                    else if(sugar == "Normal")
                    {
                        expense = 0.60 * numberOfDrinks;
                    }
                    else if(sugar == "Extra")
                    {
                        expense = 0.70 * numberOfDrinks;
                    }

                    break;
            }

            if (expense > 15)
            {
                expense -= 0.20 * expense;
            }

            Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {expense:f2} lv.");

        }
    }
}
