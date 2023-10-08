using System.Numerics;

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] dataLane = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = dataLane[col];
    }
}

string[] command = Console.ReadLine().Split();
string action = command[0];
while (action != "END")
{
    if (action == "swap" && command.Length == 5)
    {
        int currentRow = int.Parse(command[1]);
        int currentCol = int.Parse(command[2]);

        int swapRow = int.Parse(command[3]);
        int swapCol = int.Parse(command[4]);

        bool isValid = isValidPositions(matrix, currentRow, currentCol, swapRow, swapCol);

        if (isValid)
        {
            string currentValue = matrix[currentRow,currentCol];
            matrix[currentRow, currentCol] = matrix[swapRow, swapCol];
            matrix[swapRow, swapCol] = currentValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    else
    {
        Console.WriteLine("Invalid input!");
    }
    command = Console.ReadLine().Split();
    action = command[0];
}

static bool isValidPositions(string[,] matrix, int currentRow, int currentCol, int swapRow, int swapCol)
{
    bool isValid = currentRow >= 0 && currentRow < matrix.GetLength(0)
        && currentCol >= 0 && currentCol < matrix.GetLength(1)
        && swapRow >= 0 && swapRow < matrix.GetLength(0)
        && swapCol >= 0 && swapCol < matrix.GetLength(1);
    if (isValid)
    {
        return true;
    }
    else
    {
        return false;
    }
}