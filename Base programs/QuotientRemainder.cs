using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class QuotientRemainder
    {
        public static void display()
        {
            int divisor = 6;
            int dividend = 25;
            int remainder = dividend % divisor;
            int quotient = dividend / divisor;
            Console.WriteLine("Quotient is :" + quotient);
            Console.WriteLine("Remainder is :" + remainder);

        }

    }
}
