using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            //if (weather == "cloudy")
            //{
            //    Console.WriteLine("Take an umbrella");

            //}
            //else if (weather == "sunny")
            //{
            //    Console.WriteLine("Go out for a walk");
            //}
            //else if (weather == "windy")
            //{
            //    Console.WriteLine("Take a jacket");
            //}
            //else if (weather == "snowy")
            //{
            //    Console.WriteLine("Go skiing.");
            //}
            //else if (weather == "rainy")
            //{
            //    Console.WriteLine("Take an umbrella");
            //}

            switch (weather)
            {
                case "cloudy":
                    Console.WriteLine("Take an umbrella");
                    break;
                case "sunny":
                    Console.WriteLine("Go out for a walk");
                    break;
                case "windy":
                    Console.WriteLine("Take a jacket");
                    break;
                case "snowy":
                    Console.WriteLine("Go skiing.");
                    break;
                case "rainy":
                    Console.WriteLine("Take an umbrella");
                    break;
                default:
                    Console.WriteLine("No data available.");
                    break;
            }
        }
    }
}
