using System;
using System.Collections.Generic;

namespace GenericDelegate
{
   delegate void MyDelegate<T>(T value);                  // Generic delegate

   class Trivial
   {
      static public void PrintString(string s)            // Method matches delegate
      {
         Console.WriteLine(s);
      }
      static public void PrintUpperString(string s)       // Method matches delegate
      {
         Console.WriteLine("{0}", s.ToUpper());
      }
   }

   class Program
   {
      static void Main()
      {
         MyDelegate<string> MyDel = Trivial.PrintString;  // Create inst of delegate
         MyDel += Trivial.PrintUpperString;               // Add a method.
         MyDel("Hi There.");                              // Call delegate
      }
   }
}
