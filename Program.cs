using LearningCSharpNotes.Topics;
using LearningCSharpNotes.Topic01_VariablesIO;
using LearningCSharpNotes.Topic02_ControlFlow;
using LearningCSharpNotes.Topic03_Loops;
using LearningCSharpNotes.Topic08_Inheritance;
using LearningCSharpNotes.Topic09_Polymorphism;
using LearningCSharpNotes.Topic10_Encapsulation;
using LearningCSharpNotes.Topic11_AbstractionInterface;
using LearningCSharpNotes.Topic12_ExceptionHandling;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== C# Learning Notes =====");
        Console.WriteLine("1. Variables & I/O (Topic 1)");
        Console.WriteLine("10. Control Flow (If/Else) (Topic 2)");

        Console.WriteLine("3. Loops (Topic 3)");
        Console.WriteLine("2. Classes & Objects (Topic 6)");
        Console.WriteLine("3. Constructors & Methods (Topic 7)");
        Console.WriteLine("4. Inheritance (Topic 8)");
        Console.WriteLine("6. Encapsulation (Topic 10)");
        Console.WriteLine("7. Abstraction & Interface (Topic 11)");
        Console.WriteLine("8. Exception Handling (Topic 12)");
        Console.Write("Select topic number: ");

        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Topic01_VariablesIO.Demo();
                break;
            case "2":
                Topic02_ControlFlow.Demo();
                break;
            case "3":
                Topic03_Loops.Demo();
                break;
            case "4":
                Topic06_ClassesObjects.Demo();
                break;
            case "5":
                Topic07_Constructors.Demo();
                break;
            case "6":
                Topic08_Inheritance.Demo();
                break;
            case "7":
                Topic09_Polymorphism.Demo();
                break;
            case "8":
                Topic10_Encapsulation.Demo();
                break;
            case "9":
                Topic11_AbstractionInterface.Demo();
                break;
            case "10":
                Topic12_ExceptionHandling.Demo();
                break;
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}

