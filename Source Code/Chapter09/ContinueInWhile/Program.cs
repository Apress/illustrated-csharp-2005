using System;

namespace ContinueInWhile
{
   class Program
   {
      static void Main()
      {
         int x = 0;
         while (x < 5)
         {
            if (x < 3)
            {
               x++;
               continue;         // Go back to top of loop
            }

            // This line is reached only when x is 3 or greater.
            Console.WriteLine("Value of x is {0}", x);
            x++;
         }
      }
   }
}
