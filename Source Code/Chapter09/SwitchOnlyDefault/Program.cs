using System;

namespace SwitchOnlyDefault
{
   class Program
   {
      static void Main()
      {
         for (int x = 1; x < 4; x++)
         {
            switch (x)
            {
               default:
                  Console.WriteLine("x is {0} -- In Default case", x);
                  break;
            }
         }
      }
   }
}
