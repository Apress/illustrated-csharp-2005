using System;

namespace InputParameters
{
   class MyClass
   {
      public int Sum(int x, int y)                      // Declare the method.
      {
         return x + y;                                  // Return the sum.
      }

      public float Avg(float Input1, float Input2)      // Declare the method.
      {
         return (Input1 + Input2) / 2.0F;               // Return the average.
      }
   }

   class Class1
   {
      static void Main()
      {
         MyClass MyT = new MyClass();
         int SomeInt = 6;
         Console.WriteLine
            ("Newsflash: Sum: {0} and {1} is {2}",
               5, SomeInt, MyT.Sum(5, SomeInt));        // Invoke the method.

         Console.WriteLine
            ("Newsflash: Avg: {0} and {1} is {2}",
               5, SomeInt, MyT.Avg(5, SomeInt));        // Invoke the method.
      }
   }
}
