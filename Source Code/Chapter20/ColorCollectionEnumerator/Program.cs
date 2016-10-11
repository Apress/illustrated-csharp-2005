using System;
using System.Collections;

namespace ColorCollectionEnumerator
{
   class ColorEnumerator : IEnumerator
   {
      string[] Colors;
      int Position = -1;

      public ColorEnumerator(string[] theColors) // Constructor
      {
         Colors = new string[theColors.Length];
         for (int i = 0; i < theColors.Length; i++)
            Colors[i] = theColors[i];
      }

      public object Current                     // Current
      {
         get { return Colors[Position]; }
      }

      public bool MoveNext()                    // MoveNext
      {
         if (Position < Colors.Length - 1)
         { Position++; return true; }
         else
            return false;
      }

      public void Reset()                       // Reset
      {
         Position = -1;
      }
   }

   class MyColors : IEnumerable
   {
      string[] Colors = { "Red", "Yellow", "Blue" };
      public IEnumerator GetEnumerator()
      {
         return new ColorEnumerator(Colors);
      }
   }

   class Program
   {
      static void Main()
      {
         MyColors mc = new MyColors();

         foreach (string color in mc)
            Console.Write("{0} ", color);
         Console.WriteLine("");
      }
   }
}
