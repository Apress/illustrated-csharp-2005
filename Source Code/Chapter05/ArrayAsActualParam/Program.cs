using System;

namespace ArrayAsActualParam
{
   class MyClass
   {
      public void ListInts(params int[] inVals)
      {
         if (inVals != null)
            for (int i = 0; i < inVals.Length; i++)   // Process the array.
               inVals[i] = inVals[i] * 10;
      }
   }

   class Program
   {
      static void Main()
      {
         int[] MyArr = new int[] { 5, 6, 7 };         // Create and initialize array.

         MyClass mc = new MyClass();
         mc.ListInts(MyArr);                          // Call method.

         foreach (int x in MyArr)
            Console.WriteLine("{0}", x);              // Print out each element.
      }
   }
}
