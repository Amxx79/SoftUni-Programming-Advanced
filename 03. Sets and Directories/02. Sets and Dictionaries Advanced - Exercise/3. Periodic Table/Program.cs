SortedSet<string> chemicalEl = new SortedSet<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split();

    foreach (string token in tokens)
    {
        chemicalEl.Add(token);
    }
}

    Console.WriteLine(string.Join(" ", chemicalEl));


