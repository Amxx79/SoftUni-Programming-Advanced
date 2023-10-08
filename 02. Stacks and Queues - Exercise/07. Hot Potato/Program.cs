Queue<string> children = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());
int tosses = 0;

while (children.Count > 1)
{
    tosses++;
    string childWthPotato = children.Dequeue();

    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {childWthPotato}");
    }

    else
    {
        children.Enqueue(childWthPotato);
    }
}

Console.WriteLine($"Last is {children.Dequeue()}");