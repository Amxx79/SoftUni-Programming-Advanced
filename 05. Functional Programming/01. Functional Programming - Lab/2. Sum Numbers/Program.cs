List<int> sequence = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

Console.WriteLine(sequence.Count);
int sum = 0;
foreach (int element in sequence)
{
    sum += element;
}
Console.WriteLine(sum);
