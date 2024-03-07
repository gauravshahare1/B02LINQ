public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public List<string> Subjects { get; set; }

    public static List<Student> GetStudents()
    {
        return new List<Student>()
        {
        new Student(){ RollNumber = 1, Name = "Vishal", 
            Gender  = "Male", Age = 20, Subjects = new List<string>(){ "S1", "S2"} },
        new Student(){ RollNumber = 2, Name = "Shital", 
            Gender  = "Female", Age = 20, Subjects = new List<string>(){ "S3"} },
        new Student(){ RollNumber = 3, Name = "Vivek", 
            Gender  = "Male", Age = 25, Subjects = new List<string>(){ "S4", "S5"} },
        new Student(){ RollNumber = 4, Name = "Priya", 
            Gender  = "Female", Age = 21, Subjects = new List<string>(){ "S6"} },
        new Student(){ RollNumber = 5, Name = "Dipak", 
            Gender  = "Male", Age = 27, Subjects = new List<string>(){ "S7", "S8"} }
        };
    }

    public static void Print(IEnumerable<Student> students)
    {
        foreach (Student student in students)
        {
            Console.WriteLine($"Roll Number : {student.RollNumber} Name : {student.Name}" +
                $" Gender : {student.Gender} Age : {student.Age}");
        }
    }
}