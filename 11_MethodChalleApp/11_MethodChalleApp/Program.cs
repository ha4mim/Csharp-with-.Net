using System;

namespace _11_MethodChalleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();

            string fullName = GetFullName(firstName, lastName);

            Console.WriteLine("Enter Your Subject");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter your Mark:");
            int mark = Convert.ToInt32(Console.ReadLine());

            bool isPassed = GetPassed(mark);

            string grade = GetGrade(mark);

            bool isValidate = GetValidate(mark);

            if (isValidate)
            {
                if (isPassed)
                {
                    Console.WriteLine("Congratulation {0}!\nYou have passed in {1}.\nYour Grade is {2}", fullName, subject, grade);
                }
                else { Console.WriteLine("Thank You. Plese Try again!"); }
            }
        }

        private static bool GetValidate(int mark)
        {
            return mark < 100 || mark > 0;
        }

        private static string GetGrade(int mark)
        {
             if (mark > 79 || mark <= 100)
            {
                return @"A+";
            }
            else if (mark > 69 || mark <= 79)
            {
                return @"A";
            }
            else if (mark > 59 || mark <= 69)
            {
                return @"A-";
            }
            else if (mark > 49 || mark <= 59)
            {
                return @"B+";
            }
            else if (mark > 45 || mark <= 49)
            {
                return @"B";
            }
            else if (mark > 39 || mark <= 45)
            {
                return @"C";
            }
            else if (mark > 33 || mark <= 39)
            {
                return @"D";
            }
            else
            {
                return @"F";
            }
        }

        private static bool GetPassed(int mark)
        {
            return mark >= 33;
        }

        private static string GetFullName(string firstName, string lastName)
        {
            string fullName = firstName + lastName;
            return fullName;
        }
    }
}
