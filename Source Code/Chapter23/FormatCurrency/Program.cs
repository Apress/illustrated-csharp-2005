using System;

namespace FormatCurrency
{
   class Program
   {
      static void Main()
      {
         Console.WriteLine("The value: {0}.", 500);     // Print out number.
         Console.WriteLine("The value: {0:C}.", 500);   // Format as currency.
      }
   }
}
