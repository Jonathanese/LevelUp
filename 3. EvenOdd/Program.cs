using System;

namespace _3.EvenOdd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("3. Even/Odd");

            int iMin, iMax;
            iMin = GetValue("Enter Integer");
            iMax = GetValue("Enter Integer");

            //To keep the order consistent, we will swap values if iMin is larger than iMax
            if (iMin > iMax)
            {
                int TMP = iMax;
                iMax = iMin;
                iMin = TMP;
            }

            Console.WriteLine();

            if (iMin % 2 == 0) // First term is even
            {
                Console.Write("Evens: ");
                printAlternates(iMin, iMax);
                Console.Write("Odds:   "); //Spacing makes a nice alternating effect
                printAlternates(iMin + 1, iMax);
            }
            else //First term is odd
            {
                Console.Write("Evens: ");
                printAlternates(iMin + 1, iMax);
                Console.Write("Odds: ");
                printAlternates(iMin, iMax);
            }

            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }

        private static void printAlternates(int val, int max)
        {
            if (val > max)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(val.ToString() + " ");
                printAlternates(val + 2, max);
            }
        }

        private static int GetValue(String message)
        {
            while (true) //I normally don't like blocking code, but the extra complexity felt unnecessary for a simple program
            {
                Console.WriteLine(message);
                try
                {
                    return Convert.ToInt32(Console.ReadLine()); //Loop is only broken if valid number is entered
                }
                catch (FormatException)                          //Letters are accepted by ReadLine() but cannot be handled by ToDouble()
                {
                    Console.WriteLine("Retry.");
                }
            }
        }
    }
}