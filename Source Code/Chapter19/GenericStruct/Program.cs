using System;
using System.Collections.Generic;

namespace GenericStruct
{
   struct PieceOfData<T> // Generic struct
   {
      public PieceOfData(T value) { _Data = value; }
      private T _Data;
      public T Data
      {
         get { return _Data; }
         set { _Data = value; }
      }
   }

   class Program
   {
      static void Main()
      {
         PieceOfData<int> IntData       = new PieceOfData<int>(10);
         PieceOfData<string> StringData = new PieceOfData<string>("Hi there.");

         Console.WriteLine("IntData    = {0}", IntData.Data);
         Console.WriteLine("StringData = {0}", StringData.Data);
      }
   }
}
