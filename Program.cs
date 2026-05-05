using LearningCSharpNotes.Topics;
using LearningCSharpNotes.Topic08_Inheritance;   

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== C# Learning Notes =====");
        Console.WriteLine("1. Loops (Topic 3)");
        Console.WriteLine("2. Classes & Objects (Topic 6)");
        Console.WriteLine("3. Constructors & Methods (Topic 7)");
        Console.WriteLine("4. Inheritance (Topic 8)");
        Console.Write("Select topic number: ");

        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Topic03_Loops.Demo();
                break;
            case "2":
                Topic06_ClassesObjects.Demo();
                break;
            case "3":
                Topic07_Constructors.Demo();
                break;
            case "4":
                Topic08_Inheritance.Demo();
                break;
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}

