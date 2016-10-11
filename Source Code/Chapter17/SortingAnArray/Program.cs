using System;

namespace SortingAnArray
{
   class Program
   {
      static void Main()
      {
         int[] MyInt = new int[5] { 20, 4, 16, 9, 2 }; // Create an array of ints.

         Array.Sort(MyInt);                            // Sort elements by magnitude.

         foreach (int i in MyInt)                      // Print them out.
            Console.Write("{0} ", i);
      }
   }
}
