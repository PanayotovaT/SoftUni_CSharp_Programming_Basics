using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = 1;
            double sumGrades = 0;
            double averageGrade = 0;
           
            while(n <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade < 4)
                {
                    continue;
                }
                n++;

                sumGrades += grade;
                averageGrade = sumGrades / 12;


              
            }
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
