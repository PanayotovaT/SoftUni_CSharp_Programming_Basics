using System;

namespace _04.Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;


            for (int x = startNum; x <= endNum; x++)
            {
                int sum = 0;
                for (int y = startNum; y <= endNum; y++)
                {
                    sum = x + y;
                    counter++;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicNum})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");

        }
    }
}
