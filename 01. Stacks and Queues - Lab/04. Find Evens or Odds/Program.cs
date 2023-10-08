
List<int> range = new();

int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
int start = data[0];
int end = data[1];
string evenOrOdd = Console.ReadLine();

Func<int, int, List<int>> generateRange = (start, end) =>
{

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;
};

List<int> list = generateRange(start, end);

if (evenOrOdd == "even")
{
	foreach (int num in range)
	{
		Predicate<int> isEvenOrOdd = range => num % 2 == 0;
        if (isEvenOrOdd(num))
        {
            Console.Write($"{num} ");
        }
	}
}
else if (evenOrOdd == "odd")
{
    foreach (int num in range)
    {
        Predicate<int> isEvenOrOdd = range => range % 2 != 0;
        if (isEvenOrOdd(num))
        {
            Console.Write($"{num} ");
        }
    }
}




