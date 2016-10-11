using System;
using System.Timers;            // Required for the system timer.
using System.Threading;         // Required for the Sleep method.

namespace EventWithAnonymousMethod
{
   class ClassA
   {
      public void TimerHandlerA(object obj, EventArgs e)         // Event handler
      { Console.WriteLine("Class A handler called"); }
   }

   class ClassB
   {
      public static void TimerHandlerB(object obj, EventArgs e)  // Static
      { Console.WriteLine("Class B handler called"); }
   }

   class Program
   {
      static void Main()
      {
         ClassA ca = new ClassA();                               // Create the class object.
         MyTimerClass mc = new MyTimerClass();                   // Create the timer object.

         // Add the anonymous method to the event
         mc.Elapsed += delegate(object obj, EventArgs e)
               {
                  Console.WriteLine("This is the anonymous method.");
               };

         Thread.Sleep(2250);
      }
   }

   public class MyTimerClass
   {
      public event EventHandler Elapsed;
      private void OnOneSecond(object obj, EventArgs e)
      {
         if (Elapsed != null)
            Elapsed(obj, e);
      }
      //---------------------------------------------------------------------------
      private System.Timers.Timer MyPrivateTimer;             // Private timer.
      public MyTimerClass() // Constructor
      {
         MyPrivateTimer = new System.Timers.Timer();          // Create the private timer.

         // The following statement sets our OnOneSecond method above as an event
         // handler to the Elapsed event of class Timer. It is completely
         // unrelated to our event Elapsed, declared above.
         MyPrivateTimer.Elapsed += OnOneSecond; // Attach our event handler.

         // Property Interval is of type double, and specifies the number of
         // milliseconds between when its event is raised.
         MyPrivateTimer.Interval = 1000; // 1 second interval.

         // Property Enabled is of type bool, and turns the timer on and off.
         MyPrivateTimer.Enabled = true; // Start the timer.
      }
   }
}
