
Queue<string> names = new Queue<string>();

string input = Console.ReadLine();

while (input != "End")
{
    if (input == "Paid")
    {
        while (names.Any())
        {
            Console.WriteLine(names.Dequeue());
        }
        input = Console.ReadLine();
        continue;
    }
    names.Enqueue(input);
    input = Console.ReadLine();
}
Console.WriteLine($"{names.Count} people remaining.");