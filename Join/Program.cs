List<Trainer> trainers = new List<Trainer>()
{
new Trainer(){ Id = 1, Name = "Vikul", Experience = 13},
new Trainer(){ Id = 2, Name = "Usha", Experience = 2},
new Trainer(){ Id = 3, Name = "Atul", Experience = 3}
};

Console.WriteLine("*** ALL TRAINERS ***");
foreach (var item in trainers)
{
    Console.WriteLine($"Id : {item.Id} Name : {item.Name} Experience : {item.Experience}");
}

List<Student> students = new List<Student>()
{
new Student(){ RollNumber = 1, Name = "Vishal", City = "Pune", TrainerId = 1},
new Student(){ RollNumber = 2, Name = "Ramesh", City = "Mumbai", TrainerId = 2},
new Student(){ RollNumber = 3, Name = "Shital", City = "Pune", TrainerId = 1},
new Student(){ RollNumber = 4, Name = "Dipak", City = "Pune", TrainerId = null},
new Student(){ RollNumber = 5, Name = "Snehal", City = "Pune", TrainerId = null}
};
Console.WriteLine("*** ALL STUDENTS ***");
foreach (var item in students)
{
    Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} " +
        $"City : {item.City} Trainer Id : {item.TrainerId}");
}

//// Join() - returns inner join result - common items from both collections

//var result1 = students.Join(trainers, s => s.TrainerId, t => t.Id,
//    (s, t) => new { StudentName = s.Name, TrainerName = t.Name });

var result1 = from s in students
              join t in trainers
              on s.TrainerId equals t.Id
              select new
              {
                  StudentName = s.Name,
                  City = s.City,
                  TrainerName = t.Name,
                  Experience = t.Experience
              };

Console.WriteLine("*** students.Join(trainers) ***");
foreach (var item in result1)
{
    Console.WriteLine($"Student Name : {item.StudentName} City : {item.City} " +
        $"Trainer Name : {item.TrainerName}" +
        $" Experience :{item.Experience}");
}

//// GroupJoin() - returns left outer join result
//var result2 = students.GroupJoin(trainers, s => s.TrainerId,
//    t => t.Id,
//    (s, t) => new
//    {
//        StudentName = s.Name,
//        TrainerName = t.FirstOrDefault(t => t.Id == s.TrainerId)?.Name
//    });

var result2 = from s in students
              join t in trainers
              on s.TrainerId equals t.Id
              into trainer
              from tt in trainer.DefaultIfEmpty()
              select new { StudentName = s.Name, TrainerName = tt?.Name };

Console.WriteLine("*** students.GroupJoin(trainers) ***");
foreach (var item in result2)
{
    Console.WriteLine($"Student Name : {item.StudentName} " +
        $"Trainer Name : {item.TrainerName}");
}

// right join 
var result3 = from t in trainers
              join s in students
              on t.Id equals s.TrainerId
              into student
              from ss in student.DefaultIfEmpty()
              select new { StudentName = ss?.Name, TrainerName = t.Name };

Console.WriteLine("*** right join ***");
foreach (var item in result3)
{
    Console.WriteLine($"Student Name : {item.StudentName} " +
        $"Trainer Name : {item.TrainerName}");
}

Console.WriteLine("*** full join ***");
var result4 = result2.Union(result3);
foreach (var item in result4)
{
    Console.WriteLine($"Student Name : {item.StudentName} " +
        $"Trainer Name : {item.TrainerName}");
}

Console.WriteLine("*** cross join ***");
var result5 = (from s in students
               from t in trainers
               select new { StudentName = s.Name, TrainerName = t.Name })
              .ToList();

foreach (var item in result5)
{
    Console.WriteLine($"Student Name : {item.StudentName} " +
        $"Trainer Name : {item.TrainerName}");
}

// deferred execution / immediate execution
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
// find even numbers
var even1 = numbers.Where(i => i % 2 == 0); // deferred execution

var even2 = numbers.FindAll(i => i % 2 == 0); // immediate execution


Console.ReadLine();

class Trainer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
}

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int? TrainerId { get; set; }
}