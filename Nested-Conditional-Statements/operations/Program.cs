using System;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	N1 – цяло число в интервала[0...40 000]
            //•	N2 – цяло число в интервала[0...40 000]
            //•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            //•	Ако операцията е събиране, изваждане или умножение:
            //o    "{N1} {оператор} {N2} = {резултат} – {even/odd}"
            //•	Ако операцията е деление:
            //o   "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
            //•	Ако операцията е модулно деление:
            //            o   "{N1} % {N2} = {остатък}"
            //•	В случай на деление с 0(нула): 
            //o   "Cannot divide {N1} by zero"

            switch (operation)
            {
                case '+':
                    {
                        int sum = number1 + number2;
                        if (sum % 2 == 0)
                        {
                            Console.WriteLine($"{number1} + {number2} = {sum} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{number1} + {number2} = {sum} - odd");
                        }
                    }
                    break;
                case '-':
                    {
                        int diff = number1 - number2;
                        if (diff % 2 == 0)
                        {
                            Console.WriteLine($"{number1} - {number2} = {diff} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{number1} - {number2} = {diff} - odd");
                        }
                    }
                    break;
                case '*':
                    {
                        int multiply = number1 * number2;
                        if (multiply % 2 == 0)
                        {
                            Console.WriteLine($"{number1} * {number2} = {multiply} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{number1} * {number2} = {multiply} - odd");
                        }
                    }
                    break;
                case '/':
                    {
                        double division = number1 * 1.0 / number2;

                        if (number2 == 0)
                        {
                            Console.WriteLine($"Cannot divide {number1} by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{number1} / {number2} = {division:f2}");
                        }

                    }
                    break;
                case '%':
                    {
                        

                        if (number2 == 0)
                        {
                            Console.WriteLine($"Cannot divide {number1} by zero");
                        }

                        else
                        {
                            int result = number1 % number2;
                            Console.WriteLine($"{number1} % {number2} = {result}");
                        }
                    }
                    break;

            }

        }
    }
}
