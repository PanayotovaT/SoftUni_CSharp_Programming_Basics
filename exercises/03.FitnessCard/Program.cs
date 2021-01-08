using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double money = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double card = 0;

            //Пол     Gym     Boxing    Yoga    Zumba   Dances  Pilates
            //мъж	  $42     $41       $45     $34     $51     $39
            //жена    $35     $37       $42     $31     $53     $37

            switch (sport)
            {
                case "Gym":
                    if(gender == 'm')
                    {
                        card = 42;
                    }
                    else if (gender == 'f')
                    {
                        card = 35;
                    }
                    break;
                case "Boxing":

                    if(gender == 'm')
                    {
                        card = 41;
                    }
                    else if (gender == 'f')
                    {
                        card = 37;
                    }
                    break;
                case "Yoga":

                    if(gender == 'm')
                    {
                        card = 45;
                    }
                    else if (gender == 'f')
                    {
                        card = 42;
                    }
                    break;
                case "Zumba":

                    if(gender == 'm')
                    {
                        card = 34;
                    }
                    else if (gender == 'f')
                    {
                        card = 31;
                    }
                    break;
                case "Dances":

                    if(gender == 'm')
                    {
                        card = 51;
                    }
                    else if (gender == 'f')
                    {
                        card = 53;
                    }
                    break;
                case "Pilates":

                    if(gender == 'm')
                    {
                        card = 39;
                    }
                    else if (gender == 'f')
                    {
                        card = 37;
                    }
                    break;
            }

            if (age <= 19)
            {
                card = card - 0.20 * card;
            }

            if( card <= money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (card > money)
            {
                Console.WriteLine($"You don't have enough money! You need ${(card - money):f2} more.");
            }
        }
    }
}
