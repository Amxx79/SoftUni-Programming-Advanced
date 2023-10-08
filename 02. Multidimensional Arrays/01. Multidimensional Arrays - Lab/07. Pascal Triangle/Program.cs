int n = int.Parse(Console.ReadLine());

long[][] jagged = new long[n][];

jagged[0] = new long[1] { 1 };

for (int row = 1; row < n; row++)
{
    jagged[row] = new long[row + 1];

    for (int col = 0; col < jagged[row].Length; col++)
    {
        if (col < jagged[row - 1].Length)
        {
            jagged[row][col] += jagged[row - 1][col];
        }

        if (col > 0)
        {
            jagged[row][col] += jagged[row - 1][col - 1];
        }
    }
}

for (int row = 0; row < jagged.Length; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write(jagged[row][col] + " ");
    }
    Console.WriteLine();
}