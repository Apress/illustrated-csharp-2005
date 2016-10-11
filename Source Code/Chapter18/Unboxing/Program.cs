using System;

namespace Unboxing
{
   class Program
   {
      static void Main()
      {
         int i = 10;

         object oi = i;        // Box i and assign its reference to oi.
         int j = (int)oi;      // Unbox oi and assign its value to j.

         Console.WriteLine("i: {0},  oi: {1},  j: {2}", i, oi, j);
      }
   }
}
