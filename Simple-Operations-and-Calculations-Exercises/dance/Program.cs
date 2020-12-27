using System;

namespace Dance
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	L – дължина на залата в метри – реално число в интервала  [10.00 … 100.00]
            //2.	W – ширина на залата в метри – реално число в интервала  [10.00 … 100.00]
            //3.	А – страна на гардероба в метри – реално число в интервала [2.00… 20.00]
            //един танцьор е 40 см² и допълнително за свободно движение му трябват  още  7000см². 

            double lengthHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());
            double sideWardrobe = double.Parse(Console.ReadLine());
            double areaPerson = 7040;

            double fullAreaHall = lengthHall * 100 * widthHall * 100;
            double benchArea = fullAreaHall / 10;
            double areaWardrobe = sideWardrobe * 100 * sideWardrobe * 100;

            double freeAreaHall = fullAreaHall - benchArea - areaWardrobe;

            double capacityPeople = freeAreaHall / areaPerson;

            Console.WriteLine(Math.Floor(capacityPeople));


        }
    }
}
