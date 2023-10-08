using System.Runtime.InteropServices;

Action<string[], Predicate<string>> print = (names, match) =>
{
    foreach (string name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }
};

int length = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split();

print(names, n => n.Length <= length);

