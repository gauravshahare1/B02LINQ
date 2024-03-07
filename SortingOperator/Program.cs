#region Reverse() Method

//List<int> numbers = new List<int> { 20, 12, 45, 11 };

//foreach (var number in numbers)
//{
//    Console.Write($"{number} ");
//}
//Console.WriteLine();
//numbers.Reverse();
//foreach (var number in numbers)
//{
//    Console.Write($"{number} ");
//}
//Console.WriteLine();

//List<Student> students = Student.GetStudents();
//Console.WriteLine("*** ALL Student ***");
//Student.Print(students);

//Console.WriteLine("*** Students after Reverse() method ***");
//students.Reverse();
//Student.Print(students);


//Console.ReadLine();

#endregion Reverse() Method

#region OrderBy() & OrderByDescending() method

//List<Student> students = Student.GetStudents();
//Console.WriteLine("*** All Student ***");
//Student.Print(students);

//var result1 = students.OrderBy(s => s.Gender);
//Console.WriteLine("*** All Student after OrderBy(s => s.Gender); ***");
//Student.Print(result1);

//var result2 = students.OrderByDescending(s => s.Gender);
//Console.WriteLine("*** All Student after OrderByDescending(s => s.Gender); ***");
//Student.Print(result2);

//Console.ReadLine();

#endregion OrderBy() & OrderByDescending() method

#region ThenBy() & ThenByDescending() method

//List<Student> students = Student.GetStudents();
//Console.WriteLine("*** All Student ***");
//Student.Print(students);

//IOrderedEnumerable<Student> result1 = students.OrderBy(s => s.Gender);
//Console.WriteLine("*** All Student after OrderBy(s => s.Gender) ***");
//Student.Print(result1);

// var result2 = result1.ThenBy(s => s.Name);
//var result2 = result1.ThenByDescending(s => s.Name);
//Console.WriteLine("*** All Student after ThenByDescending(s => s.Name) ***");
//Student.Print(result2);

//var result3 = students.OrderBy(s => s.Gender).ThenBy(s => s.Age);
//Console.WriteLine("*** All Student after OrderBy(s => s.Gender).ThenBy(s => s.Age) ***");
//Student.Print(result3);

//Console.ReadLine();

#endregion ThenBy() & ThenByDescending() method

#region Sort() method

List<int> numbers = new List<int>() { 1, 11, 45, 12, 17 };
Console.WriteLine("*** ALL ITEMS ***");
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}
Console.WriteLine(); // new line

numbers.Sort();
Console.WriteLine("*** AFTER Sort() ***");
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}
Console.WriteLine(); // new line

numbers.Reverse();
Console.WriteLine("*** AFTER Reverse() ***");
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}
Console.WriteLine(); // new line

List<char> alphabets = new List<char>() { 'A', 'C', 'X', 'F' };
Console.WriteLine("*** ALL ITEMS ***");
foreach (char i in alphabets)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

alphabets.Sort();
Console.WriteLine("*** AFTER Sort() ***");
foreach (char i in alphabets)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

List<Student> students = Student.GetStudents();
Console.WriteLine("*** ALL STUDNETS ***");
Student.Print(students);

//students.Sort(); // sorted based on Age = implemented IComparable interface
//students.Sort(new StudentHelper()); // sorted based on implementaiton of IComparer<Student>

//students.Sort(0, 3, new StudentHelper()); // sorted limited items 

//public delegate int Comparison<in T>(T x, T y);

students.Sort((x, y) => x.Gender.CompareTo(y.Gender));

Console.WriteLine("*** AFTER Sort() ***");
Student.Print(students);

Console.ReadLine();

#endregion Sort() method
