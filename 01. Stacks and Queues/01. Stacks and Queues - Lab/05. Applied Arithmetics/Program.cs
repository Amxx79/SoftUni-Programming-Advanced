
Func<string, List<int>, List<int>> calculate = (command, numbers) =>
{
    List<int> result = new List<int>();

    foreach (int number in numbers)
    {
        switch (command)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
        }
    }

    return result;
};

Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command == "print")
    {
        print(numbers);
    }
    else
    {
        numbers = calculate(command, numbers);
    }
    
    
    command = Console.ReadLine();
}