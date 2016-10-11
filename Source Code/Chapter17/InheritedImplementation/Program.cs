using System;

namespace InheritedImplementation
{
   interface IIfc1 { void PrintOut(string s); }
   class MyBaseClass // Declare base class
   {
      public void PrintOut(string s)      // Declare the method.
      {
         Console.WriteLine("Calling through: {0}", s);
      }
   }

   class Derived : MyBaseClass, IIfc1     // Declare class
   {
   }

   class Program
   {
      static void Main()
      {
         Derived d = new Derived();       // Create class object
         d.PrintOut("object.");           // Call method
      }
   }
}
