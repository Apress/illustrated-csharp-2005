using System;
using System.Collections.Generic;

namespace GenericInterface
{
   interface IMyIfc<T>                // Generic interface
   {
      T ReturnIt(T inValue);
   }

   class Trivial<S> : IMyIfc<S>       // Generic class
   {
      public S ReturnIt(S inValue)    // Implement interface
      {
         return inValue;
      }
   }

   class Program
   {
      static void Main()
      {
         Trivial<int>    TrivInt    = new Trivial<int>();
         Trivial<string> TrivString = new Trivial<string>();

         Console.WriteLine("{0}", TrivInt.ReturnIt(5));
         Console.WriteLine("{0}", TrivString.ReturnIt("Hi there."));
      }
   }
}
