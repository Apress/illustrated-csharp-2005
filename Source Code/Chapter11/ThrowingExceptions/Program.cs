using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowingExceptions
{
   class MyClass
   {
      public static void PrintArg(string arg)
      {
         try
         {
            if (arg == null)
            {
               ArgumentNullException MyEx = new ArgumentNullException();
               throw MyEx;
            }
            Console.WriteLine(arg);
         }
         catch (ArgumentNullException e)
         {
            Console.WriteLine("Message: {0}", e.Message);
         }
      }
   }

   class Program
   {
      static void Main()
      {
         string s = null;
         MyClass.PrintArg(s);
         MyClass.PrintArg("Hi there!");
      }
   }
}
