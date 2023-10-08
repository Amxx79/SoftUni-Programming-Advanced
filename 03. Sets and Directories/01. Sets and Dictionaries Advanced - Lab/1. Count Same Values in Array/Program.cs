List<double> sequence = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());

Dictionary<double, int> calculate = new Dictionary<double, int>();

foreach (double element in sequence)
{
    if (!calculate.ContainsKey(element))
    {
        calculate.Add(element, 1);
    }

    else
    {
        calculate[element]++;
    }
}

foreach (var entry in calculate)
{
    Console.WriteLine($"{entry.Key} - {entry.Value} times");
        //-2.5 - 3 times
}