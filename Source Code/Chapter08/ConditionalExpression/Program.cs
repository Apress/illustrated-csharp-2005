using System;

namespace ConditionalExpression
{
   class Program
   {
      static void Main()
      {
         int x = 10, y = 9;
         int HighVal = (x > y)                // Condition
                          ? x                 // Expression 1
                          : y;                // Expression 2

         Console.WriteLine("HighVal: {0}\n", HighVal);
         Console.WriteLine("x is{0} greater than y",
                               x > y          // Condition
                               ? ""           // Expression 1
                               : " not");     // Expression 2

         y = 11;
         Console.WriteLine("x is{0} greater than y",
                               x > y          // Condition
                               ? ""           // Expression 1
                               : " not");     // Expression 2
      }
   }
}
