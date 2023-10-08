//9
//Europe Bulgaria Sofia
//Asia China Beijing
//Asia Japan Tokyo
//Europe Poland Warsaw
//Europe Germany Berlin
//Europe Poland Poznan
//Europe Bulgaria Plovdiv
//Africa Nigeria Abuja
//Asia China Shanghai

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string,List<string>>> countries = new Dictionary<string, Dictionary<string,List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split();
    string continent = data[0];
    string country = data[1];
    string city = data[2];

    if (!countries.ContainsKey(continent))
    {
        countries.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!countries[continent].ContainsKey(country))
    {
        countries[continent].Add(country, new List<string>());
    }
    countries[continent][country].Add(city);
}

foreach (KeyValuePair<string,Dictionary<string,List<string>>> continent in countries)
{
    Console.WriteLine($"{continent.Key}: ");

    foreach (var country in continent.Value)
    {
        Console.Write(string.Join(", ", country.Key.ToString()));
        Console.Write(" -> ");
        Console.Write(string.Join(", ", country.Value));
        Console.WriteLine();
    }
}