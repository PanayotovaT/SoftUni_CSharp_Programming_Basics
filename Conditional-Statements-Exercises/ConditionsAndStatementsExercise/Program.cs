using System;

namespace ConditionsAndStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = firstTime + secondTime + thirdtime;
            int timeInMinutes = totalTimeInSeconds / 60;
            int timeInSeconds = totalTimeInSeconds % 60;

            if (timeInSeconds < 10)
            {
                Console.WriteLine(timeInMinutes + ":0" + timeInSeconds);

            }
            else
            {
                Console.WriteLine(timeInMinutes + ":" + timeInSeconds);
            }
            //Console.WriteLine($"{timeInMinutes}:{timeInSeconds:D2}")
        }
    }
}
