using System;

namespace ReferenceParameters
{
   class MyClass
   {
      public int Val = 20;                     // Initialize field to 20.
   }

   class Program
   {
      static void MyMethod(ref MyClass f1, ref int f2)
      {
         f1.Val = f1.Val + 5;                 // Add 5 to field of f1 param.
         f2 = f2 + 5;                         // Add 5 to second param.
      }

      static void Main()
      {
         MyClass A1 = new MyClass();
         int A2 = 10;

         Console.WriteLine                    // Print values before method call.
            ("Before -- A1.Val: {0}, A2: {1}", A1.Val, A2);

         MyMethod(ref A1, ref A2);            // Call the method.

         Console.WriteLine                    // Print values after method call.
            ("After  -- A1.Val: {0}, A2: {1}", A1.Val, A2);
      }
   }
}
