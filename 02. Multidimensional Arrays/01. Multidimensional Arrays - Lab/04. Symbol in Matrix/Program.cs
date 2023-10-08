int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n , n];

for (int row = 0; row < n; row++)
{
	char[] lane = Console.ReadLine().ToCharArray();

    for (int col = 0; col < n; col++)
	{
		matrix[row, col] = lane[col];
	}
}

char symbol = (char)Console.Read();
bool flag = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		if (matrix[row,col] == symbol)
		{
			flag = true;
			Console.WriteLine($"({row}, {col})");
			return;
		}

	}
}

if (flag == false)
{
	Console.WriteLine("{0} does not occur in the matrix", symbol);
}


