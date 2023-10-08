List<Predicate<int>> predicates = new();

int endRange = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

int[] numbers = Enumerable.Range(1, endRange).ToArray();

foreach (int divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}

foreach (int number in numbers)
{
    bool isDivisible = true;

    foreach (var match in predicates)
    {
        if (!match(number)) 
        {
            isDivisible = false;
            break;
        }
    }

    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}

