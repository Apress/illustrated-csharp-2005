using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorEnumerator
{
   class MyClass : IEnumerable<string>
   {
      bool ColorFlag = true;

      public MyClass(bool flag)                   // Constructor
      {
         ColorFlag = flag;
      }

      IEnumerator<string> BlackAndWhite           // Property--enumerator iterator
      {
         get
         {
            yield return "black";
            yield return "gray";
            yield return "white";
         }
      }

      IEnumerator<string> Colors                  // Property--enumerator iterator
      {
         get
         {
            string[] TheColors = { "blue", "red", "yellow" };
            for (int i = 0; i < TheColors.Length; i++)
               yield return TheColors[i];
         }
      }

      public IEnumerator<string> GetEnumerator()  // GetEnumerator
      {
         return ColorFlag
         ? Colors                                 // Return Colors enumerator
         : BlackAndWhite;                         // Return BlackAndWhite enumerator
      }

      System.Collections.IEnumerator
      System.Collections.IEnumerable.GetEnumerator()
      {
         return ColorFlag
         ? Colors                                 // Return Colors enumerator
         : BlackAndWhite;                         // Return BlackAndWhite enumerator
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc1 = new MyClass(true);         // Call constructor with true
         foreach (string s in mc1)
            Console.Write("{0} ", s);
         Console.WriteLine("");

         MyClass mc2 = new MyClass(false);        // Call constructor with false
         foreach (string s in mc2)
            Console.Write("{0} ", s);
         Console.WriteLine("");
      }
   }
}