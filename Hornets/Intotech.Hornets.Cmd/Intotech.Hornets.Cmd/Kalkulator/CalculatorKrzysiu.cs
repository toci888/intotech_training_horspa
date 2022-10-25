using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Kalkulator
{
    public static class CalculatorKrzysiu
    {
        public static void GiveMathOperation()
        {
            Console.WriteLine("Podaj działanie:");
            string userInput = Console.ReadLine();

            CheckingChars(userInput);
        }

        public static void CheckingChars(string userInput)
        {
            Console.WriteLine("-------");
            // pomocnicze zmienne tablicowe
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] charsOperator = { '+', '-', '*', '/' };
            // pomocnicze zmienne do obliczania
            string firstNumber = string.Empty;
            string secondNumber = string.Empty;
            string charOperator = string.Empty;
            bool checker = true;

            foreach (char c in userInput)
            {
                if (checker)
                {
                    //jeżeli prawda to pierwsza liczba
                    if (numbers.Contains(c))
                    {
                        firstNumber += c.ToString();
                    }
                    else if (charsOperator.Contains(c))
                    {
                        charOperator = c.ToString();
                        checker = false;
                    }
                }
                else
                {
                    // jeżeli fałsz druga liczba
                    if (numbers.Contains(c))
                    {
                        secondNumber += c.ToString();
                    }
                }
            }

            string[] result = { firstNumber, charOperator, secondNumber };
            Calcualte(result);
        }

        public static void Calcualte(string[] canditate)
        {
            int first = int.Parse(canditate[0]);
            int second = int.Parse(canditate[2]);

            if (canditate[1] == "+")
            {
                Console.WriteLine($"{first} {canditate[1]} {second} = {first + second}");
            }
            if (canditate[1] == "-")
            {
                Console.WriteLine($"{first} {canditate[1]} {second} = {first - second}");
            }
            if (canditate[1] == "*")
            {
                Console.WriteLine($"{first} {canditate[1]} {second} = {first * second}");
            }
            if (canditate[1] == "/")
            {
                Console.WriteLine($"{first} {canditate[1]} {second} = {first / second}");
            }
        }
    }
}
