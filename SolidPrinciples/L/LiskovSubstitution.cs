// The Liskov substitution principle (LSP) states that functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.
// “Subtypes must be substitutable for their base types without breaking the program.”
// If class B is a subtype of class A, then B should be usable anywhere A is expected — without weird side effects, broken logic, or needing special handling.

// Importance
// Polymorphism: Enables the use of polymorphic behavior, making code more flexible and reusable.
// Reliability: Ensures that subclasses adhere to the contract defined by the superclass.
// Predictability: Guarantees that replacing a superclass object with a subclass object won't break the program.[5]



// define a bird abstract class
// define a Ifly class interface inherit from bird
// define a pigeon class inherit from Ifly
// define a penguin class inherit from bird

using System;
using SolidPrinciples.L;

namespace SolidPrinciples.L
{
    public abstract class Bird
    {
        public abstract void Eat();
    }

    public abstract class FlyingBird : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Fly high!");
        }
    }
    class Pigeon : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Pigeon eat seeds!");
        }

    }

    class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("The Penguin eat fish");
        }

    }

}

public class LiskovExample
{

    public static void Run()
    {
        Console.WriteLine("Liskov Substitution Principle Example:");
        Bird pigeon = new Pigeon();
        pigeon.Eat();

        if (pigeon is FlyingBird flyingPigeon)
        {
            flyingPigeon.Fly();
        }

        Bird penguin = new Penguin();
        penguin.Eat();

        if (penguin is FlyingBird)
        {
            Console.WriteLine("Penguin can fly?!!! which is not correct");

        }
        else
        {
            Console.WriteLine("Penguin can't fly!");
        }
    }
}




