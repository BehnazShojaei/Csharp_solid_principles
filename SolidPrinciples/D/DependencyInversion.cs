// The Dependency inversion principle (DIP) states to depend upon abstractions, [not] concretes.[8][7]

// Importance
// Loose coupling: Reduces dependencies between modules, making the code more flexible and easier to test.
// Flexibility: Enables changes to implementations without affecting clients.
//  Maintainability: Makes code easier to understand and modify.

// High-level modules should not depend on low-level modules. Both should depend on abstractions.
// Abstractions should not depend on details. Details should depend on abstractions.


//note to myself: difference between open/closed and Dependency inversion
// OCP	"If I add a new feature, do I have to touch old code?" (You shouldn’t.)
// DIP	"Am I depending on behavior (interface) or implementation (class)?" (Should be behavior.)


// one abstraction : send method in interface
// concrete implementation: two class for email and sms
// high level module : notification sender using the interface 

using System;

namespace SolidPrinciples.D
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");

        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending sms: {message}");
        }
    }

    public class NotificationSender
    {
        private readonly INotification _notification;
        public NotificationSender(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message)
        {
            _notification.Send(message);
        }
    }
    public class DependencyInversionExample
    {
        public static void Run()
        {
            Console.WriteLine("Dependency Inversion Principle Example:");

            INotification email = new EmailNotification();
            INotification sms = new SmsNotification();

            NotificationSender emailSender = new NotificationSender(email);
            emailSender.Notify("System is up and running");

            NotificationSender smsSender = new NotificationSender(sms);
            smsSender.Notify("System alert: Check the server!");
        }
    }
}