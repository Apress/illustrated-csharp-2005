using System;

namespace DelegateWithReturnValues
{
   delegate int MyDel();                // Declare delegate with return type.

   class MyClass
   {
      int IntValue = 5;
      public int Add2() { IntValue += 2; return IntValue; }
      public int Add3() { IntValue += 3; return IntValue; }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();    // Create an object of the class.

         MyDel mDel = mc.Add2;          // Create and initialize the delegate.
         mDel += mc.Add3;               // Add a method.
         mDel += mc.Add2;               // Add a method.

         Console.WriteLine("Value: {0}", mDel());
      }
   }
}
