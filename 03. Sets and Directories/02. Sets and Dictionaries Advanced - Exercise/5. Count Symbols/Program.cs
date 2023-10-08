string text = Console.ReadLine();

SortedDictionary<char, int> sequence = new SortedDictionary<char, int>();


foreach (char symbol in text)
{
    if (!sequence.ContainsKey(symbol))
    {
        sequence.Add(symbol, 0);
    }

    sequence[symbol]++;
}

foreach (var symbol in sequence)
{
    string print = $"{symbol.Key}: {symbol.Value} time/s";
    Console.WriteLine(print);
}