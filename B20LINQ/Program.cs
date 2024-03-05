#region regular C# code

List<Student> students = new List<Student>()
{
new Student(){ RollNumber = 1, Name = "Vishal", Gender  = "Male"},
new Student(){ RollNumber = 2, Name = "Shital", Gender  = "Female"},
new Student(){ RollNumber = 3, Name = "Vivek", Gender  = "Male"},
new Student(){ RollNumber = 4, Name = "Priya", Gender  = "Female"},
new Student(){ RollNumber = 5, Name = "Dipak", Gender  = "Male"}
};

foreach (Student s in students)
{
    Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} Gender : {s.Gender}");
}

//filter female students
//List<Student> femaleStudents = new List<Student>();
//foreach (Student s in students)
//{
//    if (s.Gender.Equals("Female"))
//    {
//        femaleStudents.Add(s);
//    }
//}

// linq query syntax
//var femaleStudents = from s in students
//                     where s.Gender.Equals("Female")
//                     select s;

var femaleStudents = students.Where(s => s.Gender.Equals("Female"));

Console.WriteLine("*** Female Students ***");
foreach (Student s in femaleStudents)
{
    Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} ");
}

//List<int> numbers1 = new List<int>();
//HashSet<int> numbers2 = new HashSet<int>();
Console.WriteLine("*******************************************\n\n\n\n");

var names = students.Select(s => s.Name);
foreach (string n in names)
{
    Console.Write($"{n} ");
}




Console.WriteLine();

List<object> a = new List<object>() { 10, 20, "Vishal", '$', 20.5f, '#' };
var result = a.OfType<int>();
foreach (int item in result)
{
    Console.Write($"{item} ");
}

#endregion regular C# code

Console.ReadLine();

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}