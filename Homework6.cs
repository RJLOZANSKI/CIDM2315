namespace Homework6;

class Student
{
    public static List<Student> studentList = new List<Student>();
    private int studentID { get; set; }
    private string studentName { get; set;}

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int inputID, string inputName)
    {
        studentID = inputID;
        studentName = inputName;
        studentList.Add(this);
    }

    public string GetStudentName()
    {
        return studentName;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"The average GPA is: {averageGPA}");

        foreach (var student in Student.studentList)
        {
            string studentName = student.GetStudentName();
            if (gradebook.ContainsKey(studentName))
            {
                double gpa = gradebook[studentName];
                if (gpa > averageGPA)
                {
                    student.PrintInfo();
                }
                
            }
           
        }
    }
}
