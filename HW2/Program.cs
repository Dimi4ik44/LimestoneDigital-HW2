using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2
            int number, result;
            int maxNumbers = 5;
            int max = 0, min = 10;
            string errorMessage = String.Empty;

            Console.WriteLine("Введите " + maxNumbers + "-ти значное число");
            bool succesNumber = Int32.TryParse(Console.ReadLine(),out number);
            if(!succesNumber)
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
                    int curDigit = (int)(number / Math.Pow(10, (maxNumbers-1)-i)) % 10;
                    if(max < curDigit)
                    {
                        max = curDigit;
                    }
                    if(min > curDigit)
                    {
                        min = curDigit;
                    }
                    Console.WriteLine((i + 1) + " цифра " + curDigit);
                }
                Console.WriteLine("maxDigit: " + max + " minDigit: " + min);
            }
            if(errorMessage==String.Empty)
            {
                Console.WriteLine("Ошибки: All done");
            }
            else
            {
                Console.WriteLine("Ошибки: " + errorMessage);
            }


            
        }
    }
}
