using System;

namespace StructPoint
{
   struct Point
   {
      public int X;
      public int Y;
   }

   class Program
   {
      static void Main()
      {
         Point First, Second, Third;

         First.X = 10; First.Y = 10;
         Second.X = 20; Second.Y = 20;
         Third.X = First.X + Second.X;
         Third.Y = First.Y + Second.Y;

         Console.WriteLine("First:  {0}, {1}", First.X, First.Y);
         Console.WriteLine("Second: {0}, {1}", Second.X, Second.Y);
         Console.WriteLine("Third:  {0}, {1}", Third.X, Third.Y);
      }
   }
}
