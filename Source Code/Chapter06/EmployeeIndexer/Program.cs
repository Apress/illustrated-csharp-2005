using System;

namespace EmployeeIndexer
{
   class Employee
   {
      public string LastName;              // Call this field 0.
      public string FirstName;             // Call this field 1.
      public string CityOfBirth;           // Call this field 2.
      public string this[int index]        // Indexer declaration
      {
         set // Set accessor declaration
         {
            switch (index)
            {
               case 0: LastName = value;
                  break;
               case 1: FirstName = value;
                  break;
               case 2: CityOfBirth = value;
                  break;
            }
         }
         get                               // Get accessor declaration
         {
            switch (index)
            {
               case 0: return LastName;
               case 1: return FirstName;
               case 2: return CityOfBirth;
               default:
                  return "";
            }
         }
      }
   }

   class Program
   {
      static void Main()
      {
         Employee E1 = new Employee();
         E1.LastName = "Doe";
         E1.FirstName = "Jane";
         E1.CityOfBirth = "Dallas";

         Console.WriteLine("{0}, {1} -- Birthplace: {2}", E1[0], E1[1], E1[2]);
      }
   }
}
