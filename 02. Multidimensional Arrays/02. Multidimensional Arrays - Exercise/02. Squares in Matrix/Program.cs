int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows,cols];

for (int row = 0; row < rows; row++)
{
	char[] dataLane = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = dataLane[col];
	}
}

int counter = 0;

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
		char currentElement = matrix[row, col];

		if (col >= 0 && col < cols - 1 && row >= 0 && row < rows - 1)
		{
			if (currentElement == matrix[row, col + 1]
				&& currentElement == matrix[row + 1, col]
				&& currentElement == matrix[row + 1, col + 1])
			{
				counter++;
			}
		}
	}
}
	Console.WriteLine(counter);