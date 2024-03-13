using System.Collections;

List<int> numbers1 = new List<int>();
Console.WriteLine(numbers1.GetType().Name);

IEnumerable<int> numbers2 = numbers1.AsEnumerable<int>();
Console.WriteLine(numbers2.GetType().Name);

int[] numbers3 = new int[] { 1, 2, 3 };
Console.WriteLine(numbers3.GetType().Name);

IEnumerable<int> numbers4 = numbers3.AsEnumerable<int>();
Console.WriteLine(numbers4.GetType().Name);
IQueryable<int> numbers5 = numbers4.AsQueryable();
Console.WriteLine(numbers5.GetType().Name);

ArrayList numbers6 = new ArrayList(); // non generic
IEnumerable<int> numbers7 = numbers6.Cast<int>(); // generic

numbers1 = new List<int>(); // list
int[] numbers8 = numbers1.ToArray(); // array

Dictionary<int, int> numbers9 =
    numbers1.ToDictionary<int, int>(i => i); //dictionary

List<string> names = new List<string>() { "OM", "ANIL", "Ramesh" };
// dicitonary name - key, length - value
Dictionary<int, string> names1 =
    names.ToDictionary<string, int>(s => s.Length);
foreach (var item in names1)
{
    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
}


Console.ReadLine();