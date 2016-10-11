using System;
using System.Collections.Generic;
using System.Text;

namespace SortingMyClass
{
   class MyClass : IComparable                    // Class implements interface
   {
      public int TheValue;
      public int CompareTo(object obj)            // Implement the method.
      {
         MyClass mc = (MyClass)obj;
         if (this.TheValue < mc.TheValue) return -1;
         if (this.TheValue > mc.TheValue) return 1;
         return 0;
      }
   }

   class Program
   {
      static void PrintOut(string s, MyClass[] ma)
      {
         Console.Write(s);
         foreach (MyClass i in ma)
            Console.Write("{0} ", i.TheValue);
         Console.WriteLine("");
      }

      static void Main()
      {
         int[] MyInt = new int[5] { 20, 4, 16, 9, 2 };

         MyClass[] MyMc = new MyClass[5];         // Create array of MyClass objs
         for (int i = 0; i < 5; i++)              // Initialize the array.
         {
            MyMc[i] = new MyClass();
            MyMc[i].TheValue = MyInt[i];
         }

         PrintOut("Initial Order: ", MyMc);       // Print the initial array.
         Array.Sort(MyMc);                        // Sort the array.
         PrintOut("Sorted Order:  ", MyMc);       // Print the sorted array.
      }
   }
}
