int[] sizes = Console.ReadLine()
    .Split(", ")
    .Select(n => int.Parse(n))
    .ToArray();
int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] laneData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = laneData[col];
    }
}

int bestSum = 0;
int[,] bestMatrix = new int[2, 2];

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (bestSum < matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1])
        {
            bestSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
            bestMatrix[0,0] = matrix[row, col];
            bestMatrix[0, 1] = matrix[row, col + 1];
            bestMatrix[1, 0] = matrix[row + 1, col];
            bestMatrix[1, 1] = matrix[row + 1, col + 1];
        }
    }
}

Console.WriteLine(string.Join(" ", bestMatrix[0,0], bestMatrix[0, 1]));
Console.WriteLine(string.Join(" ", bestMatrix[1, 0], bestMatrix[1, 1]));
Console.WriteLine(bestSum);