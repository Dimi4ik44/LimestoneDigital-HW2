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
            double number1 = new Double(), number2 = 0;
            double result = 0;
            int switcher = 1;
            bool exit = false;

            while(!exit)
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
                                    errorMessage += "Incorrect calculator input; ";
                                    Console.WriteLine(errorMessage);
                                    errorMessage = String.Empty;
                                }
                            }
                            wrongInput = true;
                            Console.WriteLine("Operation list: \n'+' \n'-' \n'*' \n'/' \n'^'-pow");
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

                            Console.WriteLine("Select next task: \n Write '1' for new calculate \n Write '2' for EXIT \n Write '3' for continue calculate \n Write '4' for Sqrt");
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            if(!s3)
                            {
                                Console.WriteLine("Wrong select! Selected EXIT");
                                switcher = 2;
                            }


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
                                    errorMessage += "Incorrect calculator input; ";
                                    Console.WriteLine(errorMessage);
                                    errorMessage = String.Empty;
                                }
                            }
                            wrongInput = true;
                            Console.WriteLine("Operation list: \n'+' \n'-' \n'*' \n'/' \n'^'-pow");
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

                            Console.WriteLine("Select next task: \n Write '1' for new calculate \n Write '2' for EXIT \n Write '3' for continue calculate \n Write '4' for Sqrt");
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            if (!s3)
                            {
                                Console.WriteLine("Wrong select! Selected EXIT");
                                switcher = 2;
                            }

                            break;
                            //continue
                        }
                    case 4:
                        {
                            result = Math.Sqrt(result);
                            Console.WriteLine("Result: " + result);

                            Console.WriteLine("Select next task: \n Write '1' for new calculate \n Write '2' for EXIT \n Write '3' for continue calculate \n Write '4' for Sqrt");
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            if (!s3)
                            {
                                Console.WriteLine("Wrong select! Selected EXIT");
                                switcher = 2;
                            }
                            break;
                            //sqrt
                        }
                    default:
                        {
                            Console.WriteLine("Sorry but it's not predicted please select another!");
                           // Console.WriteLine("Select next task: /n Write '1' to new calculate /n Write '2' to EXIT /n Write '3' to continue calculate");
                            bool s3 = int.TryParse(Console.ReadLine(), out switcher);
                            if (!s3)
                            {
                                Console.WriteLine("Wrong select! Selected EXIT");
                                switcher = 2;
                            }
                            break;
                        }
                }
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
