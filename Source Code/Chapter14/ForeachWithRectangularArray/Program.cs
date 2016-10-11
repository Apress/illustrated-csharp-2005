using System;

namespace ForeachWithRectangularArray
{
   class Sample
   {
      static void Main()
      {
         int nTotal = 0;
         int[,] arr1 = { { 10, 11 }, { 12, 13 } };
         foreach (int element in arr1)
         {
            nTotal += element;
            Console.WriteLine ("Element: {0}, Current Total: {1}", element, nTotal);
         }
      }
   }
}
