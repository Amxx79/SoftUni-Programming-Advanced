List<int> toolsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> substancesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

Queue<int> tools = new(toolsInput);
Stack<int> substances = new(substancesInput);

List<int> challanges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int resultOfMultiply;

while (true)
{
    int toolsElement = 0;
    int substanceElement = 0;
    if (tools.Count == 0 || substances.Count == 0)
    {
        break;
    }
    toolsElement = tools.Dequeue();
    substanceElement = substances.Pop();

    resultOfMultiply = toolsElement * substanceElement;


    if (challanges.Contains(resultOfMultiply))
    {
        challanges.Remove(resultOfMultiply);
    }
    else
    {
        toolsElement += 1;
        tools.Enqueue(toolsElement);
        substanceElement -= 1;
        if (substanceElement > 0)
        {
            substances.Push(substanceElement);
        }
    }
}

if ((tools.Count == 0 || substances.Count == 0) && challanges.Count != 0)
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");

    if (tools.Count != 0)
    {
        Console.WriteLine($"Tools: {string.Join(", ", tools)}");
    }
    if (substances.Count != 0)
    {
        Console.WriteLine($"Substances: {string.Join(", ", substances)}");
    }
    Console.WriteLine($"Challenges: {string.Join(", ", challanges)}");

}

if (challanges.Count == 0)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
    if (tools.Count != 0)
    {
        Console.WriteLine($"Tools: {string.Join(", ", tools)}");
    }
    if (substances.Count != 0)
    {
        Console.WriteLine($"Substances: {string.Join(", ", substances)}");
    }
}
