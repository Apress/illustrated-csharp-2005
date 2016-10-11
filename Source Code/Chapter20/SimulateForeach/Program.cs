using System;
using System.Collections;

namespace SimulateForeach
{
   class Program
   {
      static void Main()
      {
         int[] MyArray = { 10, 11, 12, 13 };         // Create an array.

         IEnumerator ie = MyArray.GetEnumerator();   // Get its enumerator.
         while (ie.MoveNext() == true)               // Move to the next item.
         {
            int i = (int)ie.Current;                 // Get the current item.
            Console.WriteLine("{0}", i);             // Write it out.
         }
      }
   }
}
