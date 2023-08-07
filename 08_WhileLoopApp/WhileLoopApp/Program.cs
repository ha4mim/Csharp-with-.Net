using System;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Lower Number:");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Upper Number:");
            int upperNumber = Convert.ToInt32(Console.ReadLine());
            int i = lowerLimit;
            while(i<=upperNumber)
            {
                i++;
                if (i ==upperNumber)
                {
                    break;
                }
                if(i%2==1)
                {
                    continue;
                }
                Console.WriteLine("The Even Numbers Are:" + (i));
            }
            Console.ReadLine();
        }
    }
}
