List<string> peopleGoing = Console.ReadLine().Split().ToList();
Dictionary<string, Predicate<string>> filters = new();

string command;

while ((command = Console.ReadLine()) != "Print")
{

    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];


    if (action == "Add filter")
    {
        if (!filters.ContainsKey(filter + value))
        {
            filters.Add(filters + value, GetPredicate(filter, value));
        }
    }

    else //DOUBLE
    {
        filters.Remove(filters + value);
    }
}

foreach (var filter in filters)
{
    peopleGoing.RemoveAll(filter.Value);
}

Console.WriteLine(string.Join(" ", peopleGoing));

Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p => p.Contains(value);
    }
    return default;
};