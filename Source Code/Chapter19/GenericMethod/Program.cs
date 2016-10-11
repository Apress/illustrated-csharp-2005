using System;
using System.Collections.Generic;

namespace GenericMethod
{
   class Trivial                                           // Non-generic class
   {
      static public void ReverseAndPrint<T>(T[] arr)       // Generic method
      {
         Array.Reverse(arr);
         foreach (T item in arr)                           // Use type argument T.
            Console.Write("{0}, ", item.ToString());
         Console.WriteLine("");
      }
   }

   class Program
   {
      static void Main()
      {
         // Create arrays of various types.
         int[] IntArray = new int[] { 3, 5, 7, 9, 11 };
         string[] StringArray = new string[] { "first", "second", "third" };
         double[] DoubleArray = new double[] { 3.567, 7.891, 2.345 };

         Trivial.ReverseAndPrint<int>(IntArray);           // Invoke method
         Trivial.ReverseAndPrint(IntArray);                // Infer type and invoke

         Trivial.ReverseAndPrint<string>(StringArray);     // Invoke method
         Trivial.ReverseAndPrint(StringArray);             // Infer type and invoke

         Trivial.ReverseAndPrint<double>(DoubleArray);     // Invoke method
         Trivial.ReverseAndPrint(DoubleArray);             // Infer type and invoke
      }
   }
}
