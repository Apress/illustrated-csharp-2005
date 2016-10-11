using System;

namespace CloneReferenceArray
{
   class A
   {
      public int Value = 5;
   }

   class Program
   {
      static void Main()
      {
         A[] AArray1 = new A[3] { new A(), new A(), new A() }; // Step 1
         A[] AArray2 = (A[])AArray1.Clone();                   // Step 2

         AArray2[0].Value = 100;                               // Step 3
         AArray2[1].Value = 200;
         AArray2[2].Value = 300;

         foreach (A a in AArray1)
            Console.WriteLine(a.Value);

         foreach (A a in AArray2)
            Console.WriteLine(a.Value);
      }
   }
}
