using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class LargestNumber
    {
        public static void display()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = 30;
            if ((a > b) && (a > c))
            {
                Console.WriteLine("The largest number is " + a);
            }
            else if ((b > c) && (b > a))
            {
                Console.WriteLine("The largest number is " + b);
            }
            else
            {
                Console.WriteLine("The largest number is " + c);
            }
        }
    }
}
