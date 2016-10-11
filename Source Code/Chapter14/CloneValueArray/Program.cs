using System;

namespace CloneValueArray
{
   class Program
   {
      static void Main()
      {
         int[] intArr1 = { 1, 2, 3 };                            // Step 1
         int[] intArr2 = (int[])intArr1.Clone();                 // Step 2

         intArr2[0] = 100;
         intArr2[1] = 200;
         intArr2[2] = 300;

         foreach (int i in intArr1)
            Console.WriteLine(i);
         foreach (int i in intArr2)
            Console.WriteLine(i);
      }
   }
}
