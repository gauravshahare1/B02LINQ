List<int> numbers = new List<int>() { 1, 11, 24, 11 };

Console.WriteLine("*** ALL ITEMS ***");
foreach (var item in numbers)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

// Distinct() -> to retrieve unique items
IEnumerable<int> result = numbers.Distinct();
Console.WriteLine("*** numbers.Distinct() ***");
foreach (var item in result)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line


List<int> numbers1 = new List<int>() { 3, 1, 2 };
List<int> numbers2 = new List<int>() { 4, 5, 2 };

var result1 = numbers1.Intersect(numbers2);
Console.WriteLine("*** numbers1.Intersect(numbers2) ***");
foreach (var item in result1)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

var result2 = numbers1.Except(numbers2);
Console.WriteLine("*** numbers1.Except(numbers2) ***");
foreach (var item in result2)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

var result3 = numbers1.Union(numbers2);
Console.WriteLine("*** numbers1.Union(numbers2) ***");
foreach (var item in result3)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

var result4 = numbers1.Concat(numbers2);
Console.WriteLine("*** numbers1.Concat(numbers2) ***");
foreach (var item in result4)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

numbers1 = new List<int>() { 3, 1, 2 };
numbers2 = new List<int>() { 1, 2, 3 };

if (numbers1.Count == numbers2.Count)
{
    numbers1.Sort();
    numbers2.Sort();

    bool b = numbers1.SequenceEqual(numbers2);
    Console.WriteLine($"Are collections equal : {b}");
}

Console.ReadLine();