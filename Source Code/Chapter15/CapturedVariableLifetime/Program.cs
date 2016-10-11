using System;
using System.Collections.Generic;
using System.Text;

namespace CapturedVariableLifetime
{
   class Program
   {
      delegate void MyDel();

      static void Main()
      {
         MyDel mDel;
         {
            int x = 5;
            mDel = delegate
                   {
                      Console.WriteLine("Value of x: {0}", x);
                   };
         }

         // Console.WriteLine("Value of x: {0}", x); // Variable x is out of scope here
                                                     // and would cause a compile error
         if (null != mDel)
            mDel();
      }
   }
}
