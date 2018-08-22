using System;

namespace _1.Arith
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1. Arithmetic");

            double dValueOne, dValueTwo, dResult;

            dValueOne = GetValue("Enter First Number");
            dValueTwo = GetValue("Enter Second Number");

            #region SHOW OUTPUTS

            dResult = dValueOne + dValueTwo;
            Console.WriteLine(dValueOne.ToString() + " + " + dValueTwo.ToString() + " = " + dResult.ToString());

            dResult = dValueOne - dValueTwo;
            Console.WriteLine(dValueOne.ToString() + " - " + dValueTwo.ToString() + " = " + dResult.ToString());

            dResult = dValueOne * dValueTwo;
            Console.WriteLine(dValueOne.ToString() + " x " + dValueTwo.ToString() + " = " + dResult.ToString());

            //In this case, C# seems to take care of division by zero by returning infinity. However, that would be incorrect.
            if (dValueOne != 0)
            {
                dResult = dValueOne / dValueTwo;
                Console.WriteLine(dValueOne.ToString() + " / " + dValueTwo.ToString() + " = " + dResult.ToString());
            }
            else
            {
                Console.WriteLine(dValueOne.ToString() + " / " + dValueTwo.ToString() + " = Undefined");
            }

            #endregion SHOW OUTPUTS

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