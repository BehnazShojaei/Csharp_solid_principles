// See https://aka.ms/new-console-template for more information

using System;
using SolidPrinciples.S;
using SolidPrinciples.O;
using SolidPrinciples.L;
using SolidPrinciples.I;
using SolidPrinciples.D;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a SOLID Principle to run:");
        Console.WriteLine("1. Single Responsibility");
        Console.WriteLine("2. Open/Closed");
        Console.WriteLine("3. Liskov Substitution");
        Console.WriteLine("4. Interface Segregation");
        Console.WriteLine("5. Dependency Inversion");

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
            case "3":
                LiskovExample.Run();
                break;
            case "4":
                InterfaceSegregationExample.Run();
                break;
            case "5":
                DependencyInversionExample.Run();
                break;

            default:
                Console.WriteLine("Invalid input. Exiting.");
                break;
        }
    }
}




