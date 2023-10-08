int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();


HashSet<int> hash1 = new();
HashSet<int> hash2 = new();



for (int j = 0; j < n[0]; j++)
{
    int num = int.Parse(Console.ReadLine());

    hash1.Add(num);

}

for (int j = 0; j < n[1]; j++)
{
    int num = int.Parse(Console.ReadLine());

    hash2.Add(num);
}

Console.WriteLine(string.Join(" ", hash1.Intersect(hash2)));
