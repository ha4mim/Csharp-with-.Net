using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StackQueeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack aStack = new Stack();
            aStack.Push(1);
            aStack.Push("Hamim");
            aStack.Push(2);
            aStack.Push("Mahmud");
            Console.WriteLine("Size Before:" + aStack.Count);
            Console.WriteLine(aStack.Pop());
            Console.WriteLine("Size After:" + aStack.Count);
            Console.WriteLine(aStack.Peek());
            Console.ReadKey();
        }
       
    }
}
