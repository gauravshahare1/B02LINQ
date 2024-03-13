using System.Linq;

//List<int> numbers = new List<int>() { 2, 4, 50, 11, 17, 6, 9 };

//Console.WriteLine("*** ALL ITEMS ***");
//foreach (var item in numbers)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//var result1 = numbers.Take(3);
//Console.WriteLine("*** numbers.Take(3) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//result1 = numbers.Take(50);
//Console.WriteLine("*** numbers.Take(50) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//result1 = numbers.TakeWhile(i => i % 2 == 0);
//Console.WriteLine("*** numbers.TakeWhile(i => i % 2 == 0) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//result1 = numbers.TakeWhile(i => i < 20);
//Console.WriteLine("*** numbers.TakeWhile(i => i < 20) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//result1 = numbers.TakeWhile(i => i > 20);
//Console.WriteLine("*** numbers.TakeWhile(i => i > 20) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//result1 = numbers.Skip(3);
//Console.WriteLine("*** numbers.Skip(3) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//result1 = numbers.SkipWhile(i => i % 2 == 0);
//Console.WriteLine("*** numbers.SkipWhile(i => i % 2 == 0) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

////// 2, 4, 3, 50, 11, 17, 6, 9
//result1 = numbers.SkipWhile(i => i % 2 != 0);
//Console.WriteLine("*** numbers.SkipWhile(i => i % 2 != 0) ***");
//foreach (var item in result1)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//// example

List<int> numbers = new List<int>() { 2, 4, 3, 50, 11, 17, 6, 9 };

int max = numbers.Max();
Console.WriteLine($"Highest number : {max}"); // 50

////second highest = 17
//numbers.OrderByDescending(i => i); // 50 17 11 9 6 4 3 2
//numbers.OrderByDescending(i => i).Take(2);// 50 17
//numbers.OrderByDescending(i => i).Take(2).OrderBy(i => i); // 17 50
//numbers.OrderByDescending(i => i).Take(2).OrderBy(i => i).Take(1); // 17

//numbers.OrderByDescending(i => i); // 50 17 11 9 6 4 3 2
//numbers.OrderByDescending(i => i).Take(2); // 50 17
//numbers.OrderByDescending(i => i).Take(2).Skip(1); // 17

//// IEnumerble<int> & int 

var secondHighest = numbers.
    OrderByDescending(i => i).Take(2).Skip(1).First();
Console.WriteLine($"Second highest number : {secondHighest}"); // 17
//foreach (var item in secondHighest)
//{
//    Console.WriteLine($"Second highest number : {item}");
//}

Console.ReadLine();