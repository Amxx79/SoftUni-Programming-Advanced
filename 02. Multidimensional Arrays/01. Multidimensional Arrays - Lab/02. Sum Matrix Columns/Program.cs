int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = data[0];
int cols = data[1];

int[,] matrix = new int[rows, cols];

int sum = 0;

for (int row = 0; row < rows; row++)
{
	int[] lane = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = lane[col];
	}
}

for (int col = 0; col < cols; col++)
{
	for (int row = 0; row < rows; row++)
	{
		sum += matrix[row, col];
	}
	Console.WriteLine(sum);
	sum = 0;
}