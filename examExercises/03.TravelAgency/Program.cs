using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Име на града -текст с възможности("Bansko",  "Borovets", "Varna" или "Burgas")
            //2.Вид на пакета -текст с възможности("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")
            //3.Притежание на VIP отстъпка - текст с възможности  "yes" или "no"
            //4.Дни за престой -цяло число в интервала[1 … 10000]

            string city = Console.ReadLine();
            string packageType = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double price = 0;

            //       Банско/ Боровец                           Варна / Бургас

            //    с екипировка    без екипировка          със закуска без закуска

            //цена за ден   100лв.           80лв                    130лв.      100лв.
            //VIP отстъпка   10 %            5 %                     12 %        7 %

            switch (city)
            {
                case "Bansko":
                case "Borovets":
                    if (packageType == "noEquipment")
                    {
                        price = 80 * numberOfNights;
                        if (vipDiscount == "yes")
                        {
                            price -= 0.05 * price;
                        }
                        if(numberOfNights > 7)
                        {
                            price -= 80;
                        }
                    }
                    else if (packageType == "withEquipment")
                    {
                        price = 100 * numberOfNights;
                        if(vipDiscount == "yes")
                        {
                            price -= 0.10 * price;
                        }
                        if(numberOfNights > 7)
                        {
                            price -= 100;
                        }
                    }
                    break;
                case "Varna":
                case "Burgas":
                    if (packageType == "noBreakfast")
                    {
                        price = 100 * numberOfNights;
                        if(vipDiscount == "yes")
                        {
                            price -= 0.07 * price;
                        }
                        if(numberOfNights > 7)
                        {
                            price -= 100;
                        }
                    }
                    else if (packageType == "withBreakfast")
                    {
                        price = 130 * numberOfNights;
                        if(vipDiscount == "yes")
                        {
                            price -= 0.12 * price;
                        }
                        if(numberOfNights > 7)
                        {
                            price -= 130;
                        }
                    }

                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }
            if (numberOfNights < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (packageType != "noEquipment" && packageType != "withEquipment" && packageType != "noBreakfast" && packageType != "withBreakfast" )
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
        }
    }
}
