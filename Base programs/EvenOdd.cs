using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class EvenOdd
    {
        public static void display()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            int num = number % 2;
            if (num == 0)
            {
                Console.WriteLine(number + " is even number");
            }
            else
            {
                Console.WriteLine(number + " is odd number");
            }
        }
    }
}
