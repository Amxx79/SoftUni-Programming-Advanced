int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

int sum = 0;

for (int row = 0; row < n; row++)
{
	int[] laneData = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < n; col++)
	{
		matrix[col, row] = laneData[col];

		if (row == col)
		{
			sum += matrix[row, col];
		}
	}
}

Console.WriteLine(sum);