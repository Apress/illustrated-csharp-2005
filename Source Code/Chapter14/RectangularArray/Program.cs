using System;

namespace RectangularArray
{
   class Program
   {
      static void Main()
      {
         // Declare, create, and initialize the array.
         int[,] arr = new int[2, 3] { { 0, 1, 2 }, { 10, 11, 12 } };

         // Print the values.
         for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
               Console.WriteLine("Element [{0},{1}] is {2}", i, j, arr[i, j]);
      }
   }
}
