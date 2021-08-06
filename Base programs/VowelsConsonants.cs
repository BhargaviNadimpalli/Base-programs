using System;
using System.Collections.Generic;
using System.Text;

namespace Base_programs
{
    class VowelsConsonants
    {
        public static void display()
        {
            char alphabet;
            Console.WriteLine("The alphabet is :");
            alphabet = char.Parse(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' || alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine(alphabet + " is vowel");
            }
            else
                Console.WriteLine(alphabet + " is consonant");
        }

    }
}
