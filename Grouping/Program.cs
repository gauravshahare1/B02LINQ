List<Student> students = Student.GetStudents();

Console.WriteLine("*** ALL STUDENTS ***");
Student.Print(students);

// group on gender
var groups = students.GroupBy(s => s.Gender);
//var groups = students.GroupBy(s => s.Age);

//var groups = from s in students
//             group s by s.Gender;

//var groups = students.ToLookup(s => s.Gender);

Console.WriteLine($"Number of Gender Group : {groups.Count()}");
foreach (var group in groups)
{
    Console.WriteLine($"{group.Key} : {group.Count()}");
    foreach (var i in group)
    {
        Console.Write($"{i.Name} ");
    }
    Console.WriteLine();
}

Console.ReadLine();