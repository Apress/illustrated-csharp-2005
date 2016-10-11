using System;

namespace MultipleInterfaces
{
   interface IDataRetrieve { int GetData(); }      // Declare interface
   interface IDataStore { void SetData(int x); }   // Declare interface

   class MyData : IDataRetrieve, IDataStore        // Declare class implementing both
   {
      int mem1; // Declare field
      public int GetData() { return mem1; }
      public void SetData(int x) { mem1 = x; }
   }

   class Program
   {
      static void Main()
      {
         MyData data = new MyData();

         // Use the implementations of both interfaces
         data.SetData(5);
         Console.WriteLine("Value = {0}", data.GetData());
      }
   }
}
