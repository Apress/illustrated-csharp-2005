using System;

namespace RefsToMultipleInterfaces
{
   interface IIfc1 { void PrintOut(string s); } // Declare interface
   interface IIfc2 { void PrintOut(string s); } // Declare interface

   class MyClass : IIfc1, IIfc2
   {
      public void PrintOut(string s)
      {
         Console.WriteLine("Calling through: {0}", s);
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();
         IIfc1 ifc1 = (IIfc1)mc;             // Get ref to IIfc1
         IIfc2 ifc2 = (IIfc2)mc;             // Get ref to IIfc2

         mc.PrintOut("object.");             // Call through class object
         ifc1.PrintOut("interface 1.");      // Call through IIfc1
         ifc2.PrintOut("interface 2.");      // Call through IIfc2
      }
   }
}
