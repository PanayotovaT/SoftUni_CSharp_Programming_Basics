using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // •На първи ред - брой незадоволителни оценки -цяло число в интервала[1…5]
            //•	След това многократно се четат по два реда:
            //o Име на задача -текст(низ)
            //o Оценка -цяло число в интервала[2…6]
            int poorExerciseNumber = int.Parse(Console.ReadLine());
            int gradeSum = 0;
            int failedENumber = 0;
            int countExercise = 0;
            int grade = 0;
            string lastExerciseName = "";
            string exerciseName = "";

            while (failedENumber < poorExerciseNumber)
            {
                exerciseName = Console.ReadLine();
                if (exerciseName == "Enough")
                {
                    break;
                }
                else if (exerciseName != "Enough")
                {
                    grade = int.Parse(Console.ReadLine());
                    countExercise++;
                    gradeSum += grade;
                    lastExerciseName = exerciseName;
                }

                if (grade <= 4)
                {
                    failedENumber++;
                    
                    
                   
                }

            }
            if (exerciseName == "Enough")
            {
                double averageScore = gradeSum * 1.0 / countExercise;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {countExercise}");
                Console.WriteLine($"Last problem: {lastExerciseName}");

            }
            else if (failedENumber >= poorExerciseNumber)
            {
                Console.WriteLine($"You need a break, {failedENumber} poor grades.");
            }

        }
    }
}
