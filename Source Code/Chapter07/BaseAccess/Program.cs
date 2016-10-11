using System;

namespace BaseAccess
{
   class SomeClass                                      // Base class
   {
      public string Field1 = "Field1 -- In the base class";
   }

   class OtherClass : SomeClass                         // Derived class
   {
      new public string Field1 = "Field1 -- In the derived class";

      public void PrintField1()
      {
         Console.WriteLine("{0}", Field1);              // Access the derived class.
         Console.WriteLine("{0}", base.Field1);         // Access the base class.
      }
   }

   class Program
   {
      static void Main()
      {
         OtherClass oc = new OtherClass();
         oc.PrintField1();
      }
   }
}
