using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {


            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examMinutes = examHour * 60 + examMinute;
            int arriveMinutes = arriveHour * 60 + arriveMinute;

            //•	“Late”, ако студентът пристига по-късно от часа на изпита.
            if (arriveMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                // “mm minutes after the start” за закъснение под час.
                //•	“hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.
                int late = arriveMinutes - examMinutes;
                if(late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else if (late >= 60)
                {
                    int lateHour = late / 60;
                    int lateMinute = late % 60;
                    Console.WriteLine($"{lateHour}:{lateMinute:d2} hours after the start");
                }
            }


            //•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            else if (arriveMinutes == examMinutes || examMinutes - arriveMinutes <= 30)
            {
                Console.WriteLine("On time");
                int diff = examMinutes - arriveMinutes;
                if (diff > 0)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }


            //•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            else if (examMinutes - arriveMinutes > 30)
            {
                Console.WriteLine("Early");
                //Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
                //•	“mm minutes before the start” за идване по - рано с по-малко от час.
                //•	“hh: mm hours before the start” за подраняване с 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:05”.
                int early = examMinutes - arriveMinutes;
                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
                else if (early >= 60)
                {
                    int earlyHour = early / 60;
                    int earlyMinute = early % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinute:d2} hours before the start");
                }
            }


        }
    }
}
