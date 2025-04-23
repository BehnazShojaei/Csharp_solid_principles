// The Interface segregation principle (ISP) states that "clients should not be forced to depend upon interfaces that they do not use."[6][7]

// Importance
// Decoupling: Reduces dependencies between classes, making the code more modular and maintainable.
// Flexibility: Allows for more targeted implementations of interfaces.
// Avoids unnecessary dependencies: Clients don't have to depend on methods they don't use.

// Interfaces should be small and focused, classes should not implement what they don't need


//modeling workers, robots and humans
// some can eat and work
//some can't eat but can work
// two interfaces workable and feedable then class inherit form them appropriatly 


using System;

namespace SolidPrinciples.I
{
    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();

    }

    public class HumanWorker : IWorkable, IFeedable
    {
        public void Work()
        {
            Console.WriteLine("Human is working");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating lunch");
        }
    }

    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");

        }
    }

    public class InterfaceSegregationExample
    {
        public static void Run()
        {
            Console.WriteLine("Interface Segregation Principle Example:");



            // HumanWorker humanWroker = new HumanWorker();
            // humanWorker.Work();
            // humanWroker.Eat();

            IWorkable humanWorker = new HumanWorker();
            humanWorker.Work();
            ((IFeedable)humanWorker).Eat();  // Need to cast to access Eat()


            IWorkable robotWorker = new RobotWorker();
            robotWorker.Work();
        }

    }
}
