int n = int.Parse(Console.ReadLine());

HashSet<string> usernames = new();

for (int i = 0; i < n; i++)
{
    string userName = Console.ReadLine();

    usernames.Add(userName);
}

foreach (string user in usernames)
{
    Console.WriteLine(user);
}