using System;

namespace FormatAllignment
{
   class Program
   {
      static void Main()
      {
         int MyInt = 500;
         Console.WriteLine("|{0, 10}|", MyInt);      // Aligned right
         Console.WriteLine("|{0,-10}|", MyInt);      // Aligned left
      }
   }
}
