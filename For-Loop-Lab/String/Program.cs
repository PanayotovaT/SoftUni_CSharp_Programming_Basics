using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Teodora&Alex";
            Console.WriteLine(name.Length);


            string nome = "Sofia";
            Console.WriteLine("My name is {0}",nome);


            string prenom = "Alexander";
                           //012345678
            Console.WriteLine(prenom[3]);


            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine(prenom[i]);
            }
            
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }



        }
    }
}
