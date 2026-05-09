using System;
using System.Collections.Generic;

namespace LearningCSharpNotes.Topic06_ClassesObjects
{
    // Student class (blueprint)
    public class Student
    {
        public string name;
        public int age;
        public int marks;
    }

    public static class Topic06_ClassesObjects
    {
        public static void Demo()
        {
            Console.WriteLine("========== CLASSES & OBJECTS DEMO ==========\n");
            Console.WriteLine("Student System\n");

            // Step 1: Ask number of students
            Console.Write("Enter number of students: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Step 2: Create list to store Student objects
            List<Student> students = new List<Student>();

            // Step 3: Input loop – create objects, fill data, add to list
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Student {i}:");

                Student s = new Student();

                Console.Write("Name: ");
                s.name = Console.ReadLine();

                Console.Write("Age: ");
                s.age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Marks: ");
                s.marks = Convert.ToInt32(Console.ReadLine());

                students.Add(s);
                Console.WriteLine();
            }

            // Step 4: Print all students
            Console.WriteLine("--- All Students ---");
            foreach (Student s in students)
            {
                Console.WriteLine($"Name: {s.name}, Age: {s.age}, Marks: {s.marks}");
            }

            // Bonus 1: Find student with highest marks
            Student top = students[0];
            foreach (Student s in students)
            {
                if (s.marks > top.marks)
                    top = s;
            }
            Console.WriteLine($"\nHighest marks: {top.name} with {top.marks} marks");

            // Bonus 2: Print only students with marks > 50
            Console.WriteLine("\nStudents with marks > 50:");
            foreach (Student s in students)
            {
                if (s.marks > 50)
                    Console.WriteLine($"- {s.name} ({s.marks})");
            }
        }
    }
}
