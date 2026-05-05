namespace LearningCSharpNotes.Models
{
    public class StudentBonus
    {
        public string name;
        public int marks;
        public int rollno;

        public StudentBonus(string n, int m, int roll)
        {
            name = n;
            marks = m;
            rollno = roll;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Marks: {marks}, RollNo: {rollno}");
        }

        public bool IsPassed()
        {
            return marks > 40;
        }
    }
}