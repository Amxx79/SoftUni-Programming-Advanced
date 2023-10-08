using System.Linq;

List<int> sequence = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> readyList = sequence.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

Console.WriteLine(string.Join(", ", readyList));