using System;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = AddNumber(firstNumber, secondNumber);

            Console.WriteLine("Do you want to see the avarage?For YES press 1. For NO press 0");
            int res = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum is:" + (sum));
            if (res == 1)
            {
                float avg = Avarage(firstNumber, secondNumber);
                Console.WriteLine("The Avarage is:" + (avg));
            }
            else{
                Console.WriteLine("Thank You.");
            }
        }
        static int AddNumber(int firstNumber,int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        static float Avarage(int firstNumber, int secondNumber)
        {
            float avarage = ((firstNumber + secondNumber) / 2);
            return avarage;
        }
    }
}
