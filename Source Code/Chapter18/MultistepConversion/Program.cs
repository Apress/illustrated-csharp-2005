using System;
using System.Collections.Generic;
using System.Text;

namespace MultistepConversion
{
   class Person
   {
      public string Name;
      public int Age;

      // Convert a Person object to an int
      public static implicit operator int(Person p)
      {
         return p.Age;
      }
   }
   
   class Employee : Person
   {
   }

   class Program
   {
      static void Main()
      {
         Employee Bill = new Employee();
         Bill.Name = "William"; Bill.Age = 25;

         float FVar1 = Bill;    // Convert an Employee to a Person to an int to a float!
         Console.WriteLine("Person Info: {0}, {1}", Bill.Name, FVar1);
      }
   }
}
