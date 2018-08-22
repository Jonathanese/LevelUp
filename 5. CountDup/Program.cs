using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CountDup
{
    internal class Program
    {
        //This could be a struct, but a list of structs contains copies of structs, and therefore the originals cannot be modified, only replaced.
        //A list of objects stores pointers to originals and can therefore be modified.
        private class NameCount
        {
            public String itsName;
            public int itsCount;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("5. Counting Instances");
            /*
             * NOTE:
             * I am aware that there is a much shorter method using about 5 lines of LINQ.
             * However, this would feel disingenuous as I assuming you are interested in my current fluency,
             * and I would not call myself particularly fluent in LINQ currently.
             */

            List<NameCount> NameCountList = new List<NameCount> { }; //stores the number of distinct names and their occurances
            List<String> Names = new List<String>{
                "Jon",
                "Jacob",
                "Jingleheimer",
                "Schmidt",
                "Jon",
                "Dave",
                "Jingleheimer",
                "Greg",
                "Jacob",
                "Jacob",
                "Mark",
                "Dave"};

            foreach (String thisName in Names)
            {
                //Finds items in which itsName = thisName, then returns the index of the first instance.
                int NameIndex = NameCountList.IndexOf(NameCountList.Where(n => n.itsName == thisName).FirstOrDefault());
                if (NameIndex == -1) //If the name does not currently exist on the list
                {
                    //Add the name to the list
                    NameCountList.Add(new NameCount { itsName = thisName, itsCount = 1 });
                }
                else
                {
                    //Increment the number of instances
                    NameCountList[NameIndex].itsCount++;
                }
            }

            //Iterate through each distinct item and display its properties
            foreach (NameCount thisNameCount in NameCountList)
            {
                Console.WriteLine(thisNameCount.itsName + ": " + thisNameCount.itsCount.ToString());
            }

            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }
    }
}