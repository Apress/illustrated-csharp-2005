using System;

namespace ShiftOperators
{
   class Program
   {
      static void Main()
      {
         int a, b, x = 14;
         a = x << 3;      // Shift left
         b = x >> 3;      // Shift right
         Console.WriteLine("{0} << 3 = {1}", x, a);
         Console.WriteLine("{0} >> 3 = {1}", x, b);
      }
   }
}
