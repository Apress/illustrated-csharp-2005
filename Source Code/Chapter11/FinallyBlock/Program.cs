using System;

namespace FinallyBlock
{
   class Program
   {
      static void Main()
      {
         int inVal = 4;
         try
         {
            if (inVal < 10)
            {
               Console.Write("First Branch - ");
               return;
            }
            else
               Console.Write("Second Branch - ");
         }
         finally
         {
            Console.WriteLine("In finally statement");
         }
      }
   }
}
