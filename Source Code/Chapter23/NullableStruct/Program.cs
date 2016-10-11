using System;

namespace NullableStruct
{
   struct MyStruct                                    // Declare a struct.
   {
      public int x;                                   // Field
      public int y;                                   // Field
      public MyStruct(int xVal, int yVal)             // Constructor
      {
         x = xVal; y = yVal;
      }
   }

   class Program
   {
      static void Main()
      {
         MyStruct MSStruct = new MyStruct(6, 11);     // Variable of struct
         MyStruct? MSNull  = new MyStruct(5, 10);     // Variable of nullable type

         Console.WriteLine("MSStruct.x: {0}", MSStruct.x);
         Console.WriteLine("MSStruct.y: {0}", MSStruct.y);

         Console.WriteLine("MSNull.x: {0}", MSNull.Value.x);
         Console.WriteLine("MSNull.y: {0}", MSNull.Value.y);
      }

   }
}
