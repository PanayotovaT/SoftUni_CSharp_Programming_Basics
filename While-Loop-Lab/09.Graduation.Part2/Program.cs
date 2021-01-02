using System;

namespace _09.Graduation.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double averageGrade = 0;
            int classN = 1;
            int counter = 1;
            double sumGrade = 0;
            while(classN <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if (grade < 4 && counter < 2)
                {
                    counter++;
                    continue;
                }
                else if (grade < 4 && counter == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {classN} grade");
                    break;
                }
                classN++;
                
                sumGrade += grade;
            }

            if (counter != 2)
            {
                averageGrade = sumGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }


        }
    }
}
