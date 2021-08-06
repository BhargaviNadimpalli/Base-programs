using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class SwapNumbers
    {
        public static void display()
        {
            int a, b, c;
            a = 10;
            b = 20;
            Console.WriteLine("Before swaping values of a " + a + " and b = " + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swaping values of a " + a + " and b = " + b);
        }


    }
}
