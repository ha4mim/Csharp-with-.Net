using System;

namespace _13_ArrayAppChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] numberList = new int [arraySize];

            Console.WriteLine("Enter Number to add in the array:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            for(int i  = firstNumber; i < numberList.Length; i++)
            {
                if(numberList.Length > arraySize)
                {
                    Console.WriteLine("Array Length can't be bigger than defined sizw");
                }
                else
                {
                    Console.WriteLine("Do You want to add another number to the array? 1 for Yes. Anything for NO ");
                    int res = Convert.ToInt32(Console.ReadLine());
                    if (res == 1)
                    {
                        Console.WriteLine("Enter Number to add in the array:");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                    }else{
                        Console.WriteLine("Proces Fininsh.");
                    }
                }
                Console.WriteLine(numberList[i]);
            }


            Console.ReadKey();
        }
    }
}
