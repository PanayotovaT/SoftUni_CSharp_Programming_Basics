using System;

namespace InterruptLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hour}:{minutes}");
                    if (hour == 2 && minutes == 37)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            //Друг начин за прекъсване
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hour}:{minutes}");
                    if (hour == 0 && minutes == 37)
                    {
                        return; //приключва цялата програма == environment.Exit(0);
                    }

                }
            }
        }


    }
}

