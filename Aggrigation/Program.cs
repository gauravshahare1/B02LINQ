List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

int result1 = numbers.Sum(i => i);
Console.WriteLine($"numbers.Sum(i => i) : {result1}");

result1 = numbers.Min();
Console.WriteLine($"numbers.Min() : {result1}");

result1 = numbers.Max();
Console.WriteLine($"numbers.Max() : {result1}");

result1 = numbers.Count();
Console.WriteLine($"numbers.Count() : {result1}"); // 6

result1 = numbers.Count(i => i % 2 == 0);
Console.WriteLine($"numbers.Count(i => i % 2 == 0) : {result1}"); // 3

long result2 = numbers.LongCount();
Console.WriteLine($"numbers.LongCount() : {result2}"); // 6

double result3 = numbers.Average();
Console.WriteLine($"numbers.Average() : {result3}");

result1 = numbers.Aggregate((i, j) => i + j);
Console.WriteLine($"numbers.Aggregate((i, j) =>  i + j) : {result1}");

result1 = numbers.Aggregate((i, j) => i * j);
Console.WriteLine($"numbers.Aggregate((i, j) =>  i * j) : {result1}");

result1 = numbers.Count(i => i > 5); // 1, 2, 3, 4, 5, 6
Console.WriteLine($"numbers.Count(i => i > 5) : {result1}"); // 1

Console.ReadLine();
