using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class Power
    {
        public static void display()
        {
            int n;
            Console.WriteLine("Enter the number :");
            n = int.Parse(Console.ReadLine());
            double power1;
            for (int i = 1; i <= n; i++)
            {
                power1 = Math.Pow(2, i);
                if (n > 0 && n < 31)
                {
                Console.WriteLine("the power of 2^n :" + power1);
                }
                else
                {
                    Console.WriteLine("Check the number it should not more than 31");
                }
            } 
            
        }
    }
}
