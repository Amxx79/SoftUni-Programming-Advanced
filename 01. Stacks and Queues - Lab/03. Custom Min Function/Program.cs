

Func<HashSet<int>, int> numbers = tokens =>
{
   return tokens.Min();
};

HashSet<int> tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToHashSet();

Console.WriteLine(numbers(tokens));