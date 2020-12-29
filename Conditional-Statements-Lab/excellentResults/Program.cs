using System;

namespace Proverki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine( a < b);
            Console.WriteLine(a > 0);
            Console.WriteLine(a > 100);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= 5);
            Console.WriteLine(b == 2 * a);

            int age = int.Parse(Console.ReadLine());
            if(age >=18)
            {
                Console.WriteLine("You may drive a car!");
            }

            double grade = double.Parse(Console.ReadLine());

            if(grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            
            }
            else
            {
                Console.WriteLine("Not Excellent");
            }

        }
    }
}
