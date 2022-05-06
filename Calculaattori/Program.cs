using System;

namespace Calculaattori
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string headertext = @"
  _____      _            _       _             
 / ____|    | |          | |     | |            
| |     __ _| | ___ _   _| | __ _| |_ ___  _ __ 
| |    / _` | |/ __| | | | |/ _` | __/ _ \| '__|
| |___| (_| | | (__| |_| | | (_| | || (_) | |   
 \_____\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|   
            ";

            
            Console.WriteLine(headertext);
            Console.WriteLine("======================================================");

            Console.WriteLine("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation (+, -, *, /): ");
            string operation = Console.ReadLine();
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            Console.WriteLine($"Result: {result}");
            
            if (result % 2 == 0)
            {
                Console.WriteLine("Result is even.");
            }
            else
            {
                Console.WriteLine("Result is odd.");
            }

        }
    }
}