using System;
using System.Globalization;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //• На първия ред е месецът – May, June, July, August, September или October
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double appartmentprice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                appartmentprice = nights * 65;
                
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = 0.95 * studioPrice;
                    
                }
                else if (nights > 14)
                {
                    studioPrice = 0.70 * studioPrice;
                    appartmentprice = 0.90 * appartmentprice;
                }
            }

            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                appartmentprice = nights * 68.70;

                if (nights > 14)
                {
                    studioPrice = 0.80 * studioPrice;
                    appartmentprice = 0.90 * appartmentprice;
                }

            }

            else if (month == "July" || month == "August")
            {
                studioPrice = nights * 76;
                appartmentprice = nights * 77; 

                if (nights > 14)
                    {
                        appartmentprice = 0.90 * appartmentprice;
                    }
            }

            Console.WriteLine($"Apartment: {appartmentprice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
