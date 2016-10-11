using System;

namespace ThrowingWithoutObjects
{
   class MyClass
   {
      public static void PrintArg(string arg)
      {
         try
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
               Console.WriteLine("Inner Catch: {0}", e.Message);
               throw;
            }
         }
         catch
         {
            Console.WriteLine("Outer Catch: Handling an Exception.");
         }
      }
   }

   class Program
   {
      static void Main()
      {
         string s = null;
         MyClass.PrintArg(s);
      }
   }
}
