using System;

namespace _4.String_Reversal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("4. String Reversal");
            String sText;
            Console.WriteLine("Enter a string");
            sText = Console.ReadLine();

            Console.WriteLine(StringReversal(sText));

            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }

        //This is basically like reversing the order of papers by making a separate stack by pulling from the top of the current stack.
        //Except upside-down, I suppose.
        private static String StringReversal(String message)
        {
            if (message.Length == 1)
            {
                return message; //Once we are down to a single letter, we are finished and can start rebuilding the string in reverse as we exit.
            }
            else
            {
                //When the altering event occurs after the  recursive call, the sequence happens in reverse.
                //In this case, we grab the first letter and move it to the end, then pass in the string with this first character removed.
                return StringReversal(message.Remove(0, 1)) + message[0];
            }
        }
    }
}