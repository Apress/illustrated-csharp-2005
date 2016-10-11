using System;

namespace TheIsOperator
{
   class Employee : Person { }

   class Person
   {
      public string Name = "Anonymous";
      public int Age = 25;
   }

   class Program
   {
      static void Main()
      {
         Employee Bill = new Employee();
         Person p;

         // Check if variable Bill can be converted to type Person
         if (Bill is Person)
         {
            p = Bill;
            Console.WriteLine("Person Info: {0}, {1}", p.Name, p.Age);
         }
      }
   }
}
