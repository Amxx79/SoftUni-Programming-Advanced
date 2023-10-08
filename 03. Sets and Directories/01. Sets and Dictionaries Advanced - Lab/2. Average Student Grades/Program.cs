int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> data = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string name = input[0];
    decimal value = decimal.Parse(input[1]);

    if (!data.ContainsKey(name))
    {
        data.Add(name, new List<decimal>());
    }
    if (data.ContainsKey(name))
    {
        data[name].Add(value);
    }
}

data.OrderByDescending(x => x.Value.Average());

foreach (var info in data)
{
    Console.Write($"{info.Key} -> ");
    foreach (double value in info.Value)
    {
        Console.Write($"{value:F2} ");
    }
    Console.Write($"(avg: {info.Value.Average():F2})");
    Console.WriteLine();
}