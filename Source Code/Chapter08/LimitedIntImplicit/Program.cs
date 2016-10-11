using System;

namespace LimitedIntImplicit
{
   class LimitedInt
   {
      const int MaxValue = 100;
      const int MinValue = 0;

      public static implicit operator int(LimitedInt li)      // Convert type
      {
         return li.TheValue;
      }

      public static implicit operator LimitedInt(int x)       // Convert type
      {
         LimitedInt li = new LimitedInt();
         li.TheValue = x;
         return li;
      }

      private int _TheValue = 0;

      public int TheValue                                     // Property
      {
         get { return _TheValue; }
         set
         {
            if (value < MinValue)
               _TheValue = 0;
            else
               _TheValue = value > MaxValue
               ? MaxValue
               : value;
         }
      }
   }

   class Program
   {
      static void Main()                                      // Main
      {
         LimitedInt li = 5;                                   // Convert 5 to LimitedInt
         int Five = li;                                       // Convert LimitedInt to int
         Console.WriteLine("li: {0}, Five: {1}", li.TheValue, Five);
      }
   }
}
