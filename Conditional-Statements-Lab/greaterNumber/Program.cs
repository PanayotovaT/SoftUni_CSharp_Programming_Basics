using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // CTRL + K + C --comment a code
            // CTRL+ K + U -- uncomment a code
            // CTRL + K + D --format a code

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The greater number is {num1}");
            }
            else if (num1 == num2){
                Console.WriteLine("They are equal");

            }
            else
            {
                Console.WriteLine($"The greater number is {num2}");
            }



        }
    }
}
