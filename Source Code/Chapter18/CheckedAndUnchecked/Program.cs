using System;
using System.Collections.Generic;
using System.Text;

namespace CheckedAndUnchecked
{
   class Program
   {
      static void Main(string[] args)
      {
         ushort sh = 2000;
         byte sb;

         sb = unchecked((byte)sh);            // Most significant bits lost
         Console.WriteLine("sb: {0}", sb);

         // Uncommenting the following line and running the program shows the OverflowException
         // sb = checked((byte)sh);              // Raises the OverflowException exception
         Console.WriteLine("sb: {0}", sb);
      }
   }
}
