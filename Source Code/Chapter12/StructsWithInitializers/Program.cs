using System;

namespace StructsWithInitializers
{
   struct Simple
   {
      public int x;
      public int y;
      public Simple(int a, int b) // Constructor with parameters
      {
         x = a;
         y = b;
      }
   }

   class Program
   {
      static void Main()
      {
         Simple s1 = new Simple();
         Simple s2 = new Simple(5, 10);

         Console.WriteLine("{0},{1}", s1.x, s1.y);
         Console.WriteLine("{0},{1}", s2.x, s2.y);
      }
   }
}
