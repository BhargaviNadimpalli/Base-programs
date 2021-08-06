using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class HarmonicSeries
    {
        public static void display()
        {
            Console.WriteLine("The harmonic series is : 1+ ");
            int number = 4;
            double harmonic = 0.0;
            for (int i = 1; i <= number; i++)
            {
                harmonic = harmonic + 1 / i;
                Console.Write("+ 1 / " + i);


           }
            
        }



    }
}
