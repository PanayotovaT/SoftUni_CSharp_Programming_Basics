using System;

namespace _03.EnergicGels
{
    class Program
    {
        static void Main(string[] args)
        {


            string friut = Console.ReadLine();
            string options = Console.ReadLine();
            int orderedPackages = int.Parse(Console.ReadLine());
            double bill = 0;

             //                Диня             Манго           Ананас              Малина
            //2 броя(small)  56 лв./ бр.      36.66 лв./ бр.   42.10 лв./ бр.      20 лв./ бр.
            //5 броя(big)    28.70 лв./ бр.   19.60 лв./ бр.   24.80 лв./ бр.      15.20 лв./ бр.

            switch (friut)
            {
                case "Watermelon":

                    if(options == "small")
                    {
                        bill = 2 * orderedPackages * 56;
                    }
                    else if (options == "big")
                    {
                        bill = 5 * orderedPackages * 28.70;
                    }
                    break;


                case "Mango":

                    if(options == "small")
                    {
                        bill = 2 * orderedPackages * 36.66;
                    }
                    else if(options == "big")
                    {
                        bill = 5 * orderedPackages * 19.60;
                    }
                    break;

                case "Pineapple":

                    if(options == "small")
                    {
                        bill = 2 * orderedPackages * 42.10;
                    }
                    else if(options == "big")
                    {
                        bill = 5 * orderedPackages * 24.80;
                    }
                    break;

                case "Raspberry":

                    if(options == "small")
                    {
                        bill = 2 * orderedPackages * 20;
                    }
                    else if (options == "big")
                    {
                        bill = 5 * orderedPackages * 15.20;
                    }
                    break;
            }

            
            if (bill >= 400 && bill <= 1000)
            {
                bill = bill - 0.15 * bill;
            }
            else if (bill > 1000)
            {
                bill = bill - 0.50 * bill;
            }


            Console.WriteLine($"{bill:f2} lv.");


        }
    }
}
