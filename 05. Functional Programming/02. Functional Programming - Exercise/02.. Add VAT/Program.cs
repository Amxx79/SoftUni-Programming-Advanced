Func<string, double> parser = n => double.Parse(n);
Func<double, double> vat = x => x * 1.20;

List<double> numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(parser).Select(vat)
    .ToList();

foreach (double num in numbers)
{
    Console.WriteLine($"{num:f2}");
}
