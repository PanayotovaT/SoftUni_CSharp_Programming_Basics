using System;

namespace _06.Buliding
{
    class Program
    {
        static void Main(string[] args)
        {
            int etageNum = int.Parse(Console.ReadLine());
            int roomsNum = int.Parse(Console.ReadLine());

            for (int n = etageNum; n >= 1; n--)
            {
                string roomN = "";
                for (int j = 0; j < roomsNum; j++)
                {
                    if (n == etageNum)
                    {
                        roomN += String.Format($"L{n}{j} ");
                        
                    }
                    else
                    {
                        if (n % 2 == 0)
                        {
                            roomN += String.Format($"O{n}{j} ");
                        }
                        else
                        {
                            roomN += String.Format($"A{n}{j} ");
                        }
                    }
                }
               Console.WriteLine(roomN);
            }
        }
    }
}
