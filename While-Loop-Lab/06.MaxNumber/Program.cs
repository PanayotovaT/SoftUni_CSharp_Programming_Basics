using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int maxNum = int.MinValue;
            
            while (i <= n)
            {
                int number = int.Parse(Console.ReadLine());
                i++;
                
                
                if(number > maxNum)
                {
                    maxNum = number;
                }



            }
            Console.WriteLine(maxNum);
        }
    }
}
