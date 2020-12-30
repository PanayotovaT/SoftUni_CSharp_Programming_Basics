using System;

namespace _10.EvenAndOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            //чете n-на брой цели числа, подадени от потребителя, и проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. 

            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }


            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sumEven - sumOdd));

            }
        }
    }
}
