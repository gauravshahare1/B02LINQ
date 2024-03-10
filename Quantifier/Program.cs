using System.Diagnostics.CodeAnalysis;

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

bool b1 = numbers.All(i => i > 1);
Console.WriteLine($"numbers.All(i => i > 1) : {b1}"); // false

b1 = numbers.All(i => i > 0);
Console.WriteLine($"numbers.All(i => i > 0) : {b1}"); // true

b1 = numbers.All(i => i > 5);
Console.WriteLine($"numbers.All(i => i > 5) : {b1}"); // false

b1 = numbers.Any(i => i > 1);
Console.WriteLine($"numbers.Any(i => i > 1) : {b1}"); // true

b1 = numbers.Any(i => i > 6);
Console.WriteLine($"numbers.Any(i => i > 6) : {b1}"); // false

b1 = numbers.Any(i => i > 5);
Console.WriteLine($"numbers.Any(i => i > 5) : {b1}"); // true

b1 = numbers.Contains(2);
Console.WriteLine($"numbers.Contains(2) : {b1}"); // true
b1 = numbers.Contains(20);
Console.WriteLine($"numbers.Contains(20) : {b1}"); // false

b1 = numbers.Contains(5);
Console.WriteLine($"numbers.Contains(5) : {b1}"); // true

List<Student> students = Student.GetStudents();
Student.Print(students);

int r1 = students.Count();
Console.WriteLine($"Number of Students : {r1}"); // 5

r1 = students.Count(s => s.Gender.Equals("Female"));
Console.WriteLine($"Number of female students : {r1}"); // 2

//Student s1 =
//    new Student()
//    {
//        RollNumber = 1,
//        Name = "Vishal",
//        Gender = "Male",
//        Age = 20
//    };

//bool b = students.Contains(s1, new StudentHelper());
//Console.WriteLine($"students.Contains(s1) : {b}");

Console.ReadLine();

class StudentHelper : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.RollNumber.Equals(y.RollNumber) &&
            x.Name.Equals(y.Name) &&
            x.Gender.Equals(y.Gender) &&
            x.Age.Equals(y.Age);
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        return obj.RollNumber.GetHashCode() ^
             obj.Name.GetHashCode() ^
             obj.Gender.GetHashCode() ^
             obj.Age.GetHashCode();
    }
}