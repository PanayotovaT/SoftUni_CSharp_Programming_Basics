﻿using System;

namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата съобщение от следния вид:
            //"You are <firstName> <lastName>, a <age>-years old person from <town>."
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age} years old person from {town}.");

        }
    }
}
