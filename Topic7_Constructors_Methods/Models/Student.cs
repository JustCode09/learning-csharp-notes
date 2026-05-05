namespace LearningCSharpNotes.Models
{
    public class Student
    {
        public string name;
        public int age;
        public int marks;

        public Student(string n, int a, int m)
        {
            name = n;
            age = a;
            marks = m;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");
        }
    }
}