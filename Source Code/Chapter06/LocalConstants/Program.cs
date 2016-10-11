using System;
using System.Collections.Generic;
using System.Text;

namespace LocalConstants
{
   class Program
   {
      static void Main()
      {
         const double PI = 3.1416;                  // Local constant
         for (int radius = 1; radius <= 5; radius++)
         {
            double area = radius * radius * PI;    // Read from local constant
            Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
         }
      }
   }
}
