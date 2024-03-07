public class Student : IComparable
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public static List<Student> GetStudents()
    {
        return new List<Student>()
        {
        new Student(){ RollNumber = 1, Name = "Vishal", Gender  = "Male", Age = 20},
        new Student(){ RollNumber = 2, Name = "Shital", Gender  = "Female", Age = 20},
        new Student(){ RollNumber = 3, Name = "Vivek", Gender  = "Male", Age = 25},
        new Student(){ RollNumber = 4, Name = "Priya", Gender  = "Female", Age = 21},
        new Student(){ RollNumber = 5, Name = "Dipak", Gender  = "Male", Age = 27}
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

    public int CompareTo(object? obj)
    {
        Student s = obj as Student;

        //if (this.Age < s.Age)
        //{
        //    return 1;
        //}
        //else if (this.Age > s.Age)
        //{
        //    return -1;
        //}
        //else
        //{
        //    return 0;
        //}

        return this.Age.CompareTo(s.Age);
    }
}