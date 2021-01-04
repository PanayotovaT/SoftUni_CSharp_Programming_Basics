using System;

namespace _07.Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int totalTicketsCount = 0;
            int kidTicketCount = 0;
            int studentTicketCount = 0;
            int standardTicketCount = 0;
            int seatsAvailable = 0;

            while (filmName != "Finish")
            {
                seatsAvailable = int.Parse(Console.ReadLine());

                string ticket = Console.ReadLine();

                int ticketCounter = 0;

                while (ticket != "End")
                {
                    ticketCounter++;
                    switch (ticket)
                    {
                        case "kid":
                            kidTicketCount++;
                            break;
                        case "student":
                            studentTicketCount++;
                            break;
                        case "standard":
                            standardTicketCount++;
                            break;
                    }


                    if (ticketCounter == seatsAvailable)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTicketsCount += ticketCounter;

                double seatsTaken = ticketCounter * 1.0 / seatsAvailable * 100;
                Console.WriteLine($"{filmName} - {seatsTaken:f2}% full.");



                filmName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketsCount}");

            double kidTicketPercent = kidTicketCount * 1.0 / totalTicketsCount * 100;
            double studentTicketPercent = studentTicketCount * 1.0 / totalTicketsCount * 100;
            double standardTicketPercemt = standardTicketCount * 1.0 / totalTicketsCount * 100;
            //o   "{процент на студентските билети}% student tickets."
            //o   "{процент на стандартните билети}% standard tickets."
            //o   "{процент на детските билети}% kids tickets."

            Console.WriteLine($"{studentTicketPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketPercemt:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercent:f2}% kids tickets.");


        }
    }
}
