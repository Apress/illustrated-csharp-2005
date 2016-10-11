using System;

namespace UserDefinedConversion
{
   class Person
   {
      public string Name;
      public int Age;
      public Person(string name, int age)
      {
         Name = name;
         Age = age;
      }

      // Convert Person to int
      public static implicit operator int(Person p)
      {
         return p.Age;
      }

      // Convert int to Person
      public static implicit operator Person(int i)
      {
         return new Person("Nemo", i);   // "Nemo" is Latin for "no one".
      }
   }

   class Program
   {
      static void Main()
      {
         Person Bill = new Person("Bill", 25);

         int age = Bill;                  // Convert a Person to an int
         Console.WriteLine("Person Info: {0}, {1}", Bill.Name, age);

         Person Anon = 35;                // Convert an int to a Person
         Console.WriteLine("Person Info: {0}, {1}", Anon.Name, Anon.Age);
      }
   }
}
