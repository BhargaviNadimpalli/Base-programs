using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class LeapYear
    {
        public static void display()
        {
            int year, a, b, c;
            Console.WriteLine("The year is :");
            year = int.Parse(Console.ReadLine());
            a = year % 4;
            b = year % 100;
            c = year % 400;
            if (a == 0 && b != 0 || c == 0)
            {
                Console.WriteLine(year + " Is leap year ");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }

        }
    }
}
