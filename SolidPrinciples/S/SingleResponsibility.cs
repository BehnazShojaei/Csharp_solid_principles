// The Single-responsibility principle (SRP) states that "There should never be more than one reason for a class to change."
// In other words, every class should have only one responsibility.

// Importance
// Maintainability: When classes have a single, well-defined responsibility, they're easier to understand and modify.
// Testability: It's easier to write unit tests for classes with a single focus.
// Flexibility: Changes to one responsibility don't affect unrelated parts of the system.

// SingleResponsibility.cs

using System;

namespace SolidPrinciples.S
{
    // Class that violates SRP (bad example)
    /*
    class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void SaveToFile(string path)
        {
            // Code to save to a file
        }
    }
    */

    // Correct SRP
    class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    class ReportSaver
    {
        public void SaveToFile(Report report, string path)
        {
            Console.WriteLine($"Saving report '{report.Title}' to {path}");
        }
    }

    class SingleResponsibilityExample
    {
        public static void Run()
        {
            var report = new Report { Title = "Weekly Report", Content = "All good!" };
            var saver = new ReportSaver();
            saver.SaveToFile(report, "/reports/weekly.txt");
        }
    }
}

