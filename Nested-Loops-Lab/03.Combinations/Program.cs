using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която изчислява колко решения в естествените числа(включително и нулата) има уравнението:
            //x1 + x2 + x3 = n
            int n = int.Parse(Console.ReadLine());
            int countInteractions = 0;
            int sum = 0;

            for(int x1 = 0; x1 <= n; x1++)
            {
                for(int x2 = 0; x2 <= n; x2++)
                {
                    for (int x3 = 0; x3 <= n; x3++)
                    {
                        sum = x1 + x2 + x3;
                        if (sum == n)
                        {
                            countInteractions++;
                        }
                    }
                }
            }
            Console.WriteLine(countInteractions);
        }
    }
}
