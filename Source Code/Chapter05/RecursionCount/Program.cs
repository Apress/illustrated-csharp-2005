using System;

namespace RecursionCount
{
   class Program
   {
      public void Count(int InVal)
      {
         if (InVal == 0)
            return;
         Count(InVal - 1); // Invoke this method again.

         Console.WriteLine("{0} ", InVal);
      }

      static void Main()
      {
         Program pr = new Program();
         pr.Count(3);
      }
   }
}
