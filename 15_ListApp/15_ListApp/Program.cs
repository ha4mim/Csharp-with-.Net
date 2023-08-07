using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aList = new List<int>();
            aList.Add(1);
            aList.Add(2);
            aList.Add(3);
            aList.Add(4);
            aList.Add(5);
            aList.Add(6);
            aList.Add(7);
            aList.Add(8);
            aList.Add(9);
            aList.Add(10);
            foreach (int res in aList)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
