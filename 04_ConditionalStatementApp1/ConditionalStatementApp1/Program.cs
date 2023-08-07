using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Your Number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 100)
            {
                Console.WriteLine("Enter a number bellow 100");
            }else if (number < 1)
            {
                Console.WriteLine("Enter a number greatter than 1");
            }else if (number >= 33)
            {
                Console.WriteLine("Paas");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.ReadKey();
        }
    }
}
