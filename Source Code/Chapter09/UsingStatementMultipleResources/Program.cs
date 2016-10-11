using System;
using System.Collections.Generic;
using System.Text;
using System.IO;                // Need System.IO for TextWriter and TextReader

namespace UsingStatementMultipleResources
{
   class Program
   {
      static void Main()
      {
         using (TextWriter tw1 = File.CreateText("Lincoln.txt"),
                           tw2 = File.CreateText("Franklin.txt"))
         {
            tw1.WriteLine("Four score and seven years ago, ...");
            tw2.WriteLine("Early to bed; Early to rise ...");
         }

         using (TextReader tr1 = File.OpenText("Lincoln.txt"),
                           tr2 = File.OpenText("Franklin.txt"))
         {
            string InputString;
            while (null != (InputString = tr1.ReadLine()))
               Console.WriteLine(InputString);
            while (null != (InputString = tr2.ReadLine()))
               Console.WriteLine(InputString);
         }
      }
   }
}
