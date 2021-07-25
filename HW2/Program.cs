using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] errorMessageList = new string[10];
            errorMessageList[0] = "Incorrect calculator input ";
            errorMessageList[1] = "Incorrect input ";
            errorMessageList[2] = "Incorrect calculator operation ";
            //1,2
            int number;
            int maxNumbers = 5;
            int max = 0, min = 10;
            string errorMessage = String.Empty;

            Console.WriteLine("Введите " + maxNumbers + "-ти значное число");
            bool succesNumber = Int32.TryParse(Console.ReadLine(), out number);
            if (!succesNumber)
            {
                errorMessage += errorMessageList[1];
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
            double number1 = new Double(), number2 = 0;
            double result = 0;
            int switcher = 1;
            bool exit = false;
            string opList = "Operation list: \n'+' \n'-' \n'*' \n'/' \n'^'-pow";
            string menu = "Select next task: \n Write '1' for new calculate \n Write '2' for EXIT \n Write '3' for continue calculate \n Write '4' for Sqrt";

            while (!exit)
            {
                switch (switcher)
                {
                    case 1:
                        {
                            while (wrongInput)
                            {
                                
                                Console.Write("First: ");
                                bool s1 = double.TryParse(Console.ReadLine(), out number1);

                                Console.Write("Second: ");
                                bool s2 = double.TryParse(Console.ReadLine(), out number2);
                                wrongInput = !(s2 && s1);

                                if (wrongInput)
                                {
                                    Console.WriteLine(errorMessageList[0]);
                                }
                            }
                            wrongInput = true;
                            Console.WriteLine(opList);
                            Console.Write("Operation: ");

                            string op = Console.ReadLine();

                            switch (op)
                            {
                                case "*":
                                    result = number1 * number2;
                                    break;
                                case "+":
                                    result = number1 + number2;
                                    break;
                                case "-":
                                    result = number1 - number2;
                                    break;
                                case "/" when number2 != 0:
                                    result = number1 / number2;
                                    break;
                                case "^":
                                    result = Math.Pow(number1,number2);
                                    break;
                                default:
                                    errorMessage += errorMessageList[2];
                                    break;
                            }

                            if (errorMessage.Length > 0)
                            {
                                Console.WriteLine(errorMessage);
                                errorMessage = String.Empty;
                            }
                            else
                            {
                                Console.WriteLine("Result: " + result);
                            }

                            Console.WriteLine(menu);
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            break;
                            //new
                        }
                    case 2:
                        {
                            exit = true;
                            break;
                            //exit
                        }
                    case 3:
                        {
                            while (wrongInput)
                            {
                                number1 = result;
                                Console.Write("Second: ");
                                bool s2 = double.TryParse(Console.ReadLine(), out number2);
                                wrongInput = !(s2);

                                if (wrongInput)
                                {
                                    Console.WriteLine(errorMessageList[0]);
                                }
                            }
                            wrongInput = true;
                            Console.WriteLine(opList);
                            Console.Write("Operation: ");

                            string op = Console.ReadLine();

                            switch (op)
                            {
                                case "*":
                                    result = number1 * number2;
                                    break;
                                case "+":
                                    result = number1 + number2;
                                    break;
                                case "-":
                                    result = number1 - number2;
                                    break;
                                case "/" when number2 != 0:
                                    result = number1 / number2;
                                    break;
                                case "^":
                                    result = Math.Pow(number1, number2);
                                    break;
                                default:
                                    errorMessage += errorMessageList[2];
                                    break;
                            }

                            if (errorMessage.Length > 0)
                            {
                                Console.WriteLine(errorMessage);
                                errorMessage = String.Empty;
                            }
                            else
                            {
                                Console.WriteLine("Result: " + result);
                            }

                            Console.WriteLine(menu);
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            break;
                            //continue
                        }
                    case 4:
                        {
                            result = Math.Sqrt(result);
                            Console.WriteLine("Result: " + result);

                            Console.WriteLine(menu);
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            break;
                            //sqrt
                        }
                    default:
                        {
                            Console.WriteLine("Sorry but it's not predicted please select another!");
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            break;
                        }
                }
            }

            if (errorMessage == String.Empty)
            {
                Console.WriteLine("Good Luck ;)");
            }
            else
            {
                Console.WriteLine("Ошибки: " + errorMessage);
            }

        }
    }
}
