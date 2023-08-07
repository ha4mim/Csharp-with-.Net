using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string messege = "Thank You";
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Name Is:" + (name));
            Console.WriteLine("Your Age Is:" + (age));
            Console.WriteLine(messege);
            Console.ReadKey();
            
        }
    }
}
