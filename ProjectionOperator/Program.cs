#region Select() with Simple type

List<string> names = new List<string>() { "Vishal", "Mahesh", "Ramesh", "Anil", "OM" };
Console.WriteLine("*** ALL ITEMS ***");
foreach (string item in names)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

var namesInUpper = names.Select(s => s.ToUpper());
Console.WriteLine("*** Select(s => s.ToUpper()) ***");
foreach (string item in namesInUpper)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

IEnumerable<int> lengths = names.Select(s => s.Length);
Console.WriteLine("*** names.Select(s => s.Length) ***");
foreach (int item in lengths)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


//IEnumerable<Any> anys = names.
//    Select(s => new Any() { Name = s, Length = s.Length });

//Console.WriteLine("*** Select(s => new Any() { Name = s, Length = s.Length}) ***");
//foreach (var item in anys)
//{
//    Console.Write($"{item.Name}: {item.Length} ");
//}
//Console.WriteLine();

var result = names.Select(s => new { Name = s, Length = s.Length });

Console.WriteLine("*** Select(s => new { Name = s, Length = s.Length }) ***");
foreach (var item in result)
{
    Console.Write($"{item.Name}: {item.Length} ");
}
Console.WriteLine();


Console.ReadLine();

class Any
{
    public string Name { get; set; }
    public int Length { get; set; }
}

//Console.ReadLine();

#endregion Select() with Simple type

#region Select() with Complex type

//List<Student> students = Student.GetStudents();
//Console.WriteLine("*** ALL STUDENTS ***");
//Student.Print(students);

//// var names = students.Select(s => s.Name);
//var names = from s in students
//            select s.Name;

//foreach (var item in names)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

////var sDetails = students.Select(s => new { Name = s.Name, Gender = s.Gender });
//var sDetails = from s in students
//               select new { Name = s.Name, Gender = s.Gender };

//foreach (var item in sDetails)
//{
//    Console.Write($"{item.Name}:{item.Gender} ");
//}
//Console.WriteLine();

//var subjects = students.Select(s => s.Subjects);
//foreach (var item in subjects)
//{
//    foreach (var i in item)
//    {
//        Console.Write($"{i} ");
//    }
//}
//Console.WriteLine();

//// selectmany()
//var subjects1 = students.SelectMany(s => s.Subjects);
//foreach (var item in subjects1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//Console.ReadLine();

#endregion Select() with Complex type