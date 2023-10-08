int n = int.Parse(Console.ReadLine());


Dictionary<int, int> numbers = new();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);
    }

    numbers[number] += 1;
}

foreach (var number in numbers)
{
    if (number.Value % 2 == 0)
    {
        Console.WriteLine(number.Key);
    }
}