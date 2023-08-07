using System;

namespace DoWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Limit:");
            int limit = Convert.ToInt32(Console.ReadLine());

            do
            {

                
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    if (number % 2 !=0)
                    {
                        Console.WriteLine("odd");
                       
                    }
                break;


            } while (number < limit);
           
            Console.ReadKey();
        }
    }
}
