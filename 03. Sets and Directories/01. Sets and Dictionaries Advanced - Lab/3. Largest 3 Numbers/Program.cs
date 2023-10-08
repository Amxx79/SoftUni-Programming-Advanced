List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
numbers = numbers.OrderByDescending(x => x).ToList();
Console.WriteLine(string.Join(" ", numbers.Take(3)));