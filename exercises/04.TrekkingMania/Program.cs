using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int groupNumber = int.Parse(Console.ReadLine());
            int peopleMusala = 0;
            int peopleMonblan = 0;
            int peopleKilimandjaro = 0;
            int peopleK2 = 0;
            int peopleEverest = 0;
            int allPeople = 0;

            for (int countGroup = 1; countGroup <= groupNumber; countGroup++)
            {
                int PeopleInGroup = int.Parse(Console.ReadLine());
                allPeople += PeopleInGroup;

               
                if (PeopleInGroup <= 5)
                {
                    peopleMusala += PeopleInGroup;
                }
                else if (PeopleInGroup >= 6 && PeopleInGroup <= 12)
                {
                    peopleMonblan += PeopleInGroup;
                }
                else if (PeopleInGroup >= 13 && PeopleInGroup <= 25)
                {
                    peopleKilimandjaro += PeopleInGroup;
                }
                else if (PeopleInGroup >= 26 && PeopleInGroup <= 40)
                {
                    peopleK2 += PeopleInGroup;
                }
                else if (PeopleInGroup >= 41)
                {
                    peopleEverest += PeopleInGroup;
                }

            }
            double percentMusala = peopleMusala * 1.0 / allPeople * 100;
            double percentMonblan = peopleMonblan * 1.0 / allPeople * 100;
            double percentKilimandjaro = peopleKilimandjaro * 1.0 / allPeople * 100;
            double percentK2 = peopleK2 * 1.0 / allPeople * 100;
            double percentEverest = peopleEverest * 1.0 / allPeople * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
           


        }
    }
}
