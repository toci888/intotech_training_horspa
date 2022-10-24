using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Kalkulator
{
    public static class CalculatorKrzysiu
    {
        public static void Calculate()
        {
            Console.WriteLine("Podaj działanie:");
            string userInput = Console.ReadLine();

            //wyciągnięcie liczb od stringa użytkownika
            string[] numbers = userInput.Split(' ');
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[2]);

            Console.WriteLine("-------");

            if (numbers[1] == "+")
            {
                Console.WriteLine($"{first} {numbers[1]} {second} = {first + second}");
            }
            if (numbers[1] == "-")
            {
                Console.WriteLine($"{first} {numbers[1]} {second} = {first - second}");
            }
            if (numbers[1] == "*")
            {
                Console.WriteLine($"{first} {numbers[1]} {second} = {first * second}");
            }
            if (numbers[1] == "/")
            {
                Console.WriteLine($"{first} {numbers[1]} {second} = {first / second}");
            }

            Console.WriteLine("-------");
        }
    }
}
