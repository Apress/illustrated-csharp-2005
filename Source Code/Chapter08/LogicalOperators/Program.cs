using System;

namespace LogicalOperators
{
   class Program
   {
      static void Main( )
      {
         const byte x = 12, y = 10;
         sbyte a;
         a = x & y;        // a = 8
         Console.WriteLine("a = {0}", a);

         a = x | y;        // a = 14
         Console.WriteLine("a = {0}", a);

         a = x ^ y;        // a = 6
         Console.WriteLine("a = {0}", a);

         a = ~x;           // a = -13
         Console.WriteLine("a = {0}", a);

      }
   }
}
