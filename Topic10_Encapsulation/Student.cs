using System;

namespace LearningCSharpNotes.Topic10_Encapsulation
{
    public class Student
    {
        // Private fields (hidden from outside)
        private string name;
        private int age;
        private int marks;

        // Public properties with validation

        public string Name
        {
            get { return name; }
            set { name = value; }   // no validation needed for name
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)   // reasonable age limit
                    age = value;
                else
                    Console.WriteLine("Invalid age! Must be between 0 and 120.");
            }
        }

        public int Marks
        {
            get { return marks; }
            set
            {
                if (value >= 0 && value <= 100)
                    marks = value;
                else
                    Console.WriteLine("Invalid marks! Must be between 0 and 100.");
            }
        }

        // Optional: a method to display all info (uses properties internally)
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Marks: {Marks}");
        }
    }
}
