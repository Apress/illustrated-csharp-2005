using System;

namespace EnumMembersWithNoObject
{
   enum TrafficLight
   {
      Green,
      Yellow,
      Red
   }
   
   class Program
   {
      static void Main()
      {
         Console.WriteLine("{0}", TrafficLight.Green);
         Console.WriteLine("{0}", TrafficLight.Yellow);
         Console.WriteLine("{0}", TrafficLight.Red);
      }
   }
}
