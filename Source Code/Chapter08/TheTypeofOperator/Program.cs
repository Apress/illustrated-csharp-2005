using System;
using System.Reflection;

namespace TypeofOperator
{
   class SomeClass
   {
      public int Field1;
      public int Field2;
      public void Method1() { }
      public int  Method2() { return 1; }
   }

   class Program
   {
      static void Main()
      {
         Type t = typeof(SomeClass);
         FieldInfo[] fi = t.GetFields();
         MethodInfo[] mi = t.GetMethods();

         foreach (FieldInfo f in fi)
            Console.WriteLine("Field : {0}", f.Name);

         foreach (MethodInfo m in mi)
            Console.WriteLine("Method: {0}", m.Name);
      }
   } 
}
