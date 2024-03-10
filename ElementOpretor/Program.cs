List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

Console.WriteLine("*** ALL ITEMS ***");
foreach (int item in numbers)
{
    Console.Write($"{item} ");
}
Console.WriteLine(); // new line

int i1 = numbers.ElementAt(0);
Console.WriteLine($"numbers.ElementAt(0) : {i1}"); // 1

i1 = numbers.ElementAt(3);
Console.WriteLine($"numbers.ElementAt(3) : {i1}"); // 4

//// ElementAt - returns element from given index
//// ElementAt - throws error when given index is not within range
//// ElementAtOrDefault - same behavior like ElementAt except 1 that it handles exception
//// if given index is out of range it handles & returns default value

i1 = numbers.ElementAtOrDefault(13);
Console.WriteLine($"numbers.ElementAtOrDefault(10) : {i1}"); // 0

i1 = numbers.ElementAtOrDefault(0);
Console.WriteLine($"numbers.ElementAtOrDefault(0) : {i1}"); // 1

//// First() - returns first matching element from collection
//// it returns first matching item even if there are multiple matching item

i1 = numbers.First();
Console.WriteLine($"numbers.First() : {i1}"); // 1

i1 = numbers.First(i => i % 2 == 0);
Console.WriteLine($"numbers.First(i => i % 2 == 0) : {i1}"); // 2

i1 = numbers.First(i => i > 5);
Console.WriteLine($"numbers.First(i => i > 5) : {i1}"); // 6

//i1 = numbers.First(i => i > 50); // error
//Console.WriteLine($"numbers.First(i => i > 50) : {i1}");

//// First() - throws error when there is no matching item in collection

//// FirstOrDefault - same behavior like First() except 1 that it handles exception
//// if there are no matching item in collection it handles exception & returns default value

i1 = numbers.FirstOrDefault(i => i > 50);
Console.WriteLine($"numbers.FirstOrDefault(i => i > 50) : {i1}"); // 0

//// Last() - returns last matching element from collection
//// it returns last matching item even if there are multiple matching item

i1 = numbers.Last();
Console.WriteLine($"numbers.Last() : {i1}"); // 6

i1 = numbers.Last(i => i % 2 == 0);
Console.WriteLine($"numbers.Last(i => i % 2 == 0) : {i1}"); // 6

i1 = numbers.Last(i => i > 5);
Console.WriteLine($"numbers.Last(i => i > 5) : {i1}"); // 6

//i1 = numbers.Last(i => i > 50); // error
//Console.WriteLine($"numbers.Last(i => i > 50) : {i1}");

//// Last() - throws error when there is no matching item in collection

//// LastOrDefault - same behavior like Last() except 1 that it handles exception
//// if there are no matching item in collection it handles exception & returns default value

i1 = numbers.LastOrDefault(i => i > 50);
Console.WriteLine($"numbers.LastOrDefault(i => i > 50) : {i1}"); // 0

//// Single() - returns first matching element from collection
//// it returns first matching item
//// 1. it throws error if there are multiple matching item
//// 2. it throws error if there are no matching item in collection

numbers = new List<int>() { 1 };


i1 = numbers.Single();
Console.WriteLine($"numbers.Single() : {i1}"); // 1

numbers = new List<int>() { 1, 21, 3, 4, 5, 63 };

i1 = numbers.Single(i => i % 2 == 0);
Console.WriteLine($"numbers.Single(i => i % 2 == 0) : {i1}"); // 4

//i1 = numbers.Single(i => i > 500);
//Console.WriteLine($"numbers.Single(i => i > 5) : {i1}"); // 6

//// Single() metho throws exception in two scenarios
//// 1. it throws error if there are multiple matching item
//// 2. it throws error if there are no matching item in collection

//// SingleOrDefault - same behavior like Single() except 1 that it handles exception
//// if there are no matching item in collection it handles exception & returns default value
//// SingleOrDefault throws error when there are multiple matching items

i1 = numbers.SingleOrDefault(i => i > 500);
Console.WriteLine($"numbers.SingleOrDefault(i => i > 5) : {i1}"); // 6

Console.ReadLine();