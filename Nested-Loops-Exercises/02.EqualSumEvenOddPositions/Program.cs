using System;

namespace _02.EqualSumEvenOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int position = 0; position < currentNum.Length; position++)
                {
                    int currentDigit = int.Parse(currentNum[position].ToString());
                    if (position % 2 == 0)
                        evenSum += currentDigit;
                    else
                    {
                        oddSum += currentDigit;
                    }
                }

                if(oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
