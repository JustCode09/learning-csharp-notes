using System;

namespace LearningCSharpNotes.Topic08_Inheritance
{
    public static class Topic08_Inheritance
    {
        public static void Demo()
        {
            Console.WriteLine("========== INHERITANCE DEMO ==========\n");

            // Create a Student object (inherits from Person)
            Student student = new Student();
            student.name = "Ram";
            student.age = 20;
            student.marks = 80;

            // Create a Teacher object
            Teacher teacher = new Teacher();
            teacher.name = "Hari";
            teacher.age = 35;
            teacher.salary = 30000;

            // Display using ShowBasic (from Person) and direct field access
            Console.WriteLine("--- Student ---");
            student.ShowBasic();          // from Person
            Console.WriteLine($"Marks: {student.marks}");

            Console.WriteLine("\n--- Teacher ---");
            teacher.ShowBasic();          // from Person
            Console.WriteLine($"Salary: {teacher.salary}");

            // Bonus: also show a combined output exactly as required:
            Console.WriteLine("\n--- Expected Format ---");
            Console.WriteLine($"Student: {student.name}, {student.age}, Marks: {student.marks}");
            Console.WriteLine($"Teacher: {teacher.name}, {teacher.age}, Salary: {teacher.salary}");
        }
    }
}