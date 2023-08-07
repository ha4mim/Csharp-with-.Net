using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Reverse:");
            for (int j = 10; j >= 1; j--)
            {
                Console.WriteLine(j+',');
            }
            Console.ReadKey();
        }
    }
}
