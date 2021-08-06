using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
   
    class PowerFactor
    {
        public static void display()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + "Is not prime number");
                    break;
                }
                if (flag == 0)
                {
                    Console.WriteLine(number + "Is prime number");
                    break;
                }

          
        
            }
       
    for (int i = 2; i <= number; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine(i + " is prime factor of " + number);
        }

    }

}

    }
}
