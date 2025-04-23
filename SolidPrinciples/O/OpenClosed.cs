// software entities should be open for extension, but closed for modification
// Importance
// Extensibility: New features can be added without modifying existing code.
// Stability: Reduces the risk of introducing bugs when making changes.
// Flexibility: Adapts to changing requirements more easily.



// build a simple notification system, initially for email later add sms (check notification type send the proper message)


using System;

namespace SolidPrinciples.O
{
    public interface Notification
    {
        void Send(string message);
    }

    public class EmailNotification : Notification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending EMAIL: {message}");
        }
    }

    public class SmsNotification : Notification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class OpenClosedExample
    {
        public static void Run()
        {
            var notifications = new Notification[]
            {
                new EmailNotification(),
                new SmsNotification()
            };

            foreach (var notification in notifications)
            {
                notification.Send("System Alert: Something happened.");
            }
        }
    }
}
