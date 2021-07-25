using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2
            int number;
            int maxNumbers = 5;
            int max = 0, min = 10;
            string errorMessage = String.Empty;

            Console.WriteLine("Введите " + maxNumbers + "-ти значное число");
            bool succesNumber = Int32.TryParse(Console.ReadLine(), out number);
            if (!succesNumber)
            {
                errorMessage += "Wrong type input";
            }
            else
            {
                //for (int i = 0; i < 5; i++)
                //{
                //    double n = (int)(number / Math.Pow(10,i)) % 10;
                //    //number = number / 10;
                //    Console.WriteLine((i+1) + " цифра " + n);
                //}
                for (int i = 0; i < maxNumbers; i++)
                {
                    int curDigit = (int)(number / Math.Pow(10, (maxNumbers - 1) - i)) % 10;
                    if (max < curDigit)
                    {
                        max = curDigit;
                    }
                    if (min > curDigit)
                    {
                        min = curDigit;
                    }
                    Console.WriteLine((i + 1) + " цифра " + curDigit);
                }
                Console.WriteLine("maxDigit: " + max + " minDigit: " + min);
               
            }

            if (errorMessage.Length > 0)
            {
                Console.WriteLine(errorMessage);
                errorMessage = String.Empty;
            }

            //Calculator-----------------------------------------------------
            Console.WriteLine("Calculator");
            bool wrongInput = true;
            double number1 = 0, number2 = 0;
            double result = 0;


            while (wrongInput)
            {
                Console.Write("First: ");
                bool s1 = double.TryParse(Console.ReadLine(), out number1);

                Console.Write("Second: ");
                bool s2 = double.TryParse(Console.ReadLine(), out number2);
                wrongInput = !(s2 && s1);

                if (wrongInput)
                {
                    errorMessage += "Incorrect calculator input; ";
                    Console.WriteLine(errorMessage);
                    errorMessage = String.Empty;
                }
            }

            Console.Write("Operation: ");

            string op = Console.ReadLine();

            switch (op)
            {
                case "*":
                    result += number1 * number2;
                    break;
                case "+":
                    result += number1 + number2;
                    break;
                case "-":
                    result += number1 - number2;
                    break;
                case "/" when number2 != 0:
                    result += number1 / number2;
                    break;
                default:
                    errorMessage += "Incorrect calculator operation; ";
                    break;
            }

            if (errorMessage.Length > 0)
            {
                Console.WriteLine(result);
                Console.WriteLine(errorMessage);
                errorMessage = String.Empty;
            }
            else
            {
                Console.WriteLine("Result: " + result);
            }













            if (errorMessage == String.Empty)
            {
                Console.WriteLine("All done");
            }
            else
            {
                Console.WriteLine("Ошибки: " + errorMessage);
            }

        }
    }
}
