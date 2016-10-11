using System;

namespace BoxingCreatesCopy
{
   class Program
   {
      static void Main()
      {
         int i = 10;           // Create and initialize value type
         object oi = i;        // Create and initialize reference type
         Console.WriteLine("i: {0}, io: {1}", i, oi);

         i  = 12;              // Change the value type
         oi = 15;              // Change the boxed copy
         Console.WriteLine("i: {0}, io: {1}", i, oi);
      }
   }
}
