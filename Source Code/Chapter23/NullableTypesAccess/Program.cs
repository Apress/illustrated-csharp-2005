using System;

namespace NullableTypesAccess
{
   class Program
   {
      static void Main()
      {
         int? MyInt1 = 15;

         // Explicitly use properties
         if (MyInt1.HasValue)
            Console.WriteLine("{0}", MyInt1.Value);

         // Use shortcut syntax
         if (MyInt1 != null)
            Console.WriteLine("{0}", MyInt1);
      }
   }
}
