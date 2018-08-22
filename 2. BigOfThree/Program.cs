using System;
using System.Linq;

namespace BigOfThree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("2. Largest of Three");

            double[] dValues = new double[3];
            double dMax = 0; //This is initialized to 0, but changed to the first entered value. This allows comparing negative numbers

            for (int i = 0; i < dValues.Length; i++)
            {
                dValues[i] = GetValue("Enter Number " + (i + 1).ToString());

                if (i == 0) //Initialize dMax with first number
                {
                    dMax = dValues[i];
                }
                else if (dValues[i] > dMax)
                {
                    dMax = dValues[i];
                }
            }
            //Simply calling the Max() method. This is what makes C# nice
            Console.WriteLine("Maximum Value Using Max() Function: " + dValues.Max());

            //Actually performing the logic myself
            Console.WriteLine("Maximum Value Using Manual Logic: " + dMax.ToString());

            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }

        private static double GetValue(String message)
        {
            while (true) //I normally don't like blocking code, but the extra complexity felt unnecessary for a simple program
            {
                Console.WriteLine(message);
                try
                {
                    return Convert.ToDouble(Console.ReadLine()); //Loop is only broken if valid number is entered
                }
                catch (FormatException)                          //Letters are accepted by ReadLine() but cannot be handled by ToDouble()
                {
                    Console.WriteLine("Retry.");
                }
            }
        }
    }
}