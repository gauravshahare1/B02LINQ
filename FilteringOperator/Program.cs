#region Where operator

//List<Student> students = Student.GetStudents();

//Console.WriteLine("*** ALL STUDENTS ***");
//Student.Print(students);

//// female students
//IEnumerable<Student> females = students.Where(s => s.Gender.Equals("Female"));
//Console.WriteLine("*** ALL FEMALES ***");
//Student.Print(females);

//age greater than 18 and less than 22
//var ages = students.Where(s => s.Age >= 18 && s.Age <= 22);
//var ages = students.Where(delegate (Student s)
//{
//    return s.Age >= 18 && s.Age <= 22;
//});

//var ages = from s in students
//           where s.Age >= 18 && s.Age <= 22
//           select s;

//Console.WriteLine("*** Age between 18 & 22 ***");
//Student.Print(ages);

//Console.ReadLine();

#endregion Where operator

#region OfType operator

List<object> list = new List<object>() { 10, 20, '$', "Vishal", '#' };
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

//filter only char type items
 //var chars = list.Where(o => o.GetType().Name == "Char");

var chars = list.OfType<int>();
foreach (var item in chars)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

List<Car> cars = new List<Car>()
{
new Car(), new AUDI(), new BMW(), new Car(), new AUDI(), new AUDI()
};

Console.WriteLine("*** ALL CARS ***");
foreach (var item in cars)
{
    Console.Write($"*{item.Name}* ");
}
Console.WriteLine();

IEnumerable<BMW> cars1 = cars.OfType<BMW>();
// var cars1 = cars.Where(c => c.GetType().Name == "AUDI");
foreach (var item in cars1)
{
    Console.Write($"*{item.Name}* ");
}
Console.WriteLine();

Console.ReadLine();

class Car
{
    public string Name = "NORMAL CAR";
    //public Car()
    //{
    //    Name = "NORMAL CAR";
    //}
}

class AUDI : Car
{
    public AUDI()
    {
        Name = "AUDI CAR";
    }
}

class BMW : Car
{
    public BMW()
    {
        Name = "BMW Car";
    }
}


#endregion OfType operator