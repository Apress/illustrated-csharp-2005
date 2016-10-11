using System;

namespace NullCoalescingOperator
{
   class Program
   {
      static void Main()
      {
         int? MyI4 = null;
         Console.WriteLine("MyI4: {0}", MyI4 ?? -1);

         MyI4 = 10;
         Console.WriteLine("MyI4: {0}", MyI4 ?? -1);
      }
   }
}
