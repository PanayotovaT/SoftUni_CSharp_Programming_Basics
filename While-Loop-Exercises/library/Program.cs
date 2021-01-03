using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBookTitle = Console.ReadLine();
            int totalBooks = int.Parse(Console.ReadLine());

            int checkedBooks = 0;

            while( totalBooks > 0)

            {
                string bookTitle = Console.ReadLine();

                if (bookTitle == searchedBookTitle)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                else
                {
                    checkedBooks++;
                }
                totalBooks--;

            }
            if(totalBooks <=0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
