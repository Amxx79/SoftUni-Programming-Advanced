Predicate<string> predicate = n => n[0] == n.ToUpper()[0];

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => predicate(x)).ToArray();

foreach (string word in words)
{
    Console.WriteLine(word);
}

