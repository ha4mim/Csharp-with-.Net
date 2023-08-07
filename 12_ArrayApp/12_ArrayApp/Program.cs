using System;

namespace _12_ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameCollection = new string[6];
            nameCollection[0] = "Hamim";
            nameCollection[1] = "Mahumd";
            Console.WriteLine(nameCollection[0] + " " + nameCollection[1]);

            int[] age = new int[10];
            age[0] = 20;
            age[1] = 25;
            age[2] = 30;
            age[3] = 35;
            age[4] = 40;
            age[5] = 45;
            age[6] = 50;
            age[7] = 55;
            age[8] = 60;
            age[9] = 65;

            Console.WriteLine("Enter 1 for 20,2 for 25,3 for 30,4 for 35,5for 40,6 for 45,7 for 50,8 for 55,9 for 60,0 for 65");
            int newAge = Convert.ToInt32(Console.ReadLine());
            if (newAge == 1)
            {
                Console.WriteLine(age[0]);
            }
            else if (newAge == 2)
            {
                Console.WriteLine(age[1]);
            }
            else if (newAge == 3)
            {
                Console.WriteLine(age[2]);
            }
            else if (newAge == 4)
            {
                Console.WriteLine(age[3]);
            }
            else if (newAge == 5)
            {
                Console.WriteLine(age[4]);
            }
            else if (newAge == 6)
            {
                Console.WriteLine(age[5]);
            }
            else if (newAge == 7)
            {
                Console.WriteLine(age[6]);
            }
            else if (newAge == 8)
            {
                Console.WriteLine(age[7]);
            }
            else if (newAge == 9)
            {
                Console.WriteLine(age[8]);
            }
            else if (newAge == 0)
            {
                Console.WriteLine(age[9]);
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            Console.ReadKey();
        }
    }
}
