using System;

namespace Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Възрастта на Лили - цяло число в интервала[1...77]
            //•	Цената на пералнята - 1

            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double giftMoney = 10;
            double toyMoney = 0;
            int toyNumber = 0;
            double totalMoney = 0;
            double moneyFromBirthday = 0;
            //За нечетните рождени дни(1, 3, 5...n) получава играчки, а за всеки четен(2, 4, 6...n) получава пари. За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден(2-> 10, 4-> 20, 6-> 30...и т.н.). През годините Лили тайно е спестявала парите.Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях.Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    moneyFromBirthday += giftMoney;
                    giftMoney += 10;
                    moneyFromBirthday--;
                    

                }
                else
                {
                    toyNumber++;
                    
                }

            }
            toyMoney = toyPrice * toyNumber;
            totalMoney = moneyFromBirthday + toyMoney;
            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - totalMoney:f2}");
            }
        }
    }
}
