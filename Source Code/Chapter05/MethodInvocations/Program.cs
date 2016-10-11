using System;

namespace MethodInvocations
{
   class MyClass
   {
      void PrintDateAndTime()               // Declare the method.
      {
         DateTime dt = DateTime.Now;        // Get the current date and time.
         Console.WriteLine("{0}", dt);      // Write it out.
      }

      static void Main()
      {
         MyClass mc = new MyClass();
         mc.PrintDateAndTime();             // Invoke the method.
      }
   }
}
