using System;
using System.Collections.Generic;

namespace MultipleGenericInterfaces
{
   interface IMyIfc<T>                            // Generic interface
   {
      T ReturnIt(T inValue);
   }

   class Trivial : IMyIfc<int>, IMyIfc<string>    // Non-generic class
   {
      public int ReturnIt(int inValue)            // Implement int interface
      {
         return inValue;
      }

      public string ReturnIt(string inValue)      // Implement string interface
      {
         return inValue;
      }
   }

   class Program
   {
      static void Main()
      {
         Trivial TrivInt = new Trivial();
         Trivial TrivString = new Trivial();

         Console.WriteLine("{0}", TrivInt.ReturnIt(5));
         Console.WriteLine("{0}", TrivString.ReturnIt("Hi there."));
      }
   }
}
