namespace LearningCSharpNotes.Models
{
    public class Student2
    {
        public string name;
        public int marks;
        public int rollno;

        public Student2(string name, int marks, int rollno)
        {
            this.name = name;
            this.marks = marks;
            this.rollno = rollno;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Marks: {marks}, RollNo: {rollno}");
        }
    }
}