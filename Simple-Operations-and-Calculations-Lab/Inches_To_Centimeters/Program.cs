using System;

namespace Inches_To_Centimeters1
{
    class Program
    {
        static void Main(string[] args)
        {
            //която чете от конзолата число (не непременно цяло) и преобразува числото от инчове в сантиметри.
            //За целта умножава инчовете по 2.54 
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
