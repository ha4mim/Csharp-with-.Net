using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nameList = new ArrayList();

            nameList.Add("Hamim");
            nameList.Add(1);
            nameList.Add("Hamim");
            nameList.Add("2");
            nameList.Add("Mahmud");
            nameList.Add('B');
            int capacity = nameList.Capacity;
            nameList.RemoveAt(5);
            nameList.Remove("Hamim");
            for (var i = 0; i<nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }
            Console.WriteLine("Capacity:"+capacity);

            Console.ReadKey();
        }
    }
}
