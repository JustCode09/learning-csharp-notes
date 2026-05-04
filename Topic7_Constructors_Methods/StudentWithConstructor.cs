namespace LearningCSharpNotes.Topic7_Constructors_Methods
{
    public class StudentWithConstructor
    {
        public string name;
        public int marks;
        public int rollno;

        public StudentWithConstructor(string n, int m, int roll)
        {
            name = n;
            marks = m;
            rollno = roll;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Marks: {marks}, RollNo: {rollno}");
        }
    }
}