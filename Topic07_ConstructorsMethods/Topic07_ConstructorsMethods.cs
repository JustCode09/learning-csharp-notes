using System;
using System.Collections.Generic;

namespace LearningCSharpNotes.Topic07_ConstructorsMethods
{
    // Student class with constructor and methods
    public class Student
    {
        public string name;
        public int age;
        public int marks;

        // Constructor: runs when object is created
        public Student(string n, int a, int m)
        {
            name = n;
            age = a;
            marks = m;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");
        }

        // Bonus: method to check if student passed (marks > 40)
        public bool IsPassed()
        {
            return marks > 40;
        }
    }

    public static class Topic07_ConstructorsMethods
    {
        public static void Demo()
        {
            Console.WriteLine("========== CONSTRUCTORS & METHODS INSIDE CLASS ==========\n");
            Console.WriteLine("Student System (Upgraded)\n");

            // Ask number of students
            Console.Write("Enter number of students: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Create list to hold Student objects
            List<Student> students = new List<Student>();

            // Input loop – using constructor to create objects
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Student {i}:");

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                // Create object using constructor – no manual assignment
                Student s = new Student(name, age, marks);
                students.Add(s);
                Console.WriteLine();
            }

            // Display all students using the Display() method
            Console.WriteLine("--- All Students ---");
            foreach (Student s in students)
            {
                s.Display();
            }

            // Bonus: show passed/failed status
            Console.WriteLine("\n--- Passed / Failed ---");
            foreach (Student s in students)
            {
                Console.Write($"{s.name}: ");
                if (s.IsPassed())
                    Console.WriteLine("Passed");
                else
                    Console.WriteLine("Failed");
            }
        }
    }
}