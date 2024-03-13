List<int> numbers1; // null
List<int> numbers2 = new List<int>(); // count = 0

IEnumerable<int> numbers3 = Enumerable.Empty<int>();
Console.WriteLine($"numbers3 count: {numbers3.Count()}");

foreach (var item in numbers3)
{
    Console.Write($"item: {item} ");
}

IEnumerable<int> numbers4 = Enumerable.DefaultIfEmpty<int>(numbers3);
Console.WriteLine($"numbers4 count: {numbers4.Count()}");
foreach (var item in numbers4)
{
    Console.Write($"item: {item} ");
}

IEnumerable<int> numbers5 = Enumerable.Repeat<int>(10, 5);
Console.WriteLine($"numbers5 count: {numbers5.Count()}");
foreach (var item in numbers5)
{
    Console.Write($"{item} ");
}

IEnumerable<int> numbers6 = Enumerable.Range(1, 10);
Console.WriteLine($"numbers6 count: {numbers6.Count()}");
foreach (var item in numbers6)
{
    Console.Write($"{item} ");
}

Console.ReadLine();