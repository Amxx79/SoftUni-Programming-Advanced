int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> integers = new Queue<int>();

for (int i = 0; i < numbers.Length; i++)
{
    integers.Enqueue(numbers[i]);
}

List<int> finalNums = new List<int>();

while (integers.Count > 0)
{
    int currentNum = integers.Dequeue();

    if (currentNum % 2 == 0)
    {
        finalNums.Add(currentNum);
    }
}

Console.WriteLine(String.Join(", ", finalNums));