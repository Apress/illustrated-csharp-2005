using System;
using System.Collections.Generic;
using System.Text;

namespace DaysTemp_1
{
   class DaysTemp                         // Declare class DaysTemp
   {
      public int High = 75;
      public int Low = 45;
   }
   class Program                          // Declare class Program.
   {
      static void Main()
      {
         DaysTemp Temp = new DaysTemp();  // Create the object.

         Temp.High = 85;                  // Assign to the fields.
         Temp.Low = 60;

         Console.WriteLine("High: {0}", Temp.High ); // Read from fields.
         Console.WriteLine("Low:  {0}", Temp.Low );
      }
   }
}
