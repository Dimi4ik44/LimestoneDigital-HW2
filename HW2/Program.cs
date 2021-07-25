using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result;
            int maxNumbers = 5;
            string errorMessage = String.Empty;

            Console.WriteLine("Введите 5-ти значное число");
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
                    double n = (int)(number / Math.Pow(10, (maxNumbers-1)-i)) % 10;
                    Console.WriteLine((i + 1) + " цифра " + n);
                }
            }


            
        }
    }
}
