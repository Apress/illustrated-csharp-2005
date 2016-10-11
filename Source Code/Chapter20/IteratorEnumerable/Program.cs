using System;
using System.Collections.Generic; // You need this namespace.
namespace ColorCollectionIterator
{
   class ColorCollection
   {
      string[] Colors ={ "Red", "Orange", "Yellow", "Green", "Blue", "Purple" };
      public IEnumerable<string> Forward()                       // Enumerable iterator
      {
         for (int i = 0; i < Colors.Length; i++)
            yield return Colors[i];
      }
      public IEnumerable<string> Reverse()                       // Enumerable iterator
      {
         for (int i = Colors.Length - 1; i >= 0; i--)
            yield return Colors[i];
      }
   }

   class Program
   {
      static void Main()
      {
         ColorCollection cc = new ColorCollection();

         foreach (string color in cc.Forward())
            Console.Write("{0} ", color);
         Console.WriteLine("");

         foreach (string color in cc.Reverse())
            Console.Write("{0} ", color);
         Console.WriteLine("");

         // Skip the foreach and manually use the enumerable and enumerator.
         IEnumerable<string> ieable = cc.Reverse();
         IEnumerator<string> ieator = ieable.GetEnumerator();

         while (ieator.MoveNext())
            Console.Write("{0} ", ieator.Current);
         Console.WriteLine("");
      }
   }
}