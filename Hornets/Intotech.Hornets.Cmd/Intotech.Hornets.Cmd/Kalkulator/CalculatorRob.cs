using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Kalkulator
{
    public static class CalculatorRob
    {
        public static void GetUserData()
        {
            Console.WriteLine("Project Calculator 1.0");
            Console.WriteLine("Created by Rob");
            Console.WriteLine("\n Podaj działanie:");

            var userInput = Console.ReadLine();

            MathsFromData(userInput);
        }

        public static void MathsFromData(string dataCandidate)
        {
            List<char> listOperators = new List<char>()
            {
                '+',
                '-',
                '*',
                '/',
            };

            List<string> numbers = new List<string>()
            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
            };

            int length = dataCandidate.Length; 
            string result = string.Empty;

            for (int i = 0; i < length; i++)
            {
                if (listOperators.Contains(dataCandidate[i])) 
                {
                    string firstNumber = dataCandidate.Substring(0, i);
                    string mathOperator = dataCandidate[i].ToString();
                    string secondNumber = dataCandidate.Substring(i + 1, length - (i + 1));
                    int firstNum = 0;
                    int secondNum = 0;
                    int.TryParse(firstNumber, out firstNum);
                    int.TryParse(secondNumber, out secondNum);

                    Calculate(firstNum, secondNum, mathOperator);
                }
            }    
        }

        public static void Calculate(int firstNumber, int secondNumber, string mathOperator)
        {
            int result = 0;
            switch (mathOperator)
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
            Console.WriteLine(result);
        }
    }
}
