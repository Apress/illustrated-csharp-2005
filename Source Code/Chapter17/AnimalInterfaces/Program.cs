using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterfaces
{
   interface ILiveBirth                          // Declare interface
   {
      string BabyCalled();
   }

   class Animal { }                              // Base class Animal

   class Cat : Animal, ILiveBirth                // Declare class Cat
   {
      string ILiveBirth.BabyCalled()
      { return "kitten"; }
   }

   class Dog : Animal, ILiveBirth                // Declare class Dog
   {
      string ILiveBirth.BabyCalled()
      { return "puppy"; }
   }

   class Bird : Animal                           // Declare class Bird
   {
   }

   class Program
   {
      static void Main()
      {
         Animal[] AnimalArray = new Animal[3];   // Create Animal array

         AnimalArray[0] = new Cat();             // Insert Cat class object
         AnimalArray[1] = new Bird();            // Insert Bird class object
         AnimalArray[2] = new Dog();             // Insert Dog class object

         foreach (Animal a in AnimalArray)       // Cycle through array
         {
            ILiveBirth b = a as ILiveBirth;      // if it implements ILiveBirth...
            if (b != null)
               Console.WriteLine("Baby is called: {0}", b.BabyCalled());
         }
      }
   }
}
