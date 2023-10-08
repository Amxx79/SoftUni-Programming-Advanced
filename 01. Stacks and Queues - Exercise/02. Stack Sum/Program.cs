int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int> stackOfNums = new Stack<int>();

for (int i = 0; i < numbers.Length; i++)
{
    stackOfNums.Push(numbers[i]);
}

string[] commandArgs = Console.ReadLine()
    .Split()
    .ToArray();

string command = commandArgs[0].ToLower();

while (command != "end")
{
    if (command == "add")
    {
        int firstNum = int.Parse(commandArgs[1]);
        int secondNum = int.Parse(commandArgs[2]);
        stackOfNums.Push(firstNum);
        stackOfNums.Push(secondNum);
    }

    if (command == "remove")
    {
        int timesToRemove = int.Parse(commandArgs[1]);
        if (timesToRemove <= stackOfNums.Count)
        {
            while(timesToRemove > 0)
            {
                stackOfNums.Pop();
                timesToRemove--;
            }
        }
    }
    commandArgs = Console.ReadLine()
    .Split()
    .ToArray();
    command = commandArgs[0].ToLower();
}

int sum = 0;

foreach (var number in stackOfNums)
{
    sum += number;
}

Console.WriteLine($"Sum: {sum}");



