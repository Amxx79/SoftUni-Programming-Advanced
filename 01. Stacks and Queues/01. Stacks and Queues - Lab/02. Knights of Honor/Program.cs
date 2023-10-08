

Action<string[]> printNamesWithTitle = names =>
{
    foreach (string name in names)
    {
        Console.WriteLine($"Sir {name}");
    }
};

string[] names = Console.ReadLine().Split();

printNamesWithTitle(names);