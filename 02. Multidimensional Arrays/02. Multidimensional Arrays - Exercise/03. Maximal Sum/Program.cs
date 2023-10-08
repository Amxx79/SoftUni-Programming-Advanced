int[] matrixData = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = matrixData[0];
int cols = matrixData[1];


int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] laneData = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = laneData[col];
    }
}

int sum = 0;
int copySum = 0;
int[,] biggestMatrix = new int[3, 3];

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        bool validRowCol = isValid(matrix, rows, cols, row, col);
        sum = 0;
        if (validRowCol)
        {
            sum = SumOfElements(matrix, sum, row, col);

            if (sum > copySum)
            {
                biggestMatrix[0, 0] = matrix[row, col];
                biggestMatrix[0, 1] = matrix[row, col + 1];
                biggestMatrix[0, 2] = matrix[row, col + 2];

                biggestMatrix[1, 0] = matrix[row + 1, col];
                biggestMatrix[1, 1] = matrix[row + 1, col + 1];
                biggestMatrix[1, 2] = matrix[row + 1, col + 2];

                biggestMatrix[2, 0] = matrix[row + 2, col];
                biggestMatrix[2, 1] = matrix[row + 2, col + 1];
                biggestMatrix[2, 2] = matrix[row + 2, col + 2];
                copySum = sum;
            }
        }
    }
}

Console.WriteLine("Sum = {0}", copySum);

for (int row = 0; row < biggestMatrix.GetLength(0); row++)
{
    for (int col = 0; col < biggestMatrix.GetLength(0); col++)
    {
        Console.Write(biggestMatrix[row, col] + " ");
    }
    Console.WriteLine();
}

static bool isValid(int[,] matrix, int rows, int cols, int row, int col)
{
    bool Valid1 = row >= 0 && row < rows && col >= 0 && col < cols && col + 2 < cols && row + 2 < rows;

    if (Valid1)
    {
        return true;
    }
    return false;
}

static int SumOfElements(int[,] matrix, int sum, int row, int col)
{
    sum += matrix[row, col];
    sum += matrix[row, col + 1];
    sum += matrix[row, col + 2];

    sum += matrix[row + 1, col];
    sum += matrix[row + 1, col + 1];
    sum += matrix[row + 1, col + 2];

    sum += matrix[row + 2, col];
    sum += matrix[row + 2, col + 1];
    sum += matrix[row + 2, col + 2];

    return sum;
}