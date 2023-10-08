//4
//Blue->dress,jeans,hat
//Gold -> dress,t-shirt, boxers
//White -> briefs, tanktop
//Blue -> gloves
//Blue dress


int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrobe = new();


for (int i = 0; i < n; i++)
{
    string[] sequence = Console.ReadLine().Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries).ToArray();
    string currentColor = sequence[0];

    foreach (string wear in sequence.Skip(1))
    {
        if (!wardrobe.ContainsKey(currentColor))
        {
            wardrobe.Add(currentColor, new Dictionary<string,int>());
        }
        if (!wardrobe[currentColor].ContainsKey(wear))
        {
            wardrobe[currentColor].Add(wear, 0);
        }
        wardrobe[currentColor][wear]++;
    }
}

string[] wantWear = Console.ReadLine().Split();
string color = wantWear[0];
string wWearWear = wantWear[1];

foreach (var colorInWardrobe in wardrobe)
{
    Console.WriteLine($"{colorInWardrobe.Key} clothes:");

    foreach (var wearInWardrobe in colorInWardrobe.Value)
    {
        if (colorInWardrobe.Key == color && wearInWardrobe.Key == wWearWear)
        {
            Console.WriteLine($"* {wearInWardrobe.Key} - {wearInWardrobe.Value} (found!)");
            continue;
        }
        Console.WriteLine($"* {wearInWardrobe.Key} - {wearInWardrobe.Value}");
    }
}