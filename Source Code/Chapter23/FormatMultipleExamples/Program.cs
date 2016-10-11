using System;

namespace FormatMultipleExamples
{
   class Program
   {
      static void Main()
      {
         double MyDouble = 12.345678;

         Console.WriteLine("{0,-10:G} -- General", MyDouble);
         Console.WriteLine("{0,-10} -- Default, same as General", MyDouble);
         Console.WriteLine("{0,-10:F4} -- Fixed Point, 4 dec places", MyDouble);
         Console.WriteLine("{0,-10:C} -- Currency", MyDouble);
         Console.WriteLine("{0,-10:E3} -- Sci. Notation, 3 dec places", MyDouble);
         Console.WriteLine("{0,-10:x} -- Hexadecimal integer", 1194719);
      }
   }
}
