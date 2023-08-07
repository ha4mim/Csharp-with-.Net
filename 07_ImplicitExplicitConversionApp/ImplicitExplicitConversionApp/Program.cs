using System;

namespace ImplicitExplicitConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            long BigNumber = number;//Implicit Conversion
            string StringNumber =Convert.ToString(number);//Explicit Conversion
            int NewNumber = Convert.ToInt32(StringNumber);//Explicit Conversion
            Console.WriteLine(BigNumber);
            Console.WriteLine(StringNumber);
            Console.WriteLine(NewNumber);
            Console.ReadKey();


        }
    }
}
