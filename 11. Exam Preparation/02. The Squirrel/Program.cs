int squareOfMatrix = int.Parse(Console.ReadLine());

char[,] matrix = new char[squareOfMatrix, squareOfMatrix];
int squirrelRow = 0;
int squirrelCol = 0;

List<string> directions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
int hazelNuts = 0;
int collectedHazelNuts = 0;
bool errorCount = false;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string currentRow = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = currentRow[col];
        if (matrix[row, col] == 's')
        {
            squirrelRow = row;
            squirrelCol = col;
        }
        if (matrix[row, col] == 'h')
        {
            hazelNuts++;
        }
    }
}

while (directions.Count > 0 && collectedHazelNuts < 3)
{
    string currentDirection = directions[0];
    directions.RemoveAt(0);

    if (currentDirection == "left")
    {
        if (squirrelCol == 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            errorCount = true;
            break;
        }
        if (matrix[squirrelRow, squirrelCol - 1] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            errorCount = true;
            break;
        }
        squirrelCol--;
        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelNuts--;
            collectedHazelNuts++;
            if (collectedHazelNuts == hazelNuts)
            {
                break;
            }
            matrix[squirrelRow, squirrelCol] = '*';
        }

    }
    else if (currentDirection == "right")
    {
        if (squirrelCol == matrix.GetLength(1) - 1)
        {
            Console.WriteLine("The squirrel is out of the field.");
            errorCount = true;
            break;
        }
        if (matrix[squirrelRow, squirrelCol + 1] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            errorCount = true;
            break;
        }
        squirrelCol++;
        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelNuts--;
            collectedHazelNuts++;
            if (collectedHazelNuts == hazelNuts)
            {
                break;
            }
            matrix[squirrelRow, squirrelCol] = '*';
        }
    }
    else if (currentDirection == "up")
    {
        if (squirrelRow == 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            errorCount = true;
            break;
        }
        if (matrix[squirrelRow - 1, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            errorCount = true;
            break;
        }
        squirrelRow--;
        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelNuts--;
            collectedHazelNuts++;
            if (collectedHazelNuts == hazelNuts)
            {
                break;
            }
            matrix[squirrelRow, squirrelCol] = '*';
        }
    }
    else if (currentDirection == "down")
    {
        if (squirrelRow == matrix.GetLength(0) - 1)
        {
            Console.WriteLine("The squirrel is out of the field.");
            errorCount = true;
            break;
        }
        if (matrix[squirrelRow + 1, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            errorCount = true;
            break;
        }
        squirrelRow++;
        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelNuts--;
            collectedHazelNuts++;
            if (collectedHazelNuts == hazelNuts)
            {
                break;
            }
            matrix[squirrelRow, squirrelCol] = '*';
        }
    }
}
if (hazelNuts == 0 && errorCount == false)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
}
if (hazelNuts != 0 && errorCount == false)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
Console.WriteLine($"Hazelnuts collected: {collectedHazelNuts}");

