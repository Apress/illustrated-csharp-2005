using System;

namespace ConstructorWithParams
{
   class Class1
   {
      int MyNumber;
      string MyName;
      public Class1() { MyNumber = 28; MyName = "Nemo"; }             // Constructor 0
      public Class1(int Value) { MyNumber = Value; MyName = "Nemo"; } // Constructor 1
      public Class1(String Name) { MyName = Name; }                   // Constructor 2

      public void SoundOff()
      {
         Console.WriteLine("MyName {0}, MyNumber {1}", MyName, MyNumber);
      }
   }

   class Program
   {
      static void Main()
      {
         Class1 a = new Class1(), // Call constructor 0.
         b = new Class1(7),       // Call constructor 1.
         c = new Class1("Bill");  // Call constructor 2.
         a.SoundOff();
         b.SoundOff();
         c.SoundOff();
      }
   }
}
