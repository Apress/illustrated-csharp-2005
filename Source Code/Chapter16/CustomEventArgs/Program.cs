using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CustomEventArgs
{
   public class MyTCEventArgs : EventArgs
   {
      public string Message;

      public MyTCEventArgs(string s)
      {
         Message = s;
      }
   }

   public class MyTimerClass
   {
      public event EventHandler<MyTCEventArgs> Elapsed; // Event declaration

      private void OnOneSecond(object obj, EventArgs e)
      {
         if (Elapsed != null)
         {
            MyTCEventArgs mtcea =
            new MyTCEventArgs("Message from OnOneSecond");
            Elapsed(obj, mtcea);
         }
      }
      private System.Timers.Timer MyPrivateTimer;      // Private timer.
      public MyTimerClass()                            // Constructor
      {
         MyPrivateTimer = new System.Timers.Timer();   // Create the private timer.
         MyPrivateTimer.Elapsed += OnOneSecond;        // Attach our event handler.
         MyPrivateTimer.Interval = 1000;               // 1 second interval.
         MyPrivateTimer.Enabled = true;                // Start the timer.
      }
   }

   class ClassA
   {
      public void TimerHandlerA(object obj, MyTCEventArgs e)
      {
         Console.WriteLine("Class A Message: {0}", e.Message);
      }
   }

   class Program
   {
      static void Main()
      {
         ClassA ca = new ClassA();
         MyTimerClass mc = new MyTimerClass();

         mc.Elapsed +=  // Register handler.
               new EventHandler<MyTCEventArgs>(ca.TimerHandlerA);

         Thread.Sleep(3250);
      }
   }
}
