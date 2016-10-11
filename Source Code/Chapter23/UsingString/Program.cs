using System;

namespace UsingString
{
   class Program
   {
      static void Main()
      {
         string s = "Hi there.";

         Console.WriteLine("{0}", s.ToUpper());    // Print uppercase copy.
         Console.WriteLine("{0}", s);              // String is unchanged.
      }
   }
}
