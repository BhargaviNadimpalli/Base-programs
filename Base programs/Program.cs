using System;

namespace Base_programs
{
    class Program
    {
        static double PercentageOfHead(int numberOfTimeCoinTossed)
        {
            Random rand = new Random();
            double headCount = 0;
            int head = 1;
            for (int i = 0; i < numberOfTimeCoinTossed; i++)
            {
                int coinTossed = rand.Next(0, 2);
                if (coinTossed == head)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                }
            }

            return (headCount / numberOfTimeCoinTossed) * 100;
        }
        static double PersentageOfTails(double headsPercentage)
        {
            return 100 - headsPercentage;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number of Coin should be Tossed : ");
            //int numberOfTimesCoinTossed = int.Parse(Console.ReadLine());
            //double headsPercentage = PercentageOfHead(numberOfTimesCoinTossed);
            //double tailPercentage = PersentageOfTails(headsPercentage);
            //Console.WriteLine("Head percentage :" + headsPercentage);
            //Console.WriteLine("Tail percentage : " + tailPercentage);
            /// LeapYear.display();
            /// HarmonicSeries.display();
           /// LargestNumber.display();
            ///QuotientRemainder.display();
            ///SwapNumbers.display();
            ///EvenOdd.display();
            ///VowelsConsonants.display();
            ///Power.display();
            ////PowerFactor.display();

        }
    }

}

