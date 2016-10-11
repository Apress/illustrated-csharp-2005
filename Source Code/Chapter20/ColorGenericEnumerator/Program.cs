using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ColorCollectionEnumerator
{
   class ColorEnumerator : IEnumerator<string>
   {
      string[] Colors; int Position = -1;

      public string Current                          // Current--generic
      {
         get { return Colors[Position]; }
      }

      object IEnumerator.Current                     // Current--non-generic
      {
         get { return Colors[Position]; }
      }

      public bool MoveNext()                         // MoveNext
      {
         if (Position < Colors.Length - 1)
         { Position++; return true; }
         else
            return false;
      }

      public void Reset()                            // Reset
      {
         Position = -1;
      }

      public void Dispose() { }

      public ColorEnumerator(string[] colors)        // Constructor
      {
         Colors = new string[colors.Length];
         for (int i = 0; i < colors.Length; i++)
            Colors[i] = colors[i];
      }
   }

   class MyColors : IEnumerable<string>
   {
      string[] Colors = { "Red", "Yellow", "Blue" };

      public IEnumerator<string> GetEnumerator()     // IEnumerable<T> version
      {
         return new ColorEnumerator(Colors);
      }

      IEnumerator IEnumerable.GetEnumerator()        // IEnumerable version
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
            Console.Write("{0}  ", color);
         Console.WriteLine("");
      }
   }
}
