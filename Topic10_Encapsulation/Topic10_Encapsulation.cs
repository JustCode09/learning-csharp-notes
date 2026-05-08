using System;

namespace LearningCSharpNotes.Topic10_Encapsulation
{
    public static class Topic10_Encapsulation
    {
        public static void Demo()
        {
            Console.WriteLine("========== ENCAPSULATION DEMO ==========\n");

            Student s = new Student();

            // Using properties (calls set behind the scenes)
            s.Name = "Ram";
            s.Age = 20;
            s.Marks = 90;

            Console.WriteLine("--- Valid data ---");
            s.Display();

            // Test validation
            Console.WriteLine("\n--- Testing invalid marks ---");
            s.Marks = 150;   // triggers "Invalid marks!"
            Console.WriteLine($"Marks after invalid attempt: {s.Marks} (remains 90)");

            Console.WriteLine("\n--- Testing invalid age ---");
            s.Age = -5;      // triggers "Invalid age!"
            Console.WriteLine($"Age after invalid attempt: {s.Age} (remains 20)");

            // Bonus: auto-property example (no validation needed)
            Console.WriteLine("\n--- Auto-property ---");
            // You could add another class with auto-properties if needed.
        }
    }
}