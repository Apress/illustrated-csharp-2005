using System;
using System.IO;

namespace UsingStatementNested
{
   class Program
   {
      static void Main()
      {
         // using statement
         using (TextWriter tw1 = File.CreateText("Lincoln.txt"))
         {
            tw1.WriteLine("Four score and seven years ago, ...");
            using (TextWriter tw2 = File.CreateText("Franklin.txt"))   // Nested
               tw2.WriteLine("Early to bed; Early to rise ...");       // Single
         }

         // using statement
         using (TextReader tr = File.OpenText("Lincoln.txt"))
         {
            string InputString;

            while (null != (InputString = tr.ReadLine()))
               Console.WriteLine(InputString);

            // Nested using statement
            using(TextReader tr2 = File.OpenText("Franklin.txt"))
               while(null != (InputString = tr2.ReadLine()))
                  Console.WriteLine(InputString);
         }
      }
   }
}
