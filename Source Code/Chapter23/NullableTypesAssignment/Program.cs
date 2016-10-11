using System;

namespace NullableTypesAssignment
{
   class Program
   {
      static void Main()
      {
         int? MyI1, MyI2, MyI3;

         MyI1 = 28;                               // Value of underlying type
         MyI2 = MyI1;                             // Value of nullable type
         MyI3 = null;                             // Null

         Console.WriteLine("MyI1: {0}, MyI2: {1}", MyI1, MyI2);
         Console.WriteLine("MyI3 {0} null", MyI3 == null ? "is" : "is not");
      }
   }
}
