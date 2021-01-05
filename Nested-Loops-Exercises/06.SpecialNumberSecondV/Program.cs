using System;

namespace _06.SpecialNumberSecondV
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int thousands = 1; thousands <= 9; thousands++)
            {
                for (int hundreds = 1; hundreds < = 9; hundreds++)
                {
                    for (int tens = 1; tens <= 9; tens++)
                    {
                        for (int units = 1; units <= 9; units++)
                        {
                            bool check1 = thousands !=0 && n % thousands == 0;
                            bool check2 = hundreds != 0 && n % hundreds == 0;
                            bool check3 = tens != 0 && n % tens == 0;
                            bool check4 = units != 0 && n % units == 0;

                            if (check1 && check2 && check3 && check4)
                            {
                                Console.WriteLine($"{thousands}{hundreds}{tens}{units} ");
                            }


                        }
                    }
                }

            }
            
        }
    }
}
