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
         MyClass mc = new MyClass();
         Type t = mc.GetType();
         object[] AttArr = t.GetCustomAttributes(false);
         foreach (Attribute a in AttArr)
         {
            MyAttributeAttribute attr = a as MyAttributeAttribute;
            if (null != attr)
            {
               Console.WriteLine("Description    : {0}", attr.Description);
               Console.WriteLine("Version Number : {0}", attr.VersionNumber);
               Console.WriteLine("Reviewer ID    : {0}", attr.ReviewerID);
            }
         }
      }
   }
}
