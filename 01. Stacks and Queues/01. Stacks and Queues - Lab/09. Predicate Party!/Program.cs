Func<string, int, bool> chechEqualOrLarger =
    (name, sum) =>
    {
        int charSum = name.Sum(ch => ch);

        return charSum >= sum;
    };

Func<string[], int, Func<string, int, bool>, string> getFirstName =
    (names, sum, match) =>
    {
        foreach (var name in names)
        {
            if (match(name, sum))
            {
                return name;
            }
        }
            return null;
    };

int sum = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();

string foundName = getFirstName(names, sum, chechEqualOrLarger);

Console.WriteLine(foundName);