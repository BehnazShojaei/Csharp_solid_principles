// See https://aka.ms/new-console-template for more information

using System;
using SolidPrinciples.S;
using SolidPrinciples.O;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a SOLID Principle to run:");
        Console.WriteLine("1. Single Responsibility");
        Console.WriteLine("2. Open/Closed");
        Console.WriteLine("Enter the number:");

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                SingleResponsibilityExample.Run();
                break;

            case "2":
                OpenClosedExample.Run();
                break;

            default:
                Console.WriteLine("Invalid input. Exiting.");
                break;
        }
    }
}
