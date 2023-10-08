using System.Numerics;

int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = data[0];
int cols = data[1];

int sum = 0;

int[,] matrix = new int[rows, cols];


for (int i = 0; i < rows; i++)
{
    int[] lane = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

	for (int j = 0; j < cols; j++)
	{
		matrix[i, j] = lane[j];
	}
}

for (int i = 0; i < rows; i++)
{
	for (int j = 0; j < cols; j++)
	{
		sum += matrix[i, j];
	}
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);




//for (int i = 0; i < rows; i++)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		Console.Write(matrix[i, j] + " ");
//	}
//	Console.WriteLine();
//}