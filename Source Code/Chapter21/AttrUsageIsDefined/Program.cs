using System;

namespace AttrUsageIsDefined
{
   [AttributeUsage(AttributeTargets.Class)]
   public sealed class MyAttributeAttribute : System.Attribute
   {
      private string _Description;
      private string _VersionNumber;
      private string _ReviewerID;
      public string Description
      { get { return _Description; } set { _Description = value; } }

      public string VersionNumber
      { get { return _VersionNumber; } set { _VersionNumber = value; } }

      public string ReviewerID
      { get { return _ReviewerID; } set { _ReviewerID = value; } }

      public MyAttributeAttribute(string desc, string ver)
      {
         Description = desc;
         VersionNumber = ver;
      }
   }

   [MyAttribute("Check it out", "2.4")]
   class MyClass
   {
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();              // Create an instance of the class.
         Type t = mc.GetType();                   // Get the Type object from the instance.
         bool ItIsDefined =                       // Check the Type for the attribute.
               t.IsDefined(typeof(MyAttributeAttribute), false);

         Console.WriteLine("MyAttribute is applied to type {0}", t.Name);
      }
   }
}
