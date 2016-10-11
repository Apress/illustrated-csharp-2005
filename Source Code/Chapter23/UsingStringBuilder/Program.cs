using System;
using System.Text;

namespace UsingStringBuilder
{
   class Program
   {
      static void Main()
      {
         StringBuilder sb = new StringBuilder("Hi there.");
         Console.WriteLine("{0}", sb);                     // Print string.

         sb.Replace("Hi", "Hello");                        // Replace a substring.
         Console.WriteLine("{0}", sb);                     // Print changed string.
      }
   }
}
