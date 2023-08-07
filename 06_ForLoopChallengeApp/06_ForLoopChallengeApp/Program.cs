using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ForLoopChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower number:");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the upper number:");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            string messege = " ";

            for(var i = lowerLimit; i<upperLimit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even:" + (i));
                }
                else
                {
                    Console.WriteLine("Odd:" + (i));
                }
            }
            Console.ReadKey();
        }
    }
}
