using System;

namespace LearningCSharpNotes.Topic08_Inheritance
{
    // Parent class: contains common properties for all persons
    public class Person
    {
        public string name;
        public int age;

        // Method that can be used by any child
        public void ShowBasic()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
