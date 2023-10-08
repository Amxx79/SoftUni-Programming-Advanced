int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < n; row++)
{
	int[] laneData = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < n; col++)
	{
		matrix[row, col] = laneData[col];
	}
}

int sumOfPrimaryDiagonal = 0;
int sumOfOtherDiagonal = 0;

for (int row = 0; row < n; row++)
{
	for (int col = 0; col < n; col++)
	{
		if (row == col)
		{
			sumOfPrimaryDiagonal += matrix[row, col];
		}
		if (col == n - row - 1)
		{
			sumOfOtherDiagonal += matrix[row, col];
		}
	}
}

Console.WriteLine(Math.Abs(sumOfPrimaryDiagonal - sumOfOtherDiagonal));