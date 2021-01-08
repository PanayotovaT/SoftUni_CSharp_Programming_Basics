using System;

namespace _06.Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countWinDays = 0;
            int countLoseDays = 0;
            double totalWin = 0;
            for (int i = 1; i <= days; i++)
            {
                double gameWin = 0;
                int countWin = 0;
                int countLost = 0;

                string sport = Console.ReadLine();
                string result = Console.ReadLine();
                while (sport != "Finish")
                {
                    if (result == "win")
                    {
                        gameWin += 20;
                        countWin++;

                    }
                    else if (result == "lose")
                    {
                        countLost++;
                    }

                    sport = Console.ReadLine();
                    if (sport != "Finish")
                          { result = Console.ReadLine(); }
                }
                if (countWin > countLost)
                {
                    gameWin += 0.10 * gameWin;
                    countWinDays++;
                }
                else if (countWin < countLost)
                {
                    countLoseDays++;
                }
                totalWin += gameWin;
            }
            if (countWinDays > countLoseDays)
            {
                totalWin += 0.20 * totalWin;
                Console.WriteLine($"You won the tournament! Total raised money: {totalWin:f2}");
            }
            else if (countWinDays < countLoseDays)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalWin:f2}");
            }
        }
    }
}
