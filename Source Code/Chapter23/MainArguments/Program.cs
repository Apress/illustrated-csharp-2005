using System;

namespace MainArguments
{
   class Program
   {
      static void Main(string[] args)
      {
         foreach (string s in args)
            Console.WriteLine(s);
      }
   }
}
