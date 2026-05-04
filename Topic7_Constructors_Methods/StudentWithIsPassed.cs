using LearningCSharpNotes.Topic7_Constructors_Methods;

class Program
{
    static void Main()
    {
        // Using constructor topic
        StudentWithConstructor s1 = new StudentWithConstructor("Ram", 80, 1);
        s1.Display();

        StudentWithIsPassed s2 = new StudentWithIsPassed("Sita", 35, 2);
        Console.WriteLine($"Passed? {s2.IsPassed()}");
    }
}