using System;
using System.Collections.Generic;
using System.Text;

namespace DaysTemp_2
{
   class DaysTemp // Declare the class.
   {
      public int High, Low; // Declare the instance fields.
      public int Avg() // Declare the instance method.
      {
         return (High + Low) / 2;
      }
   }

   class Class1
   {
      static void Main()
      {
         // Create 2 instances of DaysTemp.
         DaysTemp T1 = new DaysTemp();
         DaysTemp T2 = new DaysTemp();

         // Write to the fields of each instance.
         T1.High = 76; T1.Low = 57;
         T2.High = 75; T2.Low = 53;

         // Read from the fields of each instance and call a method of
         // each instance.
         Console.WriteLine("T1: {0}, {1}, {2}", T1.High, T1.Low, T1.Avg ());
         Console.WriteLine("T2: {0}, {1}, {2}", T2.High, T2.Low, T2.Avg ());
      }
   }
}
